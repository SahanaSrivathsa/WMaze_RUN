using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.ComponentModel;

namespace WMazeLibrary
{
    public class Arduino
    {
        
         private static readonly SerialPort serialPort = new SerialPort();
        public void Arduino_init()
        {
            
            serialPort = new SerialPort();
            serialPort.BaudRate = 9600;
            serialPort.PortName = "COM3";
            serialPort.Encoding = Encoding.UTF8;
            serialPort.DiscardNull = true;
            serialPort.WriteBufferSize = 10000;
            serialPort.Open();
            serialPort.DiscardInBuffer();
            serialPort.DiscardOutBuffer();

        }
        
        public void listen_to_arduino(object sender, DoWorkEventArgs e)
        //The "listener" that is the mediator between the worker (Felix) and the updater
        {
            try
            {
                var changedData = serialPort.ReadTo("\n");
                e.Result = changedData;
            }
            catch (Exception)
            {
            }
        }
        public static void sendMessage(string button) //handles messages to be sent to the UNO for filling/cleaning
        {
            switch (button)
            {
                case "1":
                    try
                    {
                        serialPort.Write(new[] { 'X' }, 0, 1);
                    }
                    catch (Exception)
                    {
                        ;
                    }
                    break;
                case "2":
                    try
                    {
                        serialPort.Write(new[] { 'Y' }, 0, 1);
                    }
                    catch (Exception)
                    {
                        ;
                    }
                    break;
                case "3":
                    try
                    {
                        serialPort.Write(new[] { 'Z' }, 0, 1);
                    }
                    catch (Exception)
                    {
                        ;
                    }
                    break;
                case "4":
                    try
                    {
                        serialPort.Write(new[] { 'W' }, 0, 1);
                    }
                    catch (Exception)
                    {
                        ;
                    }
                    break;
                case "11":
                    try
                    {
                        serialPort.Write(new[] { 'x' }, 0, 1);
                    }
                    catch (Exception)
                    {
                        ;
                    }
                    break;
                case "22":
                    try
                    {
                        serialPort.Write(new[] { 'y' }, 0, 1);
                    }
                    catch (Exception)
                    {
                        ;
                    }
                    break;
                case "33":
                    try
                    {
                        serialPort.Write(new[] { 'z' }, 0, 1);
                    }
                    catch (Exception)
                    {
                        ;
                    }
                    break;
                case "44":
                    try
                    {
                        serialPort.Write(new[] { 'w' }, 0, 1);
                    }
                    catch (Exception)
                    {
                        ;
                    }
                    break;
            }


        }
    }
}

