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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace VisualTCC_Prévia
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=AMI;Initial Catalog=Super_Mercado;User ID=sa;Password=98082450j";

        public Form1()
        {
            InitializeComponent();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string username = guna2TextBox1.Text;
            string password = guna2TextBox2.Text;

            // Verificando se os campos estão preenchidos
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Autenticando o usuário
            if (AuthenticateUser(username, password))
            {
                Menu Menu = new Menu();
                Menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nome de usuário ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool AuthenticateUser(string username, string password)
        {
            bool isAuthenticated = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                    connection.Open();
                    string query = "SELECT COUNT(1) FROM funcionarios WHERE id_funcionario=@id_funcionario AND senha=@senha";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id_funcionario", username);
                    cmd.Parameters.AddWithValue("@senha", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count == 1)
                    {
                        isAuthenticated = true;
                    }
            }

            return isAuthenticated;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
            
}
    
