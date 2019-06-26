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
    public partial class novoRegistro : Form
    {
        String selection, dia, mes, ano;
        DateTime data;
        String dataConvertida;
        string codigosTiposOS;

        public novoRegistro(String valor)
        {
            InitializeComponent();
            selection = valor;
        }

        private void novoRegistro_Load(object sender, EventArgs e)
        {
            clsBanco banco = new clsBanco();
            MySqlDataReader dados = null;

            #region os
            if (!banco.Consultar("Select dt_os from os where cd_os = '" + selection + "';", ref dados))
            {
                MessageBox.Show("Erro");
                return;
            }
            dados.Read();
            #endregion

            #region Situacao

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
                }
            }

            #endregion
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            login l = new login();
            l.ShowDialog();

            if (l.estado == true)
            {
                clsBanco banco = new clsBanco();
                MySqlDataReader dados = null;

                if (!banco.Consultar("Select dt_os from os where cd_os = '" + selection + "';", ref dados))
                {
                    MessageBox.Show("Erro");
                    return;
                }
                if (dados.Read())
                {
                    data = DateTime.Parse(dados[0].ToString());
                    dia = data.Day.ToString();
                    mes = data.Month.ToString();
                    ano = data.Year.ToString();
                }
                if (int.Parse(mes) < 10)
                {
                    dataConvertida = ano + "-0" + mes + "-" + dia;
                }
                else
                {
                    dataConvertida = ano + "-" + mes + "-" + dia;
                }
                if (!banco.Executar("Insert into registro values ('" + selection + "', '" + dataConvertida + "', curdate(), curtime(), '" + l.textBox1.Text + "', '" + txtDescricaoRegistro.Text + "')"))
                {
                    MessageBox.Show("Erro inserir");
                    return;
                }
                else
                {
                    MessageBox.Show("Registro Criado com Sucesso!");
                }

                if (cbSituacao.SelectedIndex == 0)
                {
                    if (!banco.Executar("update os set cd_situacao = 1 where cd_os = '" + selection + "';"))
                    {
                        MessageBox.Show("Erro inserir");
                        return;
                    }
                }

                if (cbSituacao.SelectedIndex == 1)
                {
                    if (!banco.Executar("update os set cd_situacao = 2, dt_finalizacao = curdate() where cd_os = '" + selection + "';"))
                    {
                        MessageBox.Show("Erro inserir");
                        return;
                    }
                }

                if (cbSituacao.SelectedIndex == 2)
                {
                    if (!banco.Executar("update os set cd_situacao = 3 where cd_os = '" + selection + "';"))
                    {
                        MessageBox.Show("Erro inserir");
                        return;
                    }
                }


                banco.Fechar();
                this.Close();
            }
        }              
    }
}
