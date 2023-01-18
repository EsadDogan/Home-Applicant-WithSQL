
namespace project1_home_applicant_with_SQL_
{
    partial class See
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPrice2 = new System.Windows.Forms.Label();
            this.lblQuantity3 = new System.Windows.Forms.Label();
            this.lblQuantity2 = new System.Windows.Forms.Label();
            this.lblModel2 = new System.Windows.Forms.Label();
            this.lblQuantity1 = new System.Windows.Forms.Label();
            this.lblBrand2 = new System.Windows.Forms.Label();
            this.LBLid2 = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIDSee = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnShowInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 230);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1065, 710);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "TV",
            "SMARTPHONE",
            "LAPTOP"});
            this.comboBox1.Location = new System.Drawing.Point(44, 172);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 45);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(739, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 81);
            this.label1.TabIndex = 2;
            this.label1.Text = "Products Page";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(693, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(481, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "You Can See Your Products in Here";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Crimson;
            this.btnBack.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Location = new System.Drawing.Point(44, 1018);
            this.btnBack.Margin = new System.Windows.Forms.Padding(1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(1831, 52);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back to Main Menu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(1796, 94);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 47);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSearch.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearch.Location = new System.Drawing.Point(1653, 94);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(141, 47);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Turquoise;
            this.btnShow.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShow.Location = new System.Drawing.Point(281, 172);
            this.btnShow.Margin = new System.Windows.Forms.Padding(1);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(104, 45);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblPrice2);
            this.groupBox1.Controls.Add(this.lblQuantity3);
            this.groupBox1.Controls.Add(this.lblQuantity2);
            this.groupBox1.Controls.Add(this.lblModel2);
            this.groupBox1.Controls.Add(this.lblQuantity1);
            this.groupBox1.Controls.Add(this.lblBrand2);
            this.groupBox1.Controls.Add(this.LBLid2);
            this.groupBox1.Controls.Add(this.lblBrand);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblModel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(1113, 230);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(787, 710);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(286, 381);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblPrice2
            // 
            this.lblPrice2.AutoSize = true;
            this.lblPrice2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice2.Location = new System.Drawing.Point(131, 326);
            this.lblPrice2.Name = "lblPrice2";
            this.lblPrice2.Size = new System.Drawing.Size(0, 41);
            this.lblPrice2.TabIndex = 9;
            // 
            // lblQuantity3
            // 
            this.lblQuantity3.AutoSize = true;
            this.lblQuantity3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuantity3.Location = new System.Drawing.Point(33, 575);
            this.lblQuantity3.Name = "lblQuantity3";
            this.lblQuantity3.Size = new System.Drawing.Size(0, 41);
            this.lblQuantity3.TabIndex = 9;
            // 
            // lblQuantity2
            // 
            this.lblQuantity2.AutoSize = true;
            this.lblQuantity2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuantity2.Location = new System.Drawing.Point(33, 489);
            this.lblQuantity2.Name = "lblQuantity2";
            this.lblQuantity2.Size = new System.Drawing.Size(0, 41);
            this.lblQuantity2.TabIndex = 9;
            // 
            // lblModel2
            // 
            this.lblModel2.AutoSize = true;
            this.lblModel2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblModel2.Location = new System.Drawing.Point(149, 244);
            this.lblModel2.Name = "lblModel2";
            this.lblModel2.Size = new System.Drawing.Size(0, 41);
            this.lblModel2.TabIndex = 9;
            // 
            // lblQuantity1
            // 
            this.lblQuantity1.AutoSize = true;
            this.lblQuantity1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuantity1.Location = new System.Drawing.Point(33, 404);
            this.lblQuantity1.Name = "lblQuantity1";
            this.lblQuantity1.Size = new System.Drawing.Size(0, 41);
            this.lblQuantity1.TabIndex = 9;
            // 
            // lblBrand2
            // 
            this.lblBrand2.AutoSize = true;
            this.lblBrand2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBrand2.Location = new System.Drawing.Point(149, 153);
            this.lblBrand2.Name = "lblBrand2";
            this.lblBrand2.Size = new System.Drawing.Size(0, 41);
            this.lblBrand2.TabIndex = 9;
            // 
            // LBLid2
            // 
            this.LBLid2.AutoSize = true;
            this.LBLid2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBLid2.Location = new System.Drawing.Point(101, 67);
            this.LBLid2.Name = "LBLid2";
            this.LBLid2.Size = new System.Drawing.Size(0, 41);
            this.LBLid2.TabIndex = 9;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBrand.Location = new System.Drawing.Point(69, 103);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(0, 43);
            this.lblBrand.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(28, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 43);
            this.label5.TabIndex = 0;
            this.label5.Text = "Brand: ";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblModel.Location = new System.Drawing.Point(66, 151);
            this.lblModel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(0, 43);
            this.lblModel.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(32, 242);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 43);
            this.label6.TabIndex = 0;
            this.label6.Text = "Model:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Location = new System.Drawing.Point(59, 194);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 43);
            this.lblPrice.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(32, 324);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 43);
            this.label4.TabIndex = 0;
            this.label4.Text = "Price:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.Location = new System.Drawing.Point(46, 66);
            this.lblID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 43);
            this.lblID.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(32, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 43);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID: ";
            // 
            // tbIDSee
            // 
            this.tbIDSee.Location = new System.Drawing.Point(1425, 96);
            this.tbIDSee.Name = "tbIDSee";
            this.tbIDSee.Size = new System.Drawing.Size(215, 40);
            this.tbIDSee.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Heavy", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(1421, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(355, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Write Product ID to Search or Delete it.";
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Location = new System.Drawing.Point(44, 944);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(219, 45);
            this.btnShowInfo.TabIndex = 11;
            this.btnShowInfo.Text = "Show Information";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // See
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbIDSee);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "See";
            this.Text = "See";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPrice2;
        private System.Windows.Forms.Label lblQuantity3;
        private System.Windows.Forms.Label lblQuantity2;
        private System.Windows.Forms.Label lblModel2;
        private System.Windows.Forms.Label lblQuantity1;
        private System.Windows.Forms.Label lblBrand2;
        private System.Windows.Forms.Label LBLid2;
        private System.Windows.Forms.TextBox tbIDSee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}