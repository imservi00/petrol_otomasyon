namespace Petrol_Otomasyon
{
    partial class SubeYoneticiEkrani
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewSubePerformansi;
        private System.Windows.Forms.DataGridView dataGridViewYakitStok;
        private System.Windows.Forms.DataGridView dataGridViewYakıtTalepleri;
        private System.Windows.Forms.DataGridView dataGridViewPersonel;
        private System.Windows.Forms.Label lblSubePerformansi;
        private System.Windows.Forms.Label lblYakitStok;
        private System.Windows.Forms.Label lblYakıtTalepleri;
        private System.Windows.Forms.Label lblPersonel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewSubePerformansi = new DataGridView();
            dataGridViewYakitStok = new DataGridView();
            dataGridViewYakıtTalepleri = new DataGridView();
            dataGridViewPersonel = new DataGridView();
            lblSubePerformansi = new Label();
            lblYakitStok = new Label();
            lblYakıtTalepleri = new Label();
            lblPersonel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubePerformansi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewYakitStok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewYakıtTalepleri).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersonel).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSubePerformansi
            // 
            dataGridViewSubePerformansi.BackgroundColor = Color.FromArgb(255, 192, 128);
            dataGridViewSubePerformansi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSubePerformansi.Location = new Point(12, 35);
            dataGridViewSubePerformansi.Name = "dataGridViewSubePerformansi";
            dataGridViewSubePerformansi.RowHeadersWidth = 51;
            dataGridViewSubePerformansi.Size = new Size(776, 150);
            dataGridViewSubePerformansi.TabIndex = 0;
            // 
            // dataGridViewYakitStok
            // 
            dataGridViewYakitStok.BackgroundColor = Color.FromArgb(255, 192, 128);
            dataGridViewYakitStok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewYakitStok.Location = new Point(12, 220);
            dataGridViewYakitStok.Name = "dataGridViewYakitStok";
            dataGridViewYakitStok.RowHeadersWidth = 51;
            dataGridViewYakitStok.Size = new Size(776, 150);
            dataGridViewYakitStok.TabIndex = 1;
            // 
            // dataGridViewYakıtTalepleri
            // 
            dataGridViewYakıtTalepleri.BackgroundColor = Color.FromArgb(255, 192, 128);
            dataGridViewYakıtTalepleri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewYakıtTalepleri.Location = new Point(12, 405);
            dataGridViewYakıtTalepleri.Name = "dataGridViewYakıtTalepleri";
            dataGridViewYakıtTalepleri.RowHeadersWidth = 51;
            dataGridViewYakıtTalepleri.Size = new Size(776, 150);
            dataGridViewYakıtTalepleri.TabIndex = 2;
            // 
            // dataGridViewPersonel
            // 
            dataGridViewPersonel.BackgroundColor = Color.FromArgb(255, 192, 128);
            dataGridViewPersonel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPersonel.Location = new Point(12, 590);
            dataGridViewPersonel.Name = "dataGridViewPersonel";
            dataGridViewPersonel.RowHeadersWidth = 51;
            dataGridViewPersonel.Size = new Size(776, 150);
            dataGridViewPersonel.TabIndex = 3;
            // 
            // lblSubePerformansi
            // 
            lblSubePerformansi.AutoSize = true;
            lblSubePerformansi.Location = new Point(12, 17);
            lblSubePerformansi.Name = "lblSubePerformansi";
            lblSubePerformansi.Size = new Size(124, 20);
            lblSubePerformansi.TabIndex = 4;
            lblSubePerformansi.Text = "Şube Performansı";
            // 
            // lblYakitStok
            // 
            lblYakitStok.AutoSize = true;
            lblYakitStok.Location = new Point(12, 204);
            lblYakitStok.Name = "lblYakitStok";
            lblYakitStok.Size = new Size(130, 20);
            lblYakitStok.TabIndex = 5;
            lblYakitStok.Text = "Yakıt Stok Durumu";
            // 
            // lblYakıtTalepleri
            // 
            lblYakıtTalepleri.AutoSize = true;
            lblYakıtTalepleri.Location = new Point(12, 389);
            lblYakıtTalepleri.Name = "lblYakıtTalepleri";
            lblYakıtTalepleri.Size = new Size(100, 20);
            lblYakıtTalepleri.TabIndex = 6;
            lblYakıtTalepleri.Text = "Yakıt Talepleri";
            // 
            // lblPersonel
            // 
            lblPersonel.AutoSize = true;
            lblPersonel.Location = new Point(12, 574);
            lblPersonel.Name = "lblPersonel";
            lblPersonel.Size = new Size(64, 20);
            lblPersonel.TabIndex = 7;
            lblPersonel.Text = "Personel";
            // 
            // SubeYoneticiEkrani
            // 
            ClientSize = new Size(800, 760);
            Controls.Add(lblPersonel);
            Controls.Add(lblYakıtTalepleri);
            Controls.Add(lblYakitStok);
            Controls.Add(lblSubePerformansi);
            Controls.Add(dataGridViewPersonel);
            Controls.Add(dataGridViewYakıtTalepleri);
            Controls.Add(dataGridViewYakitStok);
            Controls.Add(dataGridViewSubePerformansi);
            Name = "SubeYoneticiEkrani";
            Text = "Şube Yönetici Ekranı";
            Load += SubeYoneticiEkrani_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubePerformansi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewYakitStok).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewYakıtTalepleri).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersonel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
