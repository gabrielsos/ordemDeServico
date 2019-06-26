namespace prjTeste
{
    partial class alterarOs
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
            this.tbSolicitante = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.tbCdOs = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblSolicitante = new System.Windows.Forms.Label();
            this.txtCodOs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(12, 72);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(476, 80);
            this.txtDescricao.TabIndex = 15;
            // 
            // tbSolicitante
            // 
            this.tbSolicitante.Enabled = false;
            this.tbSolicitante.Location = new System.Drawing.Point(304, 9);
            this.tbSolicitante.Name = "tbSolicitante";
            this.tbSolicitante.Size = new System.Drawing.Size(184, 20);
            this.tbSolicitante.TabIndex = 14;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(413, 158);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(321, 158);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 12;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // tbCdOs
            // 
            this.tbCdOs.Enabled = false;
            this.tbCdOs.Location = new System.Drawing.Point(102, 8);
            this.tbCdOs.Name = "tbCdOs";
            this.tbCdOs.Size = new System.Drawing.Size(89, 20);
            this.tbCdOs.TabIndex = 11;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(9, 46);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(115, 13);
            this.lblDescricao.TabIndex = 10;
            this.lblDescricao.Text = "Descrição do Registro:";
            // 
            // lblSolicitante
            // 
            this.lblSolicitante.AutoSize = true;
            this.lblSolicitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitante.Location = new System.Drawing.Point(231, 9);
            this.lblSolicitante.Name = "lblSolicitante";
            this.lblSolicitante.Size = new System.Drawing.Size(67, 15);
            this.lblSolicitante.TabIndex = 9;
            this.lblSolicitante.Text = "Solicitante:";
            // 
            // txtCodOs
            // 
            this.txtCodOs.AutoSize = true;
            this.txtCodOs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodOs.Location = new System.Drawing.Point(9, 9);
            this.txtCodOs.Name = "txtCodOs";
            this.txtCodOs.Size = new System.Drawing.Size(72, 15);
            this.txtCodOs.TabIndex = 8;
            this.txtCodOs.Text = "Código O.S:";
            // 
            // alterarOs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 189);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.tbSolicitante);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.tbCdOs);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblSolicitante);
            this.Controls.Add(this.txtCodOs);
            this.Name = "alterarOs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar O.S";
            this.Load += new System.EventHandler(this.alterarOs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox tbSolicitante;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox tbCdOs;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblSolicitante;
        private System.Windows.Forms.Label txtCodOs;
    }
}