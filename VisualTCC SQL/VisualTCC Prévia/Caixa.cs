using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Timers;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Globalization;
using System.Text.RegularExpressions;

namespace VisualTCC_Prévia
{
    public partial class Caixa : Form
    {
        string connectionString = "Data Source=AMI;Initial Catalog=Super_Mercado;User ID=sa;Password=98082450j";
        //SerialPort serialPort1;

        public Caixa()
        {
            InitializeComponent();
            InitializeTimer();
            //serialPort1 = new SerialPort("COM4", 9600); // Altere para a porta serial correta
            //serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            //serialPort1.Open();
        }

        private void InitializeTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 2000; // Intervalo de 2 segundos (2000 milissegundos)
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            //SerialPort sp = (SerialPort)sender;
            //string indata = sp.ReadLine();
            //SetText(indata);
        }

        //delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            
            //if (this.guna2TextBox1.InvokeRequired)
            //{
            //      SetTextCallback d = new SetTextCallback(SetText);
            //      this.Invoke(d, new object[] { text });
            //}
            // else
            // {
            //    this.guna2TextBox1.Text = text;
            // }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
            //serialPort1.Close();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Estoque Estoque = new Estoque();
            Estoque.Show();
            this.Hide();
            //serialPort1.Close();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string Produto = Regex.Replace(guna2TextBox1.Text.Trim(), @"\s+", "");         

            if (Produto == "123")
            {
                
                guna2GradientButton6.Visible = true;
                guna2NumericUpDown1.Visible = true;
                guna2Button1.Visible = true;

            }   
            else
            {
                guna2GradientButton6.Visible = false;
                guna2NumericUpDown1.Visible = false;
                guna2Button1.Visible = false;

            }


            if (Produto == "111")
            {
                Point Carne = new Point(50, 97);
                Point BoxC = new Point(196, 99);
                Point btn = new Point(196, 140);

                guna2GradientButton7.Location = Carne;
                guna2NumericUpDown2.Location = BoxC;
                guna2Button2.Location = btn;
                guna2GradientButton7.Visible = true;
                guna2NumericUpDown2.Visible = true;
                guna2Button2.Visible = true;

            }
            else
            {
                guna2GradientButton7.Visible = false;
                guna2NumericUpDown2.Visible = false;
                guna2Button2.Visible = false;
            }


            if (Produto == "222")
            {
                Point Leite = new Point(50, 97);
                Point BoxL = new Point(196, 99);
                Point btn2 = new Point(196, 140);

                guna2GradientButton8.Location = Leite;
                guna2NumericUpDown3.Location = BoxL;
                guna2Button3.Location = btn2;
                guna2GradientButton8.Visible = true;
                guna2NumericUpDown3.Visible = true;
                guna2Button3.Visible = true;
            }
            else
            {
                guna2GradientButton8.Visible = false;
                guna2NumericUpDown3.Visible = false;
                guna2Button3.Visible = false;
            }
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            Cadastro Cadastro = new Cadastro();
            Cadastro.Show();
            this.Hide();
            //serialPort1.Close();

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
            //serialPort1.Close();

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Dashboard Dashboard = new Dashboard();
            Dashboard.Show();
            this.Hide();
            //serialPort1.Close();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            pao();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            carne();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            leite();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        public void pao()
        {
            int quantidadeParaSubtrair = (int)guna2NumericUpDown1.Value;
            string nome = "Pao PANCO 500g";

            string querySelect = "SELECT Quantidade, Preco_Unitario FROM Produtos WHERE descricao = @descricao"; // Consulta para obter a quantidade atual e preço
            string queryUpdate = "UPDATE Produtos SET Quantidade = @NovaQuantidade WHERE descricao = @descricao";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Recuperar a quantidade e preço atual do banco de dados
                    SqlCommand commandSelect = new SqlCommand(querySelect, connection);
                    commandSelect.Parameters.AddWithValue("@descricao", nome);

                    // Executar a consulta e obter a quantidade atual e preço
                    using (SqlDataReader reader = commandSelect.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int quantidadeAtual = reader.GetInt32(reader.GetOrdinal("Quantidade"));
                            decimal precoUnitario = reader.GetDecimal(reader.GetOrdinal("Preco_Unitario"));

                            // Subtrair a quantidade inserida pelo usuário
                            int novaQuantidade = quantidadeAtual - quantidadeParaSubtrair;

                            // Verificar se a nova quantidade não é negativa
                            if (novaQuantidade < 0)
                            {
                                MessageBox.Show("Erro: a quantidade resultante não pode ser negativa.");
                                return;
                            }

                            // Atualizar a quantidade no banco de dados
                            reader.Close();
                            SqlCommand commandUpdate = new SqlCommand(queryUpdate, connection);
                            commandUpdate.Parameters.AddWithValue("@NovaQuantidade", novaQuantidade);
                            commandUpdate.Parameters.AddWithValue("@descricao", nome);
                            int updateResult = commandUpdate.ExecuteNonQuery();

                            if (updateResult > 0)
                            {
                                MessageBox.Show("Quantidade do produto atualizada com sucesso.");
                                AdicionarProdutoNaListBox(nome, precoUnitario, quantidadeParaSubtrair);
                                AtualizarSoma();
                            }
                            else
                            {
                                MessageBox.Show("Erro ao atualizar a quantidade do produto.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Erro: Produto não encontrado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void AdicionarProdutoNaListBox(string nome, decimal preco, int quantidade)
        {
            for (int i = 0; i < quantidade; i++)
            {
                string item = $"{nome} - R$ {preco:F2}";
                listBox1.Items.Add(item);
            }
        }

        public void carne()
        {
            int quantidadeParaSubtrair = (int)guna2NumericUpDown1.Value;
            string nome = "alcatra 1kg";

            string querySelect = "SELECT Quantidade, Preco_Unitario FROM Produtos WHERE descricao = @descricao"; // Consulta para obter a quantidade atual e preço
            string queryUpdate = "UPDATE Produtos SET Quantidade = @NovaQuantidade WHERE descricao = @descricao";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Recuperar a quantidade e preço atual do banco de dados
                    SqlCommand commandSelect = new SqlCommand(querySelect, connection);
                    commandSelect.Parameters.AddWithValue("@descricao", nome);

                    // Executar a consulta e obter a quantidade atual e preço
                    using (SqlDataReader reader = commandSelect.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int quantidadeAtual = reader.GetInt32(reader.GetOrdinal("Quantidade"));
                            decimal precoUnitario = reader.GetDecimal(reader.GetOrdinal("Preco_Unitario"));

                            // Subtrair a quantidade inserida pelo usuário
                            int novaQuantidade = quantidadeAtual - quantidadeParaSubtrair;

                            // Verificar se a nova quantidade não é negativa
                            if (novaQuantidade < 0)
                            {
                                MessageBox.Show("Erro: a quantidade resultante não pode ser negativa.");
                                return;
                            }

                            // Atualizar a quantidade no banco de dados
                            reader.Close();
                            SqlCommand commandUpdate = new SqlCommand(queryUpdate, connection);
                            commandUpdate.Parameters.AddWithValue("@NovaQuantidade", novaQuantidade);
                            commandUpdate.Parameters.AddWithValue("@descricao", nome);
                            int updateResult = commandUpdate.ExecuteNonQuery();

                            if (updateResult > 0)
                            {
                                MessageBox.Show("Quantidade do produto atualizada com sucesso.");
                                AdicionarProdutoNaListBox(nome, precoUnitario, quantidadeParaSubtrair);
                                AtualizarSoma();
                            }
                            else
                            {
                                MessageBox.Show("Erro ao atualizar a quantidade do produto.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Erro: Produto não encontrado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        public void leite()
        {
            int quantidadeParaSubtrair = (int)guna2NumericUpDown1.Value;
            string nome = "Leite TIROL 1LT";

            string querySelect = "SELECT Quantidade, Preco_Unitario FROM Produtos WHERE descricao = @descricao"; // Consulta para obter a quantidade atual e preço
            string queryUpdate = "UPDATE Produtos SET Quantidade = @NovaQuantidade WHERE descricao = @descricao";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Recuperar a quantidade e preço atual do banco de dados
                    SqlCommand commandSelect = new SqlCommand(querySelect, connection);
                    commandSelect.Parameters.AddWithValue("@descricao", nome);

                    // Executar a consulta e obter a quantidade atual e preço
                    using (SqlDataReader reader = commandSelect.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int quantidadeAtual = reader.GetInt32(reader.GetOrdinal("Quantidade"));
                            decimal precoUnitario = reader.GetDecimal(reader.GetOrdinal("Preco_Unitario"));

                            // Subtrair a quantidade inserida pelo usuário
                            int novaQuantidade = quantidadeAtual - quantidadeParaSubtrair;

                            // Verificar se a nova quantidade não é negativa
                            if (novaQuantidade < 0)
                            {
                                MessageBox.Show("Erro: a quantidade resultante não pode ser negativa.");
                                return;
                            }

                            // Atualizar a quantidade no banco de dados
                            reader.Close();
                            SqlCommand commandUpdate = new SqlCommand(queryUpdate, connection);
                            commandUpdate.Parameters.AddWithValue("@NovaQuantidade", novaQuantidade);
                            commandUpdate.Parameters.AddWithValue("@descricao", nome);
                            int updateResult = commandUpdate.ExecuteNonQuery();

                            if (updateResult > 0)
                            {
                                MessageBox.Show("Quantidade do produto atualizada com sucesso.");
                                AdicionarProdutoNaListBox(nome, precoUnitario, quantidadeParaSubtrair);
                                AtualizarSoma();
                            }
                            else
                            {
                                MessageBox.Show("Erro ao atualizar a quantidade do produto.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Erro: Produto não encontrado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void AtualizarSoma()
        {
            decimal total = 0;

            foreach (var item in listBox1.Items)
            {
                string itemString = item.ToString();
                int precoIndex = itemString.LastIndexOf("R$") + 2;
                string precoString = itemString.Substring(precoIndex).Trim();

                if (decimal.TryParse(precoString, out decimal preco))
                {
                    total += preco;
                }
            }

            label2.Text = $"R$ {total:F2}";
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarSoma();
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            qrcode qrcode = new qrcode();
            qrcode.Show();
            //serialPort1.Close();
        }
    }
}
