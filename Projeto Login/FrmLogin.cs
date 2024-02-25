using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace LoginCharpBDFolhaDePag
{
    public partial class FrmLogin : Form
    {
        SqlConnection Conexao = new SqlConnection(@"Data Source=CARLOS\SQLEXPRESS;Initial Catalog=LoginCharp;Integrated Security=True");
        public FrmLogin()
        {
            InitializeComponent();
            txtUsuario.Select();
           
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        { //Abre a conexao
            Conexao.Open();
            
            string query = "SELECT * FROM Usuario WHERE Username ='"+txtUsuario.Text+"'AND Password ='"+txtPassword.Text+"'";
            SqlDataAdapter dp = new SqlDataAdapter(query,Conexao);
            DataTable dt = new DataTable();
            dp.Fill(dt);

            
            if (dt.Rows.Count == 1)
            {
                FrmPrincipal Principal = new FrmPrincipal();
                this.Hide();
                Principal.Show();
                Conexao.Close();
            }

            else
            {    
                MessageBox.Show("Usuário ou Password Incorretas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            txtUsuario.Text = "";
            txtPassword.Text = "";
            txtUsuario.Select();
            
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Salva a posição do cursor
            int cursorPosition = txtPassword.SelectionStart;

            // Alterna entre mostrar a senha como texto normal e exibir asteriscos
            txtPassword.PasswordChar = (txtPassword.PasswordChar == '\0') ? '*' : '\0';

            // Restaura a posição do cursor
            txtPassword.SelectionStart = cursorPosition;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
