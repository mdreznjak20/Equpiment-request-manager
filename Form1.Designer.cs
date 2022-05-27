namespace Equipment_request_manager
{
    partial class Login
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.krIme = new System.Windows.Forms.Label();
            this.sifra = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.gPrijava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(192, 80);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(183, 26);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // krIme
            // 
            this.krIme.AutoSize = true;
            this.krIme.Location = new System.Drawing.Point(188, 57);
            this.krIme.Name = "krIme";
            this.krIme.Size = new System.Drawing.Size(118, 20);
            this.krIme.TabIndex = 1;
            this.krIme.Text = "Korisničko ime :";
            // 
            // sifra
            // 
            this.sifra.AutoSize = true;
            this.sifra.Location = new System.Drawing.Point(188, 133);
            this.sifra.Name = "sifra";
            this.sifra.Size = new System.Drawing.Size(50, 20);
            this.sifra.TabIndex = 2;
            this.sifra.Text = "Šifra :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(192, 156);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(183, 26);
            this.txtPassword.TabIndex = 3;
            // 
            // gPrijava
            // 
            this.gPrijava.Location = new System.Drawing.Point(230, 214);
            this.gPrijava.Name = "gPrijava";
            this.gPrijava.Size = new System.Drawing.Size(91, 26);
            this.gPrijava.TabIndex = 4;
            this.gPrijava.Text = "Prijava";
            this.gPrijava.UseVisualStyleBackColor = true;
            this.gPrijava.Click += new System.EventHandler(this.gPrijava_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 325);
            this.Controls.Add(this.gPrijava);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.sifra);
            this.Controls.Add(this.krIme);
            this.Controls.Add(this.txtUsername);
            this.Name = "Login";
            this.Text = "Equipment Request Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label krIme;
        private System.Windows.Forms.Label sifra;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button gPrijava;
    }
}

