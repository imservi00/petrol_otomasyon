namespace Petrol_Otomasyon
{
    partial class YakıtTalepOnayı
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewYakıtTalepleri;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnReddet;

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
            btnOnayla = new Button();
            btnReddet = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewYakıtTalepleri).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewYakıtTalepleri
            // 
            dataGridViewYakıtTalepleri.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewYakıtTalepleri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewYakıtTalepleri.Location = new Point(11, 15);
            dataGridViewYakıtTalepleri.Margin = new Padding(3, 4, 3, 4);
            dataGridViewYakıtTalepleri.Name = "dataGridViewYakıtTalepleri";
            dataGridViewYakıtTalepleri.RowHeadersWidth = 51;
            dataGridViewYakıtTalepleri.Size = new Size(1065, 551);
            dataGridViewYakıtTalepleri.TabIndex = 0;
            // 
            // btnOnayla
            // 
            btnOnayla.BackColor = Color.FromArgb(128, 255, 128);
            btnOnayla.Location = new Point(374, 595);
            btnOnayla.Margin = new Padding(3, 4, 3, 4);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(101, 37);
            btnOnayla.TabIndex = 1;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = false;
            btnOnayla.Click += btnOnayla_Click;
            // 
            // btnReddet
            // 
            btnReddet.BackColor = Color.FromArgb(255, 128, 128);
            btnReddet.Location = new Point(613, 595);
            btnReddet.Margin = new Padding(3, 4, 3, 4);
            btnReddet.Name = "btnReddet";
            btnReddet.Size = new Size(101, 37);
            btnReddet.TabIndex = 2;
            btnReddet.Text = "Reddet";
            btnReddet.UseVisualStyleBackColor = false;
            btnReddet.Click += btnReddet_Click;
            // 
            // YakıtTalepOnayı
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 663);
            Controls.Add(btnReddet);
            Controls.Add(btnOnayla);
            Controls.Add(dataGridViewYakıtTalepleri);
            Margin = new Padding(3, 4, 3, 4);
            Name = "YakıtTalepOnayı";
            Text = "Yakıt Talep Onayı";
            Load += YakıtTalepOnayı_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewYakıtTalepleri).EndInit();
            ResumeLayout(false);
        }
    }
}
