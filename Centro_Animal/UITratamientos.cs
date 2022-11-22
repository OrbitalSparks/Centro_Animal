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
using Centro_animal_Services;

namespace Centro_AnimalUI
{
    public partial class UITratamientos : Form
    {
        Validaciones validaciones = new Validaciones();
        Tratamiento tratamiento = new Tratamiento();
        Regisanimal regisanimal2 = new Regisanimal();
        DataService dataService = new DataService();
        private string a;

        public UITratamientos(Regisanimal regisanimal1)
{
        InitializeComponent();
            regisanimal2 = regisanimal1;
            label2animal.Text= "Mascota: " + regisanimal1.NombreAnimal + "    ID: " + regisanimal1.IDanimal + "\nEspecie: " +
                       validaciones.VerEspecie(regisanimal1.especie) + "    Raza: " + regisanimal1.raza + "\nGenero: " +
                        regisanimal1.sexo;
            comboBox1.DataSource = dataService.GETVeterinarios();
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tratamiento.fechaactual=DateTime.Now;
            tratamiento.fechaproxima = dateTimePicker1.Value;
            tratamiento.IDanimalhistoiral = regisanimal2.IDanimal;
            tratamiento.datoshistorial = richTextBox1.Text.ToString();
            tratamiento.IDVeterinario = (int)comboBox1.SelectedValue;
            a = dataService.CrearConsulta(tratamiento);
            MessageBox.Show("consulta Agregada");
            this.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
