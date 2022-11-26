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
    public partial class UIListamascotas : Form
    {

        DataService dataService = new DataService();
        List<Regisanimal> listaanimatesconduenio = new List<Regisanimal>();
        Validaciones Validaciones  = new Validaciones();

        public UIListamascotas()
        {
            InitializeComponent();
            listaanimatesconduenio = dataService.GETlistaconduenio();
            llenartabla();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void llenartabla()
        {

            foreach (Regisanimal mascota in listaanimatesconduenio)
            {
                int n = dataGridViewclient2.Rows.Add();
                dataGridViewclient2.Rows[n].Cells[0].Value = mascota.IDanimal;
                dataGridViewclient2.Rows[n].Cells[1].Value = mascota.NombreAnimal;
                dataGridViewclient2.Rows[n].Cells[2].Value = mascota.nombre;
                dataGridViewclient2.Rows[n].Cells[3].Value = mascota.IDDuenio;
                dataGridViewclient2.Rows[n].Cells[4].Value = Validaciones.VerEspecie(mascota.especie);
                dataGridViewclient2.Rows[n].Cells[5].Value = mascota.raza;
                dataGridViewclient2.Rows[n].Cells[6].Value = mascota.PesoAnimal;
                dataGridViewclient2.Rows[n].Cells[7].Value = mascota.fechaIngreso;
                dataGridViewclient2.Rows[n].Cells[8].Value = mascota.fechaNacimento;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UICentro uICentro = new UICentro();
            uICentro.Show();
            this.Close();
        }
    }
}
