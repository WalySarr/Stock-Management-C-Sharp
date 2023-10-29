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
    public partial class Form3 : Form
    {
        SqlConnection bd = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=stOck;Integrated Security=True;Connection timeout=0");
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txttp.SelectedIndex = 1;
            bd.Open();
            SqlCommand cmd = new SqlCommand("select * from produit", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                txtn.Items.Add(rd.GetValue(0));

            }
            bd.Close();
        }

        private void txtn_SelectedIndexChanged(object sender, EventArgs e)
        {
            bd.Open();
            SqlCommand cmd = new SqlCommand("select * from produits where [n°produit]='" + txtn.Text + "'", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            txtpr.Text = rd.GetValue(1).ToString();
            txts.Text = rd.GetValue(2).ToString();
            bd.Close();
            txtq.Select();
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Nouveau_Click(object sender, EventArgs e)
        {
            txtp.Clear();
            tableau.Rows.Clear();
            txtp.Select();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            if (txtn.Text != "" && int.Parse(txtq.Text) > 0)
            {
                for (int i = 0; i < tableau.Rows.Count - 1; i++)
                {
                    if (tableau.Rows[i].Cells[0].Value.ToString() == txtn.Text)
                    {
                        MessageBox.Show("Produit déja ajouté");
                        return;
                    }

                }

                if (int.Parse(txtq.Text)>int.Parse(txts.Text))
                {
                    MessageBox.Show("Stock insuffisant","Gestion Stock",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    MessageBox.Show("Stock existant est " + txts.Text,"Gestion Stock",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                tableau.Rows.Add(
                    txtn.Text,
                    txtpr.Text,
                    txtq.Text

                    );
                txtn.Text = ""; txtpr.Clear(); txtq.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("Verifier la saisie Svp", "Gestion De Stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            if (txtp.Text != "" && tableau.Rows.Count > 1)
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("insert into sortie values('" + txttp.Text + "','" + txtp.Text + "','" + txtde.Value.ToString() + "')", bd);
                cmd.ExecuteNonQuery();
                SqlCommand cmd1 = new SqlCommand("select top(1) [n°sortie] from [sortie] order by [n°sortie] desc", bd);
                SqlDataReader rd = cmd1.ExecuteReader();
                rd.Read();
                int ne = Convert.ToInt32(rd.GetValue(0));
                rd.Close();

                for (int i = 0; i < tableau.Rows.Count - 1; i++)
                {
                    SqlCommand cmd2 = new SqlCommand("insert into dsortie values(" + ne.ToString() + ",'" +
                        tableau.Rows[i].Cells[0].Value.ToString() + "','" + tableau.Rows[i].Cells[2].Value.ToString() + "')", bd);
                    cmd2.ExecuteNonQuery();

                    SqlCommand cmd3 = new SqlCommand("select * from produits where [n°produit]='" +
                        tableau.Rows[i].Cells[0].Value.ToString() + "'", bd);
                    SqlDataReader rd1 = cmd3.ExecuteReader();
                    rd1.Read();
                    int qs = Convert.ToInt32(rd1.GetValue(2)) - Convert.ToInt32(tableau.Rows[i].Cells[2].Value);
                    rd1.Close();
                    SqlCommand cmd4 = new SqlCommand("update produits set [stock]='" + qs.ToString() + "' where [n°produit]='" +
                        tableau.Rows[i].Cells[0].Value.ToString() + "'", bd);
                    cmd4.ExecuteNonQuery();



                }
                bd.Close();
                MessageBox.Show("enregistrement effectué avec succée", "Gestion stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Nouveau_Click(sender, e);
            }

            else
            {
                MessageBox.Show("Verifier la saisie svp", "Gestion stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
