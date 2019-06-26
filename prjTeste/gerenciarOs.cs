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
    public partial class gerenciarOs : Form
    {
        public String selection { get; set; }
        DateTime dataOs, dataFinalizacao;
        public String solicitante, data, situacao;
        List<string> codigosSituacao = new List<string>();
        public gerenciarOs()

        {
            InitializeComponent();
        }

        private void gerenciarOs_Load(object sender, EventArgs e)
        {
            DataTable Ltable = new DataTable();

            clsBanco banco = new clsBanco();
            MySqlDataReader dados = null;

            #region Solicitante
            if (!banco.Consultar("Select cd_situacao, nm_situacao from situacao_os", ref dados))
            {
                MessageBox.Show("Erro");
                return;
            }

            if (dados.HasRows)
            {
                while (dados.Read())
                {
                    cbSituacao.Items.Add(dados["nm_situacao"].ToString());
                    codigosSituacao.Add(dados["cd_situacao"].ToString());
                }
            }
            if (!dados.IsClosed) { dados.Close(); }
            #endregion

            #region GridView

            if (!banco.Consultar("Select s.cd_os, s.dt_os, s.ds_problema, s.dt_finalizacao, ti.nm_tipo, si.nm_situacao, so.nm_solicitante, group_concat(distinct loc.nm_local separator ','), group_concat(distinct lo.nm_apelido separator ', ') from  os s join tipo_os ti on (s.cd_tipo = ti.cd_tipo) join situacao_os si on (s.cd_situacao = si.cd_situacao) join solicitante so on (s.cd_solicitante = so.cd_solicitante) left join equipamento_os eos on (s.cd_os = eos.cd_os and s.dt_os = eos.dt_os) left join equipamento lo on (lo.cd_serial = eos.cd_serial) left join local loc on (lo.cd_local = loc.cd_local) group by s.cd_os, s.dt_os order by nm_situacao", ref dados))
            {
                MessageBox.Show("Erro");
                return;
            }

            if (dados.HasRows)
            {
                
                Ltable.Columns.Add("Código da OS");
                Ltable.Columns.Add("Data Abertura");
                Ltable.Columns.Add("Descrição do Problema");
                Ltable.Columns.Add("Data Finalização");
                Ltable.Columns.Add("Tipo de Serviço");
                Ltable.Columns.Add("Situação");
                Ltable.Columns.Add("Nome Solicitante");
                Ltable.Columns.Add("Local");
                Ltable.Columns.Add("Equipamento");

                while (dados.Read())
                {
                    Ltable.Rows.Add(dados["cd_os"].ToString(), dados["dt_os"].ToString(), dados["ds_problema"].ToString(), dados["dt_finalizacao"].ToString(), dados["nm_tipo"].ToString(), dados["nm_situacao"].ToString(), dados["nm_solicitante"].ToString(), dados[7].ToString(), dados[8].ToString());
                    dataGridView1.DataSource = Ltable;
                }
            }
            if (!dados.IsClosed) { dados.Close(); }
            banco.Fechar();
            
            #endregion
        }

        private void Abrir_Click(object sender, EventArgs e)
        {
            clsBanco banco = new clsBanco();
            MySqlDataReader dados = null;

            if (!banco.Consultar("Select * from registro where cd_os = '" + selection + "';", ref dados))
            {
                MessageBox.Show("Erro!");
                return;
            }

            if (dados.HasRows)
            {
                registro novaForm = new registro(selection, solicitante, data, situacao);
                novaForm.ShowDialog();
            }
            else
            {

                MessageBox.Show("Nenhum Registro Encontrado!");
                registro novaForm = new registro(selection, solicitante, data, situacao);
                novaForm.ShowDialog();
                return;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            selection = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            solicitante = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            data = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            situacao = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DataTable Ltable = new DataTable();
            clsBanco banco = new clsBanco();
            MySqlDataReader dados = null;

            if (!banco.Consultar("Select * from registro where cd_os = '" + selection + "';", ref dados))
            {
                MessageBox.Show("Erro!");
                return;
            }

            if (dados.HasRows)
            {
                MessageBox.Show("Você não pode excluir uma O.S que possui registro!");
            }
            else
            {
                if (!banco.Executar("SET FOREIGN_KEY_CHECKS=0; delete from os where cd_os =  '" + selection + "'; SET FOREIGN_KEY_CHECKS=1;"))
                {
                    MessageBox.Show("Erro ao excluir!");
                    return;
                }
                else
                {
                    MessageBox.Show("O.S excluída com sucesso com Sucesso!");
                }

                if (!banco.Consultar("Select cd_os, dt_os, ds_problema, dt_finalizacao, ti.nm_tipo, si.nm_situacao, so.nm_solicitante  from os s join tipo_os ti on (s.cd_tipo = ti.cd_tipo) join situacao_os si on (s.cd_situacao = si.cd_situacao) join solicitante so on (s.cd_solicitante = so.cd_solicitante) order by nm_situacao;", ref dados))
                {
                    MessageBox.Show("Erro");
                    return;
                }

                if (dados.HasRows)
                {

                    Ltable.Columns.Add("Código da OS");
                    Ltable.Columns.Add("Data Abertura");
                    Ltable.Columns.Add("Descrição do Problema");
                    Ltable.Columns.Add("Data Finalização");
                    Ltable.Columns.Add("Tipo de Serviço");
                    Ltable.Columns.Add("Situação");
                    Ltable.Columns.Add("Nome Solicitante");
                    while (dados.Read())
                    {
                        Ltable.Rows.Add(dados["cd_os"].ToString(), dados["dt_os"].ToString(), dados["ds_problema"].ToString(), dados["dt_finalizacao"].ToString(), dados["nm_tipo"].ToString(), dados["nm_situacao"].ToString(), dados["nm_solicitante"].ToString());
                        dataGridView1.DataSource = Ltable;
                    }
                }
                if (!dados.IsClosed) { dados.Close(); }
                banco.Fechar();
           }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterarOs novaForm = new alterarOs(selection, solicitante);
            novaForm.ShowDialog();

            DataTable Ltable = new DataTable();

            clsBanco banco = new clsBanco();
            MySqlDataReader dados = null;

            if (!banco.Consultar("Select s.cd_os, s.dt_os, s.ds_problema, s.dt_finalizacao, ti.nm_tipo, si.nm_situacao, so.nm_solicitante, group_concat(distinct loc.nm_local separator ','), group_concat(distinct lo.nm_apelido separator ', ') from  os s join tipo_os ti on (s.cd_tipo = ti.cd_tipo) join situacao_os si on (s.cd_situacao = si.cd_situacao) join solicitante so on (s.cd_solicitante = so.cd_solicitante) left join equipamento_os eos on (s.cd_os = eos.cd_os and s.dt_os = eos.dt_os) left join equipamento lo on (lo.cd_serial = eos.cd_serial) left join local loc on (lo.cd_local = loc.cd_local) group by s.cd_os, s.dt_os order by nm_situacao", ref dados))
            {
                MessageBox.Show("Erro");
                return;
            }

            if (dados.HasRows)
            {

                Ltable.Columns.Add("Código da OS");
                Ltable.Columns.Add("Data Abertura");
                Ltable.Columns.Add("Descrição do Problema");
                Ltable.Columns.Add("Data Finalização");
                Ltable.Columns.Add("Tipo de Serviço");
                Ltable.Columns.Add("Situação");
                Ltable.Columns.Add("Nome Solicitante");
                Ltable.Columns.Add("Local");
                Ltable.Columns.Add("Equipamento");

                while (dados.Read())
                {
                    Ltable.Rows.Add(dados["cd_os"].ToString(), dados["dt_os"].ToString(), dados["ds_problema"].ToString(), dados["dt_finalizacao"].ToString(), dados["nm_tipo"].ToString(), dados["nm_situacao"].ToString(), dados["nm_solicitante"].ToString(), dados[7].ToString(), dados[8].ToString());
                    dataGridView1.DataSource = Ltable;
                }
            }
            if (!dados.IsClosed) { dados.Close(); }
            banco.Fechar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable Ltable = new DataTable();
            clsBanco banco = new clsBanco();
            MySqlDataReader dados = null;

            if (!banco.Consultar("Select cd_os, dt_os, ds_problema, dt_finalizacao, ti.nm_tipo, si.nm_situacao, so.nm_solicitante  from os s join tipo_os ti on (s.cd_tipo = ti.cd_tipo) join situacao_os si on (s.cd_situacao = si.cd_situacao) join solicitante so on (s.cd_solicitante = so.cd_solicitante) where si.cd_situacao = '" + codigosSituacao[cbSituacao.SelectedIndex] + "' and dt_os = '" + this.dtp1.Text + "' order by nm_situacao;", ref dados))
            {
                MessageBox.Show("Erro");
                return;
            }

            if (dados.HasRows)
            {

                Ltable.Columns.Add("Código da OS");
                Ltable.Columns.Add("Data Abertura");
                Ltable.Columns.Add("Descrição do Problema");
                Ltable.Columns.Add("Data Finalização");
                Ltable.Columns.Add("Tipo de Serviço");
                Ltable.Columns.Add("Situação");
                Ltable.Columns.Add("Nome Solicitante");
                while (dados.Read())
                {
                    Ltable.Rows.Add(dados["cd_os"].ToString(), dados["dt_os"].ToString(), dados["ds_problema"].ToString(), dados["dt_finalizacao"].ToString(), dados["nm_tipo"].ToString(), dados["nm_situacao"].ToString(), dados["nm_solicitante"].ToString());
                    dataGridView1.DataSource = Ltable;
                }
            }
            if (!dados.IsClosed) { dados.Close(); }
            banco.Fechar();
        }
    }
}
