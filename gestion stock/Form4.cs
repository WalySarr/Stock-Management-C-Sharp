using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        SqlConnection bd = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=stOck;Integrated Security=True;Connection timeout=0");
        int i = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (txtmdp.Text == "MamishMouha")
            {
                MDIParent1 form4 = new MDIParent1();
                form4.Show();
                this.Hide();

            }
            else {
                MessageBox.Show("Mot de Passe incorect","Gestion de Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (i == 2) {
                MessageBox.Show("Désolé! Nombre d'essais atteints maximum atteint", "Accès de Gestion de stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            i++;
        }
    }
}
