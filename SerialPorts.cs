using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace System
{
    public class SerialPorts
    {
        public void OpenConection(ref  SerialPort Port, String ComName, int BaudRate, Parity Parity, int DataBits ) 
        {
            try
            {
                
                Port= new SerialPort(ComName, BaudRate, Parity, DataBits);
                Port.Open();             
              
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Falha Abrir a Porta {0} :\n {1}",ComName,ex.Message));
            }
        }
        public string ReadSerialPort(ref SerialPort port) 
        {
            try
            {
                return  port.ReadExisting();
            }
            catch(Exception ex) 
            {
                throw new Exception(string.Format("Falha ao Ler na Porta  {0} :\n {1}", port.PortName, ex.Message));
            }
        
        }
     
        public void WriteSerialPort(ref SerialPort port,string StringToWrite) 
        {
            try
            {
                port.Write(StringToWrite);
            }
            catch(Exception ex)
            {
                throw new Exception(string.Format("Falha ao Escrever na Porta {0} :\n {1}", port.PortName, ex.Message));
            }
        }


    }
}
