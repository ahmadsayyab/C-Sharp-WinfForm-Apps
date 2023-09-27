namespace Product_detail_WinformApp
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.nametb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.companytb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.categorytb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pricetb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.stocktb = new System.Windows.Forms.TextBox();
            this.insertbtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCT DETAILS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // nametb
            // 
            this.nametb.Location = new System.Drawing.Point(205, 69);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(239, 20);
            this.nametb.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Company:";
            // 
            // companytb
            // 
            this.companytb.Location = new System.Drawing.Point(205, 113);
            this.companytb.Name = "companytb";
            this.companytb.Size = new System.Drawing.Size(239, 20);
            this.companytb.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Category:";
            // 
            // categorytb
            // 
            this.categorytb.Location = new System.Drawing.Point(205, 162);
            this.categorytb.Name = "categorytb";
            this.categorytb.Size = new System.Drawing.Size(239, 20);
            this.categorytb.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Price:";
            // 
            // pricetb
            // 
            this.pricetb.Location = new System.Drawing.Point(205, 211);
            this.pricetb.Name = "pricetb";
            this.pricetb.Size = new System.Drawing.Size(239, 20);
            this.pricetb.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(110, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Stock:";
            // 
            // stocktb
            // 
            this.stocktb.Location = new System.Drawing.Point(205, 259);
            this.stocktb.Name = "stocktb";
            this.stocktb.Size = new System.Drawing.Size(239, 20);
            this.stocktb.TabIndex = 4;
            // 
            // insertbtn
            // 
            this.insertbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertbtn.Location = new System.Drawing.Point(58, 306);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(96, 34);
            this.insertbtn.TabIndex = 5;
            this.insertbtn.Text = "INSERT";
            this.insertbtn.UseVisualStyleBackColor = true;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Location = new System.Drawing.Point(178, 306);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(96, 34);
            this.updatebtn.TabIndex = 6;
            this.updatebtn.Text = "UPDATE";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(298, 306);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(96, 34);
            this.deletebtn.TabIndex = 7;
            this.deletebtn.Text = "DELETE";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 355);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(455, 150);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // viewbtn
            // 
            this.viewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewbtn.Location = new System.Drawing.Point(417, 306);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(96, 34);
            this.viewbtn.TabIndex = 7;
            this.viewbtn.Text = "VIEW";
            this.viewbtn.UseVisualStyleBackColor = true;
            this.viewbtn.Click += new System.EventHandler(this.viewbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 509);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.viewbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.insertbtn);
            this.Controls.Add(this.stocktb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pricetb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.categorytb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.companytb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nametb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Detail";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox companytb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox categorytb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pricetb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox stocktb;
        private System.Windows.Forms.Button insertbtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button viewbtn;
    }
}

