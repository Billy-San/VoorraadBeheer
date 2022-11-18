using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoorraadBeheer
{
    public partial class PrijsTb : Form
    {
        functies con;
        public PrijsTb()
        {
            InitializeComponent();
            con = new functies();
            Listerproduct();
            CategorieBijvullen();  
        }
        private void Listerproduct()
        {
            string Req = "Select * from Product_tbl";
            ProductLijst.DataSource = con.gegevensopnemen(Req);
        }
        private void Filter()
        {
            string Req = "Select * from Product_tbl where Product_Categorie = {0}";
            int Cat = Convert.ToInt32(FiltreCb.SelectedValue.ToString());
            Req = string.Format(Req, Cat);
            ProductLijst.DataSource = con.gegevensopnemen(Req);
        }
        private void CategorieBijvullen()
        {
            string Req = "select * from Categorie_tbl";
            CatCb.DisplayMember = con.gegevensopnemen(Req).Columns["Cat_naam"].ToString();
            CatCb.ValueMember = con.gegevensopnemen(Req).Columns["id_categorie"].ToString();
            CatCb.DataSource = con.gegevensopnemen(Req);

            FiltreCb.DisplayMember = con.gegevensopnemen(Req).Columns["Cat_naam"].ToString();
            FiltreCb.ValueMember = con.gegevensopnemen(Req).Columns["id_categorie"].ToString();
            FiltreCb.DataSource = con.gegevensopnemen(Req);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bewarenbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (naamTB.Text == "" || PrixTb.Text == "" || CatCb.SelectedIndex == -1 || AantalTb.Text == "")
                {
                    MessageBox.Show("Alle gegevens invullen aub!");
                }
                else
                {
                    string Naam = naamTB.Text;
                    int prijs = Convert.ToInt32(PrixTb.Text);
                    int categorie =Convert.ToInt32(CatCb.SelectedValue.ToString());

                    int aantal = Convert.ToInt32(AantalTb.Text);
                    string Req = "insert into Product_tbl values ('{0}',{1},{2},{3},'{4}')";
                    Req = string.Format(Req, Naam, prijs, categorie, aantal);
                    con.stuurgegevens(Req);
                    Listerproduct();
                    MessageBox.Show("Product bijgevoegd !");
                    naamTB.Text = "";
                    PrixTb.Text = "";
                    AantalTb.Text = "";
                    CatCb.SelectedIndex= -1;
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        int Key = 0;
        private void ProductLijst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            naamTB.Text = ProductLijst.SelectedRows[0].Cells[1].Value.ToString();
            PrixTb.Text = ProductLijst.SelectedRows[0].Cells[2].Value.ToString();
            CatCb.Text = ProductLijst.SelectedRows[0].Cells[3].Value.ToString();
            AantalTb.Text = ProductLijst.SelectedRows[1].Cells[4].Value.ToString();

            if (naamTB.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ProductLijst.SelectedRows[0].Cells[0].Value.ToString());
            }
            if (naamTB.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ProductLijst.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Verwijderenbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show("Select een product!");
                }
                else
                {
                    string Naam = naamTB.Text;
                    int prijs = Convert.ToInt32(PrixTb.Text);
                    int categorie = Convert.ToInt32(CatCb.SelectedValue.ToString());

                    int aantal = Convert.ToInt32(AantalTb.Text);
                    string Req = "delete from Product_tbl where id_product = {0}";
                    Req = string.Format(Req, Key);
                    con.stuurgegevens(Req);
                    Listerproduct();
                    MessageBox.Show("Product verwijderd !");
                    naamTB.Text = "";
                    PrixTb.Text = "";
                    AantalTb.Text = "";
                    CatCb.SelectedIndex = -1;
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void Bewerkenbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (naamTB.Text == "" || PrixTb.Text == "" || CatCb.SelectedIndex == -1 || AantalTb.Text == "")
                {
                    MessageBox.Show("Alle gegevens invullen aub!");
                }
                else
                {
                    string Naam = naamTB.Text;
                    int prijs = Convert.ToInt32(PrixTb.Text);
                    int categorie = Convert.ToInt32(CatCb.SelectedValue.ToString());

                    int aantal = Convert.ToInt32(AantalTb.Text);
                    string Req = "update Product_tbl set Product_Naam ='{0}',Product_Prijs = {1}, Product_Categorie = {2}, Product_Aantal = {3}, where id_product = {4}";
                    Req = string.Format(Req, Naam, prijs, categorie, aantal, Key);
                    con.stuurgegevens(Req);
                    Listerproduct();
                    MessageBox.Show("Product gewijzigd !");
                    naamTB.Text = "";
                    PrixTb.Text = "";
                    AantalTb.Text = "";
                    CatCb.SelectedIndex = -1;
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void FiltreCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void Zoekenbtn_Click(object sender, EventArgs e)
        {
            Listerproduct();   
        }
    }
}
