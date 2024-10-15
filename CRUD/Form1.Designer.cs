namespace CRUD
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
            label1 = new Label();
            btnSimpan = new Button();
            label2 = new Label();
            txtKode = new TextBox();
            txtNama = new TextBox();
            btnGanti = new Button();
            btnHapus = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 1;
            label1.Text = "Kode Barang";
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(124, 98);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 2;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 3;
            label2.Text = "Nama Barang";
            // 
            // txtKode
            // 
            txtKode.Location = new Point(124, 22);
            txtKode.Name = "txtKode";
            txtKode.Size = new Size(269, 23);
            txtKode.TabIndex = 4;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(124, 53);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(269, 23);
            txtNama.TabIndex = 5;
            // 
            // btnGanti
            // 
            btnGanti.Location = new Point(205, 98);
            btnGanti.Name = "btnGanti";
            btnGanti.Size = new Size(75, 23);
            btnGanti.TabIndex = 6;
            btnGanti.Text = "Ganti";
            btnGanti.UseVisualStyleBackColor = true;
            btnGanti.Click += btnGanti_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(286, 98);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(75, 23);
            btnHapus.TabIndex = 7;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(403, 291);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnHapus);
            Controls.Add(btnGanti);
            Controls.Add(txtNama);
            Controls.Add(txtKode);
            Controls.Add(label2);
            Controls.Add(btnSimpan);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Simple CRUD";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSimpan;
        private Label label2;
        private TextBox txtKode;
        private TextBox txtNama;
        private Button btnGanti;
        private Button btnHapus;
        private DataGridView dataGridView1;
    }
}
