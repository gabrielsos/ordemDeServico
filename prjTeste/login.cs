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
    public partial class login : Form
    {
        public bool estado { get; set; }
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsBanco banco = new clsBanco();
            MySqlDataReader dados = null;

            if (!banco.Consultar("Select nm_usuario from usuario where nm_usuario = '" +textBox1.Text +"' AND nm_senha = md5('" + textBox2.Text + "')", ref dados))
            {
                MessageBox.Show("Erro de busca");
                return;
            }
            if (dados.HasRows)
            {


                if (dados.Read())
                {

                    if (dados["nm_usuario"].ToString() != "")
                    {
                        estado = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuário e/ou Senha Incorretos!");
                        estado = false;
                    }

                }
            }
            else
            {
                MessageBox.Show("Usuário e/ou Senha Incorretos!");
                estado = false;
            }
            if (!dados.IsClosed) { dados.Close(); }
            banco.Fechar();
      }

       
    }
}
