using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualTCC_Prévia
{
    public partial class Estoque2 : Form
    {
        string connectionString = "Data Source=AMI;Initial Catalog=Super_Mercado;User ID=sa;Password=98082450j";

        public Estoque2()
        {
            InitializeComponent();
            txtid.MaxLength = 50;
            guna2TextBox7.MaxLength = 50;
            guna2TextBox9.MaxLength = 5;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Caixa Caixa = new Caixa();
            Caixa.Show();
            this.Hide();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Estoque Estoque = new Estoque();
            Estoque.Show();
            this.Hide();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            Cadastro Cadastro = new Cadastro();
            Cadastro.Show();
            this.Hide();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Dashboard Dashboard = new Dashboard();
            Dashboard.Show();
            this.Hide();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            string query = "SELECT id_produto, descricao, quantidade, preco_unitario FROM produtos";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    guna2DataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show();
            this.Hide();
        }

        private void bntatualizar_Click_1(object sender, EventArgs e)
        {
            atualizar();
            vizualizar();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            excluir();
            vizualizar();
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            adicionar();
            vizualizar();
        }

        private bool Existe(string id_produto, SqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM produtos WHERE id_produto = @id_produto";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id_produto", id_produto);
            int count = (int)command.ExecuteScalar();
            return count > 0;
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void adicionar()
        {
            // Captura os dados dos campos de texto
            string id_produto = txtid.Text.Trim();
            string descricao = guna2TextBox7.Text.Trim();

            // Verifica se o campo ID do produto não está em branco
            if (string.IsNullOrWhiteSpace(id_produto))
            {
                MessageBox.Show("Por favor, preencha o ID do Produto.");
                return;
            }

            // Verifica se o campo de descrição não está em branco
            if (string.IsNullOrWhiteSpace(descricao))
            {
                MessageBox.Show("Por favor, preencha a Descrição do Produto.");
                return;
            }

            // Verifica se a quantidade é um número inteiro válido
            int quantidade;
            if (!int.TryParse(nudquantidade.Text, out quantidade))
            {
                MessageBox.Show("Quantidade deve ser um número inteiro.");
                return;
            }

            // Verifica se o preço unitário é um valor decimal válido
            decimal preco_unitario;
            if (!decimal.TryParse(guna2TextBox9.Text.Replace("R$", "").Trim(), out preco_unitario))
            {
                MessageBox.Show("Preço Unitário deve ser um valor decimal válido.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Verifica se o id_produto já existe
                    if (Existe(id_produto, connection))
                    {
                        MessageBox.Show("Produto com este ID já existe.");
                    }
                    else
                    {
                        // Consulta para inserir os dados no banco de dados
                        string query = "INSERT INTO produtos (id_produto, descricao, quantidade, preco_unitario) VALUES (@id_produto, @descricao, @quantidade, @preco_unitario)";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@id_produto", id_produto);
                        command.Parameters.AddWithValue("@descricao", descricao);
                        command.Parameters.AddWithValue("@quantidade", quantidade);
                        command.Parameters.AddWithValue("@preco_unitario", preco_unitario);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Dados inseridos com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir os dados: " + ex.Message);
                }
            }
        }


        public void atualizar()
        {
            // Verifica se o campo de ID do produto é um número válido
            int id_produto;
            if (!int.TryParse(txtid.Text, out id_produto))
            {
                MessageBox.Show("ID do Produto inválido.");
                return;
            }

            // Verifica se o campo de descrição não está vazio
            string novaDescricao = guna2TextBox7.Text.Trim();
            if (string.IsNullOrWhiteSpace(novaDescricao))
            {
                MessageBox.Show("Por favor, preencha a Descrição do Produto.");
                return;
            }

            // Verifica se o campo de preço unitário não está vazio e é um valor válido
            decimal novoPrecoUnitario;
            if (!decimal.TryParse(guna2TextBox9.Text, out novoPrecoUnitario))
            {
                MessageBox.Show("Preço Unitário inválido.");
                return;
            }

            // Verifica se o campo de quantidade não está vazio e é um valor válido
            int novaQuantidade = (int)nudquantidade.Value;

            // Query SQL para atualizar os dados do produto
            string query = "UPDATE Produtos SET Descricao = @Descricao, Quantidade = @Quantidade, Preco_Unitario = @PrecoUnitario WHERE id_produto = @Id_produto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Descricao", novaDescricao);
                command.Parameters.AddWithValue("@Quantidade", novaQuantidade);
                command.Parameters.AddWithValue("@PrecoUnitario", novoPrecoUnitario);
                command.Parameters.AddWithValue("@Id_produto", id_produto);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Produto atualizado com sucesso.");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar o produto.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        public void vizualizar()
        {
            string query = "SELECT id_produto, descricao, quantidade, preco_unitario FROM produtos";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    guna2DataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        public void excluir()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                int id_produto = int.Parse(txtid.Text);

                connection.Open();
                string deleteQuery = "DELETE FROM produtos WHERE id_produto = @id_produto";
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                deleteCommand.Parameters.AddWithValue("@id_produto", id_produto);
                int rowsAffected = deleteCommand.ExecuteNonQuery();
                MessageBox.Show("Produto excluido com sucesso.");
            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            int id_produto;
            if (!int.TryParse(txtid.Text, out id_produto))
            {
                // Limpar os campos se o ID não for um número válido
                LimparCampos();
                return;
            }

            // Consulta SQL para buscar as informações do produto pelo ID
            string query = "SELECT Descricao, Quantidade, Preco_Unitario FROM Produtos WHERE id_produto = @Id_produto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id_produto", id_produto);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read()) // Se encontrou o produto com o ID especificado
                    {
                        // Preencher os campos com as informações do produto
                        guna2TextBox7.Text = reader["Descricao"].ToString();
                        nudquantidade.Value = Convert.ToInt32(reader["Quantidade"]);
                        guna2TextBox9.Text = reader["Preco_Unitario"].ToString();
                    }
                    else
                    {
                        // Se não encontrou o produto, limpar os campos
                        LimparCampos();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar informações do produto: " + ex.Message);
                }
            }
        }
        private void LimparCampos()
        {
            guna2TextBox7.Text = string.Empty;
            nudquantidade.Value = 0;
            guna2TextBox9.Text = string.Empty;
        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
