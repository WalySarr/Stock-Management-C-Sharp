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
    public partial class Form1 : Form
    {
        SqlConnection bd = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=stock;Integrated Security=True;Connection timeout=0");
        int npr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bd.Open();
            bd.Close();
            afficher_Click(sender, e);
        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtnp.Text) > 0 && txtl.Text != "" && float.Parse(txtpa.Text) > 0 && float.Parse(txtpv.Text) > float.Parse(txtpa.Text))
            {
                bd.Open();
                //recherche produit si il existe
                SqlCommand cmd1 = new SqlCommand("select * from produits where [n°produit]='" + txtnp.Text + "'", bd);
                SqlDataReader rd = cmd1.ExecuteReader();
                if (rd.HasRows == true)
                {
                    MessageBox.Show("Produit n° " + txtnp.Text + " Existe déja", "Gestion stock", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                // fin de recherche
                else
                {
                    rd.Close();
                    SqlCommand cmd = new SqlCommand("insert into produits values(" + txtnp.Text + ",'" + txtl.Text + "','" + txts.Text + "','" + txtpa.Text + "','" + txtpv.Text + "')", bd);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Enregistrement effectué avec succée", "Gestion stock");
                    Nouveau_Click(sender, e);
                    
                   
                }
                bd.Close();
            }
            else
            {
                MessageBox.Show("Vérifier la saisie svp", "Gestion de stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            afficher_Click(sender, e);
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnp_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                    txtl.Select();
                
                
            }
        }

        private void txtnp_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Nouveau_Click(object sender, EventArgs e)
        {
            txtnp.Text = "0";
            txtl.Clear();
            txts.Text = "0";
            txtpa.Text = "0";
            txtpv.Text = "0";
            Modifier.Enabled = false;
            supprimer.Enabled = false;
            enregistrer.Enabled = true;
            txtnp.Select();
        }

        private void txtl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txts.Select();


            }
        }

        private void txts_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtl_TextChanged(object sender, EventArgs e)
        {

        }

        private void rechercher_Click(object sender, EventArgs e)
        {

            npr = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("N°produit Recherché", "Gestion Stock")); bd.Open();
            SqlCommand cmd = new SqlCommand("select * from produits where [n°produit]='" + npr.ToString() + "'", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows == true)
            {
                rd.Read();
                txtnp.Text = rd.GetValue(0).ToString();
                txtl.Text = rd.GetValue(1).ToString();
                txts.Text = rd.GetValue(2).ToString();
                txtpa.Text = rd.GetValue(3).ToString();
                txtpv.Text = rd.GetValue(4).ToString();
                enregistrer.Enabled = false;
                Modifier.Enabled = true;
                supprimer.Enabled = true;

            }
            else
            {
                MessageBox.Show("N°produit " + npr.ToString() + " N'existe pas", "Gestion Stock");
            }
            bd.Close();

           
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Effectuer la modification", "Gestion stock", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == 
                DialogResult.Yes)
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("update produits set [libelle]='" + txtl.Text + "',[stock]='" + txts.Text + "',[prix achat]='" + txtpa.Text + "',[prix vente]='" + txtpv.Text + "' where [n°produit]='" + npr.ToString() + "'", bd);
                cmd.ExecuteNonQuery();
                bd.Close();
                MessageBox.Show("Modification a été bien effectuée");
                afficher_Click(sender, e);
                Nouveau_Click(sender, e);             


            }
        }

        private void supprimer_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Effectuer la suppression", "Gestion Stock", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                == DialogResult.Yes)
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("delete  produits from produits where [n°produit]='" + npr.ToString() + "'", bd);
                cmd.ExecuteNonQuery();
                bd.Close();
                MessageBox.Show("suupression effectué avec succée", "Gestcom");
                
            }
            afficher_Click(sender, e);
            Nouveau_Click(sender, e);
        }

        private void afficher_Click(object sender, EventArgs e)
        {
            tableau.Rows.Clear();
            bd.Open();
            SqlCommand cmd = new SqlCommand("select * from produit", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tableau.Rows.Add(
                    rd.GetValue(0),
                    rd.GetValue(1),
                    rd.GetValue(2),
                    rd.GetValue(3),
                    rd.GetValue(4)
                    );

            }
            bd.Close();
        }
        }
    

       
    }

