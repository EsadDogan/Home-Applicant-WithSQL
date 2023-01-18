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
using System.IO;

namespace project1_home_applicant_with_SQL_
{
    public partial class See : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=techNoSa;Integrated Security=True");

       

        public See()
        {
            InitializeComponent();
        }

        public void Clear()
        {

            LBLid2.Text = null;
            lblBrand2.Text = null;
            lblModel2.Text = null;
            lblPrice2.Text = null;
            lblQuantity1.Text = null;
            lblQuantity2.Text = null;
            lblQuantity3.Text = null;
            pictureBox1.Image = null;

        }


        public void getData()
        {
            try
            {
                Clear();

                switch (comboBox1.SelectedItem)
                {
                    case "TV":
                        SqlDataAdapter da = new SqlDataAdapter("select ID,model,brand,price,resolution,inch,smart from TV", connect);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0]; break;

                    case "SMARTPHONE":
                        SqlDataAdapter da2 = new SqlDataAdapter("select ID,model,brand,price,rom,os,fiveg from smartphone", connect);
                        DataSet ds2 = new DataSet();
                        da2.Fill(ds2);
                        dataGridView1.DataSource = ds2.Tables[0]; break;

                    case "LAPTOP":
                        SqlDataAdapter da3 = new SqlDataAdapter("select ID,model,brand,price,ram,displayCard,gaming from laptop", connect);
                        DataSet ds3 = new DataSet();
                        da3.Fill(ds3);
                        dataGridView1.DataSource = ds3.Tables[0]; break;

                    default: break;


                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuOfTech mt = new MenuOfTech();
            this.Hide();
            mt.ShowDialog();
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
           getData();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            try
            {
                Clear();

                switch (comboBox1.SelectedItem)
                {
                    case "TV":
                        connect.Open();
                        SqlCommand delete = new SqlCommand("delete from TV where ID = @a", connect);
                        delete.Parameters.AddWithValue("@a", tbIDSee.Text);
                        delete.ExecuteNonQuery();
                        connect.Close();

                        break;

                    case "SMARTPHONE":
                        connect.Open();
                        SqlCommand delete2 = new SqlCommand("delete from smartphone where ID = @a", connect);
                        delete2.Parameters.AddWithValue("@a", tbIDSee.Text);
                        delete2.ExecuteNonQuery();
                        connect.Close();

                        break;

                    case "LAPTOP":
                        connect.Open();
                        SqlCommand delete3 = new SqlCommand("delete from laptop where ID = @a", connect);
                        delete3.Parameters.AddWithValue("@a", tbIDSee.Text);
                        delete3.ExecuteNonQuery();
                        connect.Close();

                        break;

                    default: break;


                }


                getData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {

                Clear();

                switch (comboBox1.SelectedItem)

                {


                    case "TV":
                        SqlDataAdapter da = new SqlDataAdapter("select ID,model,brand,price,resolution,inch,smart from TV where ID ='" + Convert.ToString(tbIDSee.Text) + "'", connect);
                  DataSet ds = new DataSet();
                  da.Fill(ds);
                  dataGridView1.DataSource = ds.Tables[0];

                        break;


                    case "SMARTPHONE":

                        SqlDataAdapter da2 = new SqlDataAdapter("select ID,model,brand,price,rom,os,fiveg from SMARTPHONE where ID ='" + Convert.ToString(tbIDSee.Text) + "'", connect);
                        DataSet ds2 = new DataSet();
                        da2.Fill(ds2);
                        dataGridView1.DataSource = ds2.Tables[0];

                        break;


                    case "LAPTOP":
                        SqlDataAdapter da3 = new SqlDataAdapter("select ID,model,brand,price,ram,displayCard,gaming from laptop where ID ='" + Convert.ToString(tbIDSee.Text) + "'", connect);
                        DataSet ds3 = new DataSet();
                        da3.Fill(ds3);
                        dataGridView1.DataSource = ds3.Tables[0];

                        break;


                    default: break;


                }




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();

                int ch = dataGridView1.SelectedCells[0].RowIndex;

                LBLid2.Text = dataGridView1.Rows[ch].Cells[0].Value.ToString();
                lblBrand2.Text = dataGridView1.Rows[ch].Cells[1].Value.ToString();
                lblModel2.Text = dataGridView1.Rows[ch].Cells[2].Value.ToString();
                lblPrice2.Text = dataGridView1.Rows[ch].Cells[3].Value.ToString();

 


                switch (comboBox1.SelectedItem)
                {
                    case "TV":

                        lblQuantity1.Text = "Resolution: " + dataGridView1.Rows[ch].Cells[4].Value.ToString();
                        lblQuantity2.Text = "Inch: " + dataGridView1.Rows[ch].Cells[5].Value.ToString();
                        lblQuantity3.Text = "Smart: " + dataGridView1.Rows[ch].Cells[6].Value.ToString();

                        SqlDataAdapter sdTV = new SqlDataAdapter("select Picture from TV where ID = '" + LBLid2.Text + "'", connect);
                        DataTable dttV = new DataTable();

                        sdTV.Fill(dttV);
                        byte[] imageData = new byte[0];
                        imageData = (byte[])dttV.Rows[0][0];
                        MemoryStream str = new MemoryStream(imageData);
                        pictureBox1.Image = Image.FromStream(str);

                        break;

                    case "SMARTPHONE":

                        lblQuantity1.Text = "ROM: " + dataGridView1.Rows[ch].Cells[4].Value.ToString();
                        lblQuantity2.Text = "OS: " + dataGridView1.Rows[ch].Cells[5].Value.ToString();
                        lblQuantity3.Text = "5G: " + dataGridView1.Rows[ch].Cells[6].Value.ToString();

                        SqlDataAdapter sdSmrtp = new SqlDataAdapter("select Picture from smartphone where ID = '" + LBLid2.Text + "'", connect);
                        DataTable dtSmrtp = new DataTable();

                        sdSmrtp.Fill(dtSmrtp);
                        byte[] imageData2 = new byte[0];
                        imageData = (byte[])dtSmrtp.Rows[0][0];
                        MemoryStream str2 = new MemoryStream(imageData);
                        pictureBox1.Image = Image.FromStream(str2);


                        break;

                    case "LAPTOP":

                        lblQuantity1.Text = "RAM: " + dataGridView1.Rows[ch].Cells[4].Value.ToString();
                        lblQuantity2.Text = "Display Card: " + dataGridView1.Rows[ch].Cells[5].Value.ToString();
                        lblQuantity3.Text = "Gaming: " + dataGridView1.Rows[ch].Cells[6].Value.ToString();

                        SqlDataAdapter sdLPTP = new SqlDataAdapter("select Picture from laptop where ID = '" + LBLid2.Text + "'", connect);
                        DataTable dtLptp = new DataTable();
                        sdLPTP.Fill(dtLptp);
                        byte[] imageData3 = new byte[0];
                        imageData = (byte[])dtLptp.Rows[0][0];
                        MemoryStream str3 = new MemoryStream(imageData);
                        pictureBox1.Image = Image.FromStream(str3);
                        break;



                    default:
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        // Reading picture from sql

        //private void btnPicture_Click(object sender, EventArgs e)
        //{
        //    SqlDataAdapter sd = new SqlDataAdapter("select * from imgTryNew where id = '"+Convert.ToInt32(tbIdPicture.Text)+"'", connect);
        //    DataTable dt = new DataTable();
        //    sd.Fill(dt);
        //    byte[] imageData = new byte[0];
        //    imageData = (byte[])dt.Rows[0][1];
        //    MemoryStream str = new MemoryStream(imageData);
        //    pictureBox1.Image = Image.FromStream(str);


        //}
    }
}
