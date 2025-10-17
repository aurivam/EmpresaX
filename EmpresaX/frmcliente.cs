using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MosaicoSolutions.ViaCep;

namespace EmpresaX
{
    public partial class frmcliente : Form
    {
        public frmcliente()
        {
            InitializeComponent();
            desabilitarcampos();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            habilitarcampos();
        }

        private void desabilitarcampos()
        {
            txtnome.Enabled = false;
            txtidade.Enabled = false;
            mskcep.Enabled = false;
            txtlogradouro.Enabled = false;
            txtnumero.Enabled = false;
            txtcidade.Enabled = false;
            cbbestado.Enabled = false;
            cbbuf.Enabled = false;
            txtcomplemento.Enabled = false;
            txtbairro.Enabled = false;

        }
        private void habilitarcampos()
        {
            txtnome.Enabled = true;
            txtidade.Enabled = true;
            mskcep.Enabled = true;
            txtlogradouro.Enabled = true;
            txtnumero.Enabled = true;
            txtcidade.Enabled = true;
            cbbestado.Enabled = true;
            cbbuf.Enabled = true;
            txtcomplemento.Enabled = true;
            txtbairro.Enabled = true;
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnome.ResetText();
            txtidade.ResetText();
            mskcep.Clear();
            txtlogradouro.Clear();
            txtnumero.Clear();
            txtcidade.Clear();
            cbbestado.ResetText();
            cbbuf.ResetText();
            txtcomplemento.ResetText();
            txtbairro.ResetText();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void buscarCEP(string cep)
        {
            var viaCEPService = ViaCepService.Default();
            var endereco = viaCEPService.ObterEndereco(cep);

            txtlogradouro.Text = endereco.Logradouro;
            txtcidade.Text = endereco.Localidade;
            cbbestado.Text = endereco.UF;
            cbbuf.Text = endereco.UF;
            txtcomplemento.Text = endereco.Complemento;
            txtbairro.Text = endereco.Bairro;

        }

        private void mskcep_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Enter)
                {
                    buscarCEP(mskcep.Text);
                    txtnumero.Focus();
                }

            }
        }

    }
}

