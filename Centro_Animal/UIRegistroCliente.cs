using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centro_animal.Entities;
using Centro_Animal;
using Centro_animal_Services;
using Centro_animalDB;

namespace Centro_AnimalUI
{
    public partial class UIRegistroCliente : Form
    {
        DataService dataService = new DataService();
        List<Cliente> clientes = new List<Cliente>();
        Cliente client = new Cliente();
        Validaciones validaciones = new Validaciones();

        public string a;

        public UIRegistroCliente()
        {
            InitializeComponent();
            clientes=dataService.GETCleintes();
            llenartabla();

        }
        public UIRegistroCliente(int num)
        {
            InitializeComponent();
            clientes = dataService.GETCleintes();
            llenartabla();
            buttonModificar.Hide();

        }
        public UIRegistroCliente(string str)
        {
            InitializeComponent();
            clientes = dataService.GETCleintes();
            llenartabla();
            buttonRegistrar.Hide();

        }


        private void buttonModificar_Click(object sender, EventArgs e)
        {
            client.nombre = textBoxNombre.Text;
            client.apellido = textBoxapellido.Text;
            client.Telefono = int.Parse(textBoxtelefono.Text);
            client.DNI = int.Parse(textBoxdni.Text);
            client.id = int.Parse(textBoxid.Text);
            client.Calle = textBoxdireccion.Text;
            client.Numero = int.Parse(textBoxdireccionnumero.Text);
            a = dataService.MODIFCliente(client);
            metele();
        }

        public void llenartabla()
        {

            foreach (Cliente listac in clientes )
            {
                int n = dataGridViewclient.Rows.Add();
                dataGridViewclient.Rows[n].Cells[0].Value = listac.id;
                dataGridViewclient.Rows[n].Cells[1].Value = listac.nombre;
                dataGridViewclient.Rows[n].Cells[2].Value = listac.apellido;
                dataGridViewclient.Rows[n].Cells[3].Value = listac.DNI;
                dataGridViewclient.Rows[n].Cells[4].Value = listac.Telefono;
                dataGridViewclient.Rows[n].Cells[5].Value = listac.Calle;
                dataGridViewclient.Rows[n].Cells[6].Value = listac.Numero;


            }
            

        }
        public void metele()
        {
            dataGridViewclient.Rows.Clear();
            clientes = dataService.GETCleintes();
            llenartabla();
        }


        private void dataGridViewclient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewclient_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBoxid.Text = dataGridViewclient.SelectedCells[0].Value.ToString();
            textBoxNombre.Text = dataGridViewclient.SelectedCells[1].Value.ToString();
            textBoxapellido.Text = dataGridViewclient.SelectedCells[2].Value.ToString();
            textBoxdni.Text = dataGridViewclient.SelectedCells[3].Value.ToString();
            textBoxtelefono.Text = dataGridViewclient.SelectedCells[4].Value.ToString();
            textBoxdireccion.Text = dataGridViewclient.SelectedCells[5].Value.ToString();
            textBoxdireccionnumero.Text = dataGridViewclient.SelectedCells[6].Value.ToString();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
                string ResponseValidator;

                client.nombre = textBoxNombre.Text;
                client.apellido = textBoxapellido.Text;
                client.Telefono = int.Parse(textBoxtelefono.Text);
                client.DNI = int.Parse(textBoxdni.Text);
                //client.id = int.Parse(textBoxid.Text);
                client.Calle = textBoxdireccion.Text;
                client.Numero = int.Parse(textBoxdireccionnumero.Text);
                
                
                ResponseValidator = validaciones.Validator(client);

            if (ResponseValidator == string.Empty)
            {
                a = dataService.CrearCliente(client);
                dataGridViewclient.Rows.Clear();
                clientes = dataService.GETCleintes();
                llenartabla();

            }
            else
            {
                MessageBox.Show(ResponseValidator);
            }


        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            UICentro uICentro = new UICentro();
            uICentro.Show();
            this.Close();
        }
    }
}
