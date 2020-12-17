namespace ReadWriter_Serial_Port
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.cbx_Ports = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.txtRead = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbUrl = new System.Windows.Forms.TextBox();
            this.CbxParity = new System.Windows.Forms.ComboBox();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.cbxDataBit = new System.Windows.Forms.ComboBox();
            this.cbxStation = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCOM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbx_Ports
            // 
            this.cbx_Ports.FormattingEnabled = true;
            this.cbx_Ports.Location = new System.Drawing.Point(154, 146);
            this.cbx_Ports.Name = "cbx_Ports";
            this.cbx_Ports.Size = new System.Drawing.Size(79, 21);
            this.cbx_Ports.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Portas COM:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(32, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSelCOM_Click);
            // 
            // txtRead
            // 
            this.txtRead.Location = new System.Drawing.Point(3, 294);
            this.txtRead.Multiline = true;
            this.txtRead.Name = "txtRead";
            this.txtRead.Size = new System.Drawing.Size(270, 80);
            this.txtRead.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(32, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(184, 24);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = " Comunicação Serial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Baudrate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Parity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Databit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Url API:";
            // 
            // txbUrl
            // 
            this.txbUrl.Location = new System.Drawing.Point(32, 103);
            this.txbUrl.Name = "txbUrl";
            this.txbUrl.Size = new System.Drawing.Size(204, 20);
            this.txbUrl.TabIndex = 14;
            // 
            // CbxParity
            // 
            this.CbxParity.FormattingEnabled = true;
            this.CbxParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.CbxParity.Location = new System.Drawing.Point(154, 199);
            this.CbxParity.Name = "CbxParity";
            this.CbxParity.Size = new System.Drawing.Size(79, 21);
            this.CbxParity.TabIndex = 16;
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Items.AddRange(new object[] {
            "1200",
            "4800",
            "9600",
            "19200"});
            this.cbxBaudRate.Location = new System.Drawing.Point(154, 172);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(79, 21);
            this.cbxBaudRate.TabIndex = 17;
            // 
            // cbxDataBit
            // 
            this.cbxDataBit.FormattingEnabled = true;
            this.cbxDataBit.Items.AddRange(new object[] {
            "7",
            "8"});
            this.cbxDataBit.Location = new System.Drawing.Point(154, 225);
            this.cbxDataBit.Name = "cbxDataBit";
            this.cbxDataBit.Size = new System.Drawing.Size(79, 21);
            this.cbxDataBit.TabIndex = 18;
            // 
            // cbxStation
            // 
            this.cbxStation.FormattingEnabled = true;
            this.cbxStation.Items.AddRange(new object[] {
            "Stação 1",
            "Stação 2"});
            this.cbxStation.Location = new System.Drawing.Point(32, 62);
            this.cbxStation.Name = "cbxStation";
            this.cbxStation.Size = new System.Drawing.Size(204, 21);
            this.cbxStation.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Stação:";
            // 
            // txtCOM
            // 
            this.txtCOM.Enabled = false;
            this.txtCOM.Location = new System.Drawing.Point(32, 146);
            this.txtCOM.Name = "txtCOM";
            this.txtCOM.Size = new System.Drawing.Size(79, 20);
            this.txtCOM.TabIndex = 21;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 377);
            this.Controls.Add(this.txtCOM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxStation);
            this.Controls.Add(this.cbxDataBit);
            this.Controls.Add(this.cbxBaudRate);
            this.Controls.Add(this.CbxParity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbUrl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtRead);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_Ports);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Leitor Serial ";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_Ports;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TextBox txtRead;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbUrl;
        private System.Windows.Forms.ComboBox CbxParity;
        private System.Windows.Forms.ComboBox cbxBaudRate;
        private System.Windows.Forms.ComboBox cbxDataBit;
        private System.Windows.Forms.ComboBox cbxStation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCOM;
    }
}

