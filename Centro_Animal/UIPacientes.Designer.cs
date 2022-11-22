namespace Centro_AnimalUI
{
    partial class UIPacientes
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
            this.buttonmascotaselec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.dataGridViewclient2 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dueño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDdueño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fechanac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewclient2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonmascotaselec
            // 
            this.buttonmascotaselec.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonmascotaselec.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonmascotaselec.Location = new System.Drawing.Point(1022, 169);
            this.buttonmascotaselec.Name = "buttonmascotaselec";
            this.buttonmascotaselec.Size = new System.Drawing.Size(142, 97);
            this.buttonmascotaselec.TabIndex = 7;
            this.buttonmascotaselec.Text = "Seleccionar";
            this.buttonmascotaselec.UseVisualStyleBackColor = true;
            this.buttonmascotaselec.Click += new System.EventHandler(this.buttonmascotaselec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(74, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar Mascota :";
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Location = new System.Drawing.Point(330, 54);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(260, 23);
            this.textBoxBusqueda.TabIndex = 5;
            this.textBoxBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // dataGridViewclient2
            // 
            this.dataGridViewclient2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewclient2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nombre,
            this.Dueño,
            this.IDdueño,
            this.Especie,
            this.Raza,
            this.Peso,
            this.FechaIngreso,
            this.Fechanac,
            this.Genero});
            this.dataGridViewclient2.Location = new System.Drawing.Point(12, 135);
            this.dataGridViewclient2.Name = "dataGridViewclient2";
            this.dataGridViewclient2.ReadOnly = true;
            this.dataGridViewclient2.RowTemplate.Height = 25;
            this.dataGridViewclient2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewclient2.Size = new System.Drawing.Size(989, 407);
            this.dataGridViewclient2.TabIndex = 4;
            this.dataGridViewclient2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewclient2_CellClick);
            this.dataGridViewclient2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewclient2_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 120;
            // 
            // Dueño
            // 
            this.Dueño.HeaderText = "Dueño";
            this.Dueño.Name = "Dueño";
            this.Dueño.ReadOnly = true;
            this.Dueño.Width = 120;
            // 
            // IDdueño
            // 
            this.IDdueño.HeaderText = "IDdueño";
            this.IDdueño.Name = "IDdueño";
            this.IDdueño.ReadOnly = true;
            // 
            // Especie
            // 
            this.Especie.HeaderText = "Especie";
            this.Especie.Name = "Especie";
            this.Especie.ReadOnly = true;
            // 
            // Raza
            // 
            this.Raza.HeaderText = "Raza";
            this.Raza.Name = "Raza";
            this.Raza.ReadOnly = true;
            // 
            // Peso
            // 
            this.Peso.FillWeight = 300F;
            this.Peso.HeaderText = "Peso(KG/s)";
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            this.Peso.Width = 80;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.HeaderText = "Fecha de Ingreso";
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.ReadOnly = true;
            // 
            // Fechanac
            // 
            this.Fechanac.HeaderText = "Fecha Nacimeinto";
            this.Fechanac.Name = "Fechanac";
            this.Fechanac.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            this.Genero.Width = 80;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(1022, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 97);
            this.button1.TabIndex = 8;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UIPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1197, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBusqueda);
            this.Controls.Add(this.buttonmascotaselec);
            this.Controls.Add(this.dataGridViewclient2);
            this.Name = "UIPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UIPacientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewclient2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBoxBusqueda;
        private DataGridView dataGridViewclient2;
        private Label label1;
        private Button buttonmascotaselec;
        private Button button1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn Dueño;
        private DataGridViewTextBoxColumn IDdueño;
        private DataGridViewTextBoxColumn Especie;
        private DataGridViewTextBoxColumn Raza;
        private DataGridViewTextBoxColumn Peso;
        private DataGridViewTextBoxColumn FechaIngreso;
        private DataGridViewTextBoxColumn Fechanac;
        private DataGridViewTextBoxColumn Genero;
    }
}