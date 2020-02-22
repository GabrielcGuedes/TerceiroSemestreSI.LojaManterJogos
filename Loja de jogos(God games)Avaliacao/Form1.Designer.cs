namespace Loja_de_jogos_God_games_Avaliacao
{
    partial class Form1
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
            this.txtNomeJogo = new System.Windows.Forms.TextBox();
            this.lblNomeJogo = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblQtd = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.dgvJogo = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtCodigoJogo = new System.Windows.Forms.TextBox();
            this.lblCodigojogo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnInstruções = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeJogo
            // 
            this.txtNomeJogo.Location = new System.Drawing.Point(16, 166);
            this.txtNomeJogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeJogo.Name = "txtNomeJogo";
            this.txtNomeJogo.Size = new System.Drawing.Size(132, 22);
            this.txtNomeJogo.TabIndex = 0;
            // 
            // lblNomeJogo
            // 
            this.lblNomeJogo.AutoSize = true;
            this.lblNomeJogo.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeJogo.Location = new System.Drawing.Point(16, 146);
            this.lblNomeJogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeJogo.Name = "lblNomeJogo";
            this.lblNomeJogo.Size = new System.Drawing.Size(108, 17);
            this.lblNomeJogo.TabIndex = 1;
            this.lblNomeJogo.Text = "Nome do Jogo: ";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.BackColor = System.Drawing.Color.Transparent;
            this.lblPreco.Location = new System.Drawing.Point(16, 206);
            this.lblPreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(53, 17);
            this.lblPreco.TabIndex = 2;
            this.lblPreco.Text = "Preço: ";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(16, 222);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(132, 22);
            this.txtPreco.TabIndex = 3;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.BackColor = System.Drawing.Color.Transparent;
            this.lblCod.Location = new System.Drawing.Point(16, 28);
            this.lblCod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(109, 17);
            this.lblCod.TabIndex = 4;
            this.lblCod.Text = "Código Usuário:";
            // 
            // txtCod
            // 
            this.txtCod.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCod.Location = new System.Drawing.Point(16, 48);
            this.txtCod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(132, 22);
            this.txtCod.TabIndex = 5;
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.BackColor = System.Drawing.Color.Transparent;
            this.lblQtd.Location = new System.Drawing.Point(16, 258);
            this.lblQtd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(86, 17);
            this.lblQtd.TabIndex = 6;
            this.lblQtd.Text = "Quantidade:";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(16, 278);
            this.txtQtd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(132, 22);
            this.txtQtd.TabIndex = 7;
            // 
            // dgvJogo
            // 
            this.dgvJogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJogo.Location = new System.Drawing.Point(196, 32);
            this.dgvJogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvJogo.Name = "dgvJogo";
            this.dgvJogo.Size = new System.Drawing.Size(589, 235);
            this.dgvJogo.TabIndex = 8;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(196, 275);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 28);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(825, 100);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(100, 28);
            this.btnListar.TabIndex = 10;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(825, 239);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 28);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(825, 166);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(100, 28);
            this.btnAtualizar.TabIndex = 12;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.Location = new System.Drawing.Point(825, 32);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 31);
            this.btnPesquisar.TabIndex = 13;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtCodigoJogo
            // 
            this.txtCodigoJogo.Location = new System.Drawing.Point(16, 107);
            this.txtCodigoJogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoJogo.Name = "txtCodigoJogo";
            this.txtCodigoJogo.Size = new System.Drawing.Size(132, 22);
            this.txtCodigoJogo.TabIndex = 14;
            // 
            // lblCodigojogo
            // 
            this.lblCodigojogo.AutoSize = true;
            this.lblCodigojogo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigojogo.Location = new System.Drawing.Point(16, 87);
            this.lblCodigojogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigojogo.Name = "lblCodigojogo";
            this.lblCodigojogo.Size = new System.Drawing.Size(91, 17);
            this.lblCodigojogo.TabIndex = 15;
            this.lblCodigojogo.Text = "Codigo Jogo:";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(685, 275);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 28);
            this.btnSair.TabIndex = 16;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInstruções
            // 
            this.btnInstruções.Location = new System.Drawing.Point(443, 313);
            this.btnInstruções.Margin = new System.Windows.Forms.Padding(4);
            this.btnInstruções.Name = "btnInstruções";
            this.btnInstruções.Size = new System.Drawing.Size(100, 28);
            this.btnInstruções.TabIndex = 17;
            this.btnInstruções.Text = "Instruções";
            this.btnInstruções.UseVisualStyleBackColor = true;
            this.btnInstruções.Click += new System.EventHandler(this.btnInstruções_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loja_de_jogos_God_games_Avaliacao.Properties.Resources.kratos_cortado_mt_loko;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 354);
            this.Controls.Add(this.btnInstruções);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblCodigojogo);
            this.Controls.Add(this.txtCodigoJogo);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dgvJogo);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblNomeJogo);
            this.Controls.Add(this.txtNomeJogo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "CadastroJogo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeJogo;
        private System.Windows.Forms.Label lblNomeJogo;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.DataGridView dgvJogo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtCodigoJogo;
        private System.Windows.Forms.Label lblCodigojogo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnInstruções;
    }
}

