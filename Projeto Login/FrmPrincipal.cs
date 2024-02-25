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
using System.Diagnostics;
using LoginCharpBDFolhaDePag.Resources;
namespace LoginCharpBDFolhaDePag
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()

        {
            InitializeComponent();

            
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            FrmLogin Login = new FrmLogin();
           
            this.Hide();
            Login.Show();
        }

        private void btnERP_Click(object sender, EventArgs e)
     
        {
            

           // Substitua pela ação correta do seu aplicativo ASP.NET Core

            try
            {
                FrmSeuPrograma cod = new FrmSeuPrograma();
                cod.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao abrir o aplicativo : {ex.Message}");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
