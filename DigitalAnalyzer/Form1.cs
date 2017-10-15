using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;



// TODO Fix infinite memory use - currently all teh data is saved, maybe celear every 10000 samples
// TODO Compression - don't store data, store events like state change
// TODO decimation - show every Nth sample
// TODO Move to oxycharts or live charts
// TODO clear data
// TODO auto program the arduino
// TODO add data to send to the board
// TODO show time between readings
// TODO send serial data as BIN not string, or add something for determinism
// TODO self calibrate code for e.g. fixed 1 khz sample rate


namespace DigitalAnalyzer {
    public partial class Form1:Form {
        private static SerialPort _com;
        private int _prevX = 0;
        private int _prevXrem = 0;
        private delegate void GetTextDeleg(List<string> strings);
        private delegate void GetStringDeleg(string data);

        public Form1() {
            InitializeComponent();
            chart1.MouseWheel += new MouseEventHandler(chart1_MouseWheel);

            SerialSpeedComboBox.Items.Add(19200);
            SerialSpeedComboBox.Items.Add(115200);
            SerialSpeedComboBox.SelectedItem = 115200;


            string[] ports = SerialPort.GetPortNames();
            foreach(string port in ports) {
                SerialPortComboBox.Items.Add(port);
                SerialPortComboBox.SelectedItem = port;
            }
        }

        private void chart1_MouseWheel(object sender, MouseEventArgs e) {
            try {
                if (e.Delta < 0) {
                    //chart1.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                    //chart1.ChartAreas[0].AxisY.ScaleView.ZoomReset();

                    double xMin = chart1.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
                    double xMax = chart1.ChartAreas[0].AxisX.ScaleView.ViewMaximum;
                    double yMin = chart1.ChartAreas[0].AxisY.ScaleView.ViewMinimum;
                    double yMax = chart1.ChartAreas[0].AxisY.ScaleView.ViewMaximum;

                    double posXStart = chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - (xMax - xMin);
                    double posXFinish = chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) + (xMax - xMin);
                    double posYStart = chart1.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) - (yMax - yMin);
                    double posYFinish = chart1.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) + (yMax - yMin);

                    chart1.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                    chart1.ChartAreas[0].AxisY.ScaleView.Zoom(posYStart, posYFinish);
                }

                if (e.Delta > 0) {
                    double xMin = chart1.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
                    double xMax = chart1.ChartAreas[0].AxisX.ScaleView.ViewMaximum;
                    double yMin = chart1.ChartAreas[0].AxisY.ScaleView.ViewMinimum;
                    double yMax = chart1.ChartAreas[0].AxisY.ScaleView.ViewMaximum;

                    double posXStart = chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                    double posXFinish = chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
                    double posYStart = chart1.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                    double posYFinish = chart1.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;

                    chart1.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                    chart1.ChartAreas[0].AxisY.ScaleView.Zoom(posYStart, posYFinish);
                }
            } catch { }

            Debug.WriteLine("mouse");
        }

        private void button1_Click(object sender, EventArgs e) {
            try { _com.Close(); } catch { }

            try {
                _com = new SerialPort((string) SerialPortComboBox.SelectedItem, (int) SerialSpeedComboBox.SelectedItem);
                _com.DataReceived += new SerialDataReceivedEventHandler(GotSomething);
                _com.DtrEnable = resetChk.Checked;
                _com.Open();
                _com.Write(DelayTextBox.Text);
            } catch (Exception exe) { MessageBox.Show($"Something went wrong!\n{exe.ToString()}"); }
        }

        void GotSomething(object sender, SerialDataReceivedEventArgs e) {
            String input = String.Empty;
            //input = com.ReadLine();

            //BeginInvoke(new GetStringDeleg(processInputString), new object[] { input });

            int bytes = _com.BytesToRead;
            byte[] buffer = new byte[bytes];
            _com.Read(buffer, 0, bytes);

            //TODO don't check if null but check if empty
            if (buffer.Length != 0) BytesToStrings(buffer);
        }

        void BytesToStrings(byte[] bytes) {
            List<string> strings = new List<string>();

            string temp = String.Empty;

            foreach (byte t in bytes) {
                if ((char)t != '\r') {
                    temp += (char)t;
                } else {
                    if (temp != String.Empty) {
                        strings.Add(temp);
                        temp = String.Empty;
                    }
                }
            }

            BeginInvoke(new GetTextDeleg(ProcessInput), new object[] { strings });
        }

        private void ProcessInput(List<string> strings) {
            for (int s = 0; s < strings.Count; s++) {
                ProcessInputString(strings[s]);
            }

            /*
            if (counter++ % 2 == 0) {
                processInputString("\n01010101");
            } else {
                processInputString("\n10101010");
            }*/
        }

        private void ProcessInputString(string data) {
            // TODO somehow handle this exception
            string bin = Convert.ToString(Int32.Parse(data), 2).PadLeft(16, '0');

            chart1.Series.SuspendUpdates();

            int offset = 1;

            //if (data.Length < 8) return;

            for (int i = 15; i >= 0; i--) {
                //if (bin[i] == '\n' || data[i] == ';') continue;

                if (!((CheckBox)Controls.Find("bit" + i, false)[0]).Checked) {
                    offset += 2;
                    continue;
                }

                double y = offset + (bin[i] == '1' ? 1 : 0);

                chart1.Series[i].Points.AddXY(_prevX, y);
                chart1.Series[i].Points.AddXY(_prevX + 1, y);


                // HACK Each loop adds 2 points. Removing first 2 points each loop stops working, but removing 3 works fine?
                // I think that somehow changing the number of point triggers view update
                if(chart1.Series[i].Points.Count >= 200) {
                    chart1.Series[i].Points.RemoveAt(0);
                    chart1.Series[i].Points.RemoveAt(0);
                    //chart1.Series[i].Points.RemoveAt(0);
                }

                offset += 2;
            }

            _prevX++;

            // Hack part 2 - yea this fixes from few lines up
            chart1.ResetAutoValues();

            DelayTextBox.Text = chart1.Series[1].Points.Count.ToString();


            chart1.Series.ResumeUpdates();

            chart1.ChartAreas[0].AxisX.ScaleView.Scroll(chart1.ChartAreas[0].AxisX.Maximum);

            //ctrlList.Items.Add(bin.Substring(0, 8));
            //dataList.Items.Add(bin.Substring(8, 8));
        }

        private void button2_Click(object sender, EventArgs e) {
            try { _com.Close(); } catch { }
            _com.DataReceived -= GotSomething;
        }

        private void chart1_MouseEnter(object sender, EventArgs e) {
            chart1.Focus();
        }

        private void chart1_CursorPositionChanged(object sender, CursorEventArgs e) {
            // FIX This throws exception if selected during acquisition
            ctrlList.SelectedIndex = (int)e.NewPosition;
            dataList.SelectedIndex = (int)e.NewPosition;
        }

        private void load_Click(object sender, EventArgs e) {
            OpenFileDialog loadFile = new OpenFileDialog {Title = "Load data"};
            loadFile.ShowDialog();

            if (loadFile.FileName != "") {
                chart1.Serializer.Load(loadFile.FileName);
            }
        }

        private void save_Click(object sender, EventArgs e) {
            SaveFileDialog saveFile = new SaveFileDialog {Title = "Save data"};
            saveFile.ShowDialog();

            if (saveFile.FileName != "") {
                chart1.Serializer.Save(saveFile.FileName);
            }
        }

        private void button5_Click(object sender, EventArgs e) {
            ctrlList.Items.Clear();
            dataList.Items.Clear();

            string bin;
            int total = chart1.Series.Count;
            int y = 0;

            for (double x = 0; x < chart1.ChartAreas[0].AxisX.Maximum; x++) {
                bin = String.Empty;
                for (int s = 0; s < total; s++) {
                    y = total * 2 - s * 2;
                    bin += chart1.Series[s].Points.Where(point => point.XValue == x).First().YValues[0] == y ? 1 : 0;
                }

                ctrlList.Items.Add(bin.Substring(0, 8));
                dataList.Items.Add(bin.Substring(8, 8));
            }
        }

        private void SerialPortComboBox_DropDown(object sender, EventArgs e) {
            SerialPortComboBox.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach(string port in ports) {
                SerialPortComboBox.Items.Add(port);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            
        }

        protected override void OnFormClosing(FormClosingEventArgs e) {
            base.OnFormClosing(e);

            if(e.CloseReason == CloseReason.WindowsShutDown)
                return;

            Environment.Exit(0);
        }
    }
}
