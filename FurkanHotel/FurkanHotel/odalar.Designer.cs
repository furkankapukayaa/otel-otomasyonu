﻿
namespace FurkanHotel
{
    partial class odalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(odalar));
            this.geriDon = new System.Windows.Forms.Button();
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.odaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaturDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odakisisayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaaciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odadurumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblOdaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbFurkanOtelDataSetODA2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbFurkanOtelDataSetODA2 = new FurkanHotel.dbFurkanOtelDataSetODA2();
            this.tblOdaTableAdapter = new FurkanHotel.dbFurkanOtelDataSetODA2TableAdapters.tblOdaTableAdapter();
            this.odaBosalt = new System.Windows.Forms.Button();
            this.odaTemizle = new System.Windows.Forms.Button();
            this.odaHazır = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOdaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFurkanOtelDataSetODA2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFurkanOtelDataSetODA2)).BeginInit();
            this.SuspendLayout();
            // 
            // geriDon
            // 
            this.geriDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.geriDon.BackColor = System.Drawing.Color.Transparent;
            this.geriDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("geriDon.BackgroundImage")));
            this.geriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.geriDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geriDon.FlatAppearance.BorderSize = 0;
            this.geriDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.geriDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.geriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geriDon.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.geriDon.Location = new System.Drawing.Point(1125, 686);
            this.geriDon.Margin = new System.Windows.Forms.Padding(4);
            this.geriDon.Name = "geriDon";
            this.geriDon.Size = new System.Drawing.Size(72, 56);
            this.geriDon.TabIndex = 126;
            this.geriDon.UseVisualStyleBackColor = false;
            this.geriDon.Click += new System.EventHandler(this.geriDon_Click);
            // 
            // icons
            // 
            this.icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icons.ImageStream")));
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            this.icons.Images.SetKeyName(0, "key.png");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odaidDataGridViewTextBoxColumn,
            this.odaadDataGridViewTextBoxColumn,
            this.odaturDataGridViewTextBoxColumn,
            this.odakisisayisiDataGridViewTextBoxColumn,
            this.odaaciklamaDataGridViewTextBoxColumn,
            this.odadurumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblOdaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1185, 564);
            this.dataGridView1.TabIndex = 130;
            // 
            // odaidDataGridViewTextBoxColumn
            // 
            this.odaidDataGridViewTextBoxColumn.DataPropertyName = "odaid";
            this.odaidDataGridViewTextBoxColumn.HeaderText = "odaid";
            this.odaidDataGridViewTextBoxColumn.Name = "odaidDataGridViewTextBoxColumn";
            this.odaidDataGridViewTextBoxColumn.ReadOnly = true;
            this.odaidDataGridViewTextBoxColumn.Visible = false;
            // 
            // odaadDataGridViewTextBoxColumn
            // 
            this.odaadDataGridViewTextBoxColumn.DataPropertyName = "odaad";
            this.odaadDataGridViewTextBoxColumn.HeaderText = "Oda Adı";
            this.odaadDataGridViewTextBoxColumn.Name = "odaadDataGridViewTextBoxColumn";
            this.odaadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // odaturDataGridViewTextBoxColumn
            // 
            this.odaturDataGridViewTextBoxColumn.DataPropertyName = "odatur";
            this.odaturDataGridViewTextBoxColumn.HeaderText = "odatur";
            this.odaturDataGridViewTextBoxColumn.Name = "odaturDataGridViewTextBoxColumn";
            this.odaturDataGridViewTextBoxColumn.ReadOnly = true;
            this.odaturDataGridViewTextBoxColumn.Visible = false;
            // 
            // odakisisayisiDataGridViewTextBoxColumn
            // 
            this.odakisisayisiDataGridViewTextBoxColumn.DataPropertyName = "odakisisayisi";
            this.odakisisayisiDataGridViewTextBoxColumn.HeaderText = "odakisisayisi";
            this.odakisisayisiDataGridViewTextBoxColumn.Name = "odakisisayisiDataGridViewTextBoxColumn";
            this.odakisisayisiDataGridViewTextBoxColumn.ReadOnly = true;
            this.odakisisayisiDataGridViewTextBoxColumn.Visible = false;
            // 
            // odaaciklamaDataGridViewTextBoxColumn
            // 
            this.odaaciklamaDataGridViewTextBoxColumn.DataPropertyName = "odaaciklama";
            this.odaaciklamaDataGridViewTextBoxColumn.HeaderText = "odaaciklama";
            this.odaaciklamaDataGridViewTextBoxColumn.Name = "odaaciklamaDataGridViewTextBoxColumn";
            this.odaaciklamaDataGridViewTextBoxColumn.ReadOnly = true;
            this.odaaciklamaDataGridViewTextBoxColumn.Visible = false;
            // 
            // odadurumDataGridViewTextBoxColumn
            // 
            this.odadurumDataGridViewTextBoxColumn.DataPropertyName = "odadurum";
            this.odadurumDataGridViewTextBoxColumn.HeaderText = "Oda Durumu";
            this.odadurumDataGridViewTextBoxColumn.Name = "odadurumDataGridViewTextBoxColumn";
            this.odadurumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblOdaBindingSource
            // 
            this.tblOdaBindingSource.DataMember = "tblOda";
            this.tblOdaBindingSource.DataSource = this.dbFurkanOtelDataSetODA2BindingSource;
            // 
            // dbFurkanOtelDataSetODA2BindingSource
            // 
            this.dbFurkanOtelDataSetODA2BindingSource.DataSource = this.dbFurkanOtelDataSetODA2;
            this.dbFurkanOtelDataSetODA2BindingSource.Position = 0;
            // 
            // dbFurkanOtelDataSetODA2
            // 
            this.dbFurkanOtelDataSetODA2.DataSetName = "dbFurkanOtelDataSetODA2";
            this.dbFurkanOtelDataSetODA2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblOdaTableAdapter
            // 
            this.tblOdaTableAdapter.ClearBeforeFill = true;
            // 
            // odaBosalt
            // 
            this.odaBosalt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.odaBosalt.Location = new System.Drawing.Point(335, 624);
            this.odaBosalt.Name = "odaBosalt";
            this.odaBosalt.Size = new System.Drawing.Size(140, 71);
            this.odaBosalt.TabIndex = 131;
            this.odaBosalt.Text = "Oda Boşalt";
            this.odaBosalt.UseVisualStyleBackColor = true;
            this.odaBosalt.Click += new System.EventHandler(this.odaBosalt_Click);
            // 
            // odaTemizle
            // 
            this.odaTemizle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.odaTemizle.Location = new System.Drawing.Point(481, 624);
            this.odaTemizle.Name = "odaTemizle";
            this.odaTemizle.Size = new System.Drawing.Size(140, 71);
            this.odaTemizle.TabIndex = 132;
            this.odaTemizle.Text = "Oda Temizle";
            this.odaTemizle.UseVisualStyleBackColor = true;
            this.odaTemizle.Click += new System.EventHandler(this.odaTemizle_Click);
            // 
            // odaHazır
            // 
            this.odaHazır.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.odaHazır.Location = new System.Drawing.Point(627, 624);
            this.odaHazır.Name = "odaHazır";
            this.odaHazır.Size = new System.Drawing.Size(140, 71);
            this.odaHazır.TabIndex = 133;
            this.odaHazır.Text = "Oda  Hazır";
            this.odaHazır.UseVisualStyleBackColor = true;
            this.odaHazır.Click += new System.EventHandler(this.odaHazır_Click);
            // 
            // odalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 755);
            this.Controls.Add(this.odaHazır);
            this.Controls.Add(this.odaTemizle);
            this.Controls.Add(this.odaBosalt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.geriDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "odalar";
            this.Text = "Odalar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.odalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOdaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFurkanOtelDataSetODA2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFurkanOtelDataSetODA2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button geriDon;
        private System.Windows.Forms.ImageList icons;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dbFurkanOtelDataSetODA2BindingSource;
        private dbFurkanOtelDataSetODA2 dbFurkanOtelDataSetODA2;
        private System.Windows.Forms.BindingSource tblOdaBindingSource;
        private dbFurkanOtelDataSetODA2TableAdapters.tblOdaTableAdapter tblOdaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaturDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odakisisayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaaciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odadurumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button odaBosalt;
        private System.Windows.Forms.Button odaTemizle;
        private System.Windows.Forms.Button odaHazır;
    }
}