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
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        // Creating the connection with database
        SqlConnection connect = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=techNoSa;Integrated Security=True");

        // A method for Clearing all items 
        public void Clear()
        {
            tbBrand.Text = null;
            tbID.Text = null;
            tbModel.Text = null;
            tbPrice.Text = null;
            cmbType.SelectedItem = null;
            tbLinktv.Text = null;
            tbLinkSmartphone.Text = null;
            tbLinkLaptop.Text = null;

            gbTv.Enabled = false; gbLaptop.Enabled = false; gbSmartphone.Enabled = false;
        }


        private void BtnBackHome_Click(object sender, EventArgs e)
        {
            MenuOfTech f1 = new MenuOfTech();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {

            // Error Messages for empty places.

            if (tbBrand.Text == "")
            {
                MessageBox.Show("Please first enter product Brand to proceed. ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (tbID.Text == "")
            {
                MessageBox.Show("Please first enter product ID to proceed. ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (tbModel.Text == "")
            {
                MessageBox.Show("Please first enter product Model to proceed. ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (tbPrice.Text == "")
            {
                MessageBox.Show("Please first enter product Price to proceed. ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                // groupBox enable system
                switch (cmbType.SelectedItem)
                {
                    case "TV": gbTv.Enabled = true; gbLaptop.Enabled = false; gbSmartphone.Enabled = false; break;
                    case "SMARTPHONE": gbTv.Enabled = false; gbLaptop.Enabled = false; gbSmartphone.Enabled = true; break;
                    case "LAPTOP": gbTv.Enabled = false; gbLaptop.Enabled = true; gbSmartphone.Enabled = false; break;

                    default:
                        break;
                }
            }

        }

        

        private void btnPicTv_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbLinktv.Text = openFileDialog1.FileName;
            }
        }

        private void btnAddTv_Click(object sender, EventArgs e)
        {
            
                // Error Messages for empty places.

                if (tbResolution.Text == "")
                {
                    MessageBox.Show("Please enter the value for  Resolution before add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (tbInches.Text == "")
                {
                    MessageBox.Show("Please enter the value for Inches before add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                 else if (tbLinktv.Text == "")
                 {
                MessageBox.Show("Please chose an Image  before add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 }

            else
                {
                  try
                  {

                    // Connection with the tv class and transfer the values
                    string ID = tbID.Text;
                    string model = tbModel.Text;
                    string brand = tbBrand.Text;
                    float price = float.Parse(tbPrice.Text);
                    string resolution = tbResolution.Text;
                    int inch = Convert.ToInt32(tbInches.Text);
                    bool smart = chbTV.Checked;
                    TV tv = new TV(ID, model, brand, price, resolution, inch, smart);

                    //Writing the values into database

                    connect.Open();
                    SqlCommand add = new SqlCommand("insert into TV (ID,model,brand,price,resolution,inch,smart,Picture) values('" + tv.Id + "','" + tv.Model + "','" + tv.Brand + "','" + tv.Price + "','" + tv.Resolution + "','" + tv.Inch + "','" + tv.Smart + "', @img)", connect);


                    byte[] imageData = File.ReadAllBytes(tbLinktv.Text);
                    add.Parameters.AddWithValue("@img", imageData);

                    //add.Parameters.AddWithValue("@b1", tbID.Text);
                    //add.Parameters.AddWithValue("@b2", tbModel.Text);
                    //add.Parameters.AddWithValue("@b3", tbBrand.Text);
                    //add.Parameters.AddWithValue("@b4", float.Parse(tbPrice.Text));
                    //add.Parameters.AddWithValue("@b5", tbResolution.Text);
                    //add.Parameters.AddWithValue("@b6", Convert.ToInt32(tbInches.Text));
                    //add.Parameters.AddWithValue("@b7", tv.Smart);

                    add.ExecuteNonQuery();
                    connect.Close();

                    // Cleaning The objects after adding.
                    Clear();
                    tbResolution.Text = null;
                    tbInches.Text = null;
                    chbTV.Checked = false;

                    // Information that proccess has been completed 
                    MessageBox.Show("Well done! The Brand New TV has added succesfully.", "Wow! New Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                  }

                   catch (Exception ex)
                  {

                      MessageBox.Show(ex.Message);

                  }



                      //finally
                        //{
                        //    connect.Close();
                        //} 

                }
        }


        private void btnPicSmrtp_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbLinkSmartphone.Text = openFileDialog1.FileName;
            }
        }

        private void BtnAddSmartphone_Click(object sender, EventArgs e)
        {
            // Error Messages for empty places.

            if (tbROM.Text == "")
            {
                MessageBox.Show("Please enter the value for ROM before add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (tbOs.Text == "")
            {
                MessageBox.Show("Please enter the value for OS before add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (tbLinkSmartphone.Text == "")
            {
                MessageBox.Show("Please chose an Image  before add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    // Connection with the smartphone class and transfer the values
                    string ID = tbID.Text;
                    string model = tbModel.Text;
                    string brand = tbBrand.Text;
                    float price = float.Parse(tbPrice.Text);
                    int rom = Convert.ToInt32(tbROM.Text);
                    string os = tbOs.Text;
                    bool fiveG = chbSmartphone.Checked;
                    smartphone sp = new smartphone(ID, model, brand, price, rom, os, fiveG);

                    //Writing the values into database

                    connect.Open();
                    SqlCommand add = new SqlCommand("insert into smartphone (ID,model,brand,price,rom,os,fiveg,Picture) values('" + sp.Id + "','" + sp.Model + "','" + sp.Brand + "','" + sp.Price + "','" + sp.Rom + "','" + sp.Os + "','" + sp.FiveG + "',@img)", connect);

                    byte[] imageData = File.ReadAllBytes(tbLinkSmartphone.Text);
                    add.Parameters.AddWithValue("@img", imageData);

                    //add.Parameters.AddWithValue("@b1", tbID.Text);
                    //add.Parameters.AddWithValue("@b2", tbModel.Text);
                    //add.Parameters.AddWithValue("@b3", tbBrand.Text);
                    //add.Parameters.AddWithValue("@b4", float.Parse(tbPrice.Text));
                    //add.Parameters.AddWithValue("@b5", tbResolution.Text);
                    //add.Parameters.AddWithValue("@b6", Convert.ToInt32(tbInches.Text));
                    //add.Parameters.AddWithValue("@b7", tv.Smart);

                    add.ExecuteNonQuery();
                    connect.Close();

                    // Cleaning The objects after adding.
                    Clear();
                    tbROM.Text = null;
                    tbOs.Text = null;
                    chbSmartphone.Checked = false;

                    // Information that proccess has been completed 
                    MessageBox.Show("Well done! The Brand New Smartphone has added succesfully.", "Wow! New Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }

            
        }

        private void btnPicLaptop_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbLinkLaptop.Text = openFileDialog1.FileName;
            }
        }

        private void btnAddLaptop_Click(object sender, EventArgs e)
        {

            // Error Messages for empty places.

            if (tbRam.Text == "")
            {
                MessageBox.Show("Please enter the value for RAM before add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (TbDisplayCard.Text == "")
            {
                MessageBox.Show("Please enter the value for Display Card before add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (tbLinkLaptop.Text == "")
            {
                MessageBox.Show("Please chose an Image  before add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    // Connection with the laptop class and transfer the values
                    string ID = tbID.Text;
                    string model = tbModel.Text;
                    string brand = tbBrand.Text;
                    float price = float.Parse(tbPrice.Text);
                    string ram = tbRam.Text;
                    string displaycard = TbDisplayCard.Text;
                    bool gaming = chbLaptop.Checked;
                    Laptop lp = new Laptop(ID, model, brand, price, ram, displaycard, gaming);

                    //Writing the values into database

                    connect.Open();
                    SqlCommand add = new SqlCommand("insert into laptop (ID,model,brand,price,ram,displayCard,gaming,Picture) values('" + lp.Id + "','" + lp.Model + "','" + lp.Brand + "','" + lp.Price + "','" + lp.Ram + "','" + lp.DisplayCard + "','" + lp.Gaming + "',@img)", connect);

                    byte[] imageData = File.ReadAllBytes(tbLinkLaptop.Text);
                    add.Parameters.AddWithValue("@img", imageData);

                    //add.Parameters.AddWithValue("@b1", tbID.Text);
                    //add.Parameters.AddWithValue("@b2", tbModel.Text);
                    //add.Parameters.AddWithValue("@b3", tbBrand.Text);
                    //add.Parameters.AddWithValue("@b4", float.Parse(tbPrice.Text));
                    //add.Parameters.AddWithValue("@b5", tbResolution.Text);
                    //add.Parameters.AddWithValue("@b6", Convert.ToInt32(tbInches.Text));
                    //add.Parameters.AddWithValue("@b7", tv.Smart);

                    add.ExecuteNonQuery();
                    connect.Close();

                    // Cleaning The objects after adding.
                    Clear();
                    tbRam.Text = null;
                    TbDisplayCard.Text = null;
                    chbLaptop.Checked = false;

                    // Information that proccess has been completed 
                    MessageBox.Show("Well done! The Brand New Laptop has added succesfully.", "Wow! New Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }
            
        }



       


        ////Adding Image
        //private void btnImage_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

                  //// Way 2-------------------------------------------------------------------------------------------------------
        //        connect.Open();
        //        SqlCommand img = new SqlCommand("INSERT INTO imgTryNew (id,Picture) VALUES (@id,@pic) ", connect);
        //        byte[] imageData = File.ReadAllBytes(tbLinktv.Text);
        //        img.Parameters.AddWithValue("@id", Convert.ToInt32(tbIdImage.Text));
        //        img.Parameters.AddWithValue("@pic", imageData);

        //        img.ExecuteNonQuery();
        //        connect.Close();



                //// WAY 1----------------------------------------------------------------------------------------------------------
                //FileStream fs1 = new FileStream(tbLink.Text, FileMode.Open, FileAccess.Read);
                //byte[] image = new byte[fs1.Length];
                //fs1.Read(image, 0, Convert.ToInt32(fs1.Length));
                //fs1.Close();

                //connect.Open();
                //SqlCommand img = new SqlCommand("INSERT INTO imgTry (Picture) VALUES (@pic) ", connect);
                //SqlParameter prm = new SqlParameter("@pic", SqlDbType.VarBinary, image.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, image);
                //img.Parameters.Add(prm);
                //img.ExecuteNonQuery();
                //connect.Close();
        //    }
        //    catch (Exception ex )
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
            
        //}

      
    }
}
