namespace cpractice
{
    partial class profilestudent
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
            System.Windows.Forms.Label sTUDENT_IDLabel;
            System.Windows.Forms.Label nAMELabel;
            System.Windows.Forms.Label gENDERLabel;
            System.Windows.Forms.Label dOBLabel;
            System.Windows.Forms.Label aDDRESSLabel;
            System.Windows.Forms.Label pHONE_NOLabel;
            System.Windows.Forms.Label eMAILLabel;
            this.dataSet2 = new cpractice.DataSet2();
            this.sTUDENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTTableAdapter1 = new cpractice.DataSet2TableAdapters.STUDENTTableAdapter();
            this.tableAdapterManager1 = new cpractice.DataSet2TableAdapters.TableAdapterManager();
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library = new cpractice.library();
            this.sTUDENTTableAdapter = new cpractice.libraryTableAdapters.STUDENTTableAdapter();
            this.tableAdapterManager = new cpractice.libraryTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nAMETextBox = new System.Windows.Forms.TextBox();
            this.dOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.aDDRESSTextBox = new System.Windows.Forms.TextBox();
            this.pHONE_NOTextBox = new System.Windows.Forms.TextBox();
            this.eMAILTextBox = new System.Windows.Forms.TextBox();
            this.tableAdapterManager2 = new cpractice.DataSet1TableAdapters.TableAdapterManager();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            sTUDENT_IDLabel = new System.Windows.Forms.Label();
            nAMELabel = new System.Windows.Forms.Label();
            gENDERLabel = new System.Windows.Forms.Label();
            dOBLabel = new System.Windows.Forms.Label();
            aDDRESSLabel = new System.Windows.Forms.Label();
            pHONE_NOLabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // sTUDENT_IDLabel
            // 
            sTUDENT_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            sTUDENT_IDLabel.AutoSize = true;
            sTUDENT_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sTUDENT_IDLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            sTUDENT_IDLabel.Location = new System.Drawing.Point(334, 6);
            sTUDENT_IDLabel.Name = "sTUDENT_IDLabel";
            sTUDENT_IDLabel.Size = new System.Drawing.Size(137, 24);
            sTUDENT_IDLabel.TabIndex = 3;
            sTUDENT_IDLabel.Text = "STUDENT ID:";
            // 
            // nAMELabel
            // 
            nAMELabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            nAMELabel.AutoSize = true;
            nAMELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nAMELabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            nAMELabel.Location = new System.Drawing.Point(59, 10);
            nAMELabel.Name = "nAMELabel";
            nAMELabel.Size = new System.Drawing.Size(55, 16);
            nAMELabel.TabIndex = 5;
            nAMELabel.Text = "NAME:";
            // 
            // gENDERLabel
            // 
            gENDERLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            gENDERLabel.AutoSize = true;
            gENDERLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gENDERLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            gENDERLabel.Location = new System.Drawing.Point(38, 48);
            gENDERLabel.Name = "gENDERLabel";
            gENDERLabel.Size = new System.Drawing.Size(76, 16);
            gENDERLabel.TabIndex = 7;
            gENDERLabel.Text = "GENDER:";
            // 
            // dOBLabel
            // 
            dOBLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            dOBLabel.AutoSize = true;
            dOBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dOBLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dOBLabel.Location = new System.Drawing.Point(25, 86);
            dOBLabel.Name = "dOBLabel";
            dOBLabel.Size = new System.Drawing.Size(89, 16);
            dOBLabel.TabIndex = 9;
            dOBLabel.Text = "REG DATE:";
            // 
            // aDDRESSLabel
            // 
            aDDRESSLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            aDDRESSLabel.AutoSize = true;
            aDDRESSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aDDRESSLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            aDDRESSLabel.Location = new System.Drawing.Point(427, 86);
            aDDRESSLabel.Name = "aDDRESSLabel";
            aDDRESSLabel.Size = new System.Drawing.Size(85, 16);
            aDDRESSLabel.TabIndex = 11;
            aDDRESSLabel.Text = "ADDRESS:";
            // 
            // pHONE_NOLabel
            // 
            pHONE_NOLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            pHONE_NOLabel.AutoSize = true;
            pHONE_NOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pHONE_NOLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            pHONE_NOLabel.Location = new System.Drawing.Point(421, 48);
            pHONE_NOLabel.Name = "pHONE_NOLabel";
            pHONE_NOLabel.Size = new System.Drawing.Size(91, 16);
            pHONE_NOLabel.TabIndex = 13;
            pHONE_NOLabel.Text = "PHONE NO:";
            // 
            // eMAILLabel
            // 
            eMAILLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            eMAILLabel.AutoSize = true;
            eMAILLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eMAILLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            eMAILLabel.Location = new System.Drawing.Point(456, 10);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(56, 16);
            eMAILLabel.TabIndex = 15;
            eMAILLabel.Text = "EMAIL:";
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTUDENTBindingSource1
            // 
            this.sTUDENTBindingSource1.DataMember = "STUDENT";
            this.sTUDENTBindingSource1.DataSource = this.dataSet2;
            // 
            // sTUDENTTableAdapter1
            // 
            this.sTUDENTTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BOOKSTableAdapter = null;
            this.tableAdapterManager1.BORROWTableAdapter = null;
            this.tableAdapterManager1.LIBRARIANTableAdapter = null;
            this.tableAdapterManager1.PUBLISHERTableAdapter = null;
            this.tableAdapterManager1.RETURNTableAdapter = null;
            this.tableAdapterManager1.STUDENTTableAdapter = this.sTUDENTTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = cpractice.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sTUDENTBindingSource
            // 
            this.sTUDENTBindingSource.DataMember = "STUDENT";
            this.sTUDENTBindingSource.DataSource = this.library;
            // 
            // library
            // 
            this.library.DataSetName = "library";
            this.library.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(274, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "STUDENT INFORMATION";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nAMETextBox
            // 
            this.nAMETextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTUDENTBindingSource1, "NAME", true));
            this.nAMETextBox.Location = new System.Drawing.Point(120, 3);
            this.nAMETextBox.Name = "nAMETextBox";
            this.nAMETextBox.Size = new System.Drawing.Size(278, 20);
            this.nAMETextBox.TabIndex = 6;
            this.nAMETextBox.TextChanged += new System.EventHandler(this.nAMETextBox_TextChanged);
            // 
            // dOBDateTimePicker
            // 
            this.dOBDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dOBDateTimePicker.CustomFormat = "dd-MMMM-yyyy";
            this.dOBDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sTUDENTBindingSource1, "DOB", true));
            this.dOBDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dOBDateTimePicker.Location = new System.Drawing.Point(120, 78);
            this.dOBDateTimePicker.Name = "dOBDateTimePicker";
            this.dOBDateTimePicker.Size = new System.Drawing.Size(278, 20);
            this.dOBDateTimePicker.TabIndex = 10;
            this.dOBDateTimePicker.ValueChanged += new System.EventHandler(this.dOBDateTimePicker_ValueChanged);
            // 
            // aDDRESSTextBox
            // 
            this.aDDRESSTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aDDRESSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTUDENTBindingSource1, "ADDRESS", true));
            this.aDDRESSTextBox.Location = new System.Drawing.Point(518, 78);
            this.aDDRESSTextBox.Multiline = true;
            this.aDDRESSTextBox.Name = "aDDRESSTextBox";
            this.aDDRESSTextBox.Size = new System.Drawing.Size(284, 32);
            this.aDDRESSTextBox.TabIndex = 12;
            this.aDDRESSTextBox.TextChanged += new System.EventHandler(this.aDDRESSTextBox_TextChanged);
            // 
            // pHONE_NOTextBox
            // 
            this.pHONE_NOTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pHONE_NOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTUDENTBindingSource1, "PHONE_NO", true));
            this.pHONE_NOTextBox.Location = new System.Drawing.Point(518, 40);
            this.pHONE_NOTextBox.Name = "pHONE_NOTextBox";
            this.pHONE_NOTextBox.Size = new System.Drawing.Size(284, 20);
            this.pHONE_NOTextBox.TabIndex = 14;
            this.pHONE_NOTextBox.TextChanged += new System.EventHandler(this.pHONE_NOTextBox_TextChanged);
            // 
            // eMAILTextBox
            // 
            this.eMAILTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTUDENTBindingSource1, "EMAIL", true));
            this.eMAILTextBox.Location = new System.Drawing.Point(518, 3);
            this.eMAILTextBox.Name = "eMAILTextBox";
            this.eMAILTextBox.Size = new System.Drawing.Size(284, 20);
            this.eMAILTextBox.TabIndex = 16;
            this.eMAILTextBox.TextChanged += new System.EventHandler(this.eMAILTextBox_TextChanged);
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.Connection = null;
            this.tableAdapterManager2.STUDENTTableAdapter = null;
            this.tableAdapterManager2.UpdateOrder = cpractice.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(120, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 358);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(789, 80);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
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
            this.button2.Location = new System.Drawing.Point(103, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 40);
            this.button2.TabIndex = 22;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 9);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(805, 43);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(sTUDENT_IDLabel, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 58);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(805, 36);
            this.tableLayoutPanel2.TabIndex = 24;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.64089F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.35912F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.90062F));
            this.tableLayoutPanel3.Controls.Add(nAMELabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.nAMETextBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(gENDERLabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(dOBLabel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(eMAILLabel, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.pHONE_NOTextBox, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.eMAILTextBox, 3, 0);
            this.tableLayoutPanel3.Controls.Add(pHONE_NOLabel, 2, 1);
            this.tableLayoutPanel3.Controls.Add(aDDRESSLabel, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.dOBDateTimePicker, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.aDDRESSTextBox, 3, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 154);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0033F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.66336F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(805, 113);
            this.tableLayoutPanel3.TabIndex = 25;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(614, 286);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 46);
            this.tableLayoutPanel4.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(369, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(12, 100);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(805, 31);
            this.tableLayoutPanel5.TabIndex = 27;
            // 
            // profilestudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(829, 446);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "profilestudent";
            this.ShowIcon = false;
            this.Text = "profilestudent";
            this.Load += new System.EventHandler(this.profilestudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private library library;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource;
        private libraryTableAdapters.STUDENTTableAdapter sTUDENTTableAdapter;
        private libraryTableAdapters.TableAdapterManager tableAdapterManager;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource1;
        private DataSet2TableAdapters.STUDENTTableAdapter sTUDENTTableAdapter1;
        private DataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nAMETextBox;
        private System.Windows.Forms.DateTimePicker dOBDateTimePicker;
        private System.Windows.Forms.TextBox aDDRESSTextBox;
        private System.Windows.Forms.TextBox pHONE_NOTextBox;
        private System.Windows.Forms.TextBox eMAILTextBox;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}