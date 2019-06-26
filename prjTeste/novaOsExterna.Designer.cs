namespace prjTeste
{
    partial class novaOsExterna
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
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblSolicitante = new System.Windows.Forms.Label();
            this.lblTipoServiço = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.cmbSolicitante = new System.Windows.Forms.ComboBox();
            this.cmbTipoOS = new System.Windows.Forms.ComboBox();
            this.lblEquipamento = new System.Windows.Forms.Label();
            this.deferimentoCheckBox = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.treeEquipamento = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(15, 112);
            this.txtDescricao.MaxLength = 150;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(396, 92);
            this.txtDescricao.TabIndex = 1;
            // 
            // lblSolicitante
            // 
            this.lblSolicitante.AutoSize = true;
            this.lblSolicitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitante.Location = new System.Drawing.Point(12, 11);
            this.lblSolicitante.Name = "lblSolicitante";
            this.lblSolicitante.Size = new System.Drawing.Size(73, 16);
            this.lblSolicitante.TabIndex = 3;
            this.lblSolicitante.Text = "Solicitante:";
            // 
            // lblTipoServiço
            // 
            this.lblTipoServiço.AutoSize = true;
            this.lblTipoServiço.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoServiço.Location = new System.Drawing.Point(12, 44);
            this.lblTipoServiço.Name = "lblTipoServiço";
            this.lblTipoServiço.Size = new System.Drawing.Size(107, 16);
            this.lblTipoServiço.TabIndex = 4;
            this.lblTipoServiço.Text = "Tipo de Serviço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descrição do problema:";
            // 
            // btnConcluir
            // 
            this.btnConcluir.Location = new System.Drawing.Point(450, 210);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(89, 27);
            this.btnConcluir.TabIndex = 6;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbSolicitante
            // 
            this.cmbSolicitante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSolicitante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSolicitante.FormattingEnabled = true;
            this.cmbSolicitante.Location = new System.Drawing.Point(121, 10);
            this.cmbSolicitante.Name = "cmbSolicitante";
            this.cmbSolicitante.Size = new System.Drawing.Size(196, 21);
            this.cmbSolicitante.TabIndex = 9;
            // 
            // cmbTipoOS
            // 
            this.cmbTipoOS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipoOS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipoOS.FormattingEnabled = true;
            this.cmbTipoOS.Location = new System.Drawing.Point(121, 43);
            this.cmbTipoOS.Name = "cmbTipoOS";
            this.cmbTipoOS.Size = new System.Drawing.Size(196, 21);
            this.cmbTipoOS.TabIndex = 10;
            // 
            // lblEquipamento
            // 
            this.lblEquipamento.AutoSize = true;
            this.lblEquipamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipamento.Location = new System.Drawing.Point(327, 11);
            this.lblEquipamento.Name = "lblEquipamento";
            this.lblEquipamento.Size = new System.Drawing.Size(91, 16);
            this.lblEquipamento.TabIndex = 11;
            this.lblEquipamento.Text = "Equipamento:";
            // 
            // deferimentoCheckBox
            // 
            this.deferimentoCheckBox.AutoSize = true;
            this.deferimentoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deferimentoCheckBox.Location = new System.Drawing.Point(15, 70);
            this.deferimentoCheckBox.Name = "deferimentoCheckBox";
            this.deferimentoCheckBox.Size = new System.Drawing.Size(164, 20);
            this.deferimentoCheckBox.TabIndex = 13;
            this.deferimentoCheckBox.Text = "Necessita Deferimento";
            this.deferimentoCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(545, 210);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 27);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // treeEquipamento
            // 
            this.treeEquipamento.CheckBoxes = true;
            this.treeEquipamento.Location = new System.Drawing.Point(417, 11);
            this.treeEquipamento.Name = "treeEquipamento";
            this.treeEquipamento.Size = new System.Drawing.Size(217, 193);
            this.treeEquipamento.TabIndex = 15;
            // 
            // novaOsExterna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 248);
            this.Controls.Add(this.treeEquipamento);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.deferimentoCheckBox);
            this.Controls.Add(this.lblEquipamento);
            this.Controls.Add(this.cmbTipoOS);
            this.Controls.Add(this.cmbSolicitante);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTipoServiço);
            this.Controls.Add(this.lblSolicitante);
            this.Controls.Add(this.txtDescricao);
            this.Name = "novaOsExterna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova O.S Externa";
            this.Load += new System.EventHandler(this.novaOsExterna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblSolicitante;
        private System.Windows.Forms.Label lblTipoServiço;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.ComboBox cmbSolicitante;
        private System.Windows.Forms.ComboBox cmbTipoOS;
        private System.Windows.Forms.Label lblEquipamento;
        private System.Windows.Forms.CheckBox deferimentoCheckBox;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TreeView treeEquipamento;
    }
}