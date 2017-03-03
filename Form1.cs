using System;
using System.IO.Ports;
using System.Windows.Forms;
using Serial_dll;

namespace Main // Computer Side
{
    public partial class MainFrame : Form
    {

        /// <summary>
        /// Etats de connexion
        /// </summary>
        public enum ArduinoStatus
        {
            CONNECTING,
            CONNECTED,
            DISCONNECTED
        }

        private ArduinoStatus status;
        SerialPort currentPort;
        public String[] prefix = { "[App] : ", "[Err] : ", "[READ] >> ", "[SEND] << " };
        public String data;
        SerialUtility serial = new SerialUtility();

        /// <summary>
        /// Constructeur de la Classe
        /// </summary>
        public MainFrame()
        {
            InitializeComponent();
            status = ArduinoStatus.DISCONNECTED;
            Maj();
            String[] items = SerialPort.GetPortNames();
            this.PortsBox.Items.AddRange(items);
            this.PortsBox.SelectedItem = PortsBox.Items[0];
        }

        /// <summary>
        /// Fonction appellée lors d'un clic sur le bouton "Connecter"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btConnect_Click(object sender, EventArgs e)
        {
            status = ArduinoStatus.CONNECTING;
            Maj();
            currentPort = new SerialPort(PortsBox.SelectedItem.ToString());
            try
            {
                if (serial.connect(currentPort))
                {
                    status = ArduinoStatus.CONNECTED;
                    Maj();
                    currentPort.DataReceived += new SerialDataReceivedEventHandler(onSerialDataReceived);
                }
            }
            catch (NullReferenceException nrex)
            {
                MessageBox.Show(nrex.Message);
                append(prefix[1], nrex.Message);
                lblStatus.Text = "Status: Erreur";
            }
        }

        /// <summary>
        /// Fonction appellée pour mettre à jour l'interface graphique
        /// </summary>
        private void Maj()
        {
            switch (status)
            {
                case ArduinoStatus.CONNECTED:
                    lblStatus.Text = "Statut: connecté";
                    btConnect.Enabled = false;
                    btDisconnect.Enabled = true;
                    btSend.Enabled = true;
                    sendInput.Enabled = true;
                    append(prefix[0], "Connecté !");
                    break;

                case ArduinoStatus.CONNECTING:
                    lblStatus.Text = "Statut: connexion ...";
                    btConnect.Enabled = false;
                    btSend.Enabled = false;
                    sendInput.Enabled = false;
                    append(prefix[0], "Connexion ...");
                    break;

                case ArduinoStatus.DISCONNECTED:
                    lblStatus.Text = "Statut: déconnecté";
                    btConnect.Enabled = true;
                    btDisconnect.Enabled = false;
                    btSend.Enabled = false;
                    sendInput.Enabled = false;
                    append(prefix[0], "Déconnecté");
                    break;
            }
        }

        /// <summary>
        /// Fontion appellée lors de la fermeture de l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_onClose(object sender, FormClosingEventArgs e)
        {
            if (status == ArduinoStatus.CONNECTED)
            {
                currentPort.Close();
            }
        }


        /// <summary>
        /// Fonction appellée lors d'un clic sur le bouton "Déconnecter"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                currentPort.Close();
                status = ArduinoStatus.DISCONNECTED;
                Maj();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                append(prefix[1], ex.Message);
                lblStatus.Text = "Status: Erreur";
            }
        }

        /// <summary>
        /// Fonction appellée lors d'un clic sur le bouton "Envoyer"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSend_Click(object sender, EventArgs e)
        {
            serial.send(sendInput.Text);
            append(prefix[3], sendInput.Text);
            sendInput.Text = "";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="data"></param>
        public void append(String type, String data)
        {
            this.outputTextbox.AppendText(type + data + "\n");
        }

        /// <summary>
        /// Fonction appellée lorsque des données arrivent dans la mémoire tampon du port
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void onSerialDataReceived(object sender, SerialDataReceivedEventArgs args)
        {
            data = serial.read();
            append(prefix[2], data);
        }
    }
}
