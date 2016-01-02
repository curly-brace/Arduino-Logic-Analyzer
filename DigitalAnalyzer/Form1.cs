using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DigitalAnalyzer {
    public partial class Form1:Form {
        private static SerialPort com;
        private int prevX = 0;
        private delegate void GetTextDeleg(List<string> strings);
        private delegate void GetStringDeleg(string data);

        public Form1() {
            InitializeComponent();
            chart1.MouseWheel += new MouseEventHandler(chart1_MouseWheel);
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
            try { com.Close(); } catch { }

            try {
                com = new SerialPort("COM3", 19200);
                com.DataReceived += new SerialDataReceivedEventHandler(gotSomething);
                com.DtrEnable = resetChk.Checked;
                com.Open();
            } catch { MessageBox.Show("something went wrong!"); }
        }

        void gotSomething(object sender, SerialDataReceivedEventArgs e) {
            String input = String.Empty;
            //input = com.ReadLine();

            //BeginInvoke(new GetStringDeleg(processInputString), new object[] { input });

            int bytes = com.BytesToRead;
            byte[] buffer = new byte[bytes];
            com.Read(buffer, 0, bytes);

            if (buffer != null) bytesToStrings(buffer);
        }

        void bytesToStrings(byte[] bytes) {
            List<string> strings = new List<string>();

            string temp = String.Empty;

            for (int i = 0; i < bytes.Length; i++) {
                if ((char)bytes[i] != '\r') {
                    temp += (char)bytes[i];
                } else {
                    if (temp != String.Empty) {
                        strings.Add(temp);
                        temp = String.Empty;
                    }
                }
            }

            BeginInvoke(new GetTextDeleg(processInput), new object[] { strings });
        }

        private void processInput(List<string> strings) {
            for (int s = 0; s < strings.Count; s++) {
                processInputString(strings[s]);
            }

            /*
            if (counter++ % 2 == 0) {
                processInputString("\n01010101");
            } else {
                processInputString("\n10101010");
            }*/
        }

        private void processInputString(string data) {
            string bin = Convert.ToString(Int32.Parse(data), 2).PadLeft(16, '0');

            chart1.Series.SuspendUpdates();

            int offset = 1;

            //if (data.Length < 8) return;

            for (int i = 15; i >= 0; i--) {
                //if (bin[i] == '\n' || data[i] == ';') continue;

                double y = offset + (bin[i] == '1' ? 1 : 0);

                chart1.Series[i].Points.AddXY(prevX, y);
                chart1.Series[i].Points.AddXY(prevX + 1, y);
                offset += 2;
            }

            prevX++;

            chart1.Series.ResumeUpdates();

            chart1.ChartAreas[0].AxisX.ScaleView.Scroll(chart1.ChartAreas[0].AxisX.Maximum);

            ctrlList.Items.Add(bin.Substring(0, 8));
            dataList.Items.Add(bin.Substring(8, 8));
        }

        private void button2_Click(object sender, EventArgs e) {
            try { com.Close(); } catch { }
            com.DataReceived -= gotSomething;
        }

        private void chart1_MouseEnter(object sender, EventArgs e) {
            chart1.Focus();
        }

        private void chart1_CursorPositionChanged(object sender, CursorEventArgs e) {
            ctrlList.SelectedIndex = (int)e.NewPosition;
            dataList.SelectedIndex = (int)e.NewPosition;
        }

        private void load_Click(object sender, EventArgs e) {
            OpenFileDialog loadFile = new OpenFileDialog();
            loadFile.Title = "Load data";
            loadFile.ShowDialog();

            if (loadFile.FileName != "") {
                chart1.Serializer.Load(loadFile.FileName);
            }
        }

        private void save_Click(object sender, EventArgs e) {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save data";
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
    }
}
