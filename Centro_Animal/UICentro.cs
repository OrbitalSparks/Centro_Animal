using Centro_animal.Entities;
using Centro_AnimalUI;
using DDJJAdministrator.Entities;

namespace Centro_Animal
{
    public partial class UICentro : Form
    {
        public UICentro()
        {
            InitializeComponent();
        }


        public UICentro(Usuario usuario)
        {
            InitializeComponent();
        }

        private void UICentro_Load(object sender, EventArgs e)
        {

        }

        private void registraRClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIRegistroCliente uIRegistroCliente = new UIRegistroCliente();
            uIRegistroCliente.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
           UIRegistrarmascota uIRegistrarmascota=new UIRegistrarmascota();
            uIRegistrarmascota.Show();        }

        private void listaMascotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           UIListamascotas uIListamascotas=new UIListamascotas();
           uIListamascotas.Show();

        }

        private void listaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIListaClientes uIListaClientes=new UIListaClientes();
            uIListaClientes.Show();
        }
    }
}