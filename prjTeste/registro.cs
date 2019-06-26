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
    public partial class registro : Form
    {
        string selection, solicitante, data, nmLogin, dtRegistro, hrRegistro, situacao;

        public registro(string valor, string valor2, string valor3, string valor4)
        {
            InitializeComponent();
            selection = valor;
            solicitante = valor2;
            data = valor3;
            situacao = valor4;
        }

        private void registro_Load(object sender, EventArgs e)
        {
            DataTable Ltable = new DataTable();
            DateTime dataRegistro, dataOs;
            clsBanco banco = new clsBanco();
            MySqlDataReader dados = null;

            if (!banco.Consultar("Select cd_os, dt_os, dt_registro, hr_registro, nm_login, ds_registro from registro where cd_os = '" + selection + "' order by dt_registro desc, hr_registro desc ;", ref dados))
            {
                MessageBox.Show("Erro");
                return;
            }
            if (dados.HasRows)
            {
                Ltable.Columns.Add("Código da O.S");
                Ltable.Columns.Add("Data da O.S");
                Ltable.Columns.Add("Data do Registro");
                Ltable.Columns.Add("Horário do Registro");
                Ltable.Columns.Add("Usuário");
                Ltable.Columns.Add("Descrição");

                while (dados.Read())
                {
                    dataOs = DateTime.Parse(dados[1].ToString());
                    dataRegistro = DateTime.Parse(dados[2].ToString());
                    Ltable.Rows.Add(dados["cd_os"].ToString(), dataOs.ToShortDateString(), dataRegistro.ToShortDateString(), dados["hr_registro"].ToString(), dados["nm_login"].ToString(), dados["ds_registro"].ToString());
                    dataGridView1.DataSource = Ltable;

                }
                txtSolicitante.Text = solicitante;
                txtNmOs.Text = selection;

            }

            if (!dados.IsClosed) { dados.Close(); }
            banco.Fechar();
        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            if (situacao != "Finalizado")
            {
                novoRegistro novaForm = new novoRegistro(selection);
                novaForm.ShowDialog();

                DataTable Ltable = new DataTable();
                clsBanco banco = new clsBanco();
                MySqlDataReader dados = null;
                DateTime dataRegistro, dataOs;

                if (!banco.Consultar("Select cd_os, dt_os, dt_registro, hr_registro, nm_login, ds_registro from registro where cd_os = '" + selection + "' order by dt_registro desc, hr_registro desc;", ref dados))
                {
                    MessageBox.Show("Erro");
                    return;
                }
                if (dados.HasRows)
                {
                    Ltable.Columns.Add("Código da O.S");
                    Ltable.Columns.Add("Data da O.S");
                    Ltable.Columns.Add("Data do Registro");
                    Ltable.Columns.Add("Horário do Registro");
                    Ltable.Columns.Add("Usuário");
                    Ltable.Columns.Add("Descrição");

                    while (dados.Read())
                    {
                        dataOs = DateTime.Parse(dados[1].ToString());
                        dataRegistro = DateTime.Parse(dados[2].ToString());
                        Ltable.Rows.Add(dados["cd_os"].ToString(), dataOs.ToShortDateString(), dataRegistro.ToShortDateString(), dados["hr_registro"].ToString(), dados["nm_login"].ToString(), dados["ds_registro"].ToString());
                        dataGridView1.DataSource = Ltable;

                    }
                    txtSolicitante.Text = solicitante;
                    txtNmOs.Text = selection;
                }

                if (!dados.IsClosed) { dados.Close(); }
                banco.Fechar();
            }
            else
            {
                MessageBox.Show("Não é possível criar registro em uma O.S finalizada!");
            }
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            selection = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dtRegistro = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            hrRegistro = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            nmLogin = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
