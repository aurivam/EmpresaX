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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmLogin abrir= new frmLogin();
            abrir.Show();
            this.Hide();
        }

        private void btnfuncionarios_Click(object sender, EventArgs e)
        {
            frmfuncionarios abrir= new frmfuncionarios();
            abrir.Show();
            this.Hide();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            frmprodutos abrir= new frmprodutos();   
            abrir.Show();
            this.Hide();
        }
    }
}
