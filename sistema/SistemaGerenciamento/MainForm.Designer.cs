/*
 * Criado por SharpDevelop.
 * Usuário: aluno_iot
 * Data: 27/07/2026
 * Hora: 08:23
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace SistemaDeGerenciamentoDeEstoque
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblCodigo;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label lblPreço;
		private System.Windows.Forms.TextBox txtPreço;
		private System.Windows.Forms.Label lblNomeProduto;
		private System.Windows.Forms.TextBox txtNomeDoProduto;
		private System.Windows.Forms.Label lblQuantidade;
		private System.Windows.Forms.TextBox txtQuantidade;
		private System.Windows.Forms.Label lblSistemaDeGerenciamentoDeEstoque;
		private System.Windows.Forms.Label lblCategoria;
		private System.Windows.Forms.Label lblPesquisar;
		private System.Windows.Forms.ComboBox cmbCategoria;
		private System.Windows.Forms.TextBox txtPesquisar;
		private System.Windows.Forms.Button btnAdicionar;
		private System.Windows.Forms.Button btnAtualizar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnPesquisar;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.DataGridView dgvProdutos;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblCodigo = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.lblPreço = new System.Windows.Forms.Label();
			this.txtPreço = new System.Windows.Forms.TextBox();
			this.lblNomeProduto = new System.Windows.Forms.Label();
			this.txtNomeDoProduto = new System.Windows.Forms.TextBox();
			this.lblQuantidade = new System.Windows.Forms.Label();
			this.txtQuantidade = new System.Windows.Forms.TextBox();
			this.lblSistemaDeGerenciamentoDeEstoque = new System.Windows.Forms.Label();
			this.lblCategoria = new System.Windows.Forms.Label();
			this.lblPesquisar = new System.Windows.Forms.Label();
			this.cmbCategoria = new System.Windows.Forms.ComboBox();
			this.txtPesquisar = new System.Windows.Forms.TextBox();
			this.btnAdicionar = new System.Windows.Forms.Button();
			this.btnAtualizar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.dgvProdutos = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
			this.SuspendLayout();
			// 
			// lblCodigo
			// 
			this.lblCodigo.Location = new System.Drawing.Point(48, 116);
			this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(55, 20);
			this.lblCodigo.TabIndex = 0;
			this.lblCodigo.Text = "Código\r\n";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(48, 139);
			this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
			this.txtCodigo.Multiline = true;
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(132, 24);
			this.txtCodigo.TabIndex = 1;
			// 
			// lblPreço
			// 
			this.lblPreço.Location = new System.Drawing.Point(48, 191);
			this.lblPreço.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPreço.Name = "lblPreço";
			this.lblPreço.Size = new System.Drawing.Size(55, 20);
			this.lblPreço.TabIndex = 3;
			this.lblPreço.Text = "Preço";
			// 
			// txtPreço
			// 
			this.txtPreço.Location = new System.Drawing.Point(48, 214);
			this.txtPreço.Margin = new System.Windows.Forms.Padding(4);
			this.txtPreço.Multiline = true;
			this.txtPreço.Name = "txtPreço";
			this.txtPreço.Size = new System.Drawing.Size(132, 24);
			this.txtPreço.TabIndex = 4;
			// 
			// lblNomeProduto
			// 
			this.lblNomeProduto.Location = new System.Drawing.Point(309, 116);
			this.lblNomeProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNomeProduto.Name = "lblNomeProduto";
			this.lblNomeProduto.Size = new System.Drawing.Size(119, 20);
			this.lblNomeProduto.TabIndex = 5;
			this.lblNomeProduto.Text = "Nome do produto";
			// 
			// txtNomeDoProduto
			// 
			this.txtNomeDoProduto.Location = new System.Drawing.Point(309, 139);
			this.txtNomeDoProduto.Margin = new System.Windows.Forms.Padding(4);
			this.txtNomeDoProduto.Multiline = true;
			this.txtNomeDoProduto.Name = "txtNomeDoProduto";
			this.txtNomeDoProduto.Size = new System.Drawing.Size(132, 24);
			this.txtNomeDoProduto.TabIndex = 6;
			// 
			// lblQuantidade
			// 
			this.lblQuantidade.Location = new System.Drawing.Point(309, 191);
			this.lblQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblQuantidade.Name = "lblQuantidade";
			this.lblQuantidade.Size = new System.Drawing.Size(84, 20);
			this.lblQuantidade.TabIndex = 7;
			this.lblQuantidade.Text = "Quantidade";
			// 
			// txtQuantidade
			// 
			this.txtQuantidade.Location = new System.Drawing.Point(309, 214);
			this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4);
			this.txtQuantidade.Multiline = true;
			this.txtQuantidade.Name = "txtQuantidade";
			this.txtQuantidade.Size = new System.Drawing.Size(132, 24);
			this.txtQuantidade.TabIndex = 8;
			// 
			// lblSistemaDeGerenciamentoDeEstoque
			// 
			this.lblSistemaDeGerenciamentoDeEstoque.BackColor = System.Drawing.Color.DodgerBlue;
			this.lblSistemaDeGerenciamentoDeEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSistemaDeGerenciamentoDeEstoque.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblSistemaDeGerenciamentoDeEstoque.Location = new System.Drawing.Point(1, 0);
			this.lblSistemaDeGerenciamentoDeEstoque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSistemaDeGerenciamentoDeEstoque.Name = "lblSistemaDeGerenciamentoDeEstoque";
			this.lblSistemaDeGerenciamentoDeEstoque.Size = new System.Drawing.Size(1623, 94);
			this.lblSistemaDeGerenciamentoDeEstoque.TabIndex = 10;
			this.lblSistemaDeGerenciamentoDeEstoque.Text = "Sistema De Gerenciamento De Estoque\r\n";
			// 
			// lblCategoria
			// 
			this.lblCategoria.Location = new System.Drawing.Point(527, 116);
			this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCategoria.Name = "lblCategoria";
			this.lblCategoria.Size = new System.Drawing.Size(71, 20);
			this.lblCategoria.TabIndex = 11;
			this.lblCategoria.Text = "Categoria\r\n";
			// 
			// lblPesquisar
			// 
			this.lblPesquisar.Location = new System.Drawing.Point(527, 191);
			this.lblPesquisar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPesquisar.Name = "lblPesquisar";
			this.lblPesquisar.Size = new System.Drawing.Size(119, 20);
			this.lblPesquisar.TabIndex = 12;
			this.lblPesquisar.Text = "Pesquisar";
			// 
			// cmbCategoria
			// 
			this.cmbCategoria.FormattingEnabled = true;
			this.cmbCategoria.Items.AddRange(new object[] {
			"Informática",
			"Periféricos",
			"Eletrônicos",
			"Escritório",
			"Acessórios",
			"Outros"});
			this.cmbCategoria.Location = new System.Drawing.Point(527, 139);
			this.cmbCategoria.Margin = new System.Windows.Forms.Padding(4);
			this.cmbCategoria.Name = "cmbCategoria";
			this.cmbCategoria.Size = new System.Drawing.Size(160, 24);
			this.cmbCategoria.TabIndex = 13;
			// 
			// txtPesquisar
			// 
			this.txtPesquisar.Location = new System.Drawing.Point(527, 214);
			this.txtPesquisar.Margin = new System.Windows.Forms.Padding(4);
			this.txtPesquisar.Multiline = true;
			this.txtPesquisar.Name = "txtPesquisar";
			this.txtPesquisar.Size = new System.Drawing.Size(132, 24);
			this.txtPesquisar.TabIndex = 14;
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnAdicionar.Location = new System.Drawing.Point(48, 292);
			this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(141, 41);
			this.btnAdicionar.TabIndex = 17;
			this.btnAdicionar.Text = "Adicionar";
			this.btnAdicionar.UseVisualStyleBackColor = false;
			this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
			// 
			// btnAtualizar
			// 
			this.btnAtualizar.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnAtualizar.Location = new System.Drawing.Point(228, 292);
			this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4);
			this.btnAtualizar.Name = "btnAtualizar";
			this.btnAtualizar.Size = new System.Drawing.Size(141, 41);
			this.btnAtualizar.TabIndex = 16;
			this.btnAtualizar.Text = "Atualizar\r\n";
			this.btnAtualizar.UseVisualStyleBackColor = false;
			this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.Color.Red;
			this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnExcluir.Location = new System.Drawing.Point(411, 292);
			this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(141, 41);
			this.btnExcluir.TabIndex = 16;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = false;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnPesquisar.Location = new System.Drawing.Point(596, 292);
			this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(141, 41);
			this.btnPesquisar.TabIndex = 18;
			this.btnPesquisar.Text = "Pesquisar";
			this.btnPesquisar.UseVisualStyleBackColor = false;
			this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
			// 
			// btnLimpar
			// 
			this.btnLimpar.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnLimpar.Location = new System.Drawing.Point(772, 292);
			this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(141, 41);
			this.btnLimpar.TabIndex = 19;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = false;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// btnSair
			// 
			this.btnSair.BackColor = System.Drawing.Color.Red;
			this.btnSair.Location = new System.Drawing.Point(963, 292);
			this.btnSair.Margin = new System.Windows.Forms.Padding(4);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(141, 41);
			this.btnSair.TabIndex = 20;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// dgvProdutos
			// 
			this.dgvProdutos.AllowUserToOrderColumns = true;
			this.dgvProdutos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProdutos.Location = new System.Drawing.Point(16, 372);
			this.dgvProdutos.Margin = new System.Windows.Forms.Padding(4);
			this.dgvProdutos.Name = "dgvProdutos";
			this.dgvProdutos.RowHeadersWidth = 51;
			this.dgvProdutos.Size = new System.Drawing.Size(1396, 229);
			this.dgvProdutos.TabIndex = 21;
			this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1579, 770);
			this.Controls.Add(this.dgvProdutos);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnAtualizar);
			this.Controls.Add(this.btnAdicionar);
			this.Controls.Add(this.txtPesquisar);
			this.Controls.Add(this.cmbCategoria);
			this.Controls.Add(this.lblPesquisar);
			this.Controls.Add(this.lblCategoria);
			this.Controls.Add(this.lblSistemaDeGerenciamentoDeEstoque);
			this.Controls.Add(this.txtQuantidade);
			this.Controls.Add(this.lblQuantidade);
			this.Controls.Add(this.txtNomeDoProduto);
			this.Controls.Add(this.lblNomeProduto);
			this.Controls.Add(this.txtPreço);
			this.Controls.Add(this.lblPreço);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.lblCodigo);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "SistemaDeGerenciamentoDeEstoque";
			((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
