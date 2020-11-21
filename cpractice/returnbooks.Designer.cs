namespace cpractice
{
    partial class returnbooks
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
            System.Windows.Forms.Label rETURN_DATELabel;
            System.Windows.Forms.Label rETURN_ACTUAL_DATELabel;
            System.Windows.Forms.Label fINELabel;
            System.Windows.Forms.Label sTUDENT_IDLabel;
            System.Windows.Forms.Label iSBNLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataSet2 = new cpractice.DataSet2();
            this.rETURNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rETURNTableAdapter = new cpractice.DataSet2TableAdapters.RETURNTableAdapter();
            this.tableAdapterManager = new cpractice.DataSet2TableAdapters.TableAdapterManager();
            this.rETURN_DATEDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rETURN_ACTUAL_DATEDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fINETextBox = new System.Windows.Forms.TextBox();
            this.sTUDENT_IDTextBox = new System.Windows.Forms.TextBox();
            this.iSBNTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            rETURN_DATELabel = new System.Windows.Forms.Label();
            rETURN_ACTUAL_DATELabel = new System.Windows.Forms.Label();
            fINELabel = new System.Windows.Forms.Label();
            sTUDENT_IDLabel = new System.Windows.Forms.Label();
            iSBNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rETURNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rETURN_DATELabel
            // 
            rETURN_DATELabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            rETURN_DATELabel.AutoSize = true;
            rETURN_DATELabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rETURN_DATELabel.Location = new System.Drawing.Point(17, 41);
            rETURN_DATELabel.Name = "rETURN_DATELabel";
            rETURN_DATELabel.Size = new System.Drawing.Size(99, 17);
            rETURN_DATELabel.TabIndex = 88;
            rETURN_DATELabel.Text = "RETURN DATE:";
            // 
            // rETURN_ACTUAL_DATELabel
            // 
            rETURN_ACTUAL_DATELabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            rETURN_ACTUAL_DATELabel.AutoSize = true;
            rETURN_ACTUAL_DATELabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rETURN_ACTUAL_DATELabel.Location = new System.Drawing.Point(292, 8);
            rETURN_ACTUAL_DATELabel.Name = "rETURN_ACTUAL_DATELabel";
            rETURN_ACTUAL_DATELabel.Size = new System.Drawing.Size(153, 17);
            rETURN_ACTUAL_DATELabel.TabIndex = 90;
            rETURN_ACTUAL_DATELabel.Text = "RETURN ACTUAL DATE:";
            // 
            // fINELabel
            // 
            fINELabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            fINELabel.AutoSize = true;
            fINELabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fINELabel.Location = new System.Drawing.Point(405, 74);
            fINELabel.Name = "fINELabel";
            fINELabel.Size = new System.Drawing.Size(40, 17);
            fINELabel.TabIndex = 92;
            fINELabel.Text = "FINE:";
            // 
            // sTUDENT_IDLabel
            // 
            sTUDENT_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            sTUDENT_IDLabel.AutoSize = true;
            sTUDENT_IDLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sTUDENT_IDLabel.Location = new System.Drawing.Point(356, 41);
            sTUDENT_IDLabel.Name = "sTUDENT_IDLabel";
            sTUDENT_IDLabel.Size = new System.Drawing.Size(89, 17);
            sTUDENT_IDLabel.TabIndex = 94;
            sTUDENT_IDLabel.Text = "STUDENT ID:";
            // 
            // iSBNLabel
            // 
            iSBNLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            iSBNLabel.AutoSize = true;
            iSBNLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iSBNLabel.Location = new System.Drawing.Point(75, 74);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(41, 17);
            iSBNLabel.TabIndex = 96;
            iSBNLabel.Text = "ISBN:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(220, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "RETURN BOOKS ";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(217, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 44);
            this.button4.TabIndex = 87;
            this.button4.Text = "CLOSE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(110, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 44);
            this.button2.TabIndex = 86;
            this.button2.Text = "UPDATE";
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
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 44);
            this.button1.TabIndex = 85;
            this.button1.Text = "RETURN BOOK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rETURNBindingSource
            // 
            this.rETURNBindingSource.DataMember = "RETURN";
            this.rETURNBindingSource.DataSource = this.dataSet2;
            // 
            // rETURNTableAdapter
            // 
            this.rETURNTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKSTableAdapter = null;
            this.tableAdapterManager.BORROWTableAdapter = null;
            this.tableAdapterManager.LIBRARIANTableAdapter = null;
            this.tableAdapterManager.PUBLISHERTableAdapter = null;
            this.tableAdapterManager.RETURNTableAdapter = this.rETURNTableAdapter;
            this.tableAdapterManager.STUDENTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = cpractice.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rETURN_DATEDateTimePicker
            // 
            this.rETURN_DATEDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rETURN_DATEDateTimePicker.CustomFormat = "dd-MMMM-yyyy";
            this.rETURN_DATEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rETURNBindingSource, "RETURN_DATE", true));
            this.rETURN_DATEDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rETURN_DATEDateTimePicker.Location = new System.Drawing.Point(122, 36);
            this.rETURN_DATEDateTimePicker.Name = "rETURN_DATEDateTimePicker";
            this.rETURN_DATEDateTimePicker.Size = new System.Drawing.Size(162, 20);
            this.rETURN_DATEDateTimePicker.TabIndex = 89;
            // 
            // rETURN_ACTUAL_DATEDateTimePicker
            // 
            this.rETURN_ACTUAL_DATEDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rETURN_ACTUAL_DATEDateTimePicker.CustomFormat = "dd-MMMM-yyyy";
            this.rETURN_ACTUAL_DATEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rETURNBindingSource, "RETURN_ACTUAL_DATE", true));
            this.rETURN_ACTUAL_DATEDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rETURN_ACTUAL_DATEDateTimePicker.Location = new System.Drawing.Point(451, 3);
            this.rETURN_ACTUAL_DATEDateTimePicker.Name = "rETURN_ACTUAL_DATEDateTimePicker";
            this.rETURN_ACTUAL_DATEDateTimePicker.Size = new System.Drawing.Size(168, 20);
            this.rETURN_ACTUAL_DATEDateTimePicker.TabIndex = 91;
            // 
            // fINETextBox
            // 
            this.fINETextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fINETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rETURNBindingSource, "FINE", true));
            this.fINETextBox.Location = new System.Drawing.Point(451, 69);
            this.fINETextBox.Name = "fINETextBox";
            this.fINETextBox.Size = new System.Drawing.Size(168, 20);
            this.fINETextBox.TabIndex = 93;
            // 
            // sTUDENT_IDTextBox
            // 
            this.sTUDENT_IDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sTUDENT_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rETURNBindingSource, "STUDENT_ID", true));
            this.sTUDENT_IDTextBox.Location = new System.Drawing.Point(451, 36);
            this.sTUDENT_IDTextBox.Name = "sTUDENT_IDTextBox";
            this.sTUDENT_IDTextBox.Size = new System.Drawing.Size(168, 20);
            this.sTUDENT_IDTextBox.TabIndex = 95;
            // 
            // iSBNTextBox
            // 
            this.iSBNTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iSBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rETURNBindingSource, "ISBN", true));
            this.iSBNTextBox.Location = new System.Drawing.Point(122, 69);
            this.iSBNTextBox.Name = "iSBNTextBox";
            this.iSBNTextBox.Size = new System.Drawing.Size(162, 20);
            this.iSBNTextBox.TabIndex = 97;
            this.iSBNTextBox.TextChanged += new System.EventHandler(this.iSBNTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 98;
            this.label1.Text = "LIBRARIN ID";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 99;
            this.label2.Text = "label2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 297);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(665, 117);
            this.dataGridView1.TabIndex = 100;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(665, 47);
            this.tableLayoutPanel1.TabIndex = 101;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.20152F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.94136F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.83201F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.05071F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(rETURN_DATELabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.sTUDENT_IDTextBox, 3, 1);
            this.tableLayoutPanel2.Controls.Add(sTUDENT_IDLabel, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.rETURN_ACTUAL_DATEDateTimePicker, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.fINETextBox, 3, 2);
            this.tableLayoutPanel2.Controls.Add(fINELabel, 2, 2);
            this.tableLayoutPanel2.Controls.Add(rETURN_ACTUAL_DATELabel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.rETURN_DATEDateTimePicker, 1, 1);
            this.tableLayoutPanel2.Controls.Add(iSBNLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.iSBNTextBox, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 89);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(665, 100);
            this.tableLayoutPanel2.TabIndex = 102;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.button4, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(325, 204);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(352, 50);
            this.tableLayoutPanel3.TabIndex = 103;
            // 
            // returnbooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(689, 426);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "returnbooks";
            this.Text = "returnbooks";
            this.Load += new System.EventHandler(this.returnbooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rETURNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource rETURNBindingSource;
        private DataSet2TableAdapters.RETURNTableAdapter rETURNTableAdapter;
        private DataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker rETURN_DATEDateTimePicker;
        private System.Windows.Forms.DateTimePicker rETURN_ACTUAL_DATEDateTimePicker;
        private System.Windows.Forms.TextBox fINETextBox;
        private System.Windows.Forms.TextBox sTUDENT_IDTextBox;
        private System.Windows.Forms.TextBox iSBNTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}