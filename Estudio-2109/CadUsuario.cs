using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio
{
    public partial class CadUsuario : Form
    {
        public CadUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int tipo = 0;
            if (cboTipo.SelectedIndex == 0)
                tipo = 1; //adm
            if (cboTipo.SelectedIndex == 1)
                tipo = 2; //restrito
            if (DAO_Conexao.CadLogin(TextBox1.Text, textBox2.Text, tipo))
                MessageBox.Show("Cadastro realizado com sucesso");
            else
                MessageBox.Show("Erro de cadastro!");
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
