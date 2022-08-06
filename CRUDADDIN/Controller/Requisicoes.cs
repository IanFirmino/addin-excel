using CRUDADDIN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDADDIN.Controller
{
    public static class Requisicoes
    {
        public static string ConectarBanco()
        {
            string stringConection = "Data Source=SUPER_PC\\SQLEXPRESS;Initial Catalog=Treinamentos; Integrated Security=true;";

            ConnectionBD.connectionString = stringConection;

            try
            {
                ConnectionBD.OpenConnect();
                return "Conexão realizada com sucesso!";
            }
            catch (Exception ex)
            {
                return "A conexao falhou. Detalhes:" + ex.Message;
            }
        }

        public static string DesconectarBanco()
        {
            try
            {
                ConnectionBD.CloseConnect();
                return "Desconectado com sucesso!";
            }
            catch (Exception ex)
            {
                return "O Processo falhou. Detalhes: " + ex.Message;
            }

        }












    }
}
