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
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clsConexao.Local();
        }

        private void ribbonButton4_Click(object sender, EventArgs e)
        {
            novaOsExterna novaform = new novaOsExterna();
            novaform.ShowDialog();
        }

        private void novaOsInterna_Click(object sender, EventArgs e)
        {
            novaOsInterna novaform = new novaOsInterna();
            novaform.ShowDialog();
        }

        private void btnGerenciar_Click(object sender, EventArgs e)
        {
            gerenciarOs novaform = new gerenciarOs();
            novaform.ShowDialog();
        }
    }
}