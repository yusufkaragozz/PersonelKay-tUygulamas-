namespace PersonelKayıtUygulaması
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtAd = new Label();
            txtSoyAd = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            rbtnErkek = new Label();
            txtMeslegi = new Label();
            label8 = new Label();
            Kaydetbutton = new Button();
            Çıkışbutton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            rbtnKadın = new RadioButton();
            dtpIseGirisTarihi = new DateTimePicker();
            textBox3 = new TextBox();
            rbtnErkekk = new RadioButton();
            rbtnBekar = new RadioButton();
            rbtnEvli = new RadioButton();
            txtID = new Label();
            txtTelNo = new MaskedTextBox();
            txtTcNo = new MaskedTextBox();
            Guncellebutton = new Button();
            textBox4 = new TextBox();
            createDatabaseBindingSource = new BindingSource(components);
            createDatabaseBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)createDatabaseBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)createDatabaseBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.AutoSize = true;
            txtAd.Font = new Font("Segoe UI Variable Text Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtAd.Location = new Point(75, 50);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(55, 31);
            txtAd.TabIndex = 0;
            txtAd.Text = "Ad :";
            // 
            // txtSoyAd
            // 
            txtSoyAd.AutoSize = true;
            txtSoyAd.Font = new Font("Segoe UI Variable Text Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtSoyAd.Location = new Point(30, 83);
            txtSoyAd.Name = "txtSoyAd";
            txtSoyAd.Size = new Size(100, 31);
            txtSoyAd.TabIndex = 1;
            txtSoyAd.Text = "SoyAdı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(44, 159);
            label3.Name = "label3";
            label3.Size = new Size(86, 31);
            label3.TabIndex = 2;
            label3.Text = "Tc No :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Text Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(37, 190);
            label4.Name = "label4";
            label4.Size = new Size(93, 31);
            label4.TabIndex = 3;
            label4.Text = "Tel No :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Text Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(-2, 232);
            label5.Name = "label5";
            label5.Size = new Size(170, 31);
            label5.TabIndex = 4;
            label5.Text = "İşe Giriş Tarihi :";
            // 
            // rbtnErkek
            // 
            rbtnErkek.AutoSize = true;
            rbtnErkek.Font = new Font("Segoe UI Variable Text Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rbtnErkek.Location = new Point(23, 118);
            rbtnErkek.Name = "rbtnErkek";
            rbtnErkek.Size = new Size(107, 31);
            rbtnErkek.TabIndex = 5;
            rbtnErkek.Text = "Cinsiyet :";
            // 
            // txtMeslegi
            // 
            txtMeslegi.AutoSize = true;
            txtMeslegi.Font = new Font("Segoe UI Variable Text Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtMeslegi.Location = new Point(405, 26);
            txtMeslegi.Name = "txtMeslegi";
            txtMeslegi.Size = new Size(107, 31);
            txtMeslegi.TabIndex = 6;
            txtMeslegi.Text = "Mesleği :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Text Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(405, 78);
            label8.Name = "label8";
            label8.Size = new Size(181, 31);
            label8.TabIndex = 7;
            label8.Text = "Medeni Durum :";
            // 
            // Kaydetbutton
            // 
            Kaydetbutton.BackColor = Color.FromArgb(192, 0, 0);
            Kaydetbutton.Font = new Font("Segoe UI Variable Text Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Kaydetbutton.Location = new Point(405, 222);
            Kaydetbutton.Name = "Kaydetbutton";
            Kaydetbutton.Size = new Size(107, 41);
            Kaydetbutton.TabIndex = 8;
            Kaydetbutton.Text = "Kaydet";
            Kaydetbutton.UseVisualStyleBackColor = false;
            Kaydetbutton.Click += Kaydetbutton_Click;
            // 
            // Çıkışbutton
            // 
            Çıkışbutton.BackColor = Color.FromArgb(192, 0, 0);
            Çıkışbutton.Font = new Font("Segoe UI Variable Text Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Çıkışbutton.Location = new Point(635, 222);
            Çıkışbutton.Name = "Çıkışbutton";
            Çıkışbutton.Size = new Size(107, 41);
            Çıkışbutton.TabIndex = 9;
            Çıkışbutton.Text = "Çıkış";
            Çıkışbutton.UseVisualStyleBackColor = false;
            Çıkışbutton.Click += Çıkışbutton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 27);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(136, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 27);
            textBox2.TabIndex = 11;
            // 
            // rbtnKadın
            // 
            rbtnKadın.AutoSize = true;
            rbtnKadın.Font = new Font("Segoe UI Variable Text Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rbtnKadın.Location = new Point(231, 123);
            rbtnKadın.Name = "rbtnKadın";
            rbtnKadın.Size = new Size(74, 26);
            rbtnKadın.TabIndex = 13;
            rbtnKadın.TabStop = true;
            rbtnKadın.Text = "Kadın";
            rbtnKadın.UseVisualStyleBackColor = true;
            // 
            // dtpIseGirisTarihi
            // 
            dtpIseGirisTarihi.Location = new Point(174, 236);
            dtpIseGirisTarihi.Name = "dtpIseGirisTarihi";
            dtpIseGirisTarihi.Size = new Size(190, 27);
            dtpIseGirisTarihi.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(518, 26);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 27);
            textBox3.TabIndex = 15;
            // 
            // rbtnErkekk
            // 
            rbtnErkekk.AutoSize = true;
            rbtnErkekk.Font = new Font("Segoe UI Variable Text Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rbtnErkekk.Location = new Point(136, 123);
            rbtnErkekk.Name = "rbtnErkekk";
            rbtnErkekk.Size = new Size(73, 26);
            rbtnErkekk.TabIndex = 18;
            rbtnErkekk.TabStop = true;
            rbtnErkekk.Text = "Erkek";
            rbtnErkekk.UseVisualStyleBackColor = true;
            // 
            // rbtnBekar
            // 
            rbtnBekar.AutoSize = true;
            rbtnBekar.Font = new Font("Segoe UI Variable Text Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rbtnBekar.Location = new Point(668, 83);
            rbtnBekar.Name = "rbtnBekar";
            rbtnBekar.Size = new Size(74, 26);
            rbtnBekar.TabIndex = 19;
            rbtnBekar.TabStop = true;
            rbtnBekar.Text = "Bekar";
            rbtnBekar.UseVisualStyleBackColor = true;
            // 
            // rbtnEvli
            // 
            rbtnEvli.AutoSize = true;
            rbtnEvli.Font = new Font("Segoe UI Variable Text Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rbtnEvli.Location = new Point(592, 83);
            rbtnEvli.Name = "rbtnEvli";
            rbtnEvli.Size = new Size(57, 26);
            rbtnEvli.TabIndex = 20;
            rbtnEvli.TabStop = true;
            rbtnEvli.Text = "Evli";
            rbtnEvli.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            txtID.AutoSize = true;
            txtID.Font = new Font("Segoe UI Variable Text Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtID.Location = new Point(75, 9);
            txtID.Name = "txtID";
            txtID.Size = new Size(47, 31);
            txtID.TabIndex = 21;
            txtID.Text = "Id :";
            // 
            // txtTelNo
            // 
            txtTelNo.Location = new Point(136, 194);
            txtTelNo.Mask = "(999) 000-0000";
            txtTelNo.Name = "txtTelNo";
            txtTelNo.Size = new Size(125, 27);
            txtTelNo.TabIndex = 22;
            // 
            // txtTcNo
            // 
            txtTcNo.Location = new Point(136, 161);
            txtTcNo.Mask = "00000000000";
            txtTcNo.Name = "txtTcNo";
            txtTcNo.Size = new Size(125, 27);
            txtTcNo.TabIndex = 23;
            txtTcNo.ValidatingType = typeof(int);
            // 
            // Guncellebutton
            // 
            Guncellebutton.BackColor = Color.FromArgb(192, 0, 0);
            Guncellebutton.Font = new Font("Segoe UI Variable Text Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Guncellebutton.Location = new Point(518, 222);
            Guncellebutton.Name = "Guncellebutton";
            Guncellebutton.Size = new Size(111, 41);
            Guncellebutton.TabIndex = 24;
            Guncellebutton.Text = "Güncelle";
            Guncellebutton.UseVisualStyleBackColor = false;
            Guncellebutton.Click += Guncellebutton_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(136, 90);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 27);
            textBox4.TabIndex = 25;
            // 
            // createDatabaseBindingSource
            // 
            createDatabaseBindingSource.DataSource = typeof(Migrations.CreateDatabase);
            // 
            // createDatabaseBindingSource1
            // 
            createDatabaseBindingSource1.DataSource = typeof(Migrations.CreateDatabase);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 485);
            Controls.Add(textBox4);
            Controls.Add(Guncellebutton);
            Controls.Add(txtTcNo);
            Controls.Add(txtTelNo);
            Controls.Add(txtID);
            Controls.Add(rbtnEvli);
            Controls.Add(rbtnBekar);
            Controls.Add(rbtnErkekk);
            Controls.Add(textBox3);
            Controls.Add(dtpIseGirisTarihi);
            Controls.Add(rbtnKadın);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Çıkışbutton);
            Controls.Add(Kaydetbutton);
            Controls.Add(label8);
            Controls.Add(txtMeslegi);
            Controls.Add(rbtnErkek);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtSoyAd);
            Controls.Add(txtAd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)createDatabaseBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)createDatabaseBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtAd;
        private Label txtSoyAd;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label rbtnErkek;
        private Label txtMeslegi;
        private Label label8;
        private Button Kaydetbutton;
        private Button Çıkışbutton;
        private TextBox textBox1;
        private TextBox textBox2;
        private RadioButton rbtnKadın;
        private DateTimePicker dtpIseGirisTarihi;
        private TextBox textBox3;
        private RadioButton rbtnErkekk;
        private RadioButton rbtnBekar;
        private RadioButton rbtnEvli;
        private Label txtID;
        private MaskedTextBox txtTelNo;
        private MaskedTextBox txtTcNo;
        private Button Guncellebutton;
        private TextBox textBox4;
        private BindingSource createDatabaseBindingSource;
        private BindingSource createDatabaseBindingSource1;
    }
}
