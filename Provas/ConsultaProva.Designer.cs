
namespace Provas
{
    partial class ConsultaProva
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboProva = new System.Windows.Forms.ComboBox();
            this.cboAno = new System.Windows.Forms.ComboBox();
            this.lblprova = new System.Windows.Forms.Label();
            this.lblano = new System.Windows.Forms.Label();
            this.nada = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dtgProva = new System.Windows.Forms.DataGridView();
            this.pnlGarito = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dtgGabarito = new System.Windows.Forms.DataGridView();
            this.lblGabarito = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProva)).BeginInit();
            this.pnlGarito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGabarito)).BeginInit();
            this.SuspendLayout();
            // 
            // cboProva
            // 
            this.cboProva.FormattingEnabled = true;
            this.cboProva.Location = new System.Drawing.Point(127, 73);
            this.cboProva.Name = "cboProva";
            this.cboProva.Size = new System.Drawing.Size(198, 23);
            this.cboProva.TabIndex = 0;
            // 
            // cboAno
            // 
            this.cboAno.FormattingEnabled = true;
            this.cboAno.Location = new System.Drawing.Point(127, 119);
            this.cboAno.Name = "cboAno";
            this.cboAno.Size = new System.Drawing.Size(198, 23);
            this.cboAno.TabIndex = 1;
            // 
            // lblprova
            // 
            this.lblprova.AutoSize = true;
            this.lblprova.Location = new System.Drawing.Point(50, 81);
            this.lblprova.Name = "lblprova";
            this.lblprova.Size = new System.Drawing.Size(37, 15);
            this.lblprova.TabIndex = 2;
            this.lblprova.Text = "Prova";
            // 
            // lblano
            // 
            this.lblano.AutoSize = true;
            this.lblano.Location = new System.Drawing.Point(50, 119);
            this.lblano.Name = "lblano";
            this.lblano.Size = new System.Drawing.Size(29, 15);
            this.lblano.TabIndex = 3;
            this.lblano.Text = "Ano";
            // 
            // nada
            // 
            this.nada.AutoSize = true;
            this.nada.Location = new System.Drawing.Point(209, 13);
            this.nada.Name = "nada";
            this.nada.Size = new System.Drawing.Size(87, 15);
            this.nada.TabIndex = 4;
            this.nada.Text = "Consulta prova";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(50, 160);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dtgProva
            // 
            this.dtgProva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProva.Location = new System.Drawing.Point(50, 211);
            this.dtgProva.Name = "dtgProva";
            this.dtgProva.RowTemplate.Height = 25;
            this.dtgProva.Size = new System.Drawing.Size(275, 150);
            this.dtgProva.TabIndex = 6;
            // 
            // pnlGarito
            // 
            this.pnlGarito.Controls.Add(this.btnVoltar);
            this.pnlGarito.Controls.Add(this.dtgGabarito);
            this.pnlGarito.Controls.Add(this.lblGabarito);
            this.pnlGarito.Location = new System.Drawing.Point(414, 28);
            this.pnlGarito.Name = "pnlGarito";
            this.pnlGarito.Size = new System.Drawing.Size(333, 380);
            this.pnlGarito.TabIndex = 7;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(245, 310);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // dtgGabarito
            // 
            this.dtgGabarito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGabarito.Location = new System.Drawing.Point(17, 53);
            this.dtgGabarito.Name = "dtgGabarito";
            this.dtgGabarito.RowTemplate.Height = 25;
            this.dtgGabarito.Size = new System.Drawing.Size(303, 233);
            this.dtgGabarito.TabIndex = 1;
            // 
            // lblGabarito
            // 
            this.lblGabarito.AutoSize = true;
            this.lblGabarito.Location = new System.Drawing.Point(33, 24);
            this.lblGabarito.Name = "lblGabarito";
            this.lblGabarito.Size = new System.Drawing.Size(52, 15);
            this.lblGabarito.TabIndex = 0;
            this.lblGabarito.Text = "Gabarito";
            // 
            // ConsultaProva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlGarito);
            this.Controls.Add(this.dtgProva);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.nada);
            this.Controls.Add(this.lblano);
            this.Controls.Add(this.lblprova);
            this.Controls.Add(this.cboAno);
            this.Controls.Add(this.cboProva);
            this.Name = "ConsultaProva";
            this.Text = "Consulta Prova";
            this.Load += new System.EventHandler(this.ConsultaProva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProva)).EndInit();
            this.pnlGarito.ResumeLayout(false);
            this.pnlGarito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGabarito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboProva;
        private System.Windows.Forms.ComboBox cboAno;
        private System.Windows.Forms.Label lblprova;
        private System.Windows.Forms.Label lblano;
        private System.Windows.Forms.Label nada;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dtgProva;
        private System.Windows.Forms.Panel pnlGarito;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dtgGabarito;
        private System.Windows.Forms.Label lblGabarito;
    }
}

