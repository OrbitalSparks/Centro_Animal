using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centro_animal.Entities;
using Centro_Animal;
using Centro_animal_Services;
using Centro_animalDB;

namespace Centro_AnimalUI
{
    public partial class UIListaClientes : Form
    {
        DataService dataService = new DataService();
        List<Cliente> clientes = new List<Cliente>();
        Cliente client = new Cliente();


        public UIListaClientes()
        {
            InitializeComponent();
            clientes = dataService.GETCleintes();

            foreach (Cliente listac in clientes)
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

        private void buttonvolver_Click(object sender, EventArgs e)
        {
            UICentro uICentro = new UICentro();
            uICentro.Show();
            this.Close();
        }
    }
}
