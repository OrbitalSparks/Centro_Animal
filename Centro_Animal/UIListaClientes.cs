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
using Centro_animalDB;

namespace Centro_AnimalUI
{
    public partial class UIListaClientes : Form
    {
        public UIListaClientes()
        {
            InitializeComponent();

            ListaPersonas listaclientes = new ListaPersonas();
            foreach (Cliente listac in listaclientes.GetClientes())
            {
                int n = dataGridViewclient.Rows.Add();

                dataGridViewclient.Rows[n].Cells[0].Value = listac.id;
                dataGridViewclient.Rows[n].Cells[1].Value = listac.nombre;
                dataGridViewclient.Rows[n].Cells[2].Value = listac.apellidos;
                dataGridViewclient.Rows[n].Cells[3].Value = listac.DNI;
                dataGridViewclient.Rows[n].Cells[4].Value = listac.Telefono;
            }

        }
    }
}
