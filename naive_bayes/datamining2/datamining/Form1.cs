using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace datamining
{
    public partial class Form1 : Form
    {
        koneksi conn = new koneksi();
        Form1 obj = (Form1)Application.OpenForms["dataawal"];
        
        public Form1()
        {
            InitializeComponent();
            fillcombo();
            Showdata2();
            jumplahdata();
            comboumur.Refresh();
            segar();


            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label46.Text = label25.ToString();
            segar();
        }
        void Showdata2()
        {
            try
            {
                MySqlConnection conn = koneksi.Getconn();
                conn.Open();
                string sql = "SELECT umur UMUR,status STATUS, penghasilan PENGHASILAN, hutang HUTANG,investasi INVESTASI FROM dataawal";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(command);
                da.Fill(ds, "dataawal");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }

        }
        public void jumplahdata()
        {

            try
            {
                MySqlConnection con = koneksi.Getconn();
                con.Open();
                string mysql = "select jumlah from jumlahdata";
                MySqlCommand cmd = new MySqlCommand(mysql, con);
                MySqlDataReader dr;
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                bool temp = false;
                while (dr.Read())
                {
                    label7.Text = dr.GetString(0);

                    temp = true;
                }
                if (temp == false)

                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void jumlahdata2()
        {
            try
            {
                MySqlConnection con = koneksi.Getconn();
                con.Open();
                string mysql = " select * from classbenar where no = '1' ";
                MySqlCommand cmd = new MySqlCommand(mysql, con);
                MySqlDataReader dr;
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                bool temp = false;
                while (dr.Read())
                {

                    ya0.Text = dr.GetString(3);
                    label46.Text = dr.GetString(5);
                    label25.Text = dr.GetString(5);




                    temp = true;
                }
                if (temp == false)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void jumlahdata3()
        {
            try
            {
                MySqlConnection con = koneksi.Getconn();
                con.Open();
                string mysql = " select * from classbenar where no = '2' ";
                MySqlCommand cmd = new MySqlCommand(mysql, con);
                MySqlDataReader dr;
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                bool temp = false;
                while (dr.Read())
                {

                   tidak0.Text = dr.GetString(3);
                   tidak00.Text = dr.GetString(5);
                   label33.Text = dr.GetString(5);




                    temp = true;
                }
                if (temp == false)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        public void fillcombo()
        {
            MySqlConnection cn = koneksi.Getconn();
            cn.Open();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT umur FROM dataawal GROUP BY umur", cn);
            MySqlDataAdapter db = new MySqlDataAdapter("select status from dataawal GROUP BY status", cn);
            MySqlDataAdapter ds = new MySqlDataAdapter("select penghasilan from dataawal GROUP BY penghasilan", cn);
            MySqlDataAdapter da3 = new MySqlDataAdapter("select hutang from dataawal GROUP BY hutang", cn);
            

            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            DataTable dt4 = new DataTable();
            
            try
            {
                da.Fill(dt);
                comboumur.DataSource = dt;
                comboumur.ValueMember = "umur";
                comboumur.DisplayMember = "dataawal";
                
                db.Fill(dt2);
                combostatus.DataSource = dt2;
                combostatus.ValueMember = "status";
                combostatus.DisplayMember = "dataawal";
                
                ds.Fill(dt3);
                combopenghasilan.DataSource = dt3;
                combopenghasilan.ValueMember = "penghasilan";
                combopenghasilan.DisplayMember = "dataawal";
                
                da3.Fill(dt4);
                combohutang.DataSource = dt4;
                combohutang.ValueMember = "hutang";
                combohutang.DisplayMember = "dataawal";

            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void broser_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Text Files |*.csv";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = dlg.FileName;
                }
        }

        private void uplout_Click(object sender, EventArgs e)
        {
            

        }
        
            
        public decimal yes,no;
        double a,b,c,d,f,g, h,i,j, k,l,m, o,p,q, a1,a2,a3;
        private void proses_Click(object sender, EventArgs e)
        {

            
            segar();
            ya();
            tidak();            


        }
        double aa,bb,cc, b1,b2,b3, c1,c2,c3, d1,d2,d3, e1,e2,e3, f2, f3, f1;
        
        void tidak()
        {
            aa = Convert.ToDouble(tidak1.Text);
            bb = Convert.ToDouble(tidak0.Text);
            cc = Math.Round(aa / bb, 3);
            label38.Text = Convert.ToString(cc);

            b1 = Convert.ToDouble(tidak2.Text);
            b2 = Convert.ToDouble(tidak0.Text);
            b3 = Math.Round(b1 / b2, 3);
            label37.Text = Convert.ToString(b3);

            c1 = Convert.ToDouble(tidak3.Text);
            c2 = Convert.ToDouble(tidak0.Text);
            c3 = Math.Round(c1 / c2, 3);
            label36.Text = Convert.ToString(c3);

            d1 = Convert.ToDouble(tidak4.Text);
            d2 = Convert.ToDouble(tidak0.Text);
            d3 = Math.Round(d1 / d2, 3);
            label35.Text = Convert.ToString(d3);

            e3 = Math.Round(cc*b3*c3*d3, 3);
            label34.Text = Convert.ToString(e3);

            f1 = Convert.ToDouble(label34.Text);
            f2 = Convert.ToDouble(label33.Text);
            f3 = Math.Round(f1 * f2, 3);
            label32.Text = Convert.ToString(f3);



            yes = Convert.ToDecimal(label42.Text);
            no = Convert.ToDecimal(label32.Text);

            if (yes >= no)
            {
                hasilakhir.Text = "YA ";
            }
            else
            {
                hasilakhir.Text = "TIDAK";

            }




        }
        void ya()
        {

            a = Convert.ToDouble(ya0.Text);
            b = Convert.ToDouble(hasil1.Text);
            c = Math.Round(b / a, 3);
            label31.Text = c.ToString();

            d = Convert.ToDouble(hasil2.Text);
            f = Convert.ToDouble(ya0.Text);
            g = Math.Round(d / f, 3);
            label41.Text = g.ToString();

            h = Convert.ToDouble(hasil3.Text);
            i = Convert.ToDouble(ya0.Text);
            j = Math.Round(h / i, 3);
            label40.Text = j.ToString();

            k = Convert.ToDouble(hasil4.Text);
            l = Convert.ToDouble(ya0.Text);
            m = Math.Round(k / l, 3);
            label39.Text = m.ToString();

            q = c * g * j * m;
            label24.Text = q.ToString();

            a1 = Convert.ToDouble(label24.Text);
            a2 = Convert.ToDouble(label25.Text);
            a3 = Math.Round(a1 * a2, 3);
            label42.Text = a3.ToString();

            yes = Convert.ToDecimal(label42.Text);
            no = Convert.ToDecimal(label32.Text);

            if (yes >= no)
            {
                hasilakhir.Text = " YA ";
            }
            else
            {
                hasilakhir.Text = "TIDAK ";

            }

        
        }
        void segar()
        {
            
            umur();
            umur2();
            status();
            status2();
            penghasilan();
            penghasilan2();
            hutang();
            hutang2();
            jumlahdata2();
            jumlahdata3();
        }
        public void umur()
        {
            try
            {
                MySqlConnection con = koneksi.Getconn();
                con.Open();
                string mysql = "select umur, status, penghasilan, hutang, investasi,count(*) Total from dataawal where umur =  '" + comboumur.SelectedValue + "' and investasi LIKE 'Ya' ";
                MySqlCommand cmd = new MySqlCommand(mysql, con);
                MySqlDataReader dr;
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                bool temp = false;
                while (dr.Read())
                {

                    hasil1.Text = dr.GetString(5);
                   
   
                    temp = true;
                }
                if (temp == false)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void umur2()
        {
            try
            {
                MySqlConnection con = koneksi.Getconn();
                con.Open();
                string mysql = " select umur, status, penghasilan, hutang, investasi,count(*) Total  from algoritmabayes.dataawal where umur =  '" + comboumur.SelectedValue + "' and investasi LIKE 'tidak' ";
                MySqlCommand cmd = new MySqlCommand(mysql, con);
                MySqlDataReader dr;
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                bool temp = false;
                while (dr.Read())
                {

                    tidak1.Text = dr.GetString(5);


                    temp = true;
                }
                if (temp == false)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void status()
        {

            try
            {
                MySqlConnection con = koneksi.Getconn();
                con.Open();
                string mysql = "select umur, status, penghasilan, hutang, investasi,count(*) Total from dataawal where status =  '" + combostatus.SelectedValue + "' and investasi LIKE 'Ya' ";
                MySqlCommand cmd = new MySqlCommand(mysql, con);
                MySqlDataReader dr;
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                bool temp = false;
                while (dr.Read())
                {

                    hasil2.Text = dr.GetString(5);
                    
                    temp = true;
                }
                if (temp == false)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void status2()
        {

            try
            {
                MySqlConnection con = koneksi.Getconn();
                con.Open();
                string mysql = " select umur, status, penghasilan, hutang, investasi,count(*) Total  from algoritmabayes.dataawal where status =  '" + combostatus.SelectedValue + "' and investasi LIKE 'tidak' ";
                MySqlCommand cmd = new MySqlCommand(mysql, con);
                MySqlDataReader dr;
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                bool temp = false;
                while (dr.Read())
                {

                    tidak2.Text = dr.GetString(5);

                    temp = true;
                }
                if (temp == false)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void penghasilan()
        {

            try
            {
                MySqlConnection con = koneksi.Getconn();
                con.Open();
                string mysql = "select umur, status, penghasilan, hutang, investasi,count(*) Total from dataawal where penghasilan =  '" + combopenghasilan.SelectedValue + "' and investasi LIKE 'Ya' ";
                MySqlCommand cmd = new MySqlCommand(mysql, con);
                MySqlDataReader dr;
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                bool temp = false;
                while (dr.Read())
                {

                    hasil3.Text = dr.GetString(5);

                    temp = true;
                }
                if (temp == false)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void penghasilan2()
        {

            try
            {
                MySqlConnection con = koneksi.Getconn();
                con.Open();
                string mysql = "select umur, status, penghasilan, hutang, investasi,count(*) Total  from algoritmabayes.dataawal where penghasilan =  '" + combopenghasilan.SelectedValue + "' and investasi LIKE 'tidak' ";
                MySqlCommand cmd = new MySqlCommand(mysql, con);
                MySqlDataReader dr;
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                bool temp = false;
                while (dr.Read())
                {

                    tidak3.Text = dr.GetString(5);

                    temp = true;
                }
                if (temp == false)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void hutang()
        {

            try
            {
                MySqlConnection con = koneksi.Getconn();
                con.Open();
                string mysql = "select umur, status, penghasilan, hutang, investasi,count(*) Total from dataawal where hutang =  '" + combohutang.SelectedValue + "' and investasi LIKE 'Ya' ";
                MySqlCommand cmd = new MySqlCommand(mysql, con);
                MySqlDataReader dr;
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                bool temp = false;
                while (dr.Read())
                {

                    hasil4.Text = dr.GetString(5);

                    temp = true;
                }
                if (temp == false)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void hutang2()
        {

            try
            {
                MySqlConnection con = koneksi.Getconn();
                con.Open();
                string mysql = "select umur, status, penghasilan, hutang, investasi,count(*) Total  from algoritmabayes.dataawal where hutang =  '" + combohutang.SelectedValue + "' and investasi LIKE 'tidak' ";
                MySqlCommand cmd = new MySqlCommand(mysql, con);
                MySqlDataReader dr;
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                bool temp = false;
                while (dr.Read())
                {
                    tidak4.Text = dr.GetString(5);

                    temp = true;
                }
                if (temp == false)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void combohutang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void comboumur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void combostatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void combopenghasilan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void hasil1_Click(object sender, EventArgs e)
        {

        }

        private void hasil2_Click(object sender, EventArgs e)
        {

        }

        private void hasil3_Click(object sender, EventArgs e)
        {

        }

        private void hasil4_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label59_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

    }
}
