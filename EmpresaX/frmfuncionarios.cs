using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaX
{
    public partial class frmfuncionarios : Form
    {
        public frmfuncionarios()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir= new frmMenuPrincipal();
            abrir.Show();   
            this.Hide();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnome.Clear();
            txtcodigo.Clear();
            mskcpf.Clear();
        }
    }
}
