namespace Centro_AnimalUI
{
    partial class UIListamascotas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewclient2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.dataGridViewclient2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(25, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 542);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Mascotas";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(386, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 70);
            this.button2.TabIndex = 9;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.Fechanac});
            this.dataGridViewclient2.Location = new System.Drawing.Point(6, 55);
            this.dataGridViewclient2.Name = "dataGridViewclient2";
            this.dataGridViewclient2.ReadOnly = true;
            this.dataGridViewclient2.RowTemplate.Height = 25;
            this.dataGridViewclient2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewclient2.Size = new System.Drawing.Size(970, 381);
            this.dataGridViewclient2.TabIndex = 3;
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
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.HeaderText = "Fecha de Ingreso";
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.ReadOnly = true;
            this.FechaIngreso.Width = 120;
            // 
            // Fechanac
            // 
            this.Fechanac.HeaderText = "Fecha Nacimeinto";
            this.Fechanac.Name = "Fechanac";
            this.Fechanac.ReadOnly = true;
            this.Fechanac.Width = 120;
            // 
            // UIListamascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1061, 582);
            this.Controls.Add(this.groupBox1);
            this.Name = "UIListamascotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UIListamascotas";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewclient2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridViewclient2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn Dueño;
        private DataGridViewTextBoxColumn IDdueño;
        private DataGridViewTextBoxColumn Especie;
        private DataGridViewTextBoxColumn Raza;
        private DataGridViewTextBoxColumn Peso;
        private DataGridViewTextBoxColumn FechaIngreso;
        private DataGridViewTextBoxColumn Fechanac;
        private Button button2;
    }
}