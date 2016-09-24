using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArSerial
{
    public static class ArSerial
    {
        public static void Send(this System.IO.Ports.SerialPort port, string message, string error)
        {
            try
            {
                port.Open();
                port.Write(message);
                port.Close();
            }
            catch
            {
                MessageBox.Show(error);
            }
        }
        public static string Receive(this System.IO.Ports.SerialPort port, string error)
        {
            try
            {
                port.Open();
                string message = port.ReadLine();
                port.Close();
                return message;
            }
            catch
            {
                MessageBox.Show(error);
                return null;
            }
        }
    }
}