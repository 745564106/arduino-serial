namespace Main
{
    partial class MainFrame
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.btSend = new System.Windows.Forms.Button();
            this.sendInput = new System.Windows.Forms.TextBox();
            this.outputTextbox = new System.Windows.Forms.RichTextBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.PortsBox = new System.Windows.Forms.ComboBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btSend
            // 
            resources.ApplyResources(this.btSend, "btSend");
            this.btSend.Name = "btSend";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // sendInput
            // 
            resources.ApplyResources(this.sendInput, "sendInput");
            this.sendInput.Name = "sendInput";
            // 
            // outputTextbox
            // 
            resources.ApplyResources(this.outputTextbox, "outputTextbox");
            this.outputTextbox.Name = "outputTextbox";
            this.outputTextbox.ReadOnly = true;
            // 
            // btConnect
            // 
            resources.ApplyResources(this.btConnect, "btConnect");
            this.btConnect.Name = "btConnect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.Name = "lblStatus";
            // 
            // btDisconnect
            // 
            resources.ApplyResources(this.btDisconnect, "btDisconnect");
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.UseVisualStyleBackColor = true;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // PortsBox
            // 
            this.PortsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortsBox.FormattingEnabled = true;
            resources.ApplyResources(this.PortsBox, "PortsBox");
            this.PortsBox.Name = "PortsBox";
            // 
            // trackBar1
            // 
            resources.ApplyResources(this.trackBar1, "trackBar1");
            this.trackBar1.Maximum = 360;
            this.trackBar1.Name = "trackBar1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // MainFrame
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.PortsBox);
            this.Controls.Add(this.btDisconnect);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.outputTextbox);
            this.Controls.Add(this.sendInput);
            this.Controls.Add(this.btSend);
            this.Name = "MainFrame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_onClose);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.TextBox sendInput;
        private System.Windows.Forms.RichTextBox outputTextbox;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btDisconnect;
        private System.Windows.Forms.ComboBox PortsBox;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
    }
}

