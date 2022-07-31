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
        private void DataBase_Load(object sender, RibbonUIEventArgs e)
        {
            Requisicoes Req = new Requisicoes();
            Req.SinalizarStatusConexao();
        }

        private void btnConectar_Click(object sender, RibbonControlEventArgs e)
        {
            string resultado = "";

            Requisicoes Req = new Requisicoes();
            resultado = Req.ConectarBanco();

            System.Windows.Forms.MessageBox.Show(resultado);

        }

        private void btnDesconectar_Click(object sender, RibbonControlEventArgs e)
        {
            string resultado = "";

            Requisicoes Req = new Requisicoes();
            resultado = Req.DesconectarBanco();

            System.Windows.Forms.MessageBox.Show(resultado);

        }

        private void btnConectarTabela_Click(object sender, RibbonControlEventArgs e)
        {
            
        }
    }
}
