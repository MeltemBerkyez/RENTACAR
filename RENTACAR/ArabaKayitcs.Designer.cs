namespace RENTACAR
{
    partial class ArabaKayitcs
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
            this.lvw_aracozellik = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_arabakaydet = new System.Windows.Forms.Button();
            this.cmb_yakittipi = new System.Windows.Forms.ComboBox();
            this.cmb_vites = new System.Windows.Forms.ComboBox();
            this.cmb_aractipi = new System.Windows.Forms.ComboBox();
            this.t_fiyat = new System.Windows.Forms.TextBox();
            this.t_model = new System.Windows.Forms.TextBox();
            this.t_marka = new System.Windows.Forms.TextBox();
            this.t_plakano = new System.Windows.Forms.TextBox();
            this.lbl_fiyat = new System.Windows.Forms.Label();
            this.lbl_yakıttipi = new System.Windows.Forms.Label();
            this.lbl_vites = new System.Windows.Forms.Label();
            this.lbl_aractipi = new System.Windows.Forms.Label();
            this.lbl_model = new System.Windows.Forms.Label();
            this.lbl_marka = new System.Windows.Forms.Label();
            this.lbl_plakano = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_karackiralama = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvw_aracozellik
            // 
            this.lvw_aracozellik.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvw_aracozellik.FullRowSelect = true;
            this.lvw_aracozellik.HideSelection = false;
            this.lvw_aracozellik.Location = new System.Drawing.Point(374, 44);
            this.lvw_aracozellik.Name = "lvw_aracozellik";
            this.lvw_aracozellik.Size = new System.Drawing.Size(696, 158);
            this.lvw_aracozellik.TabIndex = 12;
            this.lvw_aracozellik.UseCompatibleStateImageBehavior = false;
            this.lvw_aracozellik.View = System.Windows.Forms.View.Details;
            this.lvw_aracozellik.DoubleClick += new System.EventHandler(this.Lvw_aracozellik_DoubleClick);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ID";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Plaka No";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Marka";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Model";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Araç Tipi";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Vites";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Yakıt Tipi";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Günlük Fiyat";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_karackiralama);
            this.groupBox2.Controls.Add(this.btn_sil);
            this.groupBox2.Controls.Add(this.btn_guncelle);
            this.groupBox2.Controls.Add(this.btn_arabakaydet);
            this.groupBox2.Controls.Add(this.cmb_yakittipi);
            this.groupBox2.Controls.Add(this.cmb_vites);
            this.groupBox2.Controls.Add(this.cmb_aractipi);
            this.groupBox2.Controls.Add(this.t_fiyat);
            this.groupBox2.Controls.Add(this.t_model);
            this.groupBox2.Controls.Add(this.t_marka);
            this.groupBox2.Controls.Add(this.t_plakano);
            this.groupBox2.Controls.Add(this.lbl_fiyat);
            this.groupBox2.Controls.Add(this.lbl_yakıttipi);
            this.groupBox2.Controls.Add(this.lbl_vites);
            this.groupBox2.Controls.Add(this.lbl_aractipi);
            this.groupBox2.Controls.Add(this.lbl_model);
            this.groupBox2.Controls.Add(this.lbl_marka);
            this.groupBox2.Controls.Add(this.lbl_plakano);
            this.groupBox2.Location = new System.Drawing.Point(48, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 426);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araba Bilgileri";
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(147, 312);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(108, 28);
            this.btn_sil.TabIndex = 40;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.Btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(23, 312);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(104, 28);
            this.btn_guncelle.TabIndex = 39;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.Btn_guncelle_Click);
            // 
            // btn_arabakaydet
            // 
            this.btn_arabakaydet.Location = new System.Drawing.Point(23, 346);
            this.btn_arabakaydet.Name = "btn_arabakaydet";
            this.btn_arabakaydet.Size = new System.Drawing.Size(232, 31);
            this.btn_arabakaydet.TabIndex = 38;
            this.btn_arabakaydet.Text = "KAYDET";
            this.btn_arabakaydet.UseVisualStyleBackColor = true;
            this.btn_arabakaydet.Click += new System.EventHandler(this.Btn_arabakaydet_Click_1);
            // 
            // cmb_yakittipi
            // 
            this.cmb_yakittipi.FormattingEnabled = true;
            this.cmb_yakittipi.Items.AddRange(new object[] {
            "Benzin",
            "Diesel"});
            this.cmb_yakittipi.Location = new System.Drawing.Point(134, 237);
            this.cmb_yakittipi.Name = "cmb_yakittipi";
            this.cmb_yakittipi.Size = new System.Drawing.Size(121, 24);
            this.cmb_yakittipi.TabIndex = 37;
            // 
            // cmb_vites
            // 
            this.cmb_vites.FormattingEnabled = true;
            this.cmb_vites.Items.AddRange(new object[] {
            "Manuel",
            "Otomatik"});
            this.cmb_vites.Location = new System.Drawing.Point(134, 202);
            this.cmb_vites.Name = "cmb_vites";
            this.cmb_vites.Size = new System.Drawing.Size(121, 24);
            this.cmb_vites.TabIndex = 36;
            // 
            // cmb_aractipi
            // 
            this.cmb_aractipi.FormattingEnabled = true;
            this.cmb_aractipi.Items.AddRange(new object[] {
            "Sedan",
            "Hatchback",
            "Station Vagon",
            "SUV"});
            this.cmb_aractipi.Location = new System.Drawing.Point(134, 134);
            this.cmb_aractipi.Name = "cmb_aractipi";
            this.cmb_aractipi.Size = new System.Drawing.Size(121, 24);
            this.cmb_aractipi.TabIndex = 35;
            // 
            // t_fiyat
            // 
            this.t_fiyat.Location = new System.Drawing.Point(134, 274);
            this.t_fiyat.Name = "t_fiyat";
            this.t_fiyat.Size = new System.Drawing.Size(121, 22);
            this.t_fiyat.TabIndex = 34;
            // 
            // t_model
            // 
            this.t_model.Location = new System.Drawing.Point(134, 101);
            this.t_model.Name = "t_model";
            this.t_model.Size = new System.Drawing.Size(121, 22);
            this.t_model.TabIndex = 29;
            // 
            // t_marka
            // 
            this.t_marka.Location = new System.Drawing.Point(134, 68);
            this.t_marka.Name = "t_marka";
            this.t_marka.Size = new System.Drawing.Size(121, 22);
            this.t_marka.TabIndex = 28;
            // 
            // t_plakano
            // 
            this.t_plakano.Location = new System.Drawing.Point(134, 31);
            this.t_plakano.Name = "t_plakano";
            this.t_plakano.Size = new System.Drawing.Size(121, 22);
            this.t_plakano.TabIndex = 27;
            // 
            // lbl_fiyat
            // 
            this.lbl_fiyat.AutoSize = true;
            this.lbl_fiyat.Location = new System.Drawing.Point(20, 273);
            this.lbl_fiyat.Name = "lbl_fiyat";
            this.lbl_fiyat.Size = new System.Drawing.Size(87, 17);
            this.lbl_fiyat.TabIndex = 25;
            this.lbl_fiyat.Text = "Günlük Fiyat";
            // 
            // lbl_yakıttipi
            // 
            this.lbl_yakıttipi.AutoSize = true;
            this.lbl_yakıttipi.Location = new System.Drawing.Point(25, 238);
            this.lbl_yakıttipi.Name = "lbl_yakıttipi";
            this.lbl_yakıttipi.Size = new System.Drawing.Size(66, 17);
            this.lbl_yakıttipi.TabIndex = 15;
            this.lbl_yakıttipi.Text = "Yakıt Tipi";
            // 
            // lbl_vites
            // 
            this.lbl_vites.AutoSize = true;
            this.lbl_vites.Location = new System.Drawing.Point(27, 202);
            this.lbl_vites.Name = "lbl_vites";
            this.lbl_vites.Size = new System.Drawing.Size(39, 17);
            this.lbl_vites.TabIndex = 14;
            this.lbl_vites.Text = "Vites";
            // 
            // lbl_aractipi
            // 
            this.lbl_aractipi.AutoSize = true;
            this.lbl_aractipi.Location = new System.Drawing.Point(28, 137);
            this.lbl_aractipi.Name = "lbl_aractipi";
            this.lbl_aractipi.Size = new System.Drawing.Size(64, 17);
            this.lbl_aractipi.TabIndex = 12;
            this.lbl_aractipi.Text = "Araç Tipi";
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Location = new System.Drawing.Point(27, 100);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(46, 17);
            this.lbl_model.TabIndex = 11;
            this.lbl_model.Text = "Model";
            // 
            // lbl_marka
            // 
            this.lbl_marka.AutoSize = true;
            this.lbl_marka.Location = new System.Drawing.Point(27, 67);
            this.lbl_marka.Name = "lbl_marka";
            this.lbl_marka.Size = new System.Drawing.Size(47, 17);
            this.lbl_marka.TabIndex = 10;
            this.lbl_marka.Text = "Marka";
            // 
            // lbl_plakano
            // 
            this.lbl_plakano.AutoSize = true;
            this.lbl_plakano.Location = new System.Drawing.Point(27, 36);
            this.lbl_plakano.Name = "lbl_plakano";
            this.lbl_plakano.Size = new System.Drawing.Size(65, 17);
            this.lbl_plakano.TabIndex = 9;
            this.lbl_plakano.Text = "Plaka No";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(374, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(696, 168);
            this.dataGridView1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Aktif Müşteriler";
            // 
            // btn_karackiralama
            // 
            this.btn_karackiralama.Location = new System.Drawing.Point(23, 391);
            this.btn_karackiralama.Name = "btn_karackiralama";
            this.btn_karackiralama.Size = new System.Drawing.Size(232, 35);
            this.btn_karackiralama.TabIndex = 41;
            this.btn_karackiralama.Text = "Araç Kiralama";
            this.btn_karackiralama.UseVisualStyleBackColor = true;
            this.btn_karackiralama.Click += new System.EventHandler(this.Btn_karackiralama_Click);
            // 
            // ArabaKayitcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lvw_aracozellik);
            this.Name = "ArabaKayitcs";
            this.Text = "ArabaKayitcs";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvw_aracozellik;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_arabakaydet;
        private System.Windows.Forms.ComboBox cmb_yakittipi;
        private System.Windows.Forms.ComboBox cmb_vites;
        private System.Windows.Forms.ComboBox cmb_aractipi;
        private System.Windows.Forms.TextBox t_fiyat;
        private System.Windows.Forms.TextBox t_model;
        private System.Windows.Forms.TextBox t_marka;
        private System.Windows.Forms.TextBox t_plakano;
        private System.Windows.Forms.Label lbl_fiyat;
        private System.Windows.Forms.Label lbl_yakıttipi;
        private System.Windows.Forms.Label lbl_vites;
        private System.Windows.Forms.Label lbl_aractipi;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.Label lbl_marka;
        private System.Windows.Forms.Label lbl_plakano;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_karackiralama;
    }
}