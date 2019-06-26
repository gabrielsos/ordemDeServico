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
    public partial class novaOsInterna : Form
    {

        List<string> codigosTiposOS = new List<string>();

        public novaOsInterna()
        {
            InitializeComponent();
        }

        private void novaOsInterna_Load(object sender, EventArgs e)
        {
            clsBanco banco = new clsBanco();
            MySqlDataReader dados = null;

            #region Tipo de Serviço
            if (!banco.Consultar("Select cd_tipo, nm_tipo from tipo_os", ref dados))
            {
                MessageBox.Show("Erro");
                return;
            }



            if (dados.HasRows)
            {
                while (dados.Read())
                {
                    cmbTipoOS.Items.Add(dados["nm_tipo"].ToString());
                    codigosTiposOS.Add(dados["cd_tipo"].ToString());
                }
            }
            if (!dados.IsClosed) { dados.Close(); }
            #endregion

            #region Equipamento

            if (!banco.Consultar("Select l.nm_local, nm_apelido from equipamento e join local l on (e.cd_local = l.cd_local)", ref dados))
            {
                MessageBox.Show("Erro");
                return;
            }

            if (dados.HasRows)
            {
                while (dados.Read())
                {
                    TreeNode node = new TreeNode(dados["nm_local"].ToString());
                    node.Nodes.Add(dados["nm_apelido"].ToString());

                    treeEquipamento.Nodes.Add(node);
                }
            }
            #endregion
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            clsBanco banco = new clsBanco();
            MySqlDataReader dados = null;
            login l = new login();
            l.ShowDialog();

            if (l.estado == true)
            {

                string codigo = "1";

                if (!banco.Consultar("Select max(cd_os)+1 from os", ref dados))
                {
                    MessageBox.Show("Erro de busca");
                    return;
                }
                if (dados.HasRows)
                {
                    if (dados.Read())
                    {
                        codigo = dados[0].ToString();
                    }
                }
                if (!dados.IsClosed) { dados.Close(); }


                if (!banco.Executar("Insert into os (cd_os, dt_os, ds_problema, cd_tipo, cd_situacao, cd_solicitante) values ( " + codigo + ", current_date(), '" + txtDescricao.Text + "', '" + codigosTiposOS[cmbTipoOS.SelectedIndex] + "', 1 , 10)"))
                {
                    MessageBox.Show("Erro inserir");
                    return;
                }

                if (!banco.Executar("Insert into equipamento_os (cd_serial , cd_os, dt_os, ds_motivo) values ( '" + 111 + "' ," + codigo + ", current_date(), '" + txtDescricao.Text + "')"))
                {
                    MessageBox.Show("Erro inserir");
                    return;
                }

                banco.Fechar();

                MessageBox.Show("OS aberta com sucesso!");
                this.Close();
            }
        }
    }
}
