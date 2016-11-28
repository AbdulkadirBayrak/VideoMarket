namespace wfVideoMarketProjesi
{
    partial class frmSatisSorgulama
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTarih1 = new System.Windows.Forms.DateTimePicker();
            this.dtpTarih2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lvSatislar = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.txtToplamAdet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btngetir = new System.Windows.Forms.Button();
            this.dgvsatislar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsatislar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(193, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlk Tarih";
            // 
            // dtpTarih1
            // 
            this.dtpTarih1.Location = new System.Drawing.Point(169, 148);
            this.dtpTarih1.Name = "dtpTarih1";
            this.dtpTarih1.Size = new System.Drawing.Size(105, 20);
            this.dtpTarih1.TabIndex = 1;
            // 
            // dtpTarih2
            // 
            this.dtpTarih2.Location = new System.Drawing.Point(434, 148);
            this.dtpTarih2.Name = "dtpTarih2";
            this.dtpTarih2.Size = new System.Drawing.Size(105, 20);
            this.dtpTarih2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(455, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Son Tarih";
            // 
            // lvSatislar
            // 
            this.lvSatislar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvSatislar.FullRowSelect = true;
            this.lvSatislar.GridLines = true;
            this.lvSatislar.Location = new System.Drawing.Point(58, 231);
            this.lvSatislar.Name = "lvSatislar";
            this.lvSatislar.Size = new System.Drawing.Size(608, 46);
            this.lvSatislar.TabIndex = 40;
            this.lvSatislar.UseCompatibleStateImageBehavior = false;
            this.lvSatislar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SatışTarihi";
            this.columnHeader2.Width = 106;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "FilmAdı";
            this.columnHeader3.Width = 133;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Müşteri";
            this.columnHeader4.Width = 129;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fiyat";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 77;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Adet";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 82;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tutar";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 70;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(592, 444);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.ReadOnly = true;
            this.txtToplamTutar.Size = new System.Drawing.Size(70, 20);
            this.txtToplamTutar.TabIndex = 55;
            this.txtToplamTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtToplamAdet
            // 
            this.txtToplamAdet.Location = new System.Drawing.Point(509, 444);
            this.txtToplamAdet.Name = "txtToplamAdet";
            this.txtToplamAdet.ReadOnly = true;
            this.txtToplamAdet.Size = new System.Drawing.Size(77, 20);
            this.txtToplamAdet.TabIndex = 54;
            this.txtToplamAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(424, 447);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Toplam";
            // 
            // btngetir
            // 
            this.btngetir.Location = new System.Drawing.Point(296, 192);
            this.btngetir.Name = "btngetir";
            this.btngetir.Size = new System.Drawing.Size(108, 23);
            this.btngetir.TabIndex = 56;
            this.btngetir.Text = "Satışları Getir";
            this.btngetir.UseVisualStyleBackColor = true;
            this.btngetir.Click += new System.EventHandler(this.btngetir_Click);
            // 
            // dgvsatislar
            // 
            this.dgvsatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsatislar.Location = new System.Drawing.Point(58, 221);
            this.dgvsatislar.Name = "dgvsatislar";
            this.dgvsatislar.Size = new System.Drawing.Size(608, 168);
            this.dgvsatislar.TabIndex = 57;
            // 
            // frmSatisSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 512);
            this.Controls.Add(this.dgvsatislar);
            this.Controls.Add(this.btngetir);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.txtToplamAdet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lvSatislar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpTarih2);
            this.Controls.Add(this.dtpTarih1);
            this.Controls.Add(this.label1);
            this.Name = "frmSatisSorgulama";
            this.Text = "Satış Sorgulama";
            ((System.ComponentModel.ISupportInitialize)(this.dgvsatislar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTarih1;
        private System.Windows.Forms.DateTimePicker dtpTarih2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvSatislar;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.TextBox txtToplamAdet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btngetir;
        private System.Windows.Forms.DataGridView dgvsatislar;
    }
}