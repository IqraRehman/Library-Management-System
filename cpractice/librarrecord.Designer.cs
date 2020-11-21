namespace cpractice
{
    partial class librarrecord
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
            System.Windows.Forms.Label cNICLabel;
            System.Windows.Forms.Label nAMELabel;
            System.Windows.Forms.Label aDDRESSLabel;
            System.Windows.Forms.Label lIB_NOLabel;
            System.Windows.Forms.Label lIB_EMAILLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet2 = new cpractice.DataSet2();
            this.lIBRARIANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lIBRARIANTableAdapter = new cpractice.DataSet2TableAdapters.LIBRARIANTableAdapter();
            this.tableAdapterManager = new cpractice.DataSet2TableAdapters.TableAdapterManager();
            this.cNICTextBox = new System.Windows.Forms.TextBox();
            this.nAMETextBox = new System.Windows.Forms.TextBox();
            this.aDDRESSTextBox = new System.Windows.Forms.TextBox();
            this.lIB_NOTextBox = new System.Windows.Forms.TextBox();
            this.lIB_EMAILTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            cNICLabel = new System.Windows.Forms.Label();
            nAMELabel = new System.Windows.Forms.Label();
            aDDRESSLabel = new System.Windows.Forms.Label();
            lIB_NOLabel = new System.Windows.Forms.Label();
            lIB_EMAILLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBRARIANBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cNICLabel
            // 
            cNICLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            cNICLabel.AutoSize = true;
            cNICLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cNICLabel.Location = new System.Drawing.Point(35, 9);
            cNICLabel.Name = "cNICLabel";
            cNICLabel.Size = new System.Drawing.Size(54, 21);
            cNICLabel.TabIndex = 3;
            cNICLabel.Text = "CNIC:";
            // 
            // nAMELabel
            // 
            nAMELabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            nAMELabel.AutoSize = true;
            nAMELabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nAMELabel.Location = new System.Drawing.Point(26, 48);
            nAMELabel.Name = "nAMELabel";
            nAMELabel.Size = new System.Drawing.Size(63, 21);
            nAMELabel.TabIndex = 5;
            nAMELabel.Text = "NAME:";
            // 
            // aDDRESSLabel
            // 
            aDDRESSLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            aDDRESSLabel.AutoSize = true;
            aDDRESSLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aDDRESSLabel.Location = new System.Drawing.Point(3, 87);
            aDDRESSLabel.Name = "aDDRESSLabel";
            aDDRESSLabel.Size = new System.Drawing.Size(86, 21);
            aDDRESSLabel.TabIndex = 7;
            aDDRESSLabel.Text = "ADDRESS:";
            // 
            // lIB_NOLabel
            // 
            lIB_NOLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lIB_NOLabel.AutoSize = true;
            lIB_NOLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lIB_NOLabel.Location = new System.Drawing.Point(321, 9);
            lIB_NOLabel.Name = "lIB_NOLabel";
            lIB_NOLabel.Size = new System.Drawing.Size(102, 21);
            lIB_NOLabel.TabIndex = 9;
            lIB_NOLabel.Text = "PHONE NO:";
            // 
            // lIB_EMAILLabel
            // 
            lIB_EMAILLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lIB_EMAILLabel.AutoSize = true;
            lIB_EMAILLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lIB_EMAILLabel.Location = new System.Drawing.Point(360, 48);
            lIB_EMAILLabel.Name = "lIB_EMAILLabel";
            lIB_EMAILLabel.Size = new System.Drawing.Size(63, 21);
            lIB_EMAILLabel.TabIndex = 11;
            lIB_EMAILLabel.Text = "EMAIL:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(198, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIBRARIAN RECORD";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(657, 132);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lIBRARIANBindingSource
            // 
            this.lIBRARIANBindingSource.DataMember = "LIBRARIAN";
            this.lIBRARIANBindingSource.DataSource = this.dataSet2;
            // 
            // lIBRARIANTableAdapter
            // 
            this.lIBRARIANTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKSTableAdapter = null;
            this.tableAdapterManager.BORROWTableAdapter = null;
            this.tableAdapterManager.LIBRARIANTableAdapter = this.lIBRARIANTableAdapter;
            this.tableAdapterManager.PUBLISHERTableAdapter = null;
            this.tableAdapterManager.RETURNTableAdapter = null;
            this.tableAdapterManager.STUDENTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = cpractice.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cNICTextBox
            // 
            this.cNICTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cNICTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lIBRARIANBindingSource, "CNIC", true));
            this.cNICTextBox.Location = new System.Drawing.Point(95, 3);
            this.cNICTextBox.Name = "cNICTextBox";
            this.cNICTextBox.Size = new System.Drawing.Size(218, 20);
            this.cNICTextBox.TabIndex = 4;
            // 
            // nAMETextBox
            // 
            this.nAMETextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lIBRARIANBindingSource, "NAME", true));
            this.nAMETextBox.Location = new System.Drawing.Point(95, 42);
            this.nAMETextBox.Name = "nAMETextBox";
            this.nAMETextBox.Size = new System.Drawing.Size(218, 20);
            this.nAMETextBox.TabIndex = 6;
            // 
            // aDDRESSTextBox
            // 
            this.aDDRESSTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aDDRESSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lIBRARIANBindingSource, "ADDRESS", true));
            this.aDDRESSTextBox.Location = new System.Drawing.Point(95, 81);
            this.aDDRESSTextBox.Multiline = true;
            this.aDDRESSTextBox.Name = "aDDRESSTextBox";
            this.aDDRESSTextBox.Size = new System.Drawing.Size(218, 33);
            this.aDDRESSTextBox.TabIndex = 8;
            // 
            // lIB_NOTextBox
            // 
            this.lIB_NOTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lIB_NOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lIBRARIANBindingSource, "LIB_NO", true));
            this.lIB_NOTextBox.Location = new System.Drawing.Point(429, 3);
            this.lIB_NOTextBox.Name = "lIB_NOTextBox";
            this.lIB_NOTextBox.Size = new System.Drawing.Size(200, 20);
            this.lIB_NOTextBox.TabIndex = 10;
            // 
            // lIB_EMAILTextBox
            // 
            this.lIB_EMAILTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lIB_EMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lIBRARIANBindingSource, "LIB_EMAIL", true));
            this.lIB_EMAILTextBox.Location = new System.Drawing.Point(429, 42);
            this.lIB_EMAILTextBox.Name = "lIB_EMAILTextBox";
            this.lIB_EMAILTextBox.Size = new System.Drawing.Size(200, 20);
            this.lIB_EMAILTextBox.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(171, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 51);
            this.button2.TabIndex = 24;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(83, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 51);
            this.button1.TabIndex = 23;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(657, 39);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.56456F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.43544F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.48031F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.59843F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.Controls.Add(cNICLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cNICTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(nAMELabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.nAMETextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(aDDRESSLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lIB_EMAILTextBox, 3, 1);
            this.tableLayoutPanel2.Controls.Add(lIB_EMAILLabel, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lIB_NOTextBox, 3, 0);
            this.tableLayoutPanel2.Controls.Add(lIB_NOLabel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.aDDRESSTextBox, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 112);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(657, 117);
            this.tableLayoutPanel2.TabIndex = 27;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.84946F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.15054F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(390, 232);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(279, 57);
            this.tableLayoutPanel3.TabIndex = 28;
            // 
            // librarrecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(681, 452);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "librarrecord";
            this.ShowIcon = false;
            this.Text = "librarrecord";
            this.Load += new System.EventHandler(this.librarrecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBRARIANBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource lIBRARIANBindingSource;
        private DataSet2TableAdapters.LIBRARIANTableAdapter lIBRARIANTableAdapter;
        private DataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cNICTextBox;
        private System.Windows.Forms.TextBox nAMETextBox;
        private System.Windows.Forms.TextBox aDDRESSTextBox;
        private System.Windows.Forms.TextBox lIB_NOTextBox;
        private System.Windows.Forms.TextBox lIB_EMAILTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}