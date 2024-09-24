using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualTCC_Prévia
{
    public partial class permissoes : Form
    {
        string connectionString = "Data Source=AMI;Initial Catalog=Super_Mercado;User ID=sa;Password=98082450j";

        public permissoes()
        {
            InitializeComponent();
            string query = "SELECT id_funcionario, nome, cargo, telefone, CPF, cidade, bairro, rua, numero FROM funcionarios";

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

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Cadastro Cadastro = new Cadastro();
            Cadastro.Show();
            this.Hide();
        }

        private void permissoes_Load(object sender, EventArgs e)
        {

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            excluir();
            vizualizar();
        }
          
        public void excluir()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                int id_funcionario = int.Parse(txtid.Text);

                connection.Open();
                string deleteQuery = "DELETE FROM funcionarios WHERE id_funcionario = @id_funcionario";
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                deleteCommand.Parameters.AddWithValue("@id_funcionario", id_funcionario);
                int rowsAffected = deleteCommand.ExecuteNonQuery();
                MessageBox.Show("Produto excluido com sucesso.");
            }
        }

        public void vizualizar()
        {
            string query = "SELECT id_funcionario, nome, cargo, telefone, CPF, cidade, bairro, rua, numero FROM funcionarios";

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

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
