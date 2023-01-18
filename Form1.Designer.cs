
namespace project1_home_applicant_with_SQL_
{
    partial class MenuOfTech
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddPage = new System.Windows.Forms.Button();
            this.BtnSeePage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(580, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(850, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "TechNoSa HOME APPLICANT SHOP";
            // 
            // btnAddPage
            // 
            this.btnAddPage.BackColor = System.Drawing.Color.Moccasin;
            this.btnAddPage.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddPage.ForeColor = System.Drawing.Color.Navy;
            this.btnAddPage.Location = new System.Drawing.Point(723, 241);
            this.btnAddPage.Name = "btnAddPage";
            this.btnAddPage.Size = new System.Drawing.Size(548, 150);
            this.btnAddPage.TabIndex = 1;
            this.btnAddPage.Text = "Add Products";
            this.btnAddPage.UseVisualStyleBackColor = false;
            this.btnAddPage.Click += new System.EventHandler(this.btnAddPage_Click);
            // 
            // BtnSeePage
            // 
            this.BtnSeePage.BackColor = System.Drawing.Color.Moccasin;
            this.BtnSeePage.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSeePage.ForeColor = System.Drawing.Color.Navy;
            this.BtnSeePage.Location = new System.Drawing.Point(723, 478);
            this.BtnSeePage.Name = "BtnSeePage";
            this.BtnSeePage.Size = new System.Drawing.Size(548, 150);
            this.BtnSeePage.TabIndex = 1;
            this.BtnSeePage.Text = "See Products";
            this.BtnSeePage.UseVisualStyleBackColor = false;
            this.BtnSeePage.Click += new System.EventHandler(this.BtnSeePage_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Moccasin;
            this.btnExit.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(723, 725);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(548, 150);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Tan;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(599, 1030);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(848, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "SoftES Software Provide Company (All Rights Reserved)";
            // 
            // MenuOfTech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.BtnSeePage);
            this.Controls.Add(this.btnAddPage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuOfTech";
            this.Text = "TechNoSa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddPage;
        private System.Windows.Forms.Button BtnSeePage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
    }
}

