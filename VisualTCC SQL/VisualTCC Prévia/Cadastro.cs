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

    
    public partial class Cadastro : Form
    {
        string connectionString = "Data Source=AMI;Initial Catalog=Super_Mercado;User ID=sa;Password=98082450j";

        public Cadastro()
        {
            InitializeComponent();
            // configura o combobox
            guna2ComboBox1.Items.Clear();
            guna2ComboBox1.Items.Add("CAIXA 1");
            guna2ComboBox1.Items.Add("CAIXA 2");
            guna2ComboBox1.Items.Add("CAIXA 3");
            guna2ComboBox1.Items.Add("CAIXA 4");
            guna2ComboBox1.Items.Add("Estoquista");
            guna2ComboBox1.Items.Add("Administrador");
            guna2ComboBox1.Items.Add("Financeiro");


            // desabilita o botão inicialmente
            guna2GradientButton3.Enabled = true;

            // Define o comprimento máximo dos campos de texto
            guna2TextBox1.MaxLength = 50; // Caracteres maximos
            guna2TextBox3.MaxLength = 11; // Número de telefone (11 dígitos)
            guna2TextBox4.MaxLength = 11; // CPF (11 dígitos)
            guna2TextBox2.MaxLength = 50;  // CIDADE
            guna2TextBox7.MaxLength = 10; // senha
            guna2TextBox9.MaxLength = 50; // bairro
            guna2TextBox5.MaxLength = 50; // rua
            guna2TextBox8.MaxLength = 5; // Numero

            // Associa os eventos KeyPress para permitir apenas números
            guna2TextBox3.KeyPress += new KeyPressEventHandler(guna2TextBox_KeyPress);
            guna2TextBox4.KeyPress += new KeyPressEventHandler(guna2TextBox_KeyPress);
            guna2TextBox8.KeyPress += new KeyPressEventHandler(guna2TextBox_KeyPress);

            // Associa o evento TextChanged ao CPF para validar enquanto o usuário digita
            guna2TextBox4.TextChanged += new EventHandler(guna2TextBox4_TextChanged);
            // Associa o evento SelectedIndexChanged da ComboBox
            guna2ComboBox1.SelectedIndexChanged += new EventHandler(guna2ComboBox1_SelectedIndexChanged);

        }
        private void guna2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e teclas de controle (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela o evento se o caractere não for um número
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
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

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            Dashboard Dashboard = new Dashboard();
            Dashboard.Show();
            this.Hide();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {

            string cargo = guna2ComboBox1.SelectedItem?.ToString().Trim();
            string nome = guna2TextBox1.Text.Trim();
            string senha = guna2TextBox7.Text.Trim();
            string telefone = guna2TextBox3.Text.Trim();
            string cpf = guna2TextBox4.Text.Trim();
            string cidade = guna2TextBox2.Text.Trim();
            string bairro = guna2TextBox9.Text.Trim();
            string rua = guna2TextBox5.Text.Trim();
            string numero = guna2TextBox8.Text.Trim();

            if (string.IsNullOrWhiteSpace(cargo) || string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(senha) ||
                string.IsNullOrWhiteSpace(telefone) || string.IsNullOrWhiteSpace(cpf) || string.IsNullOrWhiteSpace(cidade) ||
                string.IsNullOrWhiteSpace(bairro) || string.IsNullOrWhiteSpace(rua) || string.IsNullOrWhiteSpace(numero))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return;
            }

            string ConexaoBanco = "Server=AMI;Database=Super_Mercado;User Id=gula;Password=senai;";

            // Verificação de CPF duplicado
            // INICIO DA VERIFICAÇÃO DE CPF
            using (SqlConnection conexaosql = new SqlConnection(ConexaoBanco))
            {
                try
                {
                    conexaosql.Open(); // Abre a conexão com o banco de dados
                    string verificarCpf = "SELECT COUNT(*) FROM funcionarios WHERE CPF = @CPF"; // Consulta para verificar duplicidade de CPF
                    SqlCommand checkCommand = new SqlCommand(verificarCpf, conexaosql); // Cria um comando SQL
                    checkCommand.Parameters.AddWithValue("@CPF", cpf); // Adiciona o parâmetro CPF

                    int cpfExistente = (int)checkCommand.ExecuteScalar(); // Executa a consulta e retorna o número de registros encontrados

                    if (cpfExistente > 0)
                    {
                        MessageBox.Show("CPF já cadastrado!"); // Exibe uma mensagem se o CPF já estiver cadastrado
                    }
                    else
                    {
                        // Consulta para inserir os dados no banco de dados
                        string PrintInformacao = "INSERT INTO funcionarios (nome, cargo, telefone,CPF,cidade,rua,senha,bairro,numero) VALUES (@Nome, @Cargo, @Telefone, @CPF, @rua, @cidade,@senha,@bairro,@numero)";
                        SqlCommand command = new SqlCommand(PrintInformacao, conexaosql); // Cria um comando SQL para inserção
                        command.Parameters.AddWithValue("@Nome", nome); // Adiciona o parâmetro Nome
                        command.Parameters.AddWithValue("@Cargo", cargo); // Adiciona o parâmetro Cargo
                        command.Parameters.AddWithValue("@Telefone", telefone); // Adiciona o parâmetro Telefone
                        command.Parameters.AddWithValue("@CPF", cpf); // Adiciona o parâmetro CPF
                        command.Parameters.AddWithValue("@rua", rua); // Adiciona o parâmetro Endereço
                        command.Parameters.AddWithValue("@cidade", cidade); // Adiciona o parâmetro Cidade
                        command.Parameters.AddWithValue("@senha", senha); // Adiciona o parâmetro Senha
                        command.Parameters.AddWithValue("@bairro", bairro); // Adiciona o parâmetro bairro
                        command.Parameters.AddWithValue("@numero", numero); // Adiciona o parâmetro numero
                        command.ExecuteNonQuery(); // Executa o comando de inserção
                        MessageBox.Show("Dados inseridos com sucesso!"); // Exibe uma mensagem de sucesso
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir os dados: " + ex.Message); // Exibe uma mensagem de erro
                }
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarSelecaoComboBox();
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
            VerificarCpf();
        }

        private void VerificarCpf()
        {
            string cpf = guna2TextBox4.Text; // Captura o CPF do campo de texto

            if (string.IsNullOrEmpty(cpf) || cpf.Length != 11)
            {
                guna2GradientButton3.Enabled = false; // Desabilita o botão se o CPF estiver vazio ou não tiver 11 dígitos
                return;
            }

            // Conecta com o banco de dados
            string connectionString = "Data Source=AMI;Initial Catalog=Super_Mercado;User ID=gula;Password=senai";

            // Verificação de CPF duplicado
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open(); // Abre a conexão com o banco de dados
                    string verificarCpf = "SELECT COUNT(*) FROM funcionarios WHERE CPF = @CPF"; // Consulta para verificar duplicidade de CPF
                    SqlCommand checkCommand = new SqlCommand(verificarCpf, connection); // Cria um comando SQL
                    checkCommand.Parameters.AddWithValue("@CPF", cpf); // Adiciona o parâmetro CPF

                    int cpfExistente = (int)checkCommand.ExecuteScalar(); // Executa a consulta e retorna o número de registros encontrados

                    if (cpfExistente > 0)
                    {
                        MessageBox.Show("CPF já cadastrado!"); // Exibe uma mensagem se o CPF já estiver cadastrado
                        guna2GradientButton3.Enabled = false; // Desabilita o botão se o CPF já estiver cadastrado
                    }
                    else
                    {
                        VerificarHabilitacaoBotao(); // Verifica se o botão pode ser habilitado
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao verificar o CPF: " + ex.Message); // Exibe uma mensagem de erro
                    guna2GradientButton3.Enabled = false; // Desabilita o botão em caso de erro
                }
            }
        }
        // Verifica se a seleção da combobox é válida
        private void VerificarSelecaoComboBox()
        {
            if (guna2ComboBox1.SelectedIndex == -1)
            {
                guna2GradientButton3.Enabled = false; // Desabilita o botão se nada estiver selecionado
            }
            else
            {
                VerificarHabilitacaoBotao(); // Verifica se o botão pode ser habilitado
            }
        }

        // Verifica se o botão pode ser habilitado
        private void VerificarHabilitacaoBotao()
        {
            if (!string.IsNullOrEmpty(guna2TextBox4.Text) && guna2TextBox4.Text.Length == 11 && guna2ComboBox1.SelectedIndex != -1)
            {
                guna2GradientButton3.Enabled = true; // Habilita o botão se todas as condições forem atendidas
            }
            else
            {
                guna2GradientButton3.Enabled = false; // Desabilita o botão se alguma condição não for atendida
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show();
            this.Hide();
        }

        private void guna2TextBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            permissoes permissoes = new permissoes();
            permissoes.Show();
            this.Hide();
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            atualizarFuncionario();
        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {
            int id_funcionario;
            if (!int.TryParse(txtid.Text, out id_funcionario))
            {
                // Limpar os campos se o ID não for um número válido
                LimparCampos();
                return;
            }

            // Consulta SQL para buscar as informações do funcionário pelo ID
            string query = "SELECT cargo, nome, senha, telefone, CPF, cidade, bairro, rua, numero FROM funcionarios WHERE id_funcionario = @id_funcionario";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id_funcionario", id_funcionario);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read()) // Se encontrou o funcionário com o ID especificado
                    {
                        // Preencher os campos com as informações do funcionário
                        guna2ComboBox1.SelectedItem = guna2ComboBox1.Items.Cast<dynamic>().FirstOrDefault(item => item.ToString() == reader["cargo"].ToString());
                        guna2TextBox1.Text = reader["nome"].ToString(); //nome
                        guna2TextBox7.Text = reader["senha"].ToString(); //senha
                        guna2TextBox2.Text = reader["cidade"].ToString(); //cidade
                        guna2TextBox9.Text = reader["bairro"].ToString(); //bairro
                        guna2TextBox5.Text = reader["rua"].ToString(); //rua
                        guna2TextBox3.Text = reader["telefone"].ToString(); //telefone
                        guna2TextBox4.Text = reader["CPF"].ToString(); //CPF
                        guna2TextBox8.Text = reader["numero"].ToString(); //numero
                    }
                    else
                    {
                        // Se não encontrou o funcionário, limpar os campos
                        LimparCampos();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar informações do funcionário: " + ex.Message);
                }
            }
        }

        public void atualizarFuncionario()
        {
            // Verifica se o campo de ID do funcionário é um número válido
            int id_funcionario;
            if (!int.TryParse(txtid.Text, out id_funcionario))
            {
                MessageBox.Show("ID do Funcionário inválido.");
                return;
            }

            // Verifica se os campos obrigatórios não estão vazios
            string cargo = guna2ComboBox1.SelectedItem?.ToString().Trim();
            string nome = guna2TextBox1.Text.Trim();
            string senha = guna2TextBox7.Text.Trim();
            string telefone = guna2TextBox3.Text.Trim();
            string cpf = guna2TextBox4.Text.Trim();
            string cidade = guna2TextBox2.Text.Trim();
            string bairro = guna2TextBox9.Text.Trim();
            string rua = guna2TextBox5.Text.Trim();
            string numero = guna2TextBox8.Text.Trim();

            if (string.IsNullOrWhiteSpace(cargo) || string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(senha) ||
                string.IsNullOrWhiteSpace(telefone) || string.IsNullOrWhiteSpace(cpf) || string.IsNullOrWhiteSpace(cidade) ||
                string.IsNullOrWhiteSpace(bairro) || string.IsNullOrWhiteSpace(rua) || string.IsNullOrWhiteSpace(numero))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return;
            }

            // Query SQL para atualizar os dados do funcionário
            string query = "UPDATE funcionarios SET cargo = @cargo, nome = @nome, telefone = @telefone, senha = @senha, CPF = @CPF, cidade = @cidade, bairro = @bairro, rua = @rua, numero = @numero WHERE id_funcionario = @id_funcionario";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@cargo", cargo);
                command.Parameters.AddWithValue("@nome", nome);
                command.Parameters.AddWithValue("@telefone", telefone);
                command.Parameters.AddWithValue("@senha", senha);
                command.Parameters.AddWithValue("@CPF", cpf);
                command.Parameters.AddWithValue("@cidade", cidade);
                command.Parameters.AddWithValue("@bairro", bairro);
                command.Parameters.AddWithValue("@rua", rua);
                command.Parameters.AddWithValue("@numero", numero);
                command.Parameters.AddWithValue("@id_funcionario", id_funcionario);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Funcionário atualizado com sucesso.");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar o funcionário.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }


        private void LimparCampos()
        {
            txtid.Text = string.Empty; //id
            guna2ComboBox1.SelectedItem = null; // cargo
            guna2TextBox1.Text = string.Empty; //nome
            guna2TextBox7.Text = string.Empty; //senha
            guna2TextBox2.Text = string.Empty; // cidade
            guna2TextBox9.Text = string.Empty; //bairro
            guna2TextBox5.Text = string.Empty; //rua
            guna2TextBox3.Text = string.Empty; //telefone
            guna2TextBox4.Text = string.Empty; //CPF
            guna2TextBox8.Text = string.Empty; //numero
        }       

    }
}
