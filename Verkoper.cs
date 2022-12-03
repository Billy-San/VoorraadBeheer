using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoorraadBeheer
{
    public partial class Verkoper : Form
    {
        functies con;
        public Verkoper()
        {
            InitializeComponent();
            con = new functies();
            ListerVerkoper();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Categorie form = new Categorie();
            form.Show(); 
        }

        private void ListerVerkoper()
        {
            string Req = "Select * from verkoper_tbl";
            VerkoperList.DataSource = con.gegevensopnemen(Req);
        }
        private void Bewaren_Verkoper_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (naamTB.Text == "" || Pseudo_tb.Text == "" || WachtWoordtb.Text == "")
                {
                    MessageBox.Show("Alle gegevens invullen aub!");
                }
                else
                {
                    string Naam = naamTB.Text;
                    string Pseudo = Pseudo_tb.Text;
                    string Wachtwoord = WachtWoordtb.Text;
                    
                    string Req = "insert into verkoper_tbl values ('{0}','{1}','{2}','{3}')";
                    Req = string.Format(Req, Naam, Pseudo, Wachtwoord);
                    con.stuurgegevens(Req);
                    ListerVerkoper();
                    MessageBox.Show("Verkoper bijgevoegd !");
                    naamTB.Text = "";
                    Pseudo_tb.Text = "";
                    WachtWoordtb.Text = "";
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        int Key = 0;
        private void VerkoperList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            naamTB.Text = VerkoperList.SelectedRows[0].Cells[1].Value.ToString();
            Pseudo_tb.Text = VerkoperList.SelectedRows[0].Cells[2].Value.ToString();
            WachtWoordtb.Text = VerkoperList.SelectedRows[0].Cells[3].Value.ToString();

            if (naamTB.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(VerkoperList.SelectedRows[0].Cells[0].Value.ToString());
            }
            if (naamTB.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(VerkoperList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Verwijderen_Verkoper_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show("Select een verkoper");
                }
                else
                {
                    string Naam = naamTB.Text;
                    string Pseudo = Pseudo_tb.Text;
                    string Wachtwoord = WachtWoordtb.Text;

                    string Req = "delete from verkoper_tbl where Id_Verkoper = {0})";
                    Req = string.Format(Req, Key);
                    con.stuurgegevens(Req);
                    ListerVerkoper();
                    MessageBox.Show("Verkoper verwijderd !");
                    naamTB.Text = "";
                    Pseudo_tb.Text = "";
                    WachtWoordtb.Text = "";
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void Bewerken_Verkoper_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (naamTB.Text == "" || Pseudo_tb.Text == "" || WachtWoordtb.Text == "")
                {
                    MessageBox.Show("Alle gegevens invullen aub!");
                }
                else
                {
                    string Naam = naamTB.Text;
                    string Pseudo = Pseudo_tb.Text;
                    string Wachtwoord = WachtWoordtb.Text;

                    string Req = "update verkoper_tbl set Verkoper_naam = '{0}',verkoper_username = '{1}',verkoper_passw = '{2}'where Id_Verkoper = '{3}'";
                    Req = string.Format(Req, Naam, Pseudo, Wachtwoord, Key);
                    con.stuurgegevens(Req);
                    ListerVerkoper();
                    MessageBox.Show("Verkoper bijgevoegd !");
                    naamTB.Text = "";
                    Pseudo_tb.Text = "";
                    WachtWoordtb.Text = "";
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void uitloggenbtn_Click(object sender, EventArgs e)
        {
            inloggen obj = new inloggen();
            obj.Show();
            this.Hide();
        }
    }
}
