namespace Petrol_Otomasyon
{
    partial class RaporEkrani
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewYakıtTalepleri;
        private System.Windows.Forms.DataGridView dataGridViewIslemler;
        private System.Windows.Forms.DataGridView dataGridViewSubePerformans;
        private System.Windows.Forms.Label lblYakıtTalepleri;
        private System.Windows.Forms.Label lblIslemler;
        private System.Windows.Forms.Label lblSubePerformans;

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
            dataGridViewYakıtTalepleri = new DataGridView();
            dataGridViewIslemler = new DataGridView();
            dataGridViewSubePerformans = new DataGridView();
            lblYakıtTalepleri = new Label();
            lblIslemler = new Label();
            lblSubePerformans = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewYakıtTalepleri).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIslemler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubePerformans).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewYakıtTalepleri
            // 
            dataGridViewYakıtTalepleri.BackgroundColor = Color.FromArgb(255, 192, 128);
            dataGridViewYakıtTalepleri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewYakıtTalepleri.Location = new Point(12, 35);
            dataGridViewYakıtTalepleri.Name = "dataGridViewYakıtTalepleri";
            dataGridViewYakıtTalepleri.RowHeadersWidth = 51;
            dataGridViewYakıtTalepleri.Size = new Size(776, 150);
            dataGridViewYakıtTalepleri.TabIndex = 0;
            // 
            // dataGridViewIslemler
            // 
            dataGridViewIslemler.BackgroundColor = Color.FromArgb(255, 192, 128);
            dataGridViewIslemler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIslemler.Location = new Point(12, 220);
            dataGridViewIslemler.Name = "dataGridViewIslemler";
            dataGridViewIslemler.RowHeadersWidth = 51;
            dataGridViewIslemler.Size = new Size(776, 150);
            dataGridViewIslemler.TabIndex = 1;
            // 
            // dataGridViewSubePerformans
            // 
            dataGridViewSubePerformans.BackgroundColor = Color.FromArgb(255, 192, 128);
            dataGridViewSubePerformans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSubePerformans.Location = new Point(12, 405);
            dataGridViewSubePerformans.Name = "dataGridViewSubePerformans";
            dataGridViewSubePerformans.RowHeadersWidth = 51;
            dataGridViewSubePerformans.Size = new Size(776, 150);
            dataGridViewSubePerformans.TabIndex = 2;
            // 
            // lblYakıtTalepleri
            // 
            lblYakıtTalepleri.AutoSize = true;
            lblYakıtTalepleri.Location = new Point(12, 17);
            lblYakıtTalepleri.Name = "lblYakıtTalepleri";
            lblYakıtTalepleri.Size = new Size(100, 20);
            lblYakıtTalepleri.TabIndex = 3;
            lblYakıtTalepleri.Text = "Yakıt Talepleri";
            // 
            // lblIslemler
            // 
            lblIslemler.AutoSize = true;
            lblIslemler.Location = new Point(12, 204);
            lblIslemler.Name = "lblIslemler";
            lblIslemler.Size = new Size(61, 20);
            lblIslemler.TabIndex = 4;
            lblIslemler.Text = "İşlemler";
            // 
            // lblSubePerformans
            // 
            lblSubePerformans.AutoSize = true;
            lblSubePerformans.Location = new Point(12, 389);
            lblSubePerformans.Name = "lblSubePerformans";
            lblSubePerformans.Size = new Size(124, 20);
            lblSubePerformans.TabIndex = 5;
            lblSubePerformans.Text = "Şube Performansı";
            // 
            // RaporEkrani
            // 
            ClientSize = new Size(800, 567);
            Controls.Add(lblSubePerformans);
            Controls.Add(lblIslemler);
            Controls.Add(lblYakıtTalepleri);
            Controls.Add(dataGridViewSubePerformans);
            Controls.Add(dataGridViewIslemler);
            Controls.Add(dataGridViewYakıtTalepleri);
            Name = "RaporEkrani";
            Text = "Rapor Ekranı";
            Load += RaporEkrani_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewYakıtTalepleri).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIslemler).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubePerformans).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
