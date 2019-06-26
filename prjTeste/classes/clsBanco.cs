using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace prjTeste.classes
{
    class clsBanco
    {
        public string linhaConexao { get; set; }

        MySqlConnection conexao = null;
        MySqlCommand cSQL = null;

        #region Construtor
        public clsBanco()
        {
            linhaConexao = clsConexao.linhaConexao;
        }
        #endregion
        
        #region Abrir
        private bool Abrir()
        {
            conexao = new MySqlConnection(linhaConexao);
            try
            {
                conexao.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Fechar
        public void Fechar()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
        #endregion

        #region Consultar
        public bool Consultar(string comando, ref MySqlDataReader dados)
        {
            if (Abrir())
            {
                cSQL = new MySqlCommand(comando, conexao);
                try
                {
                    dados = cSQL.ExecuteReader();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Executar
        public bool Executar(string comando)
        {
            if (Abrir())
            {
                cSQL = new MySqlCommand(comando, conexao);
                cSQL.ExecuteNonQuery();
                Fechar();
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
