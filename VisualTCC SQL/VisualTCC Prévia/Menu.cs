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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();            
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
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

        private void guna2GradientButton3_Click_1(object sender, EventArgs e)
        {
            Cadastro Cadastro = new Cadastro();
            Cadastro.Show();
            this.Hide();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            Dashboard Dashboard = new Dashboard();
            Dashboard.Show();
            this.Hide();
        }
    }
}
