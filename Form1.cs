using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;

namespace Exchange_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4CCALSF\SQLEXPRESS01;Initial Catalog=Db_Exchange;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_ExchangeDataSet.Tbl_Monney' table. You can move, or remove it, as needed.
            this.tbl_MonneyTableAdapter.Fill(this.db_ExchangeDataSet.Tbl_Monney);
            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldocu = new XmlDocument();
            xmldocu.Load(today);

            string dolbuy = xmldocu.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lbldollbuy.Text = dolbuy;

            string dolsale = xmldocu.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lbldolsell.Text = dolsale;

            string eurbuy = xmldocu.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lbleurbuy.Text = eurbuy;

            string eursell = xmldocu.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lbleursell.Text = eursell;
        }
        
        private void btndolbuy_Click(object sender, EventArgs e)
        {
            txtrate.Text = lbldollbuy.Text;

        }

        private void btneurbuy_Click(object sender, EventArgs e)
        {
            txtrate.Text = lbleurbuy.Text;
        }

        private void btndolsale_Click(object sender, EventArgs e)
        {
            txtrate.Text = lbldolsell.Text;

        }

        private void btneursell_Click(object sender, EventArgs e)
        {
            txtrate.Text = lbleursell.Text;
        }

        public void btnnsale_Click(object sender, EventArgs e)
        {
            double s1, s2, tut;
            s1 = Convert.ToDouble(txtrate.Text);
            s2 = Convert.ToDouble(txtquant.Text);
            tut = s1 * s2;
            txtamount.Text = tut.ToString();
        }

        private void txtrate_TextChanged(object sender, EventArgs e)
        {
            txtrate.Text = txtrate.Text.Replace(".", ",");
        }
        public string umumi;
        
        private void button1_Click(object sender, EventArgs e)
        {
            
        
        

            double kur = Convert.ToDouble(txtrate.Text);
            int mik = Convert.ToInt32(txtquant.Text);
            int tutt = Convert.ToInt32(mik / kur);
            txtamount.Text = tutt.ToString();
            double qalan;
            qalan= mik % tutt;
            txtremaind.Text = Convert.ToString(qalan);



        }

        private void button1_TextChanged(object sender, EventArgs e)
        {
            txtrate.Text = txtrate.Text.Replace(".", ",");
        }
    }
}
