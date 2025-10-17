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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario;
            int senha;

            usuario= txtusuario.Text.Trim();
            senha= int.Parse(txtsenha.Text.Trim());

            if(usuario=="admin" & senha==123)
            {
                frmMenuPrincipal abrir= new frmMenuPrincipal();
                abrir.Show();
                
            }
            else
            {
                MessageBox.Show(" Usuario e senha incorretos");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtusuario.Clear();
            txtsenha.Clear();
        }
    }
}
