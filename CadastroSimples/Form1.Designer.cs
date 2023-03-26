
namespace CadastroSimples
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblSobrenome = new System.Windows.Forms.Label();
            this.LblCelular = new System.Windows.Forms.Label();
            this.TextBoxNome = new System.Windows.Forms.TextBox();
            this.TextBoxSobrenome = new System.Windows.Forms.TextBox();
            this.MaskedTextBoxCelular = new System.Windows.Forms.MaskedTextBox();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.DataGridViewDados = new System.Windows.Forms.DataGridView();
            this.LblId = new System.Windows.Forms.Label();
            this.TextBoxId = new System.Windows.Forms.TextBox();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Cliente";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(39, 132);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(55, 20);
            this.LblNome.TabIndex = 1;
            this.LblNome.Text = "Nome:";
            // 
            // LblSobrenome
            // 
            this.LblSobrenome.AutoSize = true;
            this.LblSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSobrenome.Location = new System.Drawing.Point(257, 132);
            this.LblSobrenome.Name = "LblSobrenome";
            this.LblSobrenome.Size = new System.Drawing.Size(96, 20);
            this.LblSobrenome.TabIndex = 2;
            this.LblSobrenome.Text = "Sobrenome:";
            // 
            // LblCelular
            // 
            this.LblCelular.AutoSize = true;
            this.LblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCelular.Location = new System.Drawing.Point(34, 209);
            this.LblCelular.Name = "LblCelular";
            this.LblCelular.Size = new System.Drawing.Size(62, 20);
            this.LblCelular.TabIndex = 3;
            this.LblCelular.Text = "Celular:";
            // 
            // TextBoxNome
            // 
            this.TextBoxNome.Location = new System.Drawing.Point(96, 132);
            this.TextBoxNome.Name = "TextBoxNome";
            this.TextBoxNome.Size = new System.Drawing.Size(135, 20);
            this.TextBoxNome.TabIndex = 4;
            // 
            // TextBoxSobrenome
            // 
            this.TextBoxSobrenome.Location = new System.Drawing.Point(359, 134);
            this.TextBoxSobrenome.Name = "TextBoxSobrenome";
            this.TextBoxSobrenome.Size = new System.Drawing.Size(135, 20);
            this.TextBoxSobrenome.TabIndex = 5;
            // 
            // MaskedTextBoxCelular
            // 
            this.MaskedTextBoxCelular.Location = new System.Drawing.Point(96, 209);
            this.MaskedTextBoxCelular.Mask = "(00) 00000-0000";
            this.MaskedTextBoxCelular.Name = "MaskedTextBoxCelular";
            this.MaskedTextBoxCelular.Size = new System.Drawing.Size(135, 20);
            this.MaskedTextBoxCelular.TabIndex = 6;
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.Location = new System.Drawing.Point(33, 392);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(95, 34);
            this.BtnEnviar.TabIndex = 7;
            this.BtnEnviar.Text = "Enviar";
            this.BtnEnviar.UseVisualStyleBackColor = true;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(581, 393);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(95, 34);
            this.BtnFechar.TabIndex = 9;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(251, 392);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(95, 34);
            this.BtnExcluir.TabIndex = 11;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click_1);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(141, 392);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(95, 34);
            this.BtnAlterar.TabIndex = 12;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // DataGridViewDados
            // 
            this.DataGridViewDados.AllowUserToAddRows = false;
            this.DataGridViewDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewDados.Location = new System.Drawing.Point(33, 246);
            this.DataGridViewDados.Name = "DataGridViewDados";
            this.DataGridViewDados.Size = new System.Drawing.Size(643, 119);
            this.DataGridViewDados.TabIndex = 14;
            this.DataGridViewDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewDados_CellClick);
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.Location = new System.Drawing.Point(43, 88);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(27, 20);
            this.LblId.TabIndex = 15;
            this.LblId.Text = "Id:";
            // 
            // TextBoxId
            // 
            this.TextBoxId.Location = new System.Drawing.Point(66, 90);
            this.TextBoxId.Name = "TextBoxId";
            this.TextBoxId.Size = new System.Drawing.Size(42, 20);
            this.TextBoxId.TabIndex = 16;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(360, 393);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(95, 34);
            this.BtnPesquisar.TabIndex = 17;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(471, 393);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(95, 34);
            this.BtnLimpar.TabIndex = 18;
            this.BtnLimpar.Text = "Limpa tela";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(713, 460);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.TextBoxId);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.DataGridViewDados);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnEnviar);
            this.Controls.Add(this.MaskedTextBoxCelular);
            this.Controls.Add(this.TextBoxSobrenome);
            this.Controls.Add(this.TextBoxNome);
            this.Controls.Add(this.LblCelular);
            this.Controls.Add(this.LblSobrenome);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Simples";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblSobrenome;
        private System.Windows.Forms.Label LblCelular;
        private System.Windows.Forms.TextBox TextBoxNome;
        private System.Windows.Forms.TextBox TextBoxSobrenome;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxCelular;
        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.DataGridView DataGridViewDados;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.TextBox TextBoxId;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Button BtnLimpar;
    }
}

