using System;
using System.IO;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace UartSerialTool
{
    public partial class FormMain : Form
    {
        private readonly UartComPort serialPort = new UartComPort();

        private delegate void DelegateTextBox(string text);
        private readonly DelegateTextBox delegateTextBox;

        private readonly Timer timerRefreshStatus = new Timer()
        {
            Interval = 100,
            Enabled = true
        };

        private void TimerRefreshStatus_Tick(object sender, EventArgs e)
        {
            if (serialPort.Status)
            {
                TableLayoutPanel_SerialSettings.Enabled = false;
                ComboBox_PortCOM.Enabled = false;
                Button_Open.Enabled = false;
                Button_Send.Enabled = true;
                label_StatusCOM.Text = "Open";
                label_StatusCOM.ForeColor = Color.DarkGreen;
                label_StatusCOM.BackColor = Color.LightGreen;
            }
            else
            {
                TableLayoutPanel_SerialSettings.Enabled = true;
                ComboBox_PortCOM.Enabled = true;
                Button_Open.Enabled = true;
                Button_Send.Enabled = false;
                label_StatusCOM.Text = "Closed";
                label_StatusCOM.ForeColor = Color.DarkRed;
                label_StatusCOM.BackColor = Color.Orange;
            }
        }

        public FormMain()
        {
            InitializeComponent();
            ComboBox_BaudRate.SelectedIndex = 5;
            ComboBox_Parity.SelectedIndex = 0;
            ComboBox_DataBits.SelectedIndex = 1;
            ComboBox_StopBits.SelectedIndex = 0;
            serialPort.DataReceived += DataReceived_Event;
            delegateTextBox = TextBoxWriteDelegated;
            timerRefreshStatus.Tick += TimerRefreshStatus_Tick;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            UartComPort.RefreshCOM(ComboBox_PortCOM);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort.StopListen();
        }

        private void DataReceived_Event(object sender, EventArgSerialDataReceived e)
        {
            Invoke(delegateTextBox, e.Data);
        }

        private void TextBoxWriteDelegated(string text)
        {
            if (CheckBox_LastFrame.Checked)
            {
                TextBox_Received.Text = "";
            }
            if (CheckBox_ShowHexa.Checked)
            {
                char[] array = text.ToCharArray();
                foreach (char chr in array)
                {
                    int tmp = Convert.ToInt32(chr);
                    TextBox_Received.Text += $"0x{tmp:X2} ";
                }
            }
            else
            {
                TextBox_Received.Text += text;
            }
            TextBox_Received.Text += " \r\n";
        }

        private void Button_RefreshPorts_Click(object sender, EventArgs e)
        {
            UartComPort.RefreshCOM(ComboBox_PortCOM);
        }

        private void Button_Open_Click(object sender, EventArgs e)
        {
            if (ComboBox_PortCOM.Text == "")
            {
                MessageBox.Show("No port has been selected.");
            }
            else
            {
                try
                {
                    SerialPort portbuild = new SerialPort
                    {
                        PortName = ComboBox_PortCOM.Text,
                        BaudRate = int.Parse(ComboBox_BaudRate.Text)
                    };
                    portbuild.Parity = (Parity)ComboBox_Parity.SelectedIndex;
                    portbuild.DataBits = int.Parse(ComboBox_DataBits.Text);
                    portbuild.StopBits = (StopBits)int.Parse(ComboBox_StopBits.Text);
                    if (serialPort.Check(portbuild))
                    {
                        serialPort.StartListen();
                    }
                    else
                    {
                        MessageBox.Show("Could not open Serial Port.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not open Serial Port. Exception: " + ex.Message + ".");
                }
            }

        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            serialPort.StopListen();
        }

        private void Button_Send_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckBox_SendFile.Checked)
                {
                    if (File.Exists(TextBox_FilePath.Text))
                    {
                        TextBox_FilePath.Enabled = false;
                        Color tmpColor = TextBox_FilePath.BackColor;
                        TextBox_FilePath.BackColor = Color.Red;
                        StreamReader streamReader = new StreamReader(TextBox_FilePath.Text);
                        while (!streamReader.EndOfStream)
                        {
                            serialPort.Write(streamReader.ReadLine());
                        }
                        TextBox_FilePath.Enabled = true;
                        TextBox_FilePath.BackColor = tmpColor;
                    }
                    else
                    {
                        MessageBox.Show("File not found.");
                    }
                }
                else
                {
                    serialPort.Write(TextBox_ToSend.Text);
                }
            }
            catch (Exception excpt)
            {
                MessageBox.Show("Exception: " + excpt.Message + ".");
            }
        }

        private void Button_Clean_Click(object sender, EventArgs e)
        {
            TextBox_Received.Text = "";
        }

        private void CheckBox_SendFile_CheckedChanged(object sender, EventArgs e)
        {
            Button_SearchFile.Enabled = CheckBox_SendFile.Checked;
            TextBox_FilePath.Enabled = CheckBox_SendFile.Checked;
            TextBox_ToSend.Enabled = !CheckBox_SendFile.Checked;
        }

        private void Button_SearchFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Search file to send."
            };
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != null)
            {
                TextBox_FilePath.Text = openFileDialog.FileName;
            }
        }
    }
}
