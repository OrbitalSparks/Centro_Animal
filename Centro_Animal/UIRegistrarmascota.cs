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
    public partial class UIRegistrarmascota : Form
    {
        public UIRegistrarmascota()
        {
            InitializeComponent();

            ListaPersonas listaclientes = new ListaPersonas();
            foreach (Cliente listac in listaclientes.GetClientes())
            {
                comboBoxdueño.Items.Add(listac.nombre.ToString());
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBoxedadmascota.Text = (DateTime.Now.Year - dateTimePicker1.Value.Year).ToString();
        }


        private void comboBoxdueño_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
