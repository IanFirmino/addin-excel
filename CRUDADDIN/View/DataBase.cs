using CRUDADDIN.Controller;
using CRUDADDIN.Model;
using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDADDIN
{
    public partial class DataBase
    {
        private void btnConectar_Click(object sender, RibbonControlEventArgs e)
        {
            string resultado = "";

            resultado = Requisicoes.ConectarBanco();
            System.Windows.Forms.MessageBox.Show(resultado);

        }

        private void btnDesconectar_Click(object sender, RibbonControlEventArgs e)
        {
            string resultado = "";

            resultado = Requisicoes.DesconectarBanco();
            System.Windows.Forms.MessageBox.Show(resultado);

        }

        private void btnConectarTabela_Click(object sender, RibbonControlEventArgs e)
        {
            
        }

        private void btnSalvarAlteracoes_Click(object sender, RibbonControlEventArgs e)
        {

        }
    }
}
