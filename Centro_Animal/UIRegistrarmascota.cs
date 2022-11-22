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
using NPOI.SS.Formula.Functions;

namespace Centro_AnimalUI
{
    public partial class UIRegistrarmascota : Form
    {
        DataService dataService = new DataService();
        List<Regisanimal> listaanimatesconduenio = new List<Regisanimal>();
        Cliente client = new Cliente();
        Validaciones validaciones = new Validaciones();


        public string a;
        public UIRegistrarmascota()
        {
            InitializeComponent();           
            listaanimatesconduenio = dataService.GETlistaconduenio();
            llenartabla();
            ListaMaestra listaEspecie = new ListaMaestra();
            

            //comboBoxdueño.DataSource = listaclientes.GetClientes();

            comboBoxespecie.DataSource = dataService.GETESpecie();
            comboBoxespecie.DisplayMember = "nombreEspecie";
            comboBoxespecie.ValueMember = "idespecie";
            comboBoxdueño.DataSource=dataService.GETCleintes();
            comboBoxdueño.DisplayMember = "nombre" ;
            comboBoxdueño.ValueMember = "Id";
            comboBoxSexo.DataSource = dataService.GETsexo();
            comboBoxSexo.DisplayMember = "sexo";
            comboBoxSexo.ValueMember = "Id";

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
                dataGridViewclient2.Rows[n].Cells[4].Value = mascota.especie;
                dataGridViewclient2.Rows[n].Cells[5].Value = mascota.raza;
                dataGridViewclient2.Rows[n].Cells[6].Value = mascota.PesoAnimal;
                dataGridViewclient2.Rows[n].Cells[7].Value = mascota.fechaIngreso;
                dataGridViewclient2.Rows[n].Cells[8].Value = mascota.fechaNacimento;
            }
        }
         
        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBoxedadmascota.Text = (DateTime.Now.Year - dateTimePicker1.Value.Year).ToString();
        }


        private void comboBoxdueño_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ResponseValidator;
            Animal animal = new Animal()
            {

                NombreAnimal = textBoxNombre.Text,
                PesoAnimal = (double)numericUpDownpeso.Value,
                raza = textBoxraza.Text,
                IDDuenio = (int)comboBoxdueño.SelectedValue,
                fechaNacimento = dateTimePicker1.Value,
                sexo = (int)comboBoxSexo.SelectedValue,
                fechaIngreso = DateTime.Now,
                especie = (int)comboBoxespecie.SelectedValue,

            };
            ResponseValidator = validaciones.Validatormasc(animal);
            if (ResponseValidator == string.Empty)
            {
                client.id = (int)comboBoxdueño.SelectedValue;
                a = dataService.CrearMascota(client, animal);
                dataGridViewclient2.Rows.Clear();
                listaanimatesconduenio = dataService.GETlistaconduenio();
                llenartabla();
                //
            }
            else
            {
                MessageBox.Show(ResponseValidator);
            }
        

        }

        private void dataGridViewclient_CellClick(object sender, DataGridViewCellEventArgs e)
        {

       
        }


        
        private void button2_Click(object sender, EventArgs e)
        {
            UICentro uICentro = new UICentro();
            uICentro.Show();
            this.Close();








            dataGridViewclient2.DataSource= dataService.GETlistaconduenio();



        }
    }
}
