namespace ChattrumClient2
{
    partial class Form2
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
            this.grbLogin = new System.Windows.Forms.GroupBox();
            this.btnLoggaIn = new System.Windows.Forms.Button();
            this.txbLösenord = new System.Windows.Forms.TextBox();
            this.txbAnvändarnamn = new System.Windows.Forms.TextBox();
            this.lblLösenord = new System.Windows.Forms.Label();
            this.lblAnvändarnamn = new System.Windows.Forms.Label();
            this.grbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLogin
            // 
            this.grbLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grbLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.grbLogin.Controls.Add(this.btnLoggaIn);
            this.grbLogin.Controls.Add(this.txbLösenord);
            this.grbLogin.Controls.Add(this.txbAnvändarnamn);
            this.grbLogin.Controls.Add(this.lblLösenord);
            this.grbLogin.Controls.Add(this.lblAnvändarnamn);
            this.grbLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.grbLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbLogin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLogin.Location = new System.Drawing.Point(12, 12);
            this.grbLogin.Name = "grbLogin";
            this.grbLogin.Size = new System.Drawing.Size(137, 229);
            this.grbLogin.TabIndex = 1;
            this.grbLogin.TabStop = false;
            this.grbLogin.Text = "Inloggning";
            // 
            // btnLoggaIn
            // 
            this.btnLoggaIn.Location = new System.Drawing.Point(25, 157);
            this.btnLoggaIn.Name = "btnLoggaIn";
            this.btnLoggaIn.Size = new System.Drawing.Size(90, 31);
            this.btnLoggaIn.TabIndex = 4;
            this.btnLoggaIn.Text = "Logga in";
            this.btnLoggaIn.UseVisualStyleBackColor = true;
            // 
            // txbLösenord
            // 
            this.txbLösenord.Location = new System.Drawing.Point(20, 125);
            this.txbLösenord.Name = "txbLösenord";
            this.txbLösenord.PasswordChar = '*';
            this.txbLösenord.Size = new System.Drawing.Size(100, 26);
            this.txbLösenord.TabIndex = 3;
            this.txbLösenord.UseSystemPasswordChar = true;
            // 
            // txbAnvändarnamn
            // 
            this.txbAnvändarnamn.Location = new System.Drawing.Point(20, 74);
            this.txbAnvändarnamn.Name = "txbAnvändarnamn";
            this.txbAnvändarnamn.Size = new System.Drawing.Size(100, 26);
            this.txbAnvändarnamn.TabIndex = 2;
            // 
            // lblLösenord
            // 
            this.lblLösenord.AutoSize = true;
            this.lblLösenord.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLösenord.Location = new System.Drawing.Point(25, 103);
            this.lblLösenord.Name = "lblLösenord";
            this.lblLösenord.Size = new System.Drawing.Size(85, 19);
            this.lblLösenord.TabIndex = 1;
            this.lblLösenord.Text = "Lösenord:";
            // 
            // lblAnvändarnamn
            // 
            this.lblAnvändarnamn.AutoSize = true;
            this.lblAnvändarnamn.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnvändarnamn.Location = new System.Drawing.Point(11, 53);
            this.lblAnvändarnamn.Name = "lblAnvändarnamn";
            this.lblAnvändarnamn.Size = new System.Drawing.Size(120, 18);
            this.lblAnvändarnamn.TabIndex = 0;
            this.lblAnvändarnamn.Text = "Användarnamn:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(162, 253);
            this.Controls.Add(this.grbLogin);
            this.Name = "Form2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grbLogin.ResumeLayout(false);
            this.grbLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLogin;
        private System.Windows.Forms.Button btnLoggaIn;
        private System.Windows.Forms.TextBox txbLösenord;
        private System.Windows.Forms.TextBox txbAnvändarnamn;
        private System.Windows.Forms.Label lblLösenord;
        private System.Windows.Forms.Label lblAnvändarnamn;
    }
}

