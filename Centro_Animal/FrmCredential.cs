using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centro_Animal;
using Centro_animal.Entities;
using DDJJAdministrator.Entities;

namespace DDJJDesktop
{
    public partial class FrmCredential : Form
    {
        // private SecurytiServices securityservices =new SecurytiServices();
        
        public FrmCredential()
        {
            InitializeComponent();
            labelBandera.Visible = false;
        }



        private void buttonUsuario_Click(object sender, EventArgs e)
        {

            if (textBoxuser.Text=="admin" && textBoxpassword.Text=="1234")
            {
                UICentro Centro = new UICentro();
                Centro.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario  Incorrecto");
                //labelBandera.Visible = true;
            }
        }

        private void FrmCredential_Load(object sender, EventArgs e)
        {

        }
    }
}
