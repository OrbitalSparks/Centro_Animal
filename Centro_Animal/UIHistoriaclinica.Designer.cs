namespace Centro_AnimalUI
{
    partial class UIHistoriaclinica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIHistoriaclinica));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonvolver = new System.Windows.Forms.Button();
            this.button1nuevaconsulta = new System.Windows.Forms.Button();
            this.label1datosmascota = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelhistoriaclin = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1datosduenio = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(77, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(852, 602);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.buttonvolver);
            this.tabPage1.Controls.Add(this.button1nuevaconsulta);
            this.tabPage1.Controls.Add(this.label1datosmascota);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(844, 574);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Historia Clinica";
            // 
            // buttonvolver
            // 
            this.buttonvolver.Location = new System.Drawing.Point(81, 509);
            this.buttonvolver.Name = "buttonvolver";
            this.buttonvolver.Size = new System.Drawing.Size(184, 43);
            this.buttonvolver.TabIndex = 6;
            this.buttonvolver.Text = "Volver";
            this.buttonvolver.UseVisualStyleBackColor = true;
            this.buttonvolver.Click += new System.EventHandler(this.buttonvolver_Click);
            // 
            // button1nuevaconsulta
            // 
            this.button1nuevaconsulta.Location = new System.Drawing.Point(479, 509);
            this.button1nuevaconsulta.Name = "button1nuevaconsulta";
            this.button1nuevaconsulta.Size = new System.Drawing.Size(184, 43);
            this.button1nuevaconsulta.TabIndex = 5;
            this.button1nuevaconsulta.Text = "Nueva Consulta";
            this.button1nuevaconsulta.UseVisualStyleBackColor = true;
            this.button1nuevaconsulta.Click += new System.EventHandler(this.button1nuevaconsulta_Click);
            // 
            // label1datosmascota
            // 
            this.label1datosmascota.AutoSize = true;
            this.label1datosmascota.Location = new System.Drawing.Point(26, 25);
            this.label1datosmascota.Name = "label1datosmascota";
            this.label1datosmascota.Size = new System.Drawing.Size(148, 21);
            this.label1datosmascota.TabIndex = 2;
            this.label1datosmascota.Text = "Sin datos Mascota";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Controls.Add(this.labelhistoriaclin);
            this.panel1.Location = new System.Drawing.Point(26, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 329);
            this.panel1.TabIndex = 1;
            // 
            // labelhistoriaclin
            // 
            this.labelhistoriaclin.AutoSize = true;
            this.labelhistoriaclin.Location = new System.Drawing.Point(28, 21);
            this.labelhistoriaclin.Name = "labelhistoriaclin";
            this.labelhistoriaclin.Size = new System.Drawing.Size(0, 21);
            this.labelhistoriaclin.TabIndex = 0;
            this.labelhistoriaclin.Click += new System.EventHandler(this.labelhistoriaclin_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.NavajoWhite;
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.label1datosduenio);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(844, 574);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos Dueño";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 345);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(778, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1datosduenio
            // 
            this.label1datosduenio.AutoSize = true;
            this.label1datosduenio.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1datosduenio.Location = new System.Drawing.Point(45, 31);
            this.label1datosduenio.Name = "label1datosduenio";
            this.label1datosduenio.Size = new System.Drawing.Size(213, 30);
            this.label1datosduenio.TabIndex = 0;
            this.label1datosduenio.Text = "Sin Datos del Dueño";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(479, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(330, 143);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // UIHistoriaclinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1240, 654);
            this.Controls.Add(this.tabControl1);
            this.Name = "UIHistoriaclinica";
            this.Text = "UIHistoriaclinica";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1datosmascota;
        private Label labelhistoriaclin;
        private TabPage tabPage2;
        private Label label1datosduenio;
        private Button button1nuevaconsulta;
        private Button buttonvolver;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}