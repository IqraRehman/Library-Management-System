namespace cpractice
{
    partial class libraryissue1
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
            System.Windows.Forms.Label iSSUE_DATELabel;
            System.Windows.Forms.Label rETURN_ACTUAL_DATELabel;
            System.Windows.Forms.Label sTUDENT_IDLabel;
            System.Windows.Forms.Label iSBNLabel;
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataSet2 = new cpractice.DataSet2();
            this.bORROWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bORROWTableAdapter = new cpractice.DataSet2TableAdapters.BORROWTableAdapter();
            this.tableAdapterManager = new cpractice.DataSet2TableAdapters.TableAdapterManager();
            this.iSSUE_DATEDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rETURN_ACTUAL_DATEDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sTUDENT_IDTextBox = new System.Windows.Forms.TextBox();
            this.iSBNTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            iSSUE_DATELabel = new System.Windows.Forms.Label();
            rETURN_ACTUAL_DATELabel = new System.Windows.Forms.Label();
            sTUDENT_IDLabel = new System.Windows.Forms.Label();
            iSBNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bORROWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // iSSUE_DATELabel
            // 
            iSSUE_DATELabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            iSSUE_DATELabel.AutoSize = true;
            iSSUE_DATELabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iSSUE_DATELabel.Location = new System.Drawing.Point(32, 35);
            iSSUE_DATELabel.Name = "iSSUE_DATELabel";
            iSSUE_DATELabel.Size = new System.Drawing.Size(83, 17);
            iSSUE_DATELabel.TabIndex = 85;
            iSSUE_DATELabel.Text = "ISSUE DATE:";
            // 
            // rETURN_ACTUAL_DATELabel
            // 
            rETURN_ACTUAL_DATELabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            rETURN_ACTUAL_DATELabel.AutoSize = true;
            rETURN_ACTUAL_DATELabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rETURN_ACTUAL_DATELabel.Location = new System.Drawing.Point(16, 64);
            rETURN_ACTUAL_DATELabel.Name = "rETURN_ACTUAL_DATELabel";
            rETURN_ACTUAL_DATELabel.Size = new System.Drawing.Size(99, 17);
            rETURN_ACTUAL_DATELabel.TabIndex = 87;
            rETURN_ACTUAL_DATELabel.Text = "RETURN DATE:";
            // 
            // sTUDENT_IDLabel
            // 
            sTUDENT_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            sTUDENT_IDLabel.AutoSize = true;
            sTUDENT_IDLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sTUDENT_IDLabel.Location = new System.Drawing.Point(324, 6);
            sTUDENT_IDLabel.Name = "sTUDENT_IDLabel";
            sTUDENT_IDLabel.Size = new System.Drawing.Size(89, 17);
            sTUDENT_IDLabel.TabIndex = 89;
            sTUDENT_IDLabel.Text = "STUDENT ID:";
            // 
            // iSBNLabel
            // 
            iSBNLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            iSBNLabel.AutoSize = true;
            iSBNLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iSBNLabel.Location = new System.Drawing.Point(372, 35);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(41, 17);
            iSBNLabel.TabIndex = 91;
            iSBNLabel.Text = "ISBN:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(230, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "ISSUE BOOKS";
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
            this.button4.Location = new System.Drawing.Point(196, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 40);
            this.button4.TabIndex = 84;
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
            this.button2.Location = new System.Drawing.Point(100, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 40);
            this.button2.TabIndex = 83;
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
            this.button1.Size = new System.Drawing.Size(91, 40);
            this.button1.TabIndex = 82;
            this.button1.Text = "ISSUE BOOKS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bORROWBindingSource
            // 
            this.bORROWBindingSource.DataMember = "BORROW";
            this.bORROWBindingSource.DataSource = this.dataSet2;
            // 
            // bORROWTableAdapter
            // 
            this.bORROWTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKSTableAdapter = null;
            this.tableAdapterManager.BORROWTableAdapter = this.bORROWTableAdapter;
            this.tableAdapterManager.LIBRARIANTableAdapter = null;
            this.tableAdapterManager.PUBLISHERTableAdapter = null;
            this.tableAdapterManager.RETURNTableAdapter = null;
            this.tableAdapterManager.STUDENTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = cpractice.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iSSUE_DATEDateTimePicker
            // 
            this.iSSUE_DATEDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iSSUE_DATEDateTimePicker.CustomFormat = "dd-MMMM-yyyy";
            this.iSSUE_DATEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bORROWBindingSource, "ISSUE_DATE", true));
            this.iSSUE_DATEDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.iSSUE_DATEDateTimePicker.Location = new System.Drawing.Point(121, 32);
            this.iSSUE_DATEDateTimePicker.Name = "iSSUE_DATEDateTimePicker";
            this.iSSUE_DATEDateTimePicker.Size = new System.Drawing.Size(186, 20);
            this.iSSUE_DATEDateTimePicker.TabIndex = 86;
            // 
            // rETURN_ACTUAL_DATEDateTimePicker
            // 
            this.rETURN_ACTUAL_DATEDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rETURN_ACTUAL_DATEDateTimePicker.CustomFormat = "dd-MMMM-yyyy";
            this.rETURN_ACTUAL_DATEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bORROWBindingSource, "RETURN_ACTUAL_DATE", true));
            this.rETURN_ACTUAL_DATEDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rETURN_ACTUAL_DATEDateTimePicker.Location = new System.Drawing.Point(121, 61);
            this.rETURN_ACTUAL_DATEDateTimePicker.Name = "rETURN_ACTUAL_DATEDateTimePicker";
            this.rETURN_ACTUAL_DATEDateTimePicker.Size = new System.Drawing.Size(186, 20);
            this.rETURN_ACTUAL_DATEDateTimePicker.TabIndex = 88;
            // 
            // sTUDENT_IDTextBox
            // 
            this.sTUDENT_IDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sTUDENT_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bORROWBindingSource, "STUDENT_ID", true));
            this.sTUDENT_IDTextBox.Location = new System.Drawing.Point(419, 3);
            this.sTUDENT_IDTextBox.Name = "sTUDENT_IDTextBox";
            this.sTUDENT_IDTextBox.Size = new System.Drawing.Size(199, 20);
            this.sTUDENT_IDTextBox.TabIndex = 90;
            this.sTUDENT_IDTextBox.TextChanged += new System.EventHandler(this.sTUDENT_IDTextBox_TextChanged);
            // 
            // iSBNTextBox
            // 
            this.iSBNTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iSBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bORROWBindingSource, "ISBN", true));
            this.iSBNTextBox.Location = new System.Drawing.Point(419, 32);
            this.iSBNTextBox.Name = "iSBNTextBox";
            this.iSBNTextBox.Size = new System.Drawing.Size(199, 20);
            this.iSBNTextBox.TabIndex = 92;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(648, 96);
            this.dataGridView1.TabIndex = 93;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 94;
            this.label1.Text = "LIBRARIAN ID";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 95;
            this.label2.Text = "label2";
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(648, 51);
            this.tableLayoutPanel1.TabIndex = 96;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.95238F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.06539F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.01435F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(iSSUE_DATELabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.iSBNTextBox, 3, 1);
            this.tableLayoutPanel2.Controls.Add(iSBNLabel, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.sTUDENT_IDTextBox, 3, 0);
            this.tableLayoutPanel2.Controls.Add(sTUDENT_IDLabel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.rETURN_ACTUAL_DATEDateTimePicker, 1, 2);
            this.tableLayoutPanel2.Controls.Add(rETURN_ACTUAL_DATELabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.iSSUE_DATEDateTimePicker, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 97);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(648, 87);
            this.tableLayoutPanel2.TabIndex = 97;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.25907F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.74093F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.button4, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(345, 203);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(315, 46);
            this.tableLayoutPanel3.TabIndex = 98;
            // 
            // libraryissue1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(672, 377);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "libraryissue1";
            this.Text = "libraryissue1";
            this.Load += new System.EventHandler(this.libraryissue1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bORROWBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource bORROWBindingSource;
        private DataSet2TableAdapters.BORROWTableAdapter bORROWTableAdapter;
        private DataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker iSSUE_DATEDateTimePicker;
        private System.Windows.Forms.DateTimePicker rETURN_ACTUAL_DATEDateTimePicker;
        private System.Windows.Forms.TextBox sTUDENT_IDTextBox;
        private System.Windows.Forms.TextBox iSBNTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}