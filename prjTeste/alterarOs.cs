using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjTeste.classes;
using MySql.Data.MySqlClient;

namespace prjTeste
{
    public partial class alterarOs : Form
    {
        string cdOso, nmSolicitante;

        public alterarOs(string valor1, string valor2)
        {
            InitializeComponent();
            cdOso = valor1;
            nmSolicitante = valor2;
        }

       
        private void alterarOs_Load(object sender, EventArgs e)
        {
            tbCdOs.Text = cdOso;
            tbSolicitante.Text = nmSolicitante;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            clsBanco banco = new clsBanco();

            if (!banco.Executar("update os set ds_problema = '" + txtDescricao.Text + "' where cd_os = '" + cdOso + "';"))
            {
                MessageBox.Show("Erro inserir");
                return;
            }
            else
            {
                banco.Fechar();
                MessageBox.Show("Alteração Feita com Sucesso");
                this.Close();

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
