namespace Library
{
    partial class Books
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.kODKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yDKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KODA2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.авторыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotekaDataSet = new Library.bibliotekaDataSet();
            this.invKBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kODRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kODADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KODR2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.разделыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KODI2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.издательстваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kODIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.книгиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.книгиTableAdapter = new Library.bibliotekaDataSetTableAdapters.КнигиTableAdapter();
            this.разделыTableAdapter = new Library.bibliotekaDataSetTableAdapters.РазделыTableAdapter();
            this.авторыTableAdapter = new Library.bibliotekaDataSetTableAdapters.АвторыTableAdapter();
            this.издательстваTableAdapter = new Library.bibliotekaDataSetTableAdapters.ИздательстваTableAdapter();
            this.AddButton = new System.Windows.Forms.Button();
            this.YDKBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.AuthorBox = new System.Windows.Forms.TextBox();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.InvBox = new System.Windows.Forms.TextBox();
            this.RazdelBox = new System.Windows.Forms.TextBox();
            this.IzdBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.авторыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.разделыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.издательстваBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kODKDataGridViewTextBoxColumn,
            this.yDKDataGridViewTextBoxColumn,
            this.KODA2,
            this.invKBDataGridViewTextBoxColumn,
            this.nameBDataGridViewTextBoxColumn,
            this.yearBDataGridViewTextBoxColumn,
            this.kODRDataGridViewTextBoxColumn,
            this.kODADataGridViewTextBoxColumn,
            this.KODR2,
            this.KODI2,
            this.kODIDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.книгиBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1122, 250);
            this.dataGridView.TabIndex = 0;
            // 
            // kODKDataGridViewTextBoxColumn
            // 
            this.kODKDataGridViewTextBoxColumn.DataPropertyName = "KODK";
            this.kODKDataGridViewTextBoxColumn.HeaderText = "KODK";
            this.kODKDataGridViewTextBoxColumn.Name = "kODKDataGridViewTextBoxColumn";
            // 
            // yDKDataGridViewTextBoxColumn
            // 
            this.yDKDataGridViewTextBoxColumn.DataPropertyName = "YDK";
            this.yDKDataGridViewTextBoxColumn.HeaderText = "YDK";
            this.yDKDataGridViewTextBoxColumn.Name = "yDKDataGridViewTextBoxColumn";
            // 
            // KODA2
            // 
            this.KODA2.DataPropertyName = "KODA";
            this.KODA2.DataSource = this.авторыBindingSource;
            this.KODA2.DisplayMember = "fioA";
            this.KODA2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.KODA2.HeaderText = "KODA2";
            this.KODA2.Name = "KODA2";
            this.KODA2.ValueMember = "KODA";
            // 
            // авторыBindingSource
            // 
            this.авторыBindingSource.DataMember = "Авторы";
            this.авторыBindingSource.DataSource = this.bibliotekaDataSet;
            // 
            // bibliotekaDataSet
            // 
            this.bibliotekaDataSet.DataSetName = "bibliotekaDataSet";
            this.bibliotekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invKBDataGridViewTextBoxColumn
            // 
            this.invKBDataGridViewTextBoxColumn.DataPropertyName = "invKB";
            this.invKBDataGridViewTextBoxColumn.HeaderText = "invKB";
            this.invKBDataGridViewTextBoxColumn.Name = "invKBDataGridViewTextBoxColumn";
            // 
            // nameBDataGridViewTextBoxColumn
            // 
            this.nameBDataGridViewTextBoxColumn.DataPropertyName = "nameB";
            this.nameBDataGridViewTextBoxColumn.HeaderText = "nameB";
            this.nameBDataGridViewTextBoxColumn.Name = "nameBDataGridViewTextBoxColumn";
            // 
            // yearBDataGridViewTextBoxColumn
            // 
            this.yearBDataGridViewTextBoxColumn.DataPropertyName = "yearB";
            this.yearBDataGridViewTextBoxColumn.HeaderText = "yearB";
            this.yearBDataGridViewTextBoxColumn.Name = "yearBDataGridViewTextBoxColumn";
            // 
            // kODRDataGridViewTextBoxColumn
            // 
            this.kODRDataGridViewTextBoxColumn.DataPropertyName = "KODR";
            this.kODRDataGridViewTextBoxColumn.HeaderText = "KODR";
            this.kODRDataGridViewTextBoxColumn.Name = "kODRDataGridViewTextBoxColumn";
            this.kODRDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // kODADataGridViewTextBoxColumn
            // 
            this.kODADataGridViewTextBoxColumn.DataPropertyName = "KODA";
            this.kODADataGridViewTextBoxColumn.HeaderText = "KODA";
            this.kODADataGridViewTextBoxColumn.Name = "kODADataGridViewTextBoxColumn";
            // 
            // KODR2
            // 
            this.KODR2.DataPropertyName = "KODR";
            this.KODR2.DataSource = this.разделыBindingSource;
            this.KODR2.DisplayMember = "razdel";
            this.KODR2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.KODR2.HeaderText = "KODR2";
            this.KODR2.Name = "KODR2";
            this.KODR2.ValueMember = "KODR";
            // 
            // разделыBindingSource
            // 
            this.разделыBindingSource.DataMember = "Разделы";
            this.разделыBindingSource.DataSource = this.bibliotekaDataSet;
            // 
            // KODI2
            // 
            this.KODI2.DataPropertyName = "KODI";
            this.KODI2.DataSource = this.издательстваBindingSource;
            this.KODI2.DisplayMember = "izd";
            this.KODI2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.KODI2.HeaderText = "KODI2";
            this.KODI2.Name = "KODI2";
            this.KODI2.ValueMember = "KODI";
            // 
            // издательстваBindingSource
            // 
            this.издательстваBindingSource.DataMember = "Издательства";
            this.издательстваBindingSource.DataSource = this.bibliotekaDataSet;
            // 
            // kODIDataGridViewTextBoxColumn
            // 
            this.kODIDataGridViewTextBoxColumn.DataPropertyName = "KODI";
            this.kODIDataGridViewTextBoxColumn.HeaderText = "KODI";
            this.kODIDataGridViewTextBoxColumn.Name = "kODIDataGridViewTextBoxColumn";
            this.kODIDataGridViewTextBoxColumn.Visible = false;
            // 
            // книгиBindingSource
            // 
            this.книгиBindingSource.DataMember = "Книги";
            this.книгиBindingSource.DataSource = this.bibliotekaDataSet;
            // 
            // книгиTableAdapter
            // 
            this.книгиTableAdapter.ClearBeforeFill = true;
            // 
            // разделыTableAdapter
            // 
            this.разделыTableAdapter.ClearBeforeFill = true;
            // 
            // авторыTableAdapter
            // 
            this.авторыTableAdapter.ClearBeforeFill = true;
            // 
            // издательстваTableAdapter
            // 
            this.издательстваTableAdapter.ClearBeforeFill = true;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(177, 261);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(163, 45);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // YDKBox
            // 
            this.YDKBox.Location = new System.Drawing.Point(276, 53);
            this.YDKBox.Name = "YDKBox";
            this.YDKBox.Size = new System.Drawing.Size(190, 20);
            this.YDKBox.TabIndex = 2;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(276, 79);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(190, 20);
            this.NameBox.TabIndex = 3;
            // 
            // AuthorBox
            // 
            this.AuthorBox.Location = new System.Drawing.Point(276, 105);
            this.AuthorBox.Name = "AuthorBox";
            this.AuthorBox.Size = new System.Drawing.Size(190, 20);
            this.AuthorBox.TabIndex = 4;
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(276, 131);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(190, 20);
            this.YearBox.TabIndex = 5;
            // 
            // InvBox
            // 
            this.InvBox.Location = new System.Drawing.Point(276, 157);
            this.InvBox.Name = "InvBox";
            this.InvBox.Size = new System.Drawing.Size(190, 20);
            this.InvBox.TabIndex = 6;
            // 
            // RazdelBox
            // 
            this.RazdelBox.Location = new System.Drawing.Point(276, 183);
            this.RazdelBox.Name = "RazdelBox";
            this.RazdelBox.Size = new System.Drawing.Size(190, 20);
            this.RazdelBox.TabIndex = 7;
            // 
            // IzdBox
            // 
            this.IzdBox.Location = new System.Drawing.Point(276, 209);
            this.IzdBox.Name = "IzdBox";
            this.IzdBox.Size = new System.Drawing.Size(190, 20);
            this.IzdBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(57, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Код УДК";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(57, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(57, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Автор";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(57, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Год издания";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(57, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Инвентаризационный код";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(57, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Раздел";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(57, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Издательство";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 250);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.label15);
            this.splitContainer1.Panel1.Controls.Add(this.NameBox);
            this.splitContainer1.Panel1.Controls.Add(this.AddButton);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.IzdBox);
            this.splitContainer1.Panel1.Controls.Add(this.YDKBox);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.RazdelBox);
            this.splitContainer1.Panel1.Controls.Add(this.AuthorBox);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.InvBox);
            this.splitContainer1.Panel1.Controls.Add(this.YearBox);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.label16);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Panel2.Controls.Add(this.label13);
            this.splitContainer1.Panel2.Controls.Add(this.label14);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.textBox7);
            this.splitContainer1.Panel2.Controls.Add(this.textBox6);
            this.splitContainer1.Panel2.Controls.Add(this.textBox5);
            this.splitContainer1.Panel2.Controls.Add(this.textBox4);
            this.splitContainer1.Panel2.Controls.Add(this.textBox3);
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1122, 425);
            this.splitContainer1.SplitterDistance = 557;
            this.splitContainer1.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(22, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Код УДК";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(22, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Издательство";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(22, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Название";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(22, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Раздел";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(22, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Автор";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(22, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(206, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Инвентаризационный код";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(22, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "Год издания";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(144, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(262, 207);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(221, 20);
            this.textBox7.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(262, 181);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(221, 20);
            this.textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(262, 155);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(221, 20);
            this.textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(262, 129);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(221, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(262, 103);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(221, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(262, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(262, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(199, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 24);
            this.label15.TabIndex = 17;
            this.label15.Text = "Добавление";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(200, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 24);
            this.label16.TabIndex = 24;
            this.label16.Text = "Поиск";
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1122, 675);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Books";
            this.Text = "Books";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Books_FormClosing);
            this.Load += new System.EventHandler(this.Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.авторыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.разделыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.издательстваBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private bibliotekaDataSet bibliotekaDataSet;
        private System.Windows.Forms.BindingSource книгиBindingSource;
        private bibliotekaDataSetTableAdapters.КнигиTableAdapter книгиTableAdapter;
        private System.Windows.Forms.BindingSource разделыBindingSource;
        private bibliotekaDataSetTableAdapters.РазделыTableAdapter разделыTableAdapter;
        private System.Windows.Forms.BindingSource авторыBindingSource;
        private bibliotekaDataSetTableAdapters.АвторыTableAdapter авторыTableAdapter;
        private System.Windows.Forms.BindingSource издательстваBindingSource;
        private bibliotekaDataSetTableAdapters.ИздательстваTableAdapter издательстваTableAdapter;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox YDKBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox AuthorBox;
        private System.Windows.Forms.TextBox YearBox;
        private System.Windows.Forms.TextBox InvBox;
        private System.Windows.Forms.TextBox RazdelBox;
        private System.Windows.Forms.TextBox IzdBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn kODKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yDKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn KODA2;
        private System.Windows.Forms.DataGridViewTextBoxColumn invKBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kODRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kODADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn KODR2;
        private System.Windows.Forms.DataGridViewComboBoxColumn KODI2;
        private System.Windows.Forms.DataGridViewTextBoxColumn kODIDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}