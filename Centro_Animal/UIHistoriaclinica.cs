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
    public partial class UIHistoriaclinica : Form
    {
        List<Tratamiento> tratamientos = new List<Tratamiento>();
        Validaciones validaciones = new Validaciones();
        Regisanimal  regisanimal1=new Regisanimal();
        DataService  dataService = new DataService();
        List<Veterinario> veterinarios = new List<Veterinario>();
        Veterinario veterinariodelanimal = new Veterinario();
        List<Cliente> clientes = new List<Cliente>();
        Cliente cliente = new Cliente();

        string a;
        
        public UIHistoriaclinica(Regisanimal regisanimal)
        {
            InitializeComponent();
            label1datosmascota.Text = "Mascota: " + regisanimal.NombreAnimal + "    ID: " + regisanimal.IDanimal + "\nEspecie: " + validaciones.VerEspecie(regisanimal.especie)+"    Raza: "+regisanimal.raza+"\nGenero: "+regisanimal.sexo; 
            regisanimal1=regisanimal;
            tratamientos=dataService.GETtratamientos(regisanimal.IDanimal);
            clientes=dataService.GETCleintesconanimal(regisanimal.IDDuenio);
            foreach (Cliente item in clientes)
            {
                cliente=item;
            }
            label1datosduenio.Text = "\nNombre: " + cliente.nombre + "\napellido: " + cliente.apellido + "\nDNI: " + cliente.DNI + "\nTelefono: " + cliente.Telefono + "\nDireccion: " + cliente.Calle + "   Numero: " + cliente.Numero;



            foreach (Tratamiento item in tratamientos)
            {
                veterinarios = dataService.GETVeterinariodepaciente(item.IDVeterinario);
                foreach (Veterinario item2 in veterinarios)
                {
                    if (item.IDVeterinario == item2.id)
                    {
                        a = item2.nombre;
                    }
                    labelhistoriaclin.Text=labelhistoriaclin.Text+item.datoshistorial + "\nFecha de consulta :" + item.fechaactual.ToShortDateString() + "\nMedico que lo asistio: " + a + "\nProxima consulta :" + item.fechaproxima.ToShortDateString() + "\n----------------------------------------------------------\n";
                }            
                  
            }
            if (labelhistoriaclin.Text.Trim()=="")
            {
                labelhistoriaclin.Text = "Sin Datos";
            }

        }

        private void button1nuevaconsulta_Click(object sender, EventArgs e)
        {
           UITratamientos uITratamientos = new UITratamientos(regisanimal1);
            uITratamientos.Show();
        }

        private void buttonvolver_Click(object sender, EventArgs e)
        {
            UIPacientes uIPacientes = new UIPacientes();
            uIPacientes.Show();
            this.Close();
        }

        private void labelhistoriaclin_Click(object sender, EventArgs e)
        {

        }
    }
}
