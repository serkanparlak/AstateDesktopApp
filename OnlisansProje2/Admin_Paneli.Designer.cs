namespace OnlisansProje2
{
    partial class Admin_Paneli
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnIlanlar = new System.Windows.Forms.Button();
            this.btnIlanEkle = new System.Windows.Forms.Button();
            this.txt_Hizli_Ara = new System.Windows.Forms.TextBox();
            this.btn_Hizli_Ara = new System.Windows.Forms.Button();
            this.lblAdmin_Bilgi = new System.Windows.Forms.Label();
            this.link_Admin_Cikis = new System.Windows.Forms.LinkLabel();
            this.btnFiltreKaldir = new System.Windows.Forms.Button();
            this.btnFiltre = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbIsitma = new System.Windows.Forms.ComboBox();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.cmbDaireKati = new System.Windows.Forms.ComboBox();
            this.cmbOdaSayi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numMinMetre = new System.Windows.Forms.NumericUpDown();
            this.numMinFiyat = new System.Windows.Forms.NumericUpDown();
            this.numMaxMetre = new System.Windows.Forms.NumericUpDown();
            this.numMaxFiyat = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linkDuzenle = new System.Windows.Forms.LinkLabel();
            this.btnIlanSil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinMetre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxMetre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIlanlar
            // 
            this.btnIlanlar.BackColor = System.Drawing.Color.Gray;
            this.btnIlanlar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnIlanlar.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIlanlar.ForeColor = System.Drawing.Color.White;
            this.btnIlanlar.Location = new System.Drawing.Point(12, 12);
            this.btnIlanlar.Name = "btnIlanlar";
            this.btnIlanlar.Size = new System.Drawing.Size(133, 50);
            this.btnIlanlar.TabIndex = 0;
            this.btnIlanlar.Text = "Tüm Ilanlar";
            this.btnIlanlar.UseVisualStyleBackColor = false;
            this.btnIlanlar.Click += new System.EventHandler(this.btnIlanlar_Click);
            // 
            // btnIlanEkle
            // 
            this.btnIlanEkle.BackColor = System.Drawing.Color.Gray;
            this.btnIlanEkle.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnIlanEkle.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIlanEkle.ForeColor = System.Drawing.Color.White;
            this.btnIlanEkle.Location = new System.Drawing.Point(151, 12);
            this.btnIlanEkle.Name = "btnIlanEkle";
            this.btnIlanEkle.Size = new System.Drawing.Size(102, 50);
            this.btnIlanEkle.TabIndex = 1;
            this.btnIlanEkle.Text = "Ilan Ekle";
            this.btnIlanEkle.UseVisualStyleBackColor = false;
            this.btnIlanEkle.Click += new System.EventHandler(this.btnIlanEkle_Click);
            // 
            // txt_Hizli_Ara
            // 
            this.txt_Hizli_Ara.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Hizli_Ara.ForeColor = System.Drawing.Color.Gray;
            this.txt_Hizli_Ara.Location = new System.Drawing.Point(311, 36);
            this.txt_Hizli_Ara.Multiline = true;
            this.txt_Hizli_Ara.Name = "txt_Hizli_Ara";
            this.txt_Hizli_Ara.Size = new System.Drawing.Size(174, 25);
            this.txt_Hizli_Ara.TabIndex = 118;
            this.txt_Hizli_Ara.Text = "Hızlı arama";
            this.txt_Hizli_Ara.Enter += new System.EventHandler(this.txt_Hizli_Ara_Enter);
            this.txt_Hizli_Ara.Leave += new System.EventHandler(this.txt_Hizli_Ara_Leave);
            // 
            // btn_Hizli_Ara
            // 
            this.btn_Hizli_Ara.BackColor = System.Drawing.Color.Gray;
            this.btn_Hizli_Ara.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Hizli_Ara.ForeColor = System.Drawing.Color.White;
            this.btn_Hizli_Ara.Location = new System.Drawing.Point(487, 35);
            this.btn_Hizli_Ara.Name = "btn_Hizli_Ara";
            this.btn_Hizli_Ara.Size = new System.Drawing.Size(60, 27);
            this.btn_Hizli_Ara.TabIndex = 119;
            this.btn_Hizli_Ara.Text = "Ara";
            this.btn_Hizli_Ara.UseVisualStyleBackColor = false;
            this.btn_Hizli_Ara.Click += new System.EventHandler(this.btn_Hizli_Ara_Click);
            // 
            // lblAdmin_Bilgi
            // 
            this.lblAdmin_Bilgi.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmin_Bilgi.Font = new System.Drawing.Font("Monotype Corsiva", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdmin_Bilgi.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAdmin_Bilgi.Location = new System.Drawing.Point(3, 9);
            this.lblAdmin_Bilgi.Name = "lblAdmin_Bilgi";
            this.lblAdmin_Bilgi.Size = new System.Drawing.Size(143, 43);
            this.lblAdmin_Bilgi.TabIndex = 121;
            this.lblAdmin_Bilgi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // link_Admin_Cikis
            // 
            this.link_Admin_Cikis.ActiveLinkColor = System.Drawing.Color.MediumOrchid;
            this.link_Admin_Cikis.AutoSize = true;
            this.link_Admin_Cikis.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_Admin_Cikis.LinkColor = System.Drawing.Color.RosyBrown;
            this.link_Admin_Cikis.Location = new System.Drawing.Point(596, 82);
            this.link_Admin_Cikis.Name = "link_Admin_Cikis";
            this.link_Admin_Cikis.Size = new System.Drawing.Size(85, 16);
            this.link_Admin_Cikis.TabIndex = 122;
            this.link_Admin_Cikis.TabStop = true;
            this.link_Admin_Cikis.Text = "Oturumu Kapat";
            this.link_Admin_Cikis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Admin_Cikis_LinkClicked);
            // 
            // btnFiltreKaldir
            // 
            this.btnFiltreKaldir.BackColor = System.Drawing.Color.RosyBrown;
            this.btnFiltreKaldir.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFiltreKaldir.ForeColor = System.Drawing.Color.White;
            this.btnFiltreKaldir.Location = new System.Drawing.Point(475, 23);
            this.btnFiltreKaldir.Name = "btnFiltreKaldir";
            this.btnFiltreKaldir.Size = new System.Drawing.Size(60, 63);
            this.btnFiltreKaldir.TabIndex = 126;
            this.btnFiltreKaldir.Text = "Kaldır";
            this.btnFiltreKaldir.UseVisualStyleBackColor = false;
            this.btnFiltreKaldir.Click += new System.EventHandler(this.btnFiltreKaldir_Click);
            // 
            // btnFiltre
            // 
            this.btnFiltre.BackColor = System.Drawing.Color.Gray;
            this.btnFiltre.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFiltre.ForeColor = System.Drawing.Color.White;
            this.btnFiltre.Location = new System.Drawing.Point(404, 23);
            this.btnFiltre.Name = "btnFiltre";
            this.btnFiltre.Size = new System.Drawing.Size(64, 65);
            this.btnFiltre.TabIndex = 127;
            this.btnFiltre.Text = "Filtrele";
            this.btnFiltre.UseVisualStyleBackColor = false;
            this.btnFiltre.Click += new System.EventHandler(this.btnFiltre_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbIsitma);
            this.groupBox1.Controls.Add(this.cmbTur);
            this.groupBox1.Controls.Add(this.cmbDaireKati);
            this.groupBox1.Controls.Add(this.btnFiltreKaldir);
            this.groupBox1.Controls.Add(this.cmbOdaSayi);
            this.groupBox1.Controls.Add(this.btnFiltre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numMinMetre);
            this.groupBox1.Controls.Add(this.numMinFiyat);
            this.groupBox1.Controls.Add(this.numMaxMetre);
            this.groupBox1.Controls.Add(this.numMaxFiyat);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 92);
            this.groupBox1.TabIndex = 128;
            this.groupBox1.TabStop = false;
            // 
            // cmbIsitma
            // 
            this.cmbIsitma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsitma.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIsitma.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cmbIsitma.FormattingEnabled = true;
            this.cmbIsitma.Items.AddRange(new object[] {
            "Kalorifer",
            "Doğalgaz",
            "Klima",
            "Soba"});
            this.cmbIsitma.Location = new System.Drawing.Point(299, 22);
            this.cmbIsitma.Name = "cmbIsitma";
            this.cmbIsitma.Size = new System.Drawing.Size(82, 23);
            this.cmbIsitma.TabIndex = 133;
            // 
            // cmbTur
            // 
            this.cmbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTur.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTur.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Items.AddRange(new object[] {
            "Satılık",
            "Kiralık",
            "Günlük Kiralık"});
            this.cmbTur.Location = new System.Drawing.Point(299, 65);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(82, 23);
            this.cmbTur.TabIndex = 133;
            // 
            // cmbDaireKati
            // 
            this.cmbDaireKati.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDaireKati.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDaireKati.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cmbDaireKati.FormattingEnabled = true;
            this.cmbDaireKati.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "15+"});
            this.cmbDaireKati.Location = new System.Drawing.Point(197, 65);
            this.cmbDaireKati.Name = "cmbDaireKati";
            this.cmbDaireKati.Size = new System.Drawing.Size(82, 23);
            this.cmbDaireKati.TabIndex = 133;
            // 
            // cmbOdaSayi
            // 
            this.cmbOdaSayi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdaSayi.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOdaSayi.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cmbOdaSayi.FormattingEnabled = true;
            this.cmbOdaSayi.Items.AddRange(new object[] {
            "1+1",
            "2+1",
            "2+2",
            "3+1",
            "3+2",
            "4+1",
            "4+2",
            "5+1",
            "5+2",
            "6+1",
            "6+2",
            "7+"});
            this.cmbOdaSayi.Location = new System.Drawing.Point(197, 22);
            this.cmbOdaSayi.Name = "cmbOdaSayi";
            this.cmbOdaSayi.Size = new System.Drawing.Size(82, 23);
            this.cmbOdaSayi.TabIndex = 133;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(7, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 14);
            this.label4.TabIndex = 129;
            this.label4.Text = "Min Metre2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 14);
            this.label1.TabIndex = 130;
            this.label1.Text = "Min Fiyat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(300, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 14);
            this.label8.TabIndex = 132;
            this.label8.Text = "Konut Türü";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(198, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 14);
            this.label7.TabIndex = 132;
            this.label7.Text = "Dairenin Katı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(300, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 14);
            this.label6.TabIndex = 132;
            this.label6.Text = "Isıtma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(95, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 14);
            this.label3.TabIndex = 131;
            this.label3.Text = "Max Metre2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(198, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 14);
            this.label5.TabIndex = 132;
            this.label5.Text = "Oda Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(95, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 14);
            this.label2.TabIndex = 132;
            this.label2.Text = "Max Fiyat";
            // 
            // numMinMetre
            // 
            this.numMinMetre.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numMinMetre.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.numMinMetre.Location = new System.Drawing.Point(6, 66);
            this.numMinMetre.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.numMinMetre.Name = "numMinMetre";
            this.numMinMetre.Size = new System.Drawing.Size(82, 21);
            this.numMinMetre.TabIndex = 125;
            // 
            // numMinFiyat
            // 
            this.numMinFiyat.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numMinFiyat.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.numMinFiyat.Location = new System.Drawing.Point(6, 23);
            this.numMinFiyat.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.numMinFiyat.Name = "numMinFiyat";
            this.numMinFiyat.Size = new System.Drawing.Size(82, 21);
            this.numMinFiyat.TabIndex = 126;
            // 
            // numMaxMetre
            // 
            this.numMaxMetre.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numMaxMetre.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.numMaxMetre.Location = new System.Drawing.Point(94, 66);
            this.numMaxMetre.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numMaxMetre.Name = "numMaxMetre";
            this.numMaxMetre.Size = new System.Drawing.Size(82, 21);
            this.numMaxMetre.TabIndex = 127;
            // 
            // numMaxFiyat
            // 
            this.numMaxFiyat.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numMaxFiyat.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.numMaxFiyat.Location = new System.Drawing.Point(94, 23);
            this.numMaxFiyat.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numMaxFiyat.Name = "numMaxFiyat";
            this.numMaxFiyat.Size = new System.Drawing.Size(82, 21);
            this.numMaxFiyat.TabIndex = 128;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(4, 38);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(692, 240);
            this.dataGridView1.TabIndex = 129;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(13, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 281);
            this.groupBox2.TabIndex = 130;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(-6, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(715, 10);
            this.groupBox4.TabIndex = 132;
            this.groupBox4.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(4, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 133;
            this.label9.Text = "BAŞLIK";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.SteelBlue;
            this.label14.Location = new System.Drawing.Point(477, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 134;
            this.label14.Text = "DAİRE KATI";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(379, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 134;
            this.label10.Text = "ODA";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.SteelBlue;
            this.label13.Location = new System.Drawing.Point(579, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 135;
            this.label13.Text = "ISITMA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.SteelBlue;
            this.label11.Location = new System.Drawing.Point(279, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 135;
            this.label11.Text = "METREKARE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.SteelBlue;
            this.label12.Location = new System.Drawing.Point(180, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 136;
            this.label12.Text = "FİYAT";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblAdmin_Bilgi);
            this.groupBox3.Location = new System.Drawing.Point(564, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(149, 55);
            this.groupBox3.TabIndex = 131;
            this.groupBox3.TabStop = false;
            // 
            // linkDuzenle
            // 
            this.linkDuzenle.ActiveLinkColor = System.Drawing.Color.MediumOrchid;
            this.linkDuzenle.AutoSize = true;
            this.linkDuzenle.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkDuzenle.LinkColor = System.Drawing.Color.Gray;
            this.linkDuzenle.Location = new System.Drawing.Point(613, 65);
            this.linkDuzenle.Name = "linkDuzenle";
            this.linkDuzenle.Size = new System.Drawing.Size(51, 16);
            this.linkDuzenle.TabIndex = 122;
            this.linkDuzenle.TabStop = true;
            this.linkDuzenle.Text = "Hesabım";
            this.linkDuzenle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDuzenle_LinkClicked);
            // 
            // btnIlanSil
            // 
            this.btnIlanSil.BackColor = System.Drawing.Color.RosyBrown;
            this.btnIlanSil.Enabled = false;
            this.btnIlanSil.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIlanSil.ForeColor = System.Drawing.Color.White;
            this.btnIlanSil.Location = new System.Drawing.Point(259, 34);
            this.btnIlanSil.Name = "btnIlanSil";
            this.btnIlanSil.Size = new System.Drawing.Size(46, 28);
            this.btnIlanSil.TabIndex = 126;
            this.btnIlanSil.Text = "Sil";
            this.btnIlanSil.UseVisualStyleBackColor = false;
            this.btnIlanSil.Click += new System.EventHandler(this.btnIlanSil_Click);
            // 
            // Admin_Paneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(733, 459);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIlanSil);
            this.Controls.Add(this.linkDuzenle);
            this.Controls.Add(this.link_Admin_Cikis);
            this.Controls.Add(this.btn_Hizli_Ara);
            this.Controls.Add(this.txt_Hizli_Ara);
            this.Controls.Add(this.btnIlanEkle);
            this.Controls.Add(this.btnIlanlar);
            this.MaximizeBox = false;
            this.Name = "Admin_Paneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Paneli";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_Paneli_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinMetre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxMetre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIlanlar;
        private System.Windows.Forms.Button btnIlanEkle;
        private System.Windows.Forms.TextBox txt_Hizli_Ara;
        private System.Windows.Forms.Button btn_Hizli_Ara;
        private System.Windows.Forms.Label lblAdmin_Bilgi;
        private System.Windows.Forms.LinkLabel link_Admin_Cikis;
        private System.Windows.Forms.Button btnFiltreKaldir;
        private System.Windows.Forms.Button btnFiltre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numMinMetre;
        private System.Windows.Forms.NumericUpDown numMinFiyat;
        private System.Windows.Forms.NumericUpDown numMaxMetre;
        private System.Windows.Forms.NumericUpDown numMaxFiyat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbOdaSayi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbIsitma;
        private System.Windows.Forms.ComboBox cmbDaireKati;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkDuzenle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnIlanSil;
    }
}