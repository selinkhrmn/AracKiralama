namespace WindowsFormsApp3
{
    partial class frmSözleşme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtE_Yer = new System.Windows.Forms.TextBox();
            this.txtE_Tarih = new System.Windows.Forms.TextBox();
            this.txtE_No = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtTcAra = new System.Windows.Forms.TextBox();
            this.txtTtc = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dateDönüş = new System.Windows.Forms.DateTimePicker();
            this.dateÇıkış = new System.Windows.Forms.DateTimePicker();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtGün = new System.Windows.Forms.TextBox();
            this.comboKiraŞekli = new System.Windows.Forms.TextBox();
            this.txtKiraÜcreti = new System.Windows.Forms.TextBox();
            this.txtSeri = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.comboAraçlar = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnAraçTeslim = new System.Windows.Forms.Button();
            this.txtEkstra = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.txtE_Yer);
            this.groupBox1.Controls.Add(this.txtE_Tarih);
            this.groupBox1.Controls.Add(this.txtE_No);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtTcAra);
            this.groupBox1.Controls.Add(this.txtTtc);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtE_Yer
            // 
            this.txtE_Yer.Location = new System.Drawing.Point(104, 205);
            this.txtE_Yer.Name = "txtE_Yer";
            this.txtE_Yer.Size = new System.Drawing.Size(100, 22);
            this.txtE_Yer.TabIndex = 3;
            // 
            // txtE_Tarih
            // 
            this.txtE_Tarih.Location = new System.Drawing.Point(104, 176);
            this.txtE_Tarih.Name = "txtE_Tarih";
            this.txtE_Tarih.Size = new System.Drawing.Size(100, 22);
            this.txtE_Tarih.TabIndex = 3;
            this.txtE_Tarih.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtE_No
            // 
            this.txtE_No.Location = new System.Drawing.Point(104, 147);
            this.txtE_No.Name = "txtE_No";
            this.txtE_No.Size = new System.Drawing.Size(100, 22);
            this.txtE_No.TabIndex = 3;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(104, 118);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtTelefon.TabIndex = 3;
            // 
            // txtTcAra
            // 
            this.txtTcAra.Location = new System.Drawing.Point(104, 23);
            this.txtTcAra.Name = "txtTcAra";
            this.txtTcAra.Size = new System.Drawing.Size(100, 22);
            this.txtTcAra.TabIndex = 3;
            this.txtTcAra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTtc
            // 
            this.txtTtc.Location = new System.Drawing.Point(104, 60);
            this.txtTtc.Name = "txtTtc";
            this.txtTtc.Size = new System.Drawing.Size(100, 22);
            this.txtTtc.TabIndex = 3;
            this.txtTtc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(104, 89);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtAdSoyad.TabIndex = 3;
            this.txtAdSoyad.TextChanged += new System.EventHandler(this.txtAdSoyad_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "E_verildiği Yer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ehliyet Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ehliyet No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad Soyad";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(49, 27);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(49, 16);
            this.label25.TabIndex = 3;
            this.label25.Text = "TC Ara";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "TC";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(250, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 210);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç Bilgileri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(199, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "label7";
            this.label13.Click += new System.EventHandler(this.label11_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "label7";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "label7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "label7";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(199, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "label7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "label7";
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 278);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(792, 316);
            this.dgv.TabIndex = 2;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.btnTemizle);
            this.groupBox3.Controls.Add(this.btnGüncelle);
            this.groupBox3.Controls.Add(this.btnEkle);
            this.groupBox3.Controls.Add(this.dateDönüş);
            this.groupBox3.Controls.Add(this.dateÇıkış);
            this.groupBox3.Controls.Add(this.txtRenk);
            this.groupBox3.Controls.Add(this.txtYil);
            this.groupBox3.Controls.Add(this.txtTutar);
            this.groupBox3.Controls.Add(this.txtGün);
            this.groupBox3.Controls.Add(this.comboKiraŞekli);
            this.groupBox3.Controls.Add(this.txtKiraÜcreti);
            this.groupBox3.Controls.Add(this.txtSeri);
            this.groupBox3.Controls.Add(this.txtMarka);
            this.groupBox3.Controls.Add(this.comboAraçlar);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Location = new System.Drawing.Point(251, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(553, 249);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Araç Bilgileri";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnTemizle
            // 
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemizle.Location = new System.Drawing.Point(363, 209);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(146, 34);
            this.btnTemizle.TabIndex = 10;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGüncelle.Location = new System.Drawing.Point(169, 209);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(151, 34);
            this.btnGüncelle.TabIndex = 8;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.Location = new System.Drawing.Point(6, 209);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(146, 34);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateDönüş
            // 
            this.dateDönüş.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDönüş.Location = new System.Drawing.Point(363, 170);
            this.dateDönüş.Name = "dateDönüş";
            this.dateDönüş.Size = new System.Drawing.Size(142, 22);
            this.dateDönüş.TabIndex = 7;
            // 
            // dateÇıkış
            // 
            this.dateÇıkış.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateÇıkış.Location = new System.Drawing.Point(363, 142);
            this.dateÇıkış.Name = "dateÇıkış";
            this.dateÇıkış.Size = new System.Drawing.Size(142, 22);
            this.dateÇıkış.TabIndex = 6;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(87, 149);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(137, 22);
            this.txtRenk.TabIndex = 5;
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(87, 121);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(137, 22);
            this.txtYil.TabIndex = 5;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(363, 113);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(141, 22);
            this.txtTutar.TabIndex = 5;
            // 
            // txtGün
            // 
            this.txtGün.Location = new System.Drawing.Point(363, 81);
            this.txtGün.Name = "txtGün";
            this.txtGün.Size = new System.Drawing.Size(141, 22);
            this.txtGün.TabIndex = 5;
            // 
            // comboKiraŞekli
            // 
            this.comboKiraŞekli.Location = new System.Drawing.Point(363, 24);
            this.comboKiraŞekli.Name = "comboKiraŞekli";
            this.comboKiraŞekli.Size = new System.Drawing.Size(141, 22);
            this.comboKiraŞekli.TabIndex = 5;
            this.comboKiraŞekli.TextChanged += new System.EventHandler(this.comboKiraŞekli_TextChanged);
            // 
            // txtKiraÜcreti
            // 
            this.txtKiraÜcreti.Location = new System.Drawing.Point(363, 53);
            this.txtKiraÜcreti.Name = "txtKiraÜcreti";
            this.txtKiraÜcreti.Size = new System.Drawing.Size(141, 22);
            this.txtKiraÜcreti.TabIndex = 5;
            this.txtKiraÜcreti.TextChanged += new System.EventHandler(this.txtKiraÜcreti_TextChanged);
            // 
            // txtSeri
            // 
            this.txtSeri.Location = new System.Drawing.Point(87, 90);
            this.txtSeri.Name = "txtSeri";
            this.txtSeri.Size = new System.Drawing.Size(137, 22);
            this.txtSeri.TabIndex = 5;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(87, 60);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(137, 22);
            this.txtMarka.TabIndex = 5;
            // 
            // comboAraçlar
            // 
            this.comboAraçlar.Location = new System.Drawing.Point(87, 30);
            this.comboAraçlar.Name = "comboAraçlar";
            this.comboAraçlar.Size = new System.Drawing.Size(137, 24);
            this.comboAraçlar.TabIndex = 9;
            this.comboAraçlar.SelectedIndexChanged += new System.EventHandler(this.comboAraçlar_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(289, 56);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(68, 16);
            this.label23.TabIndex = 0;
            this.label23.Text = "Kira Ücreti";
            this.label23.Click += new System.EventHandler(this.label11_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(319, 116);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(38, 16);
            this.label22.TabIndex = 0;
            this.label22.Text = "Tutar";
            this.label22.Click += new System.EventHandler(this.label11_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(326, 86);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 16);
            this.label21.TabIndex = 0;
            this.label21.Text = "Gün";
            this.label21.Click += new System.EventHandler(this.label11_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(274, 175);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(83, 16);
            this.label24.TabIndex = 0;
            this.label24.Text = "Dönüş Tarihi";
            this.label24.Click += new System.EventHandler(this.label11_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(284, 146);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Çıkış Tarihi";
            this.label14.Click += new System.EventHandler(this.label11_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(42, 151);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "Renk";
            this.label15.Click += new System.EventHandler(this.label11_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 121);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "Model(Yıl)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(50, 91);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 16);
            this.label17.TabIndex = 0;
            this.label17.Text = "Seri";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(36, 61);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 16);
            this.label18.TabIndex = 0;
            this.label18.Text = "Marka";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(294, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 16);
            this.label19.TabIndex = 0;
            this.label19.Text = "Kira Şekli";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(31, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(50, 16);
            this.label20.TabIndex = 0;
            this.label20.Text = "Araçlar";
            // 
            // btnAraçTeslim
            // 
            this.btnAraçTeslim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAraçTeslim.Location = new System.Drawing.Point(654, 600);
            this.btnAraçTeslim.Name = "btnAraçTeslim";
            this.btnAraçTeslim.Size = new System.Drawing.Size(150, 39);
            this.btnAraçTeslim.TabIndex = 8;
            this.btnAraçTeslim.Text = "Araç Teslim";
            this.btnAraçTeslim.UseVisualStyleBackColor = false;
            this.btnAraçTeslim.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtEkstra
            // 
            this.txtEkstra.Location = new System.Drawing.Point(511, 608);
            this.txtEkstra.Name = "txtEkstra";
            this.txtEkstra.Size = new System.Drawing.Size(137, 22);
            this.txtEkstra.TabIndex = 9;
            this.txtEkstra.TextChanged += new System.EventHandler(this.txtEkstra_TextChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(352, 611);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(153, 16);
            this.label26.TabIndex = 10;
            this.label26.Text = "Alacak/Verecek Durumu";
            // 
            // frmSözleşme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(816, 645);
            this.Controls.Add(this.txtEkstra);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.btnAraçTeslim);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSözleşme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sözleşme Sayfası";
            this.Load += new System.EventHandler(this.frmSözleşme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtE_Yer;
        private System.Windows.Forms.TextBox txtE_Tarih;
        private System.Windows.Forms.TextBox txtE_No;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboAraçlar;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DateTimePicker dateDönüş;
        private System.Windows.Forms.DateTimePicker dateÇıkış;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtGün;
        private System.Windows.Forms.TextBox txtKiraÜcreti;
        private System.Windows.Forms.TextBox txtSeri;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnAraçTeslim;
        private System.Windows.Forms.TextBox txtTtc;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox comboKiraŞekli;
        private System.Windows.Forms.TextBox txtTcAra;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtEkstra;
        private System.Windows.Forms.Label label26;
    }
}