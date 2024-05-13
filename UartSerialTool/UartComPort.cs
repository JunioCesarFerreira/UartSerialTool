using System;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace UartSerialTool
{
    public class EventArgSerialDataReceived : EventArgs
    {
        public string Data;
    }

    internal class UartComPort
    {
        private SerialPort serialPort = new SerialPort();
        private bool enableListenThread = false;
        private string serialBuffer = "";

        public bool Status { get => serialPort.IsOpen; }

        public event EventHandler<EventArgSerialDataReceived> DataReceived;
        protected virtual void OnDataReceived(EventArgSerialDataReceived args)
        {
            DataReceived?.Invoke(this, args);
        }

        public static void RefreshCOM(ComboBox comboBoxPorts)
        {
            string[] portsNames = SerialPort.GetPortNames();
            comboBoxPorts.Items.Clear();
            foreach (string portName in portsNames)
            {
                comboBoxPorts.Items.Add(portName);
            }
            comboBoxPorts.Sorted = true;
            if (comboBoxPorts.Items.Count > 0)
            {
                comboBoxPorts.Text = comboBoxPorts.Items[0].ToString();
            }
            else
            {
                MessageBox.Show("No serial ports were detected.");
            }
        }

        public bool Check(SerialPort port)
        {
            try
            {
                serialPort.Close();
                serialPort = port;
                serialPort.Encoding = Encoding.ASCII;
                serialPort.ReadTimeout = 500;
                serialPort.WriteTimeout = 500;
                serialPort.Open();
                return serialPort.IsOpen;
            }
            catch
            {
                return false;
            }
        }

        public void Write(string data)
        {
            serialPort.Write(data);
        }

        public void Write(byte[] data)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write(data, 0, data.Length);
            }
            else
            {
                serialPort.Open();
                if (serialPort.IsOpen)
                    serialPort.Write(data, 0, data.Length);
                else
                    throw new Exception("Failed to open the serial port.");
            }
        }

        public void StartListen()
        {
            Thread th = new Thread(ThreadListen);
            enableListenThread = true;
            th.Start();
        }

        public void StopListen()
        {
            enableListenThread = false;
            serialPort.Close();
        }

        private void ThreadListen()
        {
            try
            {
                while (enableListenThread)
                {
                    if (!serialPort.IsOpen)
                        serialPort.Open();

                    if (serialPort.BytesToRead > 0)
                    {
                        for (int i = 0; i < serialPort.BytesToRead; i++)
                            serialBuffer += (char)serialPort.ReadByte();

                        EventArgSerialDataReceived arg = new EventArgSerialDataReceived
                        {
                            Data = serialBuffer
                        };
                        OnDataReceived(arg);
                        serialBuffer = "";
                    }
                }
            }
            catch (Exception Ex)
            {
                serialPort.Close();
                MessageBox.Show("PortName: " + serialPort.PortName + ".\r\nException: " + Ex.ToString() + ".");
            }
        }
    }
}
