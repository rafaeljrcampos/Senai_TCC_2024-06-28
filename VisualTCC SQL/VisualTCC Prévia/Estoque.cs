using Guna.UI2.WinForms;
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
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
            LoadProgressBarValue();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Estoque Estoque = new Estoque();
            Estoque.Show();
            this.Hide();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Caixa Caixa = new Caixa();
            Caixa.Show();
            this.Hide();
        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            Cadastro Cadastro = new Cadastro();
            Cadastro.Show();
            this.Hide();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
        
        private void guna2CircleProgressBar6_ValueChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=AMI;Initial Catalog=Super_Mercado;User ID=sa;Password=98082450j";
            string nome = "Pao PANCO 500g"; 
            string querySelect = "SELECT Quantidade FROM Produtos WHERE descricao = @descricao"; // Consulta para obter a quantidade atual
            using (SqlConnection connection = new SqlConnection(connectionString))

                try
                {
                    connection.Open();
                    // Recuperar a quantidade atual do banco de dados
                    SqlCommand commandSelect = new SqlCommand(querySelect, connection);
                    commandSelect.Parameters.AddWithValue("@descricao", nome);

                    // Executar a consulta e obter a quantidade atual
                    object result = commandSelect.ExecuteScalar();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro: Produto não encontrado.");
                    
                }
        }

        private void LoadProgressBarValue()
        {
            string connectionString = "Data Source=AMI;Initial Catalog=Super_Mercado;User ID=sa;Password=98082450j";
            string query = "SELECT id_produto, quantidade FROM produtos";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id_produto"]);
                        int percentage = Convert.ToInt32(reader["quantidade"]);

                        // Atualize os valores das barras de progresso com base no ID
                        switch (id)
                        {
                            case 567:
                                guna2CircleProgressBar1.Value = percentage;
                                break;
                            case 456:
                                guna2CircleProgressBar2.Value = percentage;
                                break;
                            case 345:
                                guna2CircleProgressBar3.Value = percentage;
                                break;
                            case 222://Leite
                                guna2CircleProgressBar4.Value = percentage;
                                break;
                            case 111://Alcatra
                                guna2CircleProgressBar5.Value = percentage;
                                break;
                            case 123://Pao
                                guna2CircleProgressBar6.Value = percentage;
                                break;
                                // Adicione mais casos conforme necessário
                        }
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
                }
            }
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            Estoque2 Estoque2 = new Estoque2();
            Estoque2.Show();
            this.Hide();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Dashboard Dashboard = new Dashboard();
            Dashboard.Show();
            this.Hide();
        }

        private void guna2CircleProgressBar5_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
    

