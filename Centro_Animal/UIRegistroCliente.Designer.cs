namespace Centro_AnimalUI
{
    partial class UIRegistroCliente
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
            this.groupBoxcliente = new System.Windows.Forms.GroupBox();
            this.labelid = new System.Windows.Forms.Label();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxtelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxdireccionnumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxdireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxdni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxapellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.dataGridViewclient = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirecNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxcliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewclient)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxcliente
            // 
            this.groupBoxcliente.Controls.Add(this.labelid);
            this.groupBoxcliente.Controls.Add(this.textBoxid);
            this.groupBoxcliente.Controls.Add(this.buttonModificar);
            this.groupBoxcliente.Controls.Add(this.buttoncancel);
            this.groupBoxcliente.Controls.Add(this.buttonRegistrar);
            this.groupBoxcliente.Controls.Add(this.label6);
            this.groupBoxcliente.Controls.Add(this.textBoxtelefono);
            this.groupBoxcliente.Controls.Add(this.label5);
            this.groupBoxcliente.Controls.Add(this.textBoxdireccionnumero);
            this.groupBoxcliente.Controls.Add(this.label4);
            this.groupBoxcliente.Controls.Add(this.textBoxdireccion);
            this.groupBoxcliente.Controls.Add(this.label3);
            this.groupBoxcliente.Controls.Add(this.textBoxdni);
            this.groupBoxcliente.Controls.Add(this.label2);
            this.groupBoxcliente.Controls.Add(this.textBoxapellido);
            this.groupBoxcliente.Controls.Add(this.label1);
            this.groupBoxcliente.Controls.Add(this.textBoxNombre);
            this.groupBoxcliente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxcliente.Location = new System.Drawing.Point(36, 23);
            this.groupBoxcliente.Name = "groupBoxcliente";
            this.groupBoxcliente.Size = new System.Drawing.Size(724, 394);
            this.groupBoxcliente.TabIndex = 0;
            this.groupBoxcliente.TabStop = false;
            this.groupBoxcliente.Text = "Datos Cliente";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(6, 41);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(37, 25);
            this.labelid.TabIndex = 18;
            this.labelid.Text = "ID:";
            // 
            // textBoxid
            // 
            this.textBoxid.Enabled = false;
            this.textBoxid.Location = new System.Drawing.Point(110, 33);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(240, 33);
            this.textBoxid.TabIndex = 17;
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(319, 320);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(106, 44);
            this.buttonModificar.TabIndex = 16;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttoncancel
            // 
            this.buttoncancel.Location = new System.Drawing.Point(109, 320);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(110, 44);
            this.buttoncancel.TabIndex = 15;
            this.buttoncancel.Text = "Cancelar";
            this.buttoncancel.UseVisualStyleBackColor = true;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(541, 320);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(102, 44);
            this.buttonRegistrar.TabIndex = 14;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefono:";
            // 
            // textBoxtelefono
            // 
            this.textBoxtelefono.Location = new System.Drawing.Point(109, 228);
            this.textBoxtelefono.MaxLength = 100;
            this.textBoxtelefono.Name = "textBoxtelefono";
            this.textBoxtelefono.Size = new System.Drawing.Size(240, 33);
            this.textBoxtelefono.TabIndex = 10;
            this.textBoxtelefono.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Numero:";
            // 
            // textBoxdireccionnumero
            // 
            this.textBoxdireccionnumero.Location = new System.Drawing.Point(457, 189);
            this.textBoxdireccionnumero.Name = "textBoxdireccionnumero";
            this.textBoxdireccionnumero.Size = new System.Drawing.Size(95, 33);
            this.textBoxdireccionnumero.TabIndex = 8;
            this.textBoxdireccionnumero.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Direccion:";
            // 
            // textBoxdireccion
            // 
            this.textBoxdireccion.Location = new System.Drawing.Point(109, 189);
            this.textBoxdireccion.Name = "textBoxdireccion";
            this.textBoxdireccion.Size = new System.Drawing.Size(240, 33);
            this.textBoxdireccion.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "DNI:";
            // 
            // textBoxdni
            // 
            this.textBoxdni.Location = new System.Drawing.Point(109, 150);
            this.textBoxdni.Name = "textBoxdni";
            this.textBoxdni.ShortcutsEnabled = false;
            this.textBoxdni.Size = new System.Drawing.Size(151, 33);
            this.textBoxdni.TabIndex = 4;
            this.textBoxdni.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido:";
            // 
            // textBoxapellido
            // 
            this.textBoxapellido.Location = new System.Drawing.Point(109, 111);
            this.textBoxapellido.Name = "textBoxapellido";
            this.textBoxapellido.Size = new System.Drawing.Size(240, 33);
            this.textBoxapellido.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(109, 72);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(240, 33);
            this.textBoxNombre.TabIndex = 0;
            // 
            // dataGridViewclient
            // 
            this.dataGridViewclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewclient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nombre,
            this.Apellido,
            this.DNI,
            this.telefono,
            this.Direccion,
            this.DirecNum});
            this.dataGridViewclient.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataGridViewclient.Location = new System.Drawing.Point(42, 439);
            this.dataGridViewclient.Name = "dataGridViewclient";
            this.dataGridViewclient.ReadOnly = true;
            this.dataGridViewclient.RowTemplate.Height = 25;
            this.dataGridViewclient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewclient.Size = new System.Drawing.Size(734, 268);
            this.dataGridViewclient.TabIndex = 3;
            this.dataGridViewclient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewclient_CellClick_1);
            this.dataGridViewclient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewclient_CellContentClick);
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
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 120;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.FillWeight = 300F;
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 120;
            // 
            // DirecNum
            // 
            this.DirecNum.HeaderText = "DirecNum";
            this.DirecNum.Name = "DirecNum";
            this.DirecNum.ReadOnly = true;
            this.DirecNum.Width = 80;
            // 
            // UIRegistroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(872, 719);
            this.Controls.Add(this.dataGridViewclient);
            this.Controls.Add(this.groupBoxcliente);
            this.Name = "UIRegistroCliente";
            this.Text = "UIRegistroCliente";
            this.groupBoxcliente.ResumeLayout(false);
            this.groupBoxcliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewclient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxcliente;
        private Label label6;
        private TextBox textBoxtelefono;
        private Label label5;
        private TextBox textBoxdireccionnumero;
        private Label label4;
        private TextBox textBoxdireccion;
        private Label label3;
        private TextBox textBoxdni;
        private Label label2;
        private TextBox textBoxapellido;
        private Label label1;
        private TextBox textBoxNombre;
        private Button buttoncancel;
        private Button buttonRegistrar;
        private Label labelid;
        private TextBox textBoxid;
        private Button buttonModificar;
        private DataGridView dataGridViewclient;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn DirecNum;
    }
}