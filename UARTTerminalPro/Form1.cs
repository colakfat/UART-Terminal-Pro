using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics.Tracing;
using System.IO;


namespace UARTTerminalPro
{
    public partial class Form1 : Form
    {
        SerialPort serialPort = new SerialPort();
        private Timer timerPeriodicSend = new Timer();
        private long rxCount = 0;
        private long txCount = 0;
        private long failCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxBaudRate.Items.AddRange(new object[] { "9600", "19200", "38400", "57600", "115200", "230400", "460800", "921600"});
            comboBoxBaudRate.SelectedItem = "115200";
            comboBoxDataBits.Items.AddRange(new object[] { "7", "8" });
            comboBoxDataBits.SelectedItem = "8";
            comboBoxParity.Items.AddRange(Enum.GetNames(typeof(Parity)).Cast<object>().ToArray());
            comboBoxParity.SelectedItem = "None";
            comboBoxStopBits.Items.Add(StopBits.One);
            comboBoxStopBits.Items.Add(StopBits.Two);
            comboBoxStopBits.SelectedItem = StopBits.One;
            timerPeriodicSend.Tick += TimerPeriodicSend_Tick;
            checkBoxAutoScroll.Checked = true;
            rtbTerminal.Font = new Font("Consolas", 10F);
            loadComboBoxComPort();
            labelRxCount.Text = "RX Msg: 0";
            labelTxCount.Text = "TX Msg: 0";
            labelFailCount.Text = "Hata: 0";
        }
        private void labelPeriod_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPeriod_TextChanged(object sender, EventArgs e)
        {

        }
        public void loadComboBoxComPort()
        {
            comboBoxComPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();

            Array.Sort(ports);
            comboBoxComPort.Items.AddRange(ports);
            if(comboBoxComPort.Items.Count > 0 )
            {
                comboBoxComPort.SelectedIndex = 0;
            }
            else
            {
                comboBoxComPort.Text = "Com Yok!";
            }
        }

        private void buttonConnection_Click(object sender, EventArgs e)
        {
            try
            {
                if(!serialPort.IsOpen)
                {
                    serialPort.PortName = comboBoxComPort.SelectedItem.ToString();
                    serialPort.BaudRate = Convert.ToInt32(comboBoxBaudRate.SelectedItem);
                    serialPort.DataBits = Convert.ToInt32(comboBoxDataBits.SelectedItem);
                    serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), comboBoxParity.Text);
                    serialPort.StopBits = (StopBits)comboBoxStopBits.SelectedItem;
                    serialPort.DataReceived += SerialPort_DataReceived;
                    serialPort.Open();

                    buttonConnection.Text = "Bağlantıyı Kes";
                    labelStatus.Text = "  ● Bağlı";
                    labelStatus.ForeColor = Color.LimeGreen;

                }
                else
                {
                    serialPort.Close();
                    buttonConnection.Text = "Bağlan";
                    labelStatus.Text = "● Bağlı Değil";
                    labelStatus.ForeColor = Color.Red;
                }
            }
            catch { }
        }
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            int byteCount = serialPort.BytesToRead;
            byte[] buffer = new byte[byteCount];

            serialPort.Read(buffer, 0, byteCount);

            this.Invoke((MethodInvoker)delegate
            {
                string displayData;
                if (checkBoxHexMode.Checked)
                {
                    displayData = BitConverter.ToString(buffer).Replace("-", " ");
                }
                else
                {
                    displayData = Encoding.ASCII.GetString(buffer);
                }
                rxCount++;
                labelRxCount.Text = $"RX Msg: {rxCount}";
                addTerminalLine("[RX]", displayData.Trim());
            });
        }

        private void addTerminalLine(string direction, string data)
        {
            string time = DateTime.Now.ToString("HH:mm:ss.fff");
            rtbTerminal.SelectionColor = Color.FromArgb(180, 180, 180);

            if(checkBoxTimestamp.Checked)
            {
                rtbTerminal.AppendText(time + "   ");
            }
            

            if (direction == "[RX]")
            {
                rtbTerminal.SelectionColor = Color.LimeGreen;
            }
            else if(direction == "[WAIT]")
            {
                rtbTerminal.SelectionColor = Color.Gold;
            }
            else
            {
                rtbTerminal.SelectionColor = Color.DodgerBlue;
            }
            rtbTerminal.AppendText(direction + "   ");
            rtbTerminal.SelectionColor = Color.White;
            rtbTerminal.AppendText(data + Environment.NewLine);

            rtbTerminal.SelectionColor = rtbTerminal.ForeColor;

            if(checkBoxAutoScroll.Checked)
            {
                rtbTerminal.SelectionStart = rtbTerminal.Text.Length;
                rtbTerminal.ScrollToCaret();
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            SendCommandsAsync();
        }
        private async Task SendCommandsAsync()
        {
            string[] commands = textBoxSend.Lines;


            foreach (string command in commands)
            {
                string data = command.Trim();

                if (command.StartsWith("WAIT", StringComparison.OrdinalIgnoreCase))
                {
                    string[] parts = command.Split(' ');
                    
                    if (parts.Length == 2 && int.TryParse(parts[1], out int delay))
                    {
                        addTerminalLine("[WAIT]", $"{delay} ms");
                        await Task.Delay(delay);
                    }

                    continue;
                }

                if (checkBoxHexSend.Checked)
                {
                    byte[] bytes = new byte[data.Length / 2];
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        bytes[i] = Convert.ToByte(data.Substring(i * 2, 2), 16);
                    }

                    serialPort.Write(bytes, 0, bytes.Length);
                    txCount++;
                    labelTxCount.Text = $"TX Msg: {txCount}";
                    addTerminalLine("[TX]", data);
                }
                else
                {
                    serialPort.Write(data);
                    txCount++;
                    labelTxCount.Text = $"TX Msg: {txCount}";
                    addTerminalLine("[TX]", data);
                }
                //await Task.Delay(25);
            }
        }
        private async Task SendData()
        {

            string[] commands = textBoxSend.Lines;
            foreach(string command in commands)
            {
                string data = command.Trim();

                if (command.StartsWith("[WAIT]", StringComparison.OrdinalIgnoreCase))
                {
                    string[] parts = command.Split(' ');

                    if (parts.Length == 2 && int.TryParse(parts[1], out int delay))
                    {
                        await Task.Delay(delay);
                    }

                    continue;
                }
                serialPort.Write(data);
                txCount++;
                labelTxCount.Text = $"TX Msg: {txCount}";
                addTerminalLine("[TX]", data);
                await Task.Delay(25);
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            rtbTerminal.Clear();
            labelRxCount.Text = "RX Msg: 0";
            labelTxCount.Text = "TX Msg: 0";
            labelFailCount.Text = "Hata: 0";
            rxCount = 0;
            txCount = 0;
            failCount = 0;
        }

        private void checkBoxPeriodic_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPeriodic.Checked)
            {
                int interval;
                int.TryParse(textBoxPeriod.Text, out interval);
                timerPeriodicSend.Interval = interval;
                timerPeriodicSend.Start();
            }
            else
            {
                timerPeriodicSend.Stop();
            }
        }

        private void TimerPeriodicSend_Tick(object sender, EventArgs e)
        {
            SendData();
        }



        private void buttonSaveLog_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "UART Log Kaydet";
            saveFileDialog.Filter = "Text File (*.txt)|*.txt|Log File (*.log)|*.log";
            saveFileDialog.FileName = "UART_Log_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(
                    saveFileDialog.FileName,
                    rtbTerminal.Text,
                    Encoding.UTF8);

                MessageBox.Show("Log başarıyla kaydedildi.");
            }
        }
    }
}
