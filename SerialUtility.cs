using System;
using System.IO.Ports;
using System.Threading;

namespace Serial_dll
{
    public class SerialUtility {

        public SerialPort currentPort;

        public SerialUtility() { }

        /// <summary>
        /// Débute le protocole Handshake sur la connexion série spécifiée
        /// </summary>
        /// <param name="port">Spécifie le port de connexion</param>
        /// <returns>retourne true si l'arduino répond / false sinon</returns>
        public bool connect(SerialPort port)
        {
            currentPort = port;
            try
            {
                if (currentPort.IsOpen)
                {

                } else
                {
                    currentPort.Open();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        /// <summary>
        /// Envoie des bytes sur la connexion spécifiée
        /// </summary>
        /// <param name="key"></param>
        public void send(String data)
        {
            currentPort.WriteLine(data);
        }
        public String read()
        {
            return currentPort.ReadLine();
        }
    }
}
