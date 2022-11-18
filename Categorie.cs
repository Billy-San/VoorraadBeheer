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
    public partial class Categorie : Form
    {
        functies con;

        public Categorie()
        {
            InitializeComponent();
            con = new functies();
            ListerCategories();

        }
        private void ListerCategories()
        {
            string Req = "Select * from Categorie_tbl";
            categorieLijst.DataSource = con.gegevensopnemen(Req);
        }
        private void inlog_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if(naamTB.Text == "" || OpmerkingTB.Text == "")
                {
                    MessageBox.Show("Alle gegevens invullen aub!");
                }
                else
                {
                    string Naam = naamTB.Text;
                    string Opmer = OpmerkingTB.Text;
                    string Req = "insert into Categorie_tbl values ('{0}','{1}')";
                    Req = string.Format(Req, Naam, Opmer);
                    con.stuurgegevens(Req);
                    ListerCategories();
                    MessageBox.Show("Categorie bijgevoegd !");
                    naamTB.Text = "";
                    OpmerkingTB.Text = "";
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        int Key = 0;
        private void categorieLijst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            naamTB.Text = categorieLijst.SelectedRows[0].Cells[1].Value.ToString();
            OpmerkingTB.Text = categorieLijst.SelectedRows[0].Cells[2].Value.ToString();
            if (naamTB.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(categorieLijst.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void bewerkenbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (naamTB.Text == "" || OpmerkingTB.Text == "")
                {
                    MessageBox.Show("Alle gegevens invullen aub!");
                }
                else
                {
                    string Naam = naamTB.Text;
                    string Opmer = OpmerkingTB.Text;
                    string Req = "Update into Categorie_tbl set Cat_naam = '{0}',Cat_opmerking = '{1}' where id_categorie = {2}";
                    Req = string.Format(Req, Naam, Opmer, Key);
                    con.stuurgegevens(Req);
                    ListerCategories();
                    MessageBox.Show("Categorie aangepast !");
                    naamTB.Text = "";
                    OpmerkingTB.Text = "";
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void verwijderenbtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (naamTB.Text == "" || OpmerkingTB.Text == "")
                {
                    MessageBox.Show("Alle gegevens invullen aub!");
                }
                else
                {
                    string Naam = naamTB.Text;
                    string Opmer = OpmerkingTB.Text;
                    string Req = "delete from Categorie_tbl where id_categorie = {0}";
                    Req = string.Format(Req, Key);
                    con.stuurgegevens(Req);
                    ListerCategories();
                    MessageBox.Show("Categorie verwijderd !");
                    naamTB.Text = "";
                    OpmerkingTB.Text = "";
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }
    }
}
