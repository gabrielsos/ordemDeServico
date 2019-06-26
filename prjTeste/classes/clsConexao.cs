using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjTeste.classes
{
    class clsConexao
    {
        public static string linhaConexao = "SERVER=localhost;UID=root;PASSWORD=root;DATABASE=sistemaos";

        public static void Local()
        {
            linhaConexao = "SERVER=localhost;UID=root;PASSWORD=root;DATABASE=sistemaos";
        }

        public static void Servidor()
        {
            linhaConexao = "SERVER=200.157.5.2;UID=sistema;PASSWORD=seila;DATABASE=sistemaos";
        }
    }
}
