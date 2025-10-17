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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void tmtSplash_Tick(object sender, EventArgs e)
        {
            if (pgbSplash.Value < 100)
            {
                pgbSplash.Value = pgbSplash.Value + 1;
                lblnumero.Text = pgbSplash.Value.ToString() + " % ";
            }
            else
            {
                tmtSplash.Enabled= false;
                frmLogin abrir= new frmLogin();
                abrir.Show();
                this.Hide();
            }
                    
        }
    }
}
