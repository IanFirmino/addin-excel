namespace CRUDADDIN
{
    partial class DataBase : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public DataBase()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.btnSalvarAlteracoes = this.Factory.CreateRibbonButton();
            this.btnDescartarAlteracoes = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.btnConectarTabela = this.Factory.CreateRibbonButton();
            this.btnDesconectarTabela = this.Factory.CreateRibbonButton();
            this.tab2 = this.Factory.CreateRibbonTab();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.btnConectar = this.Factory.CreateRibbonButton();
            this.btnDesconectar = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.tab2.SuspendLayout();
            this.group3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Label = "Database";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btnSalvarAlteracoes);
            this.group1.Items.Add(this.btnDescartarAlteracoes);
            this.group1.Label = "Alterações";
            this.group1.Name = "group1";
            // 
            // btnSalvarAlteracoes
            // 
            this.btnSalvarAlteracoes.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnSalvarAlteracoes.Label = "Salvar Alterações";
            this.btnSalvarAlteracoes.Name = "btnSalvarAlteracoes";
            this.btnSalvarAlteracoes.ShowImage = true;
            this.btnSalvarAlteracoes.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSalvarAlteracoes_Click);
            // 
            // btnDescartarAlteracoes
            // 
            this.btnDescartarAlteracoes.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnDescartarAlteracoes.Label = "Descartar Alterações";
            this.btnDescartarAlteracoes.Name = "btnDescartarAlteracoes";
            this.btnDescartarAlteracoes.ShowImage = true;
            // 
            // group2
            // 
            this.group2.Items.Add(this.btnConectarTabela);
            this.group2.Items.Add(this.btnDesconectarTabela);
            this.group2.Label = "Tabelas";
            this.group2.Name = "group2";
            // 
            // btnConectarTabela
            // 
            this.btnConectarTabela.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnConectarTabela.Label = "Conectar Tabela";
            this.btnConectarTabela.Name = "btnConectarTabela";
            this.btnConectarTabela.ShowImage = true;
            this.btnConectarTabela.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnConectarTabela_Click);
            // 
            // btnDesconectarTabela
            // 
            this.btnDesconectarTabela.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnDesconectarTabela.Label = "Desconectar Tabela";
            this.btnDesconectarTabela.Name = "btnDesconectarTabela";
            this.btnDesconectarTabela.ShowImage = true;
            // 
            // tab2
            // 
            this.tab2.Groups.Add(this.group3);
            this.tab2.Label = "Conexão";
            this.tab2.Name = "tab2";
            // 
            // group3
            // 
            this.group3.Items.Add(this.btnConectar);
            this.group3.Items.Add(this.btnDesconectar);
            this.group3.Label = "Conexão";
            this.group3.Name = "group3";
            // 
            // btnConectar
            // 
            this.btnConectar.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnConectar.Label = "Conectar";
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.ShowImage = true;
            this.btnConectar.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnDesconectar.Label = "Desconectar";
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.ShowImage = true;
            this.btnDesconectar.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnDesconectar_Click);
            // 
            // DataBase
            // 
            this.Name = "DataBase";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Tabs.Add(this.tab2);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        private Microsoft.Office.Tools.Ribbon.RibbonTab tab2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSalvarAlteracoes;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnDescartarAlteracoes;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnConectarTabela;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnDesconectarTabela;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnConectar;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnDesconectar;
    }

    partial class ThisRibbonCollection
    {
        internal DataBase DataBase
        {
            get { return this.GetRibbon<DataBase>(); }
        }
    }
}
