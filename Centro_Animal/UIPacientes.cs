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
using NPOI.SS.Formula.Functions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Centro_AnimalUI
{
    public partial class UIPacientes : Form
    {
        DataService dataService = new DataService();
        Cliente client = new Cliente();
        List<Regisanimal> listaanimatesconduenio = new List<Regisanimal>();

        Regisanimal animatesconduenio = new Regisanimal();
        public UIPacientes()
        {
            InitializeComponent();
            cargardatos();

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridViewclient2.Rows.Clear();
            cargardatosfiltrado(textBoxBusqueda.Text);
        }

        private void cargardatos()
        {
            listaanimatesconduenio = dataService.GETlistaconduenio();

            foreach (Regisanimal mascota in listaanimatesconduenio)
            {
                int n = dataGridViewclient2.Rows.Add();
                dataGridViewclient2.Rows[n].Cells[0].Value = mascota.IDanimal;
                dataGridViewclient2.Rows[n].Cells[1].Value = mascota.NombreAnimal;
                dataGridViewclient2.Rows[n].Cells[2].Value = mascota.nombre;
                dataGridViewclient2.Rows[n].Cells[3].Value = mascota.IDDuenio;
                dataGridViewclient2.Rows[n].Cells[4].Value = mascota.especie;
                dataGridViewclient2.Rows[n].Cells[5].Value = mascota.raza;
                dataGridViewclient2.Rows[n].Cells[6].Value = mascota.PesoAnimal;
                dataGridViewclient2.Rows[n].Cells[7].Value = mascota.fechaIngreso;
                dataGridViewclient2.Rows[n].Cells[8].Value = mascota.fechaNacimento;
                dataGridViewclient2.Rows[n].Cells[9].Value = mascota.sexo;
            }
        }
        private void cargardatosfiltrado(string dato)
        {
            listaanimatesconduenio = dataService.GETanimalfiltadro(dato);

            foreach (Regisanimal mascota in listaanimatesconduenio)
            {
                int n = dataGridViewclient2.Rows.Add();
                dataGridViewclient2.Rows[n].Cells[0].Value = mascota.IDanimal;
                dataGridViewclient2.Rows[n].Cells[1].Value = mascota.NombreAnimal;
                dataGridViewclient2.Rows[n].Cells[2].Value = mascota.nombre;
                dataGridViewclient2.Rows[n].Cells[3].Value = mascota.IDDuenio;
                dataGridViewclient2.Rows[n].Cells[4].Value = mascota.especie;
                dataGridViewclient2.Rows[n].Cells[5].Value = mascota.raza;
                dataGridViewclient2.Rows[n].Cells[6].Value = mascota.PesoAnimal;
                dataGridViewclient2.Rows[n].Cells[7].Value = mascota.fechaIngreso;
                dataGridViewclient2.Rows[n].Cells[8].Value = mascota.fechaNacimento;
                dataGridViewclient2.Rows[n].Cells[9].Value = mascota.sexo;
            }
        }

        private void buttonmascotaselec_Click(object sender, EventArgs e)
        {
            if (animatesconduenio != null)
            {
                UIHistoriaclinica uIHistoriaclinica = new UIHistoriaclinica(animatesconduenio);
                uIHistoriaclinica.Show();
                this.Close();

            }
            else {
                MessageBox.Show("Seleccione un Mascota");
            }
        }

        private void dataGridViewclient2_CellClick(object sender, DataGridViewCellEventArgs e)
{
            animatesconduenio.IDanimal = int.Parse(dataGridViewclient2.SelectedCells[0].Value.ToString());
            animatesconduenio.NombreAnimal = dataGridViewclient2.SelectedCells[1].Value.ToString();
            animatesconduenio.nombre = dataGridViewclient2.SelectedCells[2].Value.ToString();
            animatesconduenio.IDDuenio = int.Parse(dataGridViewclient2.SelectedCells[3].Value.ToString());
            animatesconduenio.especie = int.Parse(dataGridViewclient2.SelectedCells[4].Value.ToString());
            animatesconduenio.raza = dataGridViewclient2.SelectedCells[5].Value.ToString();
            animatesconduenio.PesoAnimal = double.Parse(dataGridViewclient2.SelectedCells[6].Value.ToString());
            animatesconduenio.sexo = int.Parse(dataGridViewclient2.SelectedCells[9].Value.ToString()); ;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UICentro uICentro = new UICentro();
            uICentro.Show();
            this.Close();
        }
    }
}   
