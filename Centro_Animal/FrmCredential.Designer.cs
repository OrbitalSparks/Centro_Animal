namespace DDJJDesktop
{
    partial class FrmCredential
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBandera = new System.Windows.Forms.Label();
            this.labelingreso = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.labeluser = new System.Windows.Forms.Label();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.textBoxuser = new System.Windows.Forms.TextBox();
            this.buttonUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(268, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 27);
            this.label3.TabIndex = 21;
            this.label3.Text = " Veterinaria \"Valentin\"";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, -2);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(120, 0, 120, 20);
            this.label1.Size = new System.Drawing.Size(797, 52);
            this.label1.TabIndex = 19;
            this.label1.Text = "Centro de Salud Animal | \"Valentin\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelBandera
            // 
            this.labelBandera.AutoSize = true;
            this.labelBandera.ForeColor = System.Drawing.Color.Red;
            this.labelBandera.Location = new System.Drawing.Point(323, 293);
            this.labelBandera.Name = "labelBandera";
            this.labelBandera.Size = new System.Drawing.Size(135, 15);
            this.labelBandera.TabIndex = 29;
            this.labelBandera.Text = "Error: Usuario Incorrecto";
            this.labelBandera.Visible = false;
            // 
            // labelingreso
            // 
            this.labelingreso.AutoSize = true;
            this.labelingreso.BackColor = System.Drawing.Color.Transparent;
            this.labelingreso.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelingreso.Location = new System.Drawing.Point(258, 154);
            this.labelingreso.Name = "labelingreso";
            this.labelingreso.Size = new System.Drawing.Size(148, 21);
            this.labelingreso.TabIndex = 28;
            this.labelingreso.Text = " Ingreso al Sistema :";
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelpassword.Location = new System.Drawing.Point(258, 245);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(118, 21);
            this.labelpassword.TabIndex = 27;
            this.labelpassword.Text = "CONTRASEÑA :";
            // 
            // labeluser
            // 
            this.labeluser.AutoSize = true;
            this.labeluser.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeluser.Location = new System.Drawing.Point(258, 187);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(84, 21);
            this.labeluser.TabIndex = 26;
            this.labeluser.Text = "USUARIO :";
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxpassword.Location = new System.Drawing.Point(258, 267);
            this.textBoxpassword.MaxLength = 32;
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.PasswordChar = '*';
            this.textBoxpassword.Size = new System.Drawing.Size(265, 23);
            this.textBoxpassword.TabIndex = 25;
            // 
            // textBoxuser
            // 
            this.textBoxuser.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxuser.Location = new System.Drawing.Point(258, 209);
            this.textBoxuser.MaxLength = 100;
            this.textBoxuser.Name = "textBoxuser";
            this.textBoxuser.Size = new System.Drawing.Size(265, 23);
            this.textBoxuser.TabIndex = 24;
            // 
            // buttonUsuario
            // 
            this.buttonUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUsuario.Location = new System.Drawing.Point(303, 328);
            this.buttonUsuario.Name = "buttonUsuario";
            this.buttonUsuario.Size = new System.Drawing.Size(173, 29);
            this.buttonUsuario.TabIndex = 30;
            this.buttonUsuario.Text = "Ingresar";
            this.buttonUsuario.UseVisualStyleBackColor = false;
            this.buttonUsuario.Click += new System.EventHandler(this.buttonUsuario_Click);
            // 
            // FrmCredential
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUsuario);
            this.Controls.Add(this.labelBandera);
            this.Controls.Add(this.labelingreso);
            this.Controls.Add(this.labelpassword);
            this.Controls.Add(this.labeluser);
            this.Controls.Add(this.textBoxpassword);
            this.Controls.Add(this.textBoxuser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmCredential";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credential";
            this.Load += new System.EventHandler(this.FrmCredential_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private Label label1;
        private Label labelBandera;
        private Label labelingreso;
        private Label labelpassword;
        private Label labeluser;
        private TextBox textBoxpassword;
        private TextBox textBoxuser;
        private Button buttonUsuario;
    }
}