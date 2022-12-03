using System.Data;

namespace VoorraadBeheer
{
    public partial class inloggen : Form
    {
        functies con;
        public inloggen()
        {
            InitializeComponent();
            con = new functies();
        }

        public static int UserId;
        public static string UserName;

        private void inloggenbtn_Click(object sender, EventArgs e)
        {
            if (usernametb.Text == "" || passwordtb.Text == "")
            {
                MessageBox.Show("Alle gegevens intypen!!");
            }
            else if (usernametb.Text == "Admin" && passwordtb.Text == "Admin")
            {
                Verkoper obj = new Verkoper();
                obj.Show();
                this.Hide();
            }
            else 
            {
                string Req = "select * from verkoper_tbl where verkoper-username = '{0}' and verkoper_passw = '{1}'";
                Req = string.Format(Req, usernametb.Text, passwordtb.Text);
                DataTable dt = con.gegevensopnemen(Req);
                if(dt.Rows.Count == 0)
                {
                    MessageBox.Show("Verkoper Bestaat niet");
                }
                else
                {
                    Verkoper obj = new Verkoper();
                    obj.Show();
                    this.Hide();
                }
            }

        }
    }
}