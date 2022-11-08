namespace Centro_AnimalUI
{
    partial class UIRegistrarmascota
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
            this.groupBoxcmascota = new System.Windows.Forms.GroupBox();
            this.comboBoxdueño = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxespecie = new System.Windows.Forms.ComboBox();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxpeso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxedadmascota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxraza = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.groupBoxcmascota.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxcmascota
            // 
            this.groupBoxcmascota.Controls.Add(this.comboBoxdueño);
            this.groupBoxcmascota.Controls.Add(this.label9);
            this.groupBoxcmascota.Controls.Add(this.comboBoxespecie);
            this.groupBoxcmascota.Controls.Add(this.comboBoxSexo);
            this.groupBoxcmascota.Controls.Add(this.label8);
            this.groupBoxcmascota.Controls.Add(this.dateTimePicker1);
            this.groupBoxcmascota.Controls.Add(this.button2);
            this.groupBoxcmascota.Controls.Add(this.button1);
            this.groupBoxcmascota.Controls.Add(this.label7);
            this.groupBoxcmascota.Controls.Add(this.textBoxpeso);
            this.groupBoxcmascota.Controls.Add(this.label6);
            this.groupBoxcmascota.Controls.Add(this.label5);
            this.groupBoxcmascota.Controls.Add(this.textBoxedadmascota);
            this.groupBoxcmascota.Controls.Add(this.label4);
            this.groupBoxcmascota.Controls.Add(this.textBoxraza);
            this.groupBoxcmascota.Controls.Add(this.label3);
            this.groupBoxcmascota.Controls.Add(this.label1);
            this.groupBoxcmascota.Controls.Add(this.textBoxNombre);
            this.groupBoxcmascota.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxcmascota.Location = new System.Drawing.Point(38, 35);
            this.groupBoxcmascota.Name = "groupBoxcmascota";
            this.groupBoxcmascota.Size = new System.Drawing.Size(724, 380);
            this.groupBoxcmascota.TabIndex = 1;
            this.groupBoxcmascota.TabStop = false;
            this.groupBoxcmascota.Text = "Datos Mascota";
            // 
            // comboBoxdueño
            // 
            this.comboBoxdueño.FormattingEnabled = true;
            this.comboBoxdueño.Location = new System.Drawing.Point(110, 71);
            this.comboBoxdueño.Name = "comboBoxdueño";
            this.comboBoxdueño.Size = new System.Drawing.Size(121, 33);
            this.comboBoxdueño.TabIndex = 22;
            this.comboBoxdueño.SelectedIndexChanged += new System.EventHandler(this.comboBoxdueño_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Dueño:";
            // 
            // comboBoxespecie
            // 
            this.comboBoxespecie.FormattingEnabled = true;
            this.comboBoxespecie.Items.AddRange(new object[] {
            "Perro",
            "Gato",
            "Conejo",
            "Otro"});
            this.comboBoxespecie.Location = new System.Drawing.Point(448, 154);
            this.comboBoxespecie.Name = "comboBoxespecie";
            this.comboBoxespecie.Size = new System.Drawing.Size(121, 33);
            this.comboBoxespecie.TabIndex = 19;
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Items.AddRange(new object[] {
            "Macho",
            "Hembra"});
            this.comboBoxSexo.Location = new System.Drawing.Point(110, 193);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(121, 33);
            this.comboBoxSexo.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Sexo:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(205, 121);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 27);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(458, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 44);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 44);
            this.button1.TabIndex = 14;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Peso Kg/s:";
            // 
            // textBoxpeso
            // 
            this.textBoxpeso.Location = new System.Drawing.Point(110, 232);
            this.textBoxpeso.Name = "textBoxpeso";
            this.textBoxpeso.Size = new System.Drawing.Size(240, 33);
            this.textBoxpeso.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Especie:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Edad:";
            // 
            // textBoxedadmascota
            // 
            this.textBoxedadmascota.Enabled = false;
            this.textBoxedadmascota.Location = new System.Drawing.Point(428, 115);
            this.textBoxedadmascota.Name = "textBoxedadmascota";
            this.textBoxedadmascota.Size = new System.Drawing.Size(95, 33);
            this.textBoxedadmascota.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Raza:";
            // 
            // textBoxraza
            // 
            this.textBoxraza.Location = new System.Drawing.Point(110, 154);
            this.textBoxraza.Name = "textBoxraza";
            this.textBoxraza.Size = new System.Drawing.Size(240, 33);
            this.textBoxraza.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de nacimento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(110, 32);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(240, 33);
            this.textBoxNombre.TabIndex = 0;
            // 
            // UIRegistrarmascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxcmascota);
            this.Name = "UIRegistrarmascota";
            this.Text = "UIRegistrarmascota";
            this.groupBoxcmascota.ResumeLayout(false);
            this.groupBoxcmascota.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxcmascota;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Button button1;
        private Label label7;
        private TextBox textBoxpeso;
        private Label label6;
        private Label label5;
        private TextBox textBoxedadmascota;
        private Label label4;
        private TextBox textBoxraza;
        private Label label3;
        private Label label2;
        private TextBox textBoxapellido;
        private Label label1;
        private TextBox textBoxNombre;
        private ComboBox comboBoxSexo;
        private Label label8;
        private ComboBox comboBoxespecie;
        private Label label9;
        private ComboBox comboBoxdueño;
    }
}