namespace cpractice
{
    partial class booksrecord1
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
            System.Windows.Forms.Label iSBNLabel;
            System.Windows.Forms.Label tITLELabel;
            System.Windows.Forms.Label cATEGORYLabel;
            System.Windows.Forms.Label aUTHORLabel;
            System.Windows.Forms.Label pRICELabel;
            System.Windows.Forms.Label lANGUAGELabel;
            System.Windows.Forms.Label pUBLISH_DATELabel;
            System.Windows.Forms.Label pUB_IDLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet2 = new cpractice.DataSet2();
            this.bOOKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKSTableAdapter = new cpractice.DataSet2TableAdapters.BOOKSTableAdapter();
            this.tableAdapterManager = new cpractice.DataSet2TableAdapters.TableAdapterManager();
            this.iSBNTextBox = new System.Windows.Forms.TextBox();
            this.tITLETextBox = new System.Windows.Forms.TextBox();
            this.aUTHORTextBox = new System.Windows.Forms.TextBox();
            this.pRICETextBox = new System.Windows.Forms.TextBox();
            this.pUBLISH_DATEDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pUB_IDTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            iSBNLabel = new System.Windows.Forms.Label();
            tITLELabel = new System.Windows.Forms.Label();
            cATEGORYLabel = new System.Windows.Forms.Label();
            aUTHORLabel = new System.Windows.Forms.Label();
            pRICELabel = new System.Windows.Forms.Label();
            lANGUAGELabel = new System.Windows.Forms.Label();
            pUBLISH_DATELabel = new System.Windows.Forms.Label();
            pUB_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iSBNLabel
            // 
            iSBNLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            iSBNLabel.AutoSize = true;
            iSBNLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iSBNLabel.Location = new System.Drawing.Point(54, 5);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(43, 19);
            iSBNLabel.TabIndex = 47;
            iSBNLabel.Text = "ISBN:";
            // 
            // tITLELabel
            // 
            tITLELabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            tITLELabel.AutoSize = true;
            tITLELabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tITLELabel.Location = new System.Drawing.Point(53, 35);
            tITLELabel.Name = "tITLELabel";
            tITLELabel.Size = new System.Drawing.Size(44, 19);
            tITLELabel.TabIndex = 49;
            tITLELabel.Text = "TITLE:";
            // 
            // cATEGORYLabel
            // 
            cATEGORYLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            cATEGORYLabel.AutoSize = true;
            cATEGORYLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cATEGORYLabel.Location = new System.Drawing.Point(16, 65);
            cATEGORYLabel.Name = "cATEGORYLabel";
            cATEGORYLabel.Size = new System.Drawing.Size(81, 19);
            cATEGORYLabel.TabIndex = 51;
            cATEGORYLabel.Text = "CATEGORY:";
            // 
            // aUTHORLabel
            // 
            aUTHORLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            aUTHORLabel.AutoSize = true;
            aUTHORLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aUTHORLabel.Location = new System.Drawing.Point(30, 95);
            aUTHORLabel.Name = "aUTHORLabel";
            aUTHORLabel.Size = new System.Drawing.Size(67, 19);
            aUTHORLabel.TabIndex = 53;
            aUTHORLabel.Text = "AUTHOR:";
            // 
            // pRICELabel
            // 
            pRICELabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            pRICELabel.AutoSize = true;
            pRICELabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pRICELabel.Location = new System.Drawing.Point(425, 95);
            pRICELabel.Name = "pRICELabel";
            pRICELabel.Size = new System.Drawing.Size(48, 19);
            pRICELabel.TabIndex = 55;
            pRICELabel.Text = "PRICE:";
            // 
            // lANGUAGELabel
            // 
            lANGUAGELabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lANGUAGELabel.AutoSize = true;
            lANGUAGELabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lANGUAGELabel.Location = new System.Drawing.Point(388, 5);
            lANGUAGELabel.Name = "lANGUAGELabel";
            lANGUAGELabel.Size = new System.Drawing.Size(85, 19);
            lANGUAGELabel.TabIndex = 57;
            lANGUAGELabel.Text = "LANGUAGE:";
            // 
            // pUBLISH_DATELabel
            // 
            pUBLISH_DATELabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            pUBLISH_DATELabel.AutoSize = true;
            pUBLISH_DATELabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pUBLISH_DATELabel.Location = new System.Drawing.Point(369, 35);
            pUBLISH_DATELabel.Name = "pUBLISH_DATELabel";
            pUBLISH_DATELabel.Size = new System.Drawing.Size(104, 19);
            pUBLISH_DATELabel.TabIndex = 59;
            pUBLISH_DATELabel.Text = "PUBLISH DATE:";
            // 
            // pUB_IDLabel
            // 
            pUB_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            pUB_IDLabel.AutoSize = true;
            pUB_IDLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pUB_IDLabel.Location = new System.Drawing.Point(417, 65);
            pUB_IDLabel.Name = "pUB_IDLabel";
            pUB_IDLabel.Size = new System.Drawing.Size(56, 19);
            pUB_IDLabel.TabIndex = 61;
            pUB_IDLabel.Text = "PUB ID:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(261, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "BOOKS RECORD";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(281, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 45);
            this.button3.TabIndex = 44;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.button2.Location = new System.Drawing.Point(191, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 45);
            this.button2.TabIndex = 43;
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
            this.button1.Location = new System.Drawing.Point(97, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 45);
            this.button1.TabIndex = 42;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 380);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(743, 150);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOOKSBindingSource
            // 
            this.bOOKSBindingSource.DataMember = "BOOKS";
            this.bOOKSBindingSource.DataSource = this.dataSet2;
            // 
            // bOOKSTableAdapter
            // 
            this.bOOKSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKSTableAdapter = this.bOOKSTableAdapter;
            this.tableAdapterManager.BORROWTableAdapter = null;
            this.tableAdapterManager.LIBRARIANTableAdapter = null;
            this.tableAdapterManager.PUBLISHERTableAdapter = null;
            this.tableAdapterManager.RETURNTableAdapter = null;
            this.tableAdapterManager.STUDENTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = cpractice.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iSBNTextBox
            // 
            this.iSBNTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iSBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKSBindingSource, "ISBN", true));
            this.iSBNTextBox.Location = new System.Drawing.Point(103, 3);
            this.iSBNTextBox.Name = "iSBNTextBox";
            this.iSBNTextBox.Size = new System.Drawing.Size(250, 20);
            this.iSBNTextBox.TabIndex = 48;
            this.iSBNTextBox.TextChanged += new System.EventHandler(this.iSBNTextBox_TextChanged);
            // 
            // tITLETextBox
            // 
            this.tITLETextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tITLETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKSBindingSource, "TITLE", true));
            this.tITLETextBox.Location = new System.Drawing.Point(103, 33);
            this.tITLETextBox.Name = "tITLETextBox";
            this.tITLETextBox.Size = new System.Drawing.Size(250, 20);
            this.tITLETextBox.TabIndex = 50;
            this.tITLETextBox.TextChanged += new System.EventHandler(this.tITLETextBox_TextChanged);
            // 
            // aUTHORTextBox
            // 
            this.aUTHORTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aUTHORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKSBindingSource, "AUTHOR", true));
            this.aUTHORTextBox.Location = new System.Drawing.Point(103, 93);
            this.aUTHORTextBox.Name = "aUTHORTextBox";
            this.aUTHORTextBox.Size = new System.Drawing.Size(250, 20);
            this.aUTHORTextBox.TabIndex = 54;
            // 
            // pRICETextBox
            // 
            this.pRICETextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pRICETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKSBindingSource, "PRICE", true));
            this.pRICETextBox.Location = new System.Drawing.Point(479, 93);
            this.pRICETextBox.Name = "pRICETextBox";
            this.pRICETextBox.Size = new System.Drawing.Size(232, 20);
            this.pRICETextBox.TabIndex = 56;
            // 
            // pUBLISH_DATEDateTimePicker
            // 
            this.pUBLISH_DATEDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pUBLISH_DATEDateTimePicker.CustomFormat = "dd-MMMM-yyyy";
            this.pUBLISH_DATEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bOOKSBindingSource, "PUBLISH_DATE", true));
            this.pUBLISH_DATEDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pUBLISH_DATEDateTimePicker.Location = new System.Drawing.Point(479, 33);
            this.pUBLISH_DATEDateTimePicker.Name = "pUBLISH_DATEDateTimePicker";
            this.pUBLISH_DATEDateTimePicker.Size = new System.Drawing.Size(232, 20);
            this.pUBLISH_DATEDateTimePicker.TabIndex = 60;
            // 
            // pUB_IDTextBox
            // 
            this.pUB_IDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pUB_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKSBindingSource, "PUB_ID", true));
            this.pUB_IDTextBox.Location = new System.Drawing.Point(479, 63);
            this.pUB_IDTextBox.Name = "pUB_IDTextBox";
            this.pUB_IDTextBox.Size = new System.Drawing.Size(232, 20);
            this.pUB_IDTextBox.TabIndex = 62;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 27);
            this.textBox1.TabIndex = 67;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(182, 23);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 27);
            this.button5.TabIndex = 68;
            this.button5.Text = "SEARCH";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Search Book By Title";
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(3, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 45);
            this.button6.TabIndex = 70;
            this.button6.Text = "VIEW";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(103, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 21);
            this.comboBox1.TabIndex = 71;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(479, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(232, 21);
            this.comboBox2.TabIndex = 72;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(743, 52);
            this.tableLayoutPanel1.TabIndex = 73;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.10714F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.89286F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.78225F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.2871F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Controls.Add(iSBNLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.iSBNTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox2, 3, 0);
            this.tableLayoutPanel2.Controls.Add(tITLELabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tITLETextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.pRICETextBox, 3, 3);
            this.tableLayoutPanel2.Controls.Add(pRICELabel, 2, 3);
            this.tableLayoutPanel2.Controls.Add(cATEGORYLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(aUTHORLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.pUB_IDTextBox, 3, 2);
            this.tableLayoutPanel2.Controls.Add(pUB_IDLabel, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.pUBLISH_DATEDateTimePicker, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.aUTHORTextBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(lANGUAGELabel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(pUBLISH_DATELabel, 2, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 100);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(743, 120);
            this.tableLayoutPanel2.TabIndex = 74;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.Controls.Add(this.button4, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.button6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.button3, 3, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(278, 237);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(477, 51);
            this.tableLayoutPanel3.TabIndex = 75;
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
            this.button4.Location = new System.Drawing.Point(371, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 45);
            this.button4.TabIndex = 71;
            this.button4.Text = "CLOSE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(471, 321);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 53);
            this.panel1.TabIndex = 76;
            // 
            // booksrecord1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(767, 542);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "booksrecord1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "booksrecord1";
            this.Load += new System.EventHandler(this.booksrecord1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource bOOKSBindingSource;
        private DataSet2TableAdapters.BOOKSTableAdapter bOOKSTableAdapter;
        private DataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iSBNTextBox;
        private System.Windows.Forms.TextBox tITLETextBox;
        private System.Windows.Forms.TextBox aUTHORTextBox;
        private System.Windows.Forms.TextBox pRICETextBox;
        private System.Windows.Forms.DateTimePicker pUBLISH_DATEDateTimePicker;
        private System.Windows.Forms.TextBox pUB_IDTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
    }
}