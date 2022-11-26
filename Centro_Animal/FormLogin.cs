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

namespace Centro_AnimalUI
{
    public partial class FormLogin : Form
    {
        DataService dataService = new DataService();
        List<Usuario> users = new List<Usuario>();
        Usuario user = new Usuario();
        public FormLogin()
        {
            InitializeComponent();
            labelBandera.Visible = false;
        }

        private void buttonUsuario_Click(object sender, EventArgs e)
        {
            if (textBoxuser2.Text.Trim() == "" && textBoxpassword2.Text.Trim() == "")
            {
                MessageBox.Show("Usuario o contraseña Vacia");
            }
            else {
                user.username = textBoxuser2.Text.Trim();
                user.userpassword = textBoxpassword2.Text.Trim();
                users = dataService.LoginMain(textBoxuser2.Text,textBoxpassword2.Text);
                if (users.Count == 0)
                {
                    MessageBox.Show("Usuario  Incorrecto");
                }
                else {
                    UICentro Centro = new UICentro();
                    Centro.Show();
                    this.Hide();
                }
            }
            

        }
    }
}
