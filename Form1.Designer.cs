namespace Exchange_project
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbldollbuy = new System.Windows.Forms.Label();
            this.lbleurbuy = new System.Windows.Forms.Label();
            this.lbldolsell = new System.Windows.Forms.Label();
            this.lbleursell = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnnsale = new System.Windows.Forms.Button();
            this.txtremaind = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtquant = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtrate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btndolbuy = new System.Windows.Forms.Button();
            this.btndolsale = new System.Windows.Forms.Button();
            this.btneursell = new System.Windows.Forms.Button();
            this.btneurbuy = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.db_ExchangeDataSet = new Exchange_project.Db_ExchangeDataSet();
            this.tblMonneyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_MonneyTableAdapter = new Exchange_project.Db_ExchangeDataSetTableAdapters.Tbl_MonneyTableAdapter();
            this.tLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eURDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOLLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ExchangeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMonneyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(4, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dollar Buying:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Wide Latin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(12, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dollar Selling:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Wide Latin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(34, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Euro Buying:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Wide Latin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Azure;
            this.label4.Location = new System.Drawing.Point(34, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Euro Selling:";
            // 
            // lbldollbuy
            // 
            this.lbldollbuy.AutoSize = true;
            this.lbldollbuy.BackColor = System.Drawing.Color.Transparent;
            this.lbldollbuy.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldollbuy.ForeColor = System.Drawing.Color.Azure;
            this.lbldollbuy.Location = new System.Drawing.Point(363, 156);
            this.lbldollbuy.Name = "lbldollbuy";
            this.lbldollbuy.Size = new System.Drawing.Size(58, 23);
            this.lbldollbuy.TabIndex = 4;
            this.lbldollbuy.Text = "00";
            // 
            // lbleurbuy
            // 
            this.lbleurbuy.AutoSize = true;
            this.lbleurbuy.BackColor = System.Drawing.Color.Transparent;
            this.lbleurbuy.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleurbuy.ForeColor = System.Drawing.Color.Azure;
            this.lbleurbuy.Location = new System.Drawing.Point(363, 317);
            this.lbleurbuy.Name = "lbleurbuy";
            this.lbleurbuy.Size = new System.Drawing.Size(58, 23);
            this.lbleurbuy.TabIndex = 6;
            this.lbleurbuy.Text = "00";
            // 
            // lbldolsell
            // 
            this.lbldolsell.AutoSize = true;
            this.lbldolsell.BackColor = System.Drawing.Color.Transparent;
            this.lbldolsell.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldolsell.ForeColor = System.Drawing.Color.Azure;
            this.lbldolsell.Location = new System.Drawing.Point(363, 215);
            this.lbldolsell.Name = "lbldolsell";
            this.lbldolsell.Size = new System.Drawing.Size(58, 23);
            this.lbldolsell.TabIndex = 7;
            this.lbldolsell.Text = "00";
            // 
            // lbleursell
            // 
            this.lbleursell.AutoSize = true;
            this.lbleursell.BackColor = System.Drawing.Color.Transparent;
            this.lbleursell.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleursell.ForeColor = System.Drawing.Color.Azure;
            this.lbleursell.Location = new System.Drawing.Point(363, 374);
            this.lbleursell.Name = "lbleursell";
            this.lbleursell.Size = new System.Drawing.Size(58, 23);
            this.lbleursell.TabIndex = 8;
            this.lbleursell.Text = "00";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnnsale);
            this.groupBox1.Controls.Add(this.txtremaind);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtamount);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtquant);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtrate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 471);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 311);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(794, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 79);
            this.button1.TabIndex = 18;
            this.button1.Text = "SALE 2";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.TextChanged += new System.EventHandler(this.button1_TextChanged);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnnsale
            // 
            this.btnnsale.BackColor = System.Drawing.Color.Gainsboro;
            this.btnnsale.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnnsale.Location = new System.Drawing.Point(560, 215);
            this.btnnsale.Name = "btnnsale";
            this.btnnsale.Size = new System.Drawing.Size(119, 79);
            this.btnnsale.TabIndex = 14;
            this.btnnsale.Text = "SALE";
            this.btnnsale.UseVisualStyleBackColor = false;
            this.btnnsale.Click += new System.EventHandler(this.btnnsale_Click);
            // 
            // txtremaind
            // 
            this.txtremaind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtremaind.Location = new System.Drawing.Point(560, 170);
            this.txtremaind.Name = "txtremaind";
            this.txtremaind.Size = new System.Drawing.Size(353, 29);
            this.txtremaind.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Wide Latin", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Azure;
            this.label11.Location = new System.Drawing.Point(150, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(368, 33);
            this.label11.TabIndex = 16;
            this.label11.Text = "REMAINDER:";
            // 
            // txtamount
            // 
            this.txtamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtamount.Location = new System.Drawing.Point(560, 119);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(353, 29);
            this.txtamount.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Wide Latin", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Azure;
            this.label12.Location = new System.Drawing.Point(263, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(255, 33);
            this.label12.TabIndex = 14;
            this.label12.Text = "AMOUNT:";
            // 
            // txtquant
            // 
            this.txtquant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtquant.Location = new System.Drawing.Point(560, 70);
            this.txtquant.Name = "txtquant";
            this.txtquant.Size = new System.Drawing.Size(353, 29);
            this.txtquant.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Wide Latin", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Azure;
            this.label10.Location = new System.Drawing.Point(219, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(299, 33);
            this.label10.TabIndex = 12;
            this.label10.Text = "QUANTITY:";
            // 
            // txtrate
            // 
            this.txtrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtrate.Location = new System.Drawing.Point(560, 19);
            this.txtrate.Name = "txtrate";
            this.txtrate.Size = new System.Drawing.Size(353, 29);
            this.txtrate.TabIndex = 11;
            this.txtrate.TextChanged += new System.EventHandler(this.txtrate_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Wide Latin", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Azure;
            this.label6.Location = new System.Drawing.Point(29, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(489, 33);
            this.label6.TabIndex = 10;
            this.label6.Text = "EXCHANGE RATE:";
            // 
            // btndolbuy
            // 
            this.btndolbuy.BackColor = System.Drawing.Color.Gainsboro;
            this.btndolbuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndolbuy.Location = new System.Drawing.Point(542, 154);
            this.btndolbuy.Name = "btndolbuy";
            this.btndolbuy.Size = new System.Drawing.Size(48, 33);
            this.btndolbuy.TabIndex = 10;
            this.btndolbuy.Text = "...";
            this.btndolbuy.UseVisualStyleBackColor = false;
            this.btndolbuy.Click += new System.EventHandler(this.btndolbuy_Click);
            // 
            // btndolsale
            // 
            this.btndolsale.BackColor = System.Drawing.Color.Gainsboro;
            this.btndolsale.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndolsale.Location = new System.Drawing.Point(542, 213);
            this.btndolsale.Name = "btndolsale";
            this.btndolsale.Size = new System.Drawing.Size(48, 33);
            this.btndolsale.TabIndex = 11;
            this.btndolsale.Text = "...";
            this.btndolsale.UseVisualStyleBackColor = false;
            this.btndolsale.Click += new System.EventHandler(this.btndolsale_Click);
            // 
            // btneursell
            // 
            this.btneursell.BackColor = System.Drawing.Color.Gainsboro;
            this.btneursell.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btneursell.Location = new System.Drawing.Point(542, 374);
            this.btneursell.Name = "btneursell";
            this.btneursell.Size = new System.Drawing.Size(48, 33);
            this.btneursell.TabIndex = 13;
            this.btneursell.Text = "...";
            this.btneursell.UseVisualStyleBackColor = false;
            this.btneursell.Click += new System.EventHandler(this.btneursell_Click);
            // 
            // btneurbuy
            // 
            this.btneurbuy.BackColor = System.Drawing.Color.Gainsboro;
            this.btneurbuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btneurbuy.Location = new System.Drawing.Point(542, 315);
            this.btneurbuy.Name = "btneurbuy";
            this.btneurbuy.Size = new System.Drawing.Size(48, 33);
            this.btneurbuy.TabIndex = 12;
            this.btneurbuy.Text = "...";
            this.btneurbuy.UseVisualStyleBackColor = false;
            this.btneurbuy.Click += new System.EventHandler(this.btneurbuy_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Wide Latin", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.SteelBlue;
            this.label13.Location = new System.Drawing.Point(281, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1156, 46);
            this.label13.TabIndex = 14;
            this.label13.Text = "SHAKHAE EXCHANGE CENTER";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(989, 474);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(720, 308);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tLDataGridViewTextBoxColumn,
            this.eURDataGridViewTextBoxColumn,
            this.dOLLDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblMonneyBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(714, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // db_ExchangeDataSet
            // 
            this.db_ExchangeDataSet.DataSetName = "Db_ExchangeDataSet";
            this.db_ExchangeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMonneyBindingSource
            // 
            this.tblMonneyBindingSource.DataMember = "Tbl_Monney";
            this.tblMonneyBindingSource.DataSource = this.db_ExchangeDataSet;
            // 
            // tbl_MonneyTableAdapter
            // 
            this.tbl_MonneyTableAdapter.ClearBeforeFill = true;
            // 
            // tLDataGridViewTextBoxColumn
            // 
            this.tLDataGridViewTextBoxColumn.DataPropertyName = "TL";
            this.tLDataGridViewTextBoxColumn.HeaderText = "TL";
            this.tLDataGridViewTextBoxColumn.Name = "tLDataGridViewTextBoxColumn";
            // 
            // eURDataGridViewTextBoxColumn
            // 
            this.eURDataGridViewTextBoxColumn.DataPropertyName = "EUR";
            this.eURDataGridViewTextBoxColumn.HeaderText = "EUR";
            this.eURDataGridViewTextBoxColumn.Name = "eURDataGridViewTextBoxColumn";
            // 
            // dOLLDataGridViewTextBoxColumn
            // 
            this.dOLLDataGridViewTextBoxColumn.DataPropertyName = "DOLL";
            this.dOLLDataGridViewTextBoxColumn.HeaderText = "DOLL";
            this.dOLLDataGridViewTextBoxColumn.Name = "dOLLDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1721, 870);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btneursell);
            this.Controls.Add(this.btneurbuy);
            this.Controls.Add(this.btndolsale);
            this.Controls.Add(this.btndolbuy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbleursell);
            this.Controls.Add(this.lbldolsell);
            this.Controls.Add(this.lbleurbuy);
            this.Controls.Add(this.lbldollbuy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Currency_Exchange";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ExchangeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMonneyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbldollbuy;
        private System.Windows.Forms.Label lbleurbuy;
        private System.Windows.Forms.Label lbldolsell;
        private System.Windows.Forms.Label lbleursell;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtremaind;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtquant;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtrate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btndolbuy;
        private System.Windows.Forms.Button btnnsale;
        private System.Windows.Forms.Button btndolsale;
        private System.Windows.Forms.Button btneursell;
        private System.Windows.Forms.Button btneurbuy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Db_ExchangeDataSet db_ExchangeDataSet;
        private System.Windows.Forms.BindingSource tblMonneyBindingSource;
        private Db_ExchangeDataSetTableAdapters.Tbl_MonneyTableAdapter tbl_MonneyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eURDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOLLDataGridViewTextBoxColumn;
    }
}

