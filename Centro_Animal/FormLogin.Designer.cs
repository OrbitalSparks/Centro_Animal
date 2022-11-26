namespace Centro_AnimalUI
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonUsuario = new System.Windows.Forms.Button();
            this.labelBandera = new System.Windows.Forms.Label();
            this.labelingreso = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.labeluser = new System.Windows.Forms.Label();
            this.textBoxpassword2 = new System.Windows.Forms.TextBox();
            this.textBoxuser2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(38, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(352, 310);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // buttonUsuario
            // 
            this.buttonUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUsuario.Location = new System.Drawing.Point(483, 327);
            this.buttonUsuario.Name = "buttonUsuario";
            this.buttonUsuario.Size = new System.Drawing.Size(177, 29);
            this.buttonUsuario.TabIndex = 41;
            this.buttonUsuario.Text = "Ingresar";
            this.buttonUsuario.UseVisualStyleBackColor = false;
            this.buttonUsuario.Click += new System.EventHandler(this.buttonUsuario_Click);
            // 
            // labelBandera
            // 
            this.labelBandera.AutoSize = true;
            this.labelBandera.ForeColor = System.Drawing.Color.Red;
            this.labelBandera.Location = new System.Drawing.Point(503, 292);
            this.labelBandera.Name = "labelBandera";
            this.labelBandera.Size = new System.Drawing.Size(135, 15);
            this.labelBandera.TabIndex = 40;
            this.labelBandera.Text = "Error: Usuario Incorrecto";
            this.labelBandera.Visible = false;
            // 
            // labelingreso
            // 
            this.labelingreso.AutoSize = true;
            this.labelingreso.BackColor = System.Drawing.Color.Transparent;
            this.labelingreso.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelingreso.Location = new System.Drawing.Point(438, 153);
            this.labelingreso.Name = "labelingreso";
            this.labelingreso.Size = new System.Drawing.Size(148, 21);
            this.labelingreso.TabIndex = 39;
            this.labelingreso.Text = " Ingreso al Sistema :";
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelpassword.Location = new System.Drawing.Point(438, 244);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(118, 21);
            this.labelpassword.TabIndex = 38;
            this.labelpassword.Text = "CONTRASEÑA :";
            // 
            // labeluser
            // 
            this.labeluser.AutoSize = true;
            this.labeluser.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeluser.Location = new System.Drawing.Point(438, 186);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(84, 21);
            this.labeluser.TabIndex = 37;
            this.labeluser.Text = "USUARIO :";
            // 
            // textBoxpassword2
            // 
            this.textBoxpassword2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxpassword2.Location = new System.Drawing.Point(438, 266);
            this.textBoxpassword2.MaxLength = 32;
            this.textBoxpassword2.Name = "textBoxpassword2";
            this.textBoxpassword2.PasswordChar = '*';
            this.textBoxpassword2.Size = new System.Drawing.Size(269, 23);
            this.textBoxpassword2.TabIndex = 36;
            // 
            // textBoxuser2
            // 
            this.textBoxuser2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxuser2.Location = new System.Drawing.Point(438, 208);
            this.textBoxuser2.MaxLength = 100;
            this.textBoxuser2.Name = "textBoxuser2";
            this.textBoxuser2.Size = new System.Drawing.Size(269, 23);
            this.textBoxuser2.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(448, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 27);
            this.label3.TabIndex = 34;
            this.label3.Text = " Veterinaria \"Valentin\"";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(120, 0, 120, 20);
            this.label1.Size = new System.Drawing.Size(801, 52);
            this.label1.TabIndex = 33;
            this.label1.Text = "Centro de Salud Animal | \"Valentin\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonUsuario);
            this.Controls.Add(this.labelBandera);
            this.Controls.Add(this.labelingreso);
            this.Controls.Add(this.labelpassword);
            this.Controls.Add(this.labeluser);
            this.Controls.Add(this.textBoxpassword2);
            this.Controls.Add(this.textBoxuser2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox2;
        private Button buttonUsuario;
        private Label labelBandera;
        private Label labelingreso;
        private Label labelpassword;
        private Label labeluser;
        private TextBox textBoxpassword2;
        private TextBox textBoxuser2;
        private Label label3;
        private Label label1;
    }
}