namespace prjTeste
{
    partial class principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            this.c1Ribbon1 = new C1.Win.C1Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.C1Ribbon.RibbonApplicationMenu();
            this.ribbonConfigToolBar1 = new C1.Win.C1Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.C1Ribbon.RibbonQat();
            this.ribbonTab1 = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup2 = new C1.Win.C1Ribbon.RibbonGroup();
            this.nosaOsExterna = new C1.Win.C1Ribbon.RibbonButton();
            this.novaOsInterna = new C1.Win.C1Ribbon.RibbonButton();
            this.btnGerenciar = new C1.Win.C1Ribbon.RibbonButton();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Tabs.Add(this.ribbonTab1);
            this.c1Ribbon1.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Windows7;
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.Name = "ribbonQat1";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Groups.Add(this.ribbonGroup2);
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Tab";
            // 
            // ribbonGroup2
            // 
            this.ribbonGroup2.Items.Add(this.nosaOsExterna);
            this.ribbonGroup2.Items.Add(this.novaOsInterna);
            this.ribbonGroup2.Items.Add(this.btnGerenciar);
            this.ribbonGroup2.Name = "ribbonGroup2";
            this.ribbonGroup2.Text = "Ordem de Serviço";
            // 
            // nosaOsExterna
            // 
            this.nosaOsExterna.LargeImage = ((System.Drawing.Image)(resources.GetObject("nosaOsExterna.LargeImage")));
            this.nosaOsExterna.Name = "nosaOsExterna";
            this.nosaOsExterna.SmallImage = ((System.Drawing.Image)(resources.GetObject("nosaOsExterna.SmallImage")));
            this.nosaOsExterna.Text = "Nova O.S Externa";
            this.nosaOsExterna.Click += new System.EventHandler(this.ribbonButton4_Click);
            // 
            // novaOsInterna
            // 
            this.novaOsInterna.LargeImage = ((System.Drawing.Image)(resources.GetObject("novaOsInterna.LargeImage")));
            this.novaOsInterna.Name = "novaOsInterna";
            this.novaOsInterna.SmallImage = ((System.Drawing.Image)(resources.GetObject("novaOsInterna.SmallImage")));
            this.novaOsInterna.Text = "Nova O.S Interna";
            this.novaOsInterna.Click += new System.EventHandler(this.novaOsInterna_Click);
            // 
            // btnGerenciar
            // 
            this.btnGerenciar.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGerenciar.LargeImage")));
            this.btnGerenciar.Name = "btnGerenciar";
            this.btnGerenciar.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnGerenciar.SmallImage")));
            this.btnGerenciar.Text = "Gerenciar O.S";
            this.btnGerenciar.Click += new System.EventHandler(this.btnGerenciar_Click);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1333, 620);
            this.Controls.Add(this.c1Ribbon1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordem de Serviço";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.C1Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.C1Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.C1Ribbon.RibbonQat ribbonQat1;
        private C1.Win.C1Ribbon.RibbonTab ribbonTab1;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup2;
        private C1.Win.C1Ribbon.RibbonButton nosaOsExterna;
        private C1.Win.C1Ribbon.RibbonButton novaOsInterna;
        private C1.Win.C1Ribbon.RibbonButton btnGerenciar;
    }
}

