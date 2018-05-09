namespace ChattrumClient2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grbLogin = new System.Windows.Forms.GroupBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblInloggad = new System.Windows.Forms.Label();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.lblStatusLogin = new System.Windows.Forms.Label();
            this.btnLoggaIn = new System.Windows.Forms.Button();
            this.txbLösenord = new System.Windows.Forms.TextBox();
            this.txbAnvändarnamn = new System.Windows.Forms.TextBox();
            this.lblLösenord = new System.Windows.Forms.Label();
            this.lblAnvändarnamn = new System.Windows.Forms.Label();
            this.grbChatt = new System.Windows.Forms.GroupBox();
            this.txbmeddelande = new System.Windows.Forms.RichTextBox();
            this.txbChattText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSkicka = new System.Windows.Forms.Button();
            this.txbSendTo = new System.Windows.Forms.TextBox();
            this.grbChattlista = new System.Windows.Forms.GroupBox();
            this.lsbAnvändare = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tsPogramToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.loggaUtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bytAnvändarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.grbLogin.SuspendLayout();
            this.grbChatt.SuspendLayout();
            this.grbChattlista.SuspendLayout();
            this.tsPogramToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLogin
            // 
            this.grbLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grbLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.grbLogin.Controls.Add(this.lblIP);
            this.grbLogin.Controls.Add(this.lblInloggad);
            this.grbLogin.Controls.Add(this.txbIP);
            this.grbLogin.Controls.Add(this.lblStatusLogin);
            this.grbLogin.Controls.Add(this.btnLoggaIn);
            this.grbLogin.Controls.Add(this.txbLösenord);
            this.grbLogin.Controls.Add(this.txbAnvändarnamn);
            this.grbLogin.Controls.Add(this.lblLösenord);
            this.grbLogin.Controls.Add(this.lblAnvändarnamn);
            this.grbLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.grbLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbLogin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLogin.Location = new System.Drawing.Point(12, 27);
            this.grbLogin.Name = "grbLogin";
            this.grbLogin.Size = new System.Drawing.Size(230, 460);
            this.grbLogin.TabIndex = 0;
            this.grbLogin.TabStop = false;
            this.grbLogin.Text = "Inloggning";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(6, 35);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(30, 19);
            this.lblIP.TabIndex = 12;
            this.lblIP.Text = "IP:";
            // 
            // lblInloggad
            // 
            this.lblInloggad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInloggad.Location = new System.Drawing.Point(65, 264);
            this.lblInloggad.Name = "lblInloggad";
            this.lblInloggad.Size = new System.Drawing.Size(129, 23);
            this.lblInloggad.TabIndex = 10;
            this.lblInloggad.Text = "Ej inloggad";
            // 
            // txbIP
            // 
            this.txbIP.Location = new System.Drawing.Point(40, 32);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(154, 26);
            this.txbIP.TabIndex = 11;
            this.txbIP.Text = "192.168.250.86";
            // 
            // lblStatusLogin
            // 
            this.lblStatusLogin.Location = new System.Drawing.Point(6, 264);
            this.lblStatusLogin.Name = "lblStatusLogin";
            this.lblStatusLogin.Size = new System.Drawing.Size(78, 23);
            this.lblStatusLogin.TabIndex = 9;
            this.lblStatusLogin.Text = "Status:";
            // 
            // btnLoggaIn
            // 
            this.btnLoggaIn.Location = new System.Drawing.Point(40, 213);
            this.btnLoggaIn.Name = "btnLoggaIn";
            this.btnLoggaIn.Size = new System.Drawing.Size(117, 35);
            this.btnLoggaIn.TabIndex = 4;
            this.btnLoggaIn.Text = "Logga in";
            this.btnLoggaIn.UseVisualStyleBackColor = true;
            this.btnLoggaIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbLösenord
            // 
            this.txbLösenord.Location = new System.Drawing.Point(40, 181);
            this.txbLösenord.Name = "txbLösenord";
            this.txbLösenord.PasswordChar = '*';
            this.txbLösenord.Size = new System.Drawing.Size(117, 26);
            this.txbLösenord.TabIndex = 3;
            this.txbLösenord.UseSystemPasswordChar = true;
            this.txbLösenord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbLösenord_KeyDown);
            // 
            // txbAnvändarnamn
            // 
            this.txbAnvändarnamn.Location = new System.Drawing.Point(40, 112);
            this.txbAnvändarnamn.Name = "txbAnvändarnamn";
            this.txbAnvändarnamn.Size = new System.Drawing.Size(117, 26);
            this.txbAnvändarnamn.TabIndex = 2;
            this.txbAnvändarnamn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbAnvändarnamn_KeyDown);
            // 
            // lblLösenord
            // 
            this.lblLösenord.AutoSize = true;
            this.lblLösenord.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLösenord.Location = new System.Drawing.Point(46, 159);
            this.lblLösenord.Name = "lblLösenord";
            this.lblLösenord.Size = new System.Drawing.Size(85, 19);
            this.lblLösenord.TabIndex = 1;
            this.lblLösenord.Text = "Lösenord:";
            // 
            // lblAnvändarnamn
            // 
            this.lblAnvändarnamn.AutoSize = true;
            this.lblAnvändarnamn.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnvändarnamn.Location = new System.Drawing.Point(37, 91);
            this.lblAnvändarnamn.Name = "lblAnvändarnamn";
            this.lblAnvändarnamn.Size = new System.Drawing.Size(120, 18);
            this.lblAnvändarnamn.TabIndex = 0;
            this.lblAnvändarnamn.Text = "Användarnamn:";
            this.lblAnvändarnamn.Click += new System.EventHandler(this.label1_Click);
            // 
            // grbChatt
            // 
            this.grbChatt.Controls.Add(this.txbmeddelande);
            this.grbChatt.Controls.Add(this.txbChattText);
            this.grbChatt.Controls.Add(this.label1);
            this.grbChatt.Controls.Add(this.btnSkicka);
            this.grbChatt.Controls.Add(this.txbSendTo);
            this.grbChatt.Enabled = false;
            this.grbChatt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbChatt.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChatt.Location = new System.Drawing.Point(248, 27);
            this.grbChatt.Name = "grbChatt";
            this.grbChatt.Size = new System.Drawing.Size(479, 460);
            this.grbChatt.TabIndex = 4;
            this.grbChatt.TabStop = false;
            this.grbChatt.Text = "Chatt";
            // 
            // txbmeddelande
            // 
            this.txbmeddelande.Location = new System.Drawing.Point(6, 387);
            this.txbmeddelande.Name = "txbmeddelande";
            this.txbmeddelande.Size = new System.Drawing.Size(344, 46);
            this.txbmeddelande.TabIndex = 7;
            this.txbmeddelande.Text = "";
            this.txbmeddelande.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbmeddelande_KeyDown_1);
            // 
            // txbChattText
            // 
            this.txbChattText.Location = new System.Drawing.Point(6, 65);
            this.txbChattText.Name = "txbChattText";
            this.txbChattText.Size = new System.Drawing.Size(467, 316);
            this.txbChattText.TabIndex = 6;
            this.txbChattText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Send to:";
            // 
            // btnSkicka
            // 
            this.btnSkicka.Location = new System.Drawing.Point(356, 387);
            this.btnSkicka.Name = "btnSkicka";
            this.btnSkicka.Size = new System.Drawing.Size(117, 46);
            this.btnSkicka.TabIndex = 2;
            this.btnSkicka.Text = "Skicka";
            this.btnSkicka.UseVisualStyleBackColor = true;
            this.btnSkicka.Click += new System.EventHandler(this.btnSkicka_Click);
            // 
            // txbSendTo
            // 
            this.txbSendTo.Location = new System.Drawing.Point(185, 24);
            this.txbSendTo.Name = "txbSendTo";
            this.txbSendTo.Size = new System.Drawing.Size(156, 26);
            this.txbSendTo.TabIndex = 4;
            this.txbSendTo.Text = "all";
            // 
            // grbChattlista
            // 
            this.grbChattlista.Controls.Add(this.lsbAnvändare);
            this.grbChattlista.Enabled = false;
            this.grbChattlista.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChattlista.Location = new System.Drawing.Point(735, 27);
            this.grbChattlista.Name = "grbChattlista";
            this.grbChattlista.Size = new System.Drawing.Size(296, 460);
            this.grbChattlista.TabIndex = 5;
            this.grbChattlista.TabStop = false;
            this.grbChattlista.Text = "Chatt Användare";
            // 
            // lsbAnvändare
            // 
            this.lsbAnvändare.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lsbAnvändare.FormattingEnabled = true;
            this.lsbAnvändare.ItemHeight = 22;
            this.lsbAnvändare.Location = new System.Drawing.Point(10, 27);
            this.lsbAnvändare.Name = "lsbAnvändare";
            this.lsbAnvändare.Size = new System.Drawing.Size(280, 422);
            this.lsbAnvändare.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timerCheckNewData_Tick);
            // 
            // tsPogramToolStrip
            // 
            this.tsPogramToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsPogramToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.tsPogramToolStrip.Location = new System.Drawing.Point(0, 0);
            this.tsPogramToolStrip.Name = "tsPogramToolStrip";
            this.tsPogramToolStrip.Size = new System.Drawing.Size(805, 27);
            this.tsPogramToolStrip.TabIndex = 6;
            this.tsPogramToolStrip.Text = "toolStrip2";
            this.tsPogramToolStrip.Visible = false;
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loggaUtToolStripMenuItem,
            this.bytAnvändarToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(61, 24);
            this.toolStripSplitButton1.Text = "Arkiv";
            // 
            // loggaUtToolStripMenuItem
            // 
            this.loggaUtToolStripMenuItem.Enabled = false;
            this.loggaUtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loggaUtToolStripMenuItem.Image")));
            this.loggaUtToolStripMenuItem.Name = "loggaUtToolStripMenuItem";
            this.loggaUtToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.loggaUtToolStripMenuItem.Text = "Logga ut";
            this.loggaUtToolStripMenuItem.Click += new System.EventHandler(this.loggaUtToolStripMenuItem_Click);
            // 
            // bytAnvändarToolStripMenuItem
            // 
            this.bytAnvändarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.bytAnvändarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bytAnvändarToolStripMenuItem.Image")));
            this.bytAnvändarToolStripMenuItem.Name = "bytAnvändarToolStripMenuItem";
            this.bytAnvändarToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.bytAnvändarToolStripMenuItem.Text = "Byt namn";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1043, 493);
            this.Controls.Add(this.grbLogin);
            this.Controls.Add(this.tsPogramToolStrip);
            this.Controls.Add(this.grbChattlista);
            this.Controls.Add(this.grbChatt);
            this.Name = "Form1";
            this.Text = "Chatt Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbLogin.ResumeLayout(false);
            this.grbLogin.PerformLayout();
            this.grbChatt.ResumeLayout(false);
            this.grbChatt.PerformLayout();
            this.grbChattlista.ResumeLayout(false);
            this.tsPogramToolStrip.ResumeLayout(false);
            this.tsPogramToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLogin;
        private System.Windows.Forms.TextBox txbLösenord;
        private System.Windows.Forms.TextBox txbAnvändarnamn;
        private System.Windows.Forms.Label lblLösenord;
        private System.Windows.Forms.Label lblAnvändarnamn;
        private System.Windows.Forms.Button btnLoggaIn;
        private System.Windows.Forms.GroupBox grbChatt;
        private System.Windows.Forms.Button btnSkicka;
        private System.Windows.Forms.GroupBox grbChattlista;
        private System.Windows.Forms.Label lblInloggad;
        private System.Windows.Forms.Label lblStatusLogin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox lsbAnvändare;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.ToolStrip tsPogramToolStrip;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem loggaUtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bytAnvändarToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSendTo;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.RichTextBox txbChattText;
        private System.Windows.Forms.RichTextBox txbmeddelande;
    }
}

