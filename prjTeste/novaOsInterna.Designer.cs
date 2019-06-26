namespace prjTeste
{
    partial class novaOsInterna
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
            this.treeEquipamento = new System.Windows.Forms.TreeView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.deferimentoCheckBox = new System.Windows.Forms.CheckBox();
            this.lblEquipamento = new System.Windows.Forms.Label();
            this.cmbTipoOS = new System.Windows.Forms.ComboBox();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTipoServiço = new System.Windows.Forms.Label();
            this.lblSolicitante = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtSolicitante = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treeEquipamento
            // 
            this.treeEquipamento.CheckBoxes = true;
            this.treeEquipamento.Location = new System.Drawing.Point(419, 12);
            this.treeEquipamento.Name = "treeEquipamento";
            this.treeEquipamento.Size = new System.Drawing.Size(217, 193);
            this.treeEquipamento.TabIndex = 26;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(546, 211);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 27);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // deferimentoCheckBox
            // 
            this.deferimentoCheckBox.AutoSize = true;
            this.deferimentoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deferimentoCheckBox.Location = new System.Drawing.Point(15, 67);
            this.deferimentoCheckBox.Name = "deferimentoCheckBox";
            this.deferimentoCheckBox.Size = new System.Drawing.Size(164, 20);
            this.deferimentoCheckBox.TabIndex = 24;
            this.deferimentoCheckBox.Text = "Necessita Deferimento";
            this.deferimentoCheckBox.UseVisualStyleBackColor = true;
            // 
            // lblEquipamento
            // 
            this.lblEquipamento.AutoSize = true;
            this.lblEquipamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipamento.Location = new System.Drawing.Point(329, 8);
            this.lblEquipamento.Name = "lblEquipamento";
            this.lblEquipamento.Size = new System.Drawing.Size(91, 16);
            this.lblEquipamento.TabIndex = 23;
            this.lblEquipamento.Text = "Equipamento:";
            // 
            // cmbTipoOS
            // 
            this.cmbTipoOS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipoOS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipoOS.FormattingEnabled = true;
            this.cmbTipoOS.Location = new System.Drawing.Point(121, 40);
            this.cmbTipoOS.Name = "cmbTipoOS";
            this.cmbTipoOS.Size = new System.Drawing.Size(196, 21);
            this.cmbTipoOS.TabIndex = 22;
            // 
            // btnConcluir
            // 
            this.btnConcluir.Location = new System.Drawing.Point(451, 211);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(89, 27);
            this.btnConcluir.TabIndex = 20;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Descrição do problema:";
            // 
            // lblTipoServiço
            // 
            this.lblTipoServiço.AutoSize = true;
            this.lblTipoServiço.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoServiço.Location = new System.Drawing.Point(12, 40);
            this.lblTipoServiço.Name = "lblTipoServiço";
            this.lblTipoServiço.Size = new System.Drawing.Size(107, 16);
            this.lblTipoServiço.TabIndex = 18;
            this.lblTipoServiço.Text = "Tipo de Serviço:";
            // 
            // lblSolicitante
            // 
            this.lblSolicitante.AutoSize = true;
            this.lblSolicitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitante.Location = new System.Drawing.Point(12, 12);
            this.lblSolicitante.Name = "lblSolicitante";
            this.lblSolicitante.Size = new System.Drawing.Size(73, 16);
            this.lblSolicitante.TabIndex = 17;
            this.lblSolicitante.Text = "Solicitante:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(12, 109);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(396, 92);
            this.txtDescricao.TabIndex = 16;
            // 
            // txtSolicitante
            // 
            this.txtSolicitante.Enabled = false;
            this.txtSolicitante.Location = new System.Drawing.Point(121, 7);
            this.txtSolicitante.Name = "txtSolicitante";
            this.txtSolicitante.Size = new System.Drawing.Size(196, 20);
            this.txtSolicitante.TabIndex = 27;
            this.txtSolicitante.Text = "CPD";
            // 
            // novaOsInterna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 246);
            this.Controls.Add(this.txtSolicitante);
            this.Controls.Add(this.treeEquipamento);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.deferimentoCheckBox);
            this.Controls.Add(this.lblEquipamento);
            this.Controls.Add(this.cmbTipoOS);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTipoServiço);
            this.Controls.Add(this.lblSolicitante);
            this.Controls.Add(this.txtDescricao);
            this.Name = "novaOsInterna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova O.S Interna";
            this.Load += new System.EventHandler(this.novaOsInterna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeEquipamento;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox deferimentoCheckBox;
        private System.Windows.Forms.Label lblEquipamento;
        private System.Windows.Forms.ComboBox cmbTipoOS;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTipoServiço;
        private System.Windows.Forms.Label lblSolicitante;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtSolicitante;
    }
}