namespace cpractice
{
    partial class Form2
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
            System.Windows.Forms.Label nAMELabel;
            System.Windows.Forms.Label gENDERLabel;
            System.Windows.Forms.Label dOBLabel;
            System.Windows.Forms.Label aDDRESSLabel;
            System.Windows.Forms.Label pHONE_NOLabel;
            System.Windows.Forms.Label eMAILLabel;
            System.Windows.Forms.Label pASSWORDLabel;
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.library = new cpractice.library();
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTTableAdapter = new cpractice.libraryTableAdapters.STUDENTTableAdapter();
            this.tableAdapterManager = new cpractice.libraryTableAdapters.TableAdapterManager();
            this.nAMETextBox = new System.Windows.Forms.TextBox();
            this.dOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.aDDRESSTextBox = new System.Windows.Forms.TextBox();
            this.pHONE_NOTextBox = new System.Windows.Forms.TextBox();
            this.eMAILTextBox = new System.Windows.Forms.TextBox();
            this.pASSWORDTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            nAMELabel = new System.Windows.Forms.Label();
            gENDERLabel = new System.Windows.Forms.Label();
            dOBLabel = new System.Windows.Forms.Label();
            aDDRESSLabel = new System.Windows.Forms.Label();
            pHONE_NOLabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            pASSWORDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.library)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // nAMELabel
            // 
            nAMELabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            nAMELabel.AutoSize = true;
            nAMELabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nAMELabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            nAMELabel.Location = new System.Drawing.Point(38, 13);
            nAMELabel.Name = "nAMELabel";
            nAMELabel.Size = new System.Drawing.Size(49, 17);
            nAMELabel.TabIndex = 20;
            nAMELabel.Text = "NAME:";
            // 
            // gENDERLabel
            // 
            gENDERLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            gENDERLabel.AutoSize = true;
            gENDERLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gENDERLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            gENDERLabel.Location = new System.Drawing.Point(354, 13);
            gENDERLabel.Name = "gENDERLabel";
            gENDERLabel.Size = new System.Drawing.Size(62, 17);
            gENDERLabel.TabIndex = 22;
            gENDERLabel.Text = "GENDER:";
            // 
            // dOBLabel
            // 
            dOBLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            dOBLabel.AutoSize = true;
            dOBLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dOBLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dOBLabel.Location = new System.Drawing.Point(20, 56);
            dOBLabel.Name = "dOBLabel";
            dOBLabel.Size = new System.Drawing.Size(67, 17);
            dOBLabel.TabIndex = 24;
            dOBLabel.Text = "Reg Date:";
            // 
            // aDDRESSLabel
            // 
            aDDRESSLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            aDDRESSLabel.AutoSize = true;
            aDDRESSLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aDDRESSLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            aDDRESSLabel.Location = new System.Drawing.Point(347, 99);
            aDDRESSLabel.Name = "aDDRESSLabel";
            aDDRESSLabel.Size = new System.Drawing.Size(69, 17);
            aDDRESSLabel.TabIndex = 26;
            aDDRESSLabel.Text = "ADDRESS:";
            aDDRESSLabel.Click += new System.EventHandler(this.aDDRESSLabel_Click);
            // 
            // pHONE_NOLabel
            // 
            pHONE_NOLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            pHONE_NOLabel.AutoSize = true;
            pHONE_NOLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pHONE_NOLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            pHONE_NOLabel.Location = new System.Drawing.Point(7, 99);
            pHONE_NOLabel.Name = "pHONE_NOLabel";
            pHONE_NOLabel.Size = new System.Drawing.Size(80, 17);
            pHONE_NOLabel.TabIndex = 28;
            pHONE_NOLabel.Text = "PHONE NO:";
            // 
            // eMAILLabel
            // 
            eMAILLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            eMAILLabel.AutoSize = true;
            eMAILLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eMAILLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            eMAILLabel.Location = new System.Drawing.Point(366, 56);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(50, 17);
            eMAILLabel.TabIndex = 30;
            eMAILLabel.Text = "EMAIL:";
            // 
            // pASSWORDLabel
            // 
            pASSWORDLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            pASSWORDLabel.AutoSize = true;
            pASSWORDLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pASSWORDLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            pASSWORDLabel.Location = new System.Drawing.Point(4, 142);
            pASSWORDLabel.Name = "pASSWORDLabel";
            pASSWORDLabel.Size = new System.Drawing.Size(83, 17);
            pASSWORDLabel.TabIndex = 32;
            pASSWORDLabel.Text = "PASSWORD:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(202, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "STUDENT REGISTRTAION FORM";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 42);
            this.button1.TabIndex = 15;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button2.Location = new System.Drawing.Point(107, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 42);
            this.button2.TabIndex = 16;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button3.Location = new System.Drawing.Point(210, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 42);
            this.button3.TabIndex = 17;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // library
            // 
            this.library.DataSetName = "library";
            this.library.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTUDENTBindingSource
            // 
            this.sTUDENTBindingSource.DataMember = "STUDENT";
            this.sTUDENTBindingSource.DataSource = this.library;
            // 
            // sTUDENTTableAdapter
            // 
            this.sTUDENTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKSTableAdapter = null;
            this.tableAdapterManager.BORROWTableAdapter = null;
            this.tableAdapterManager.LIBRARIANTableAdapter = null;
            this.tableAdapterManager.PUBLISHERTableAdapter = null;
            this.tableAdapterManager.STUDENTTableAdapter = this.sTUDENTTableAdapter;
            this.tableAdapterManager.UpdateOrder = cpractice.libraryTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nAMETextBox
            // 
            this.nAMETextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTUDENTBindingSource, "NAME", true));
            this.nAMETextBox.Location = new System.Drawing.Point(93, 3);
            this.nAMETextBox.Name = "nAMETextBox";
            this.nAMETextBox.Size = new System.Drawing.Size(245, 20);
            this.nAMETextBox.TabIndex = 21;
            this.nAMETextBox.TextChanged += new System.EventHandler(this.nAMETextBox_TextChanged);
            // 
            // dOBDateTimePicker
            // 
            this.dOBDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dOBDateTimePicker.CustomFormat = "dd-MMMM-yyyy";
            this.dOBDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sTUDENTBindingSource, "DOB", true));
            this.dOBDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dOBDateTimePicker.Location = new System.Drawing.Point(93, 46);
            this.dOBDateTimePicker.Name = "dOBDateTimePicker";
            this.dOBDateTimePicker.Size = new System.Drawing.Size(245, 20);
            this.dOBDateTimePicker.TabIndex = 25;
            // 
            // aDDRESSTextBox
            // 
            this.aDDRESSTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aDDRESSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTUDENTBindingSource, "ADDRESS", true));
            this.aDDRESSTextBox.Location = new System.Drawing.Point(422, 89);
            this.aDDRESSTextBox.Multiline = true;
            this.aDDRESSTextBox.Name = "aDDRESSTextBox";
            this.aDDRESSTextBox.Size = new System.Drawing.Size(263, 37);
            this.aDDRESSTextBox.TabIndex = 27;
            // 
            // pHONE_NOTextBox
            // 
            this.pHONE_NOTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pHONE_NOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTUDENTBindingSource, "PHONE_NO", true));
            this.pHONE_NOTextBox.Location = new System.Drawing.Point(93, 89);
            this.pHONE_NOTextBox.Name = "pHONE_NOTextBox";
            this.pHONE_NOTextBox.Size = new System.Drawing.Size(245, 20);
            this.pHONE_NOTextBox.TabIndex = 29;
            // 
            // eMAILTextBox
            // 
            this.eMAILTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTUDENTBindingSource, "EMAIL", true));
            this.eMAILTextBox.Location = new System.Drawing.Point(422, 46);
            this.eMAILTextBox.Name = "eMAILTextBox";
            this.eMAILTextBox.Size = new System.Drawing.Size(263, 20);
            this.eMAILTextBox.TabIndex = 31;
            // 
            // pASSWORDTextBox
            // 
            this.pASSWORDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pASSWORDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTUDENTBindingSource, "PASSWORD", true));
            this.pASSWORDTextBox.Location = new System.Drawing.Point(93, 132);
            this.pASSWORDTextBox.Name = "pASSWORDTextBox";
            this.pASSWORDTextBox.Size = new System.Drawing.Size(245, 20);
            this.pASSWORDTextBox.TabIndex = 33;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(422, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(263, 21);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(690, 47);
            this.tableLayoutPanel1.TabIndex = 35;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.22674F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.62791F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.48256F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.95349F));
            this.tableLayoutPanel2.Controls.Add(nAMELabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.eMAILTextBox, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.aDDRESSTextBox, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.nAMETextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(eMAILLabel, 2, 1);
            this.tableLayoutPanel2.Controls.Add(dOBLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 3, 0);
            this.tableLayoutPanel2.Controls.Add(aDDRESSLabel, 2, 2);
            this.tableLayoutPanel2.Controls.Add(pHONE_NOLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(gENDERLabel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.dOBDateTimePicker, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.pASSWORDTextBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.pHONE_NOTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(pASSWORDLabel, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 100);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(688, 173);
            this.tableLayoutPanel2.TabIndex = 36;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(381, 290);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(321, 48);
            this.tableLayoutPanel3.TabIndex = 37;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(714, 359);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.library)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private library library;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource;
        private libraryTableAdapters.STUDENTTableAdapter sTUDENTTableAdapter;
        private libraryTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nAMETextBox;
        private System.Windows.Forms.DateTimePicker dOBDateTimePicker;
        private System.Windows.Forms.TextBox aDDRESSTextBox;
        private System.Windows.Forms.TextBox pHONE_NOTextBox;
        private System.Windows.Forms.TextBox eMAILTextBox;
        private System.Windows.Forms.TextBox pASSWORDTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}