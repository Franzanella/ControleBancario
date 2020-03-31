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
using MySql.Data.MySqlClient;

namespace ControleBancario_Franciele_04981
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;user id=root;password=root;persistsecurityinfo=True;database=dbbanco");
            MySqlCommand inclui = new MySqlCommand("insert into tb_movimenta values('" + txt_data.Text + "','" + txt_historico.Text + "','" + txt_lancamento.Text + "','" + txt_cd.Text + "');", conexao);
            int linhas = 0;
            conexao.Open();
        }

        private void txt_historico_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_data.Clear();
            txt_historico.Clear();
            txt_lancamento.Clear();
            txt_cd.Clear();
            txt_valor.Clear();
            txt_saldo.Clear();
        }
    }
}
