using CRUDADDIN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDADDIN.Controller
{
    public static class ListarInformacoes
    {


        public static string listarTabelas()
        {
            string Sql = "SELECT name FROM SYSOBJECTS where xtype = 'U'";
            string retorno = "";

            var listaTabelas = ConnectionBD.SqlScalar(Sql);
            foreach(object item in listaTabelas.GetType().GetProperties())
            {
                retorno = retorno + "|" + item;               
            }

            return retorno;

        }

    }
}
