using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;
using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;

using MySql.Data.MySqlClient;



namespace Sistema_gestao_estudantes

{

    public partial class Login_Form : Form

    {

        public Login_Form()

        {

            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)

        {

            pictureBox1.Image = Image.FromFile("../../Imagens/user.png");

        }



        private void label2_Click(object sender, EventArgs e)

        {



        }



        private void textBox1_TextChanged(object sender, EventArgs e)

        {



        }



        private void label1_Click(object sender, EventArgs e)

        {



        }



        private void btnCancelar_Click(object sender, EventArgs e)

        {

            Close();

        }




        private void btnentrar_Click_1(object sender, EventArgs e)
        {
            MEU_BD bancoDeDados = new MEU_BD();
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            DataTable tabela = new DataTable();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM `usuario` WHERE `username` = @usn and `password` = @psd", bancoDeDados.getConexao);
            comando.Parameters.Add("@usn", MySqlDbType.VarChar).Value = txtusuario.Text;

            comando.Parameters.Add("@psd", MySqlDbType.VarChar).Value = txtsenha.Text;



            adaptador.SelectCommand = comando;

            adaptador.Fill(tabela);



            if (tabela.Rows.Count > 0)

            {

                MessageBox.Show("SIM");

            }

            else

            {

                MessageBox.Show("NÃO");

            }
        }

        private void btncancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }

}






