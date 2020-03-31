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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja sair?", "Controle Bancario",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            == DialogResult.Yes)
            {
                if (Application.OpenForms.OfType<Form2>().Count() > 0)
                {
                    Form home = Application.OpenForms["Form2"];
                    home.Show();
                    this.Hide();
                }
                else
                {

                    Form2 home = new Form2();
                    home.Show();
                    this.Hide();
                }
            }

        }
    }
}
