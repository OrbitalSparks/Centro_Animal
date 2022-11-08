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
    public partial class UIListamascotas : Form
    {

        
       
        public UIListamascotas()
        {
            InitializeComponent();
            Listamascotas listamascotas = new Listamascotas();
            foreach (Animal listaM in listamascotas.GetAnimales())
            {
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value= listaM.IDanimal ;
                dataGridView1.Rows[n].Cells[1].Value = listaM.NombreAnimal;
                dataGridView1.Rows[n].Cells[2].Value = listaM.raza;
                dataGridView1.Rows[n].Cells[3].Value = listaM.IDDuenio;
                dataGridView1.Rows[n].Cells[4].Value = listaM.PesoAnimal+" Kg/s";
            }
   
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
