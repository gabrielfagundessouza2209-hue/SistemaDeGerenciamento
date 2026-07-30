using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Globalization;

namespace SistemaDeGerenciamentoDeEstoque
{
	public partial class MainForm : Form
	{
	public class Produto
        {
	
            // Propriedades
            public int Codigo { get; set; }
            public string Nome { get; set; }
            public string Categoria { get; set; }
            public decimal Preco { get; set; }
            public int Quantidade { get; set; }

            // Propriedade Calculada
         public decimal ValorEmEstoque
{
    get
    {
        return Preco * Quantidade;
    }
}
            // Construtor Completo
           public Produto(int codigo, string nome, string categoria, decimal preco, int quantidade)
{
    Codigo = codigo;
    Nome = nome;
    Categoria = categoria;
    Preco = preco;
    Quantidade = quantidade;
}
        }

        // Coleção em memória para armazenar os produtos durante a execução
        private List<Produto> ListaProdutos = new List<Produto>();

        public MainForm()
        {
            InitializeComponent();
            InicializarComponentesPersonalizados();
        }

        private void InicializarComponentesPersonalizados()
        {
            // Configurações do DataGridView
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.MultiSelect = false;
            dgvProdutos.ReadOnly = true;

            // Popular o ComboBox de categorias
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.Add("Selecione uma categoria");
            cmbCategoria.Items.Add("Informática");
            cmbCategoria.Items.Add("Periféricos");
            cmbCategoria.Items.Add("Eletrônicos");
            cmbCategoria.Items.Add("Escritório");
            cmbCategoria.Items.Add("Acessórios");
            cmbCategoria.Items.Add("Outros");
            cmbCategoria.SelectedIndex = 0;

            AtualizarGrid();
        }

        #region Botões de Ação (CRUD)

        // CREATE - Adicionar produto
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int codigo;
            decimal preco;
            int quantidade;

            // Interrompe se a validação falhar
            if (!ValidarCampos(out codigo, out preco, out quantidade))
                return;

            if (ProdutoJaCadastrado(codigo))
            {
                MessageBox.Show("Já existe um produto cadastrado com esse código.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Pega o texto da categoria selecionada, não o índice
            string categoriaSelecionada = cmbCategoria.SelectedItem.ToString();

            Produto novoProduto = new Produto(codigo, txtNomeDoProduto.Text.Trim(), categoriaSelecionada, preco, quantidade);
            ListaProdutos.Add(novoProduto);

            MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            AtualizarGrid();
            LimparCampos();
        }

        // UPDATE - Atualizar produto selecionado
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto na tabela para atualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int codigo;
            decimal preco;
            int quantidade;

            if (!ValidarCampos(out codigo, out preco, out quantidade))
                return;

            int codigoSelecionado = Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells["Codigo"].Value);
            Produto produto = ListaProdutos.FirstOrDefault(p => p.Codigo == codigoSelecionado);

            if (produto != null)
            {
                // Impede alterar o código para um código de outro produto existente
                if (codigo != codigoSelecionado && ProdutoJaCadastrado(codigo))
                {
                    MessageBox.Show("Já existe outro produto cadastrado com esse novo código.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Atualiza os dados do objeto existente
                produto.Codigo = codigo;
                produto.Nome = txtNomeDoProduto.Text.Trim();
                produto.Categoria = cmbCategoria.SelectedItem.ToString();
                produto.Preco = preco;
                produto.Quantidade = quantidade;

                MessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AtualizarGrid();
                LimparCampos();
            }
        }

        // DELETE - Excluir produto selecionado
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto na tabela para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacao = MessageBox.Show("Deseja realmente excluir o produto selecionado?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                int codigoSelecionado = Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells["Codigo"].Value);
                Produto produto = ListaProdutos.FirstOrDefault(p => p.Codigo == codigoSelecionado);

                if (produto != null)
                {
                    ListaProdutos.Remove(produto);
                    MessageBox.Show("Produto excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGrid();
                    LimparCampos();
                }
            }
        }

        // READ / SEARCH - Pesquisar produtos
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarProdutos();
        }

        // Pesquisa automática enquanto digita
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            PesquisarProdutos();
        }

        // Limpar campos e seleção
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        // Encerrar aplicação
        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente encerrar o sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        #endregion

        #region Eventos do DataGridView

       private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
{
    // Garante que o clique foi em uma linha válida, e não no cabeçalho (e.RowIndex >= 0)
    if (e.RowIndex >= 0)
    {
        CarregarProdutoSelecionado();
    }
}

        #endregion

        #region Métodos Auxiliares

        private bool ValidarCampos(out int codigo, out decimal preco, out int quantidade)
        {
            codigo = 0;
            preco = 0;
            quantidade = 0;

            // RN01 & RN02: Código
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || !int.TryParse(txtCodigo.Text, out codigo) || codigo <= 0)
            {
                MessageBox.Show("Informe um código numérico válido e maior que zero.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return false;
            }

            // RN03: Nome
            if (string.IsNullOrWhiteSpace(txtNomeDoProduto.Text))
            {
                MessageBox.Show("Digite o nome do produto.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeDoProduto.Focus();
                return false;
            }

            // RN04: Categoria
            if (cmbCategoria.SelectedIndex <= 0)
            {
                MessageBox.Show("Selecione uma categoria válida.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategoria.Focus();
                return false;
            }

            // RN05: Preço
           // RN05: Preço com suporte flexível a vírgula/ponto
if (string.IsNullOrWhiteSpace(txtPreço.Text) || 
    !decimal.TryParse(txtPreço.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out preco) || 
    preco <= 0)
{
    MessageBox.Show("Informe um preço válido e maior que zero.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    txtPreço.Focus();
    return false;
}
            // RN06: Quantidade
            if (string.IsNullOrWhiteSpace(txtQuantidade.Text) || !int.TryParse(txtQuantidade.Text, out quantidade) || quantidade < 0)
            {
                MessageBox.Show("Informe uma quantidade válida (não negativa).", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantidade.Focus();
                return false;
            }

            return true;
        }

        private bool ProdutoJaCadastrado(int codigo)
        {
            return ListaProdutos.Any(p => p.Codigo == codigo);
        }

        private void AtualizarGrid(List<Produto> listaExibicao = null)
        {
            var fonte = listaExibicao ?? ListaProdutos;

            // Projeta os dados formatados
            dgvProdutos.DataSource = fonte.Select(p => new
            {
                Codigo = p.Codigo,
                Nome = p.Nome,
                Categoria = p.Categoria,
                Preco = p.Preco.ToString("C2"),
                Quantidade = p.Quantidade,
                ValorEmEstoque = p.ValorEmEstoque.ToString("C2")
            }).ToList();

            // Ajusta os cabeçalhos das colunas
            if (dgvProdutos.Columns.Count > 0)
            {
                dgvProdutos.Columns["Codigo"].HeaderText = "Código";
                dgvProdutos.Columns["Nome"].HeaderText = "Nome";
                dgvProdutos.Columns["Categoria"].HeaderText = "Categoria";
                dgvProdutos.Columns["Preco"].HeaderText = "Preço";
                dgvProdutos.Columns["Quantidade"].HeaderText = "Quantidade";
                dgvProdutos.Columns["ValorEmEstoque"].HeaderText = "Valor em Estoque";
            }
        }

        private void CarregarProdutoSelecionado()
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvProdutos.SelectedRows[0];
                int codigo = Convert.ToInt32(row.Cells["Codigo"].Value);

                Produto produto = ListaProdutos.FirstOrDefault(p => p.Codigo == codigo);
                if (produto != null)
                {
                    txtCodigo.Text = produto.Codigo.ToString();
                    txtNomeDoProduto.Text = produto.Nome;
                    cmbCategoria.SelectedItem = produto.Categoria;
                    txtPreço.Text = produto.Preco.ToString("F2");
                    txtQuantidade.Text = produto.Quantidade.ToString();
                }
            }
        }

        private void PesquisarProdutos()
        {
            string termo = txtPesquisar.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(termo))
            {
                AtualizarGrid();
                return;
            }

            var resultados = ListaProdutos.Where(p =>
                p.Codigo.ToString().Contains(termo) ||
                p.Nome.ToLower().Contains(termo) ||
                p.Categoria.ToLower().Contains(termo)
            ).ToList();

            AtualizarGrid(resultados);
        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNomeDoProduto.Clear();
            cmbCategoria.SelectedIndex = 0;
            txtPreço.Clear();
            txtQuantidade.Clear();
            txtPesquisar.Clear();

            dgvProdutos.ClearSelection();
            AtualizarGrid();
            txtCodigo.Focus();
        }
        #endregion
    }
}

