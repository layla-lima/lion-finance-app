namespace lion_finance_app
{
    partial class TelaRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaRelatorio));
            lblAluguel = new Label();
            lblLazer = new Label();
            lblParcelas = new Label();
            lblTransporte = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lblAluguel
            // 
            lblAluguel.AutoSize = true;
            lblAluguel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAluguel.ForeColor = SystemColors.ButtonHighlight;
            lblAluguel.Location = new Point(795, 522);
            lblAluguel.Name = "lblAluguel";
            lblAluguel.Size = new Size(110, 32);
            lblAluguel.TabIndex = 0;
            lblAluguel.Text = "Aluguel: ";
            // 
            // lblLazer
            // 
            lblLazer.AutoSize = true;
            lblLazer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblLazer.ForeColor = SystemColors.ButtonHighlight;
            lblLazer.Location = new Point(795, 563);
            lblLazer.Name = "lblLazer";
            lblLazer.Size = new Size(86, 32);
            lblLazer.TabIndex = 1;
            lblLazer.Text = "Lazer: ";
            // 
            // lblParcelas
            // 
            lblParcelas.AutoSize = true;
            lblParcelas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblParcelas.ForeColor = SystemColors.ButtonHighlight;
            lblParcelas.Location = new Point(795, 643);
            lblParcelas.Name = "lblParcelas";
            lblParcelas.Size = new Size(115, 32);
            lblParcelas.TabIndex = 2;
            lblParcelas.Text = "Parcelas: ";
            // 
            // lblTransporte
            // 
            lblTransporte.AutoSize = true;
            lblTransporte.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTransporte.ForeColor = SystemColors.ButtonHighlight;
            lblTransporte.Location = new Point(795, 604);
            lblTransporte.Name = "lblTransporte";
            lblTransporte.Size = new Size(144, 32);
            lblTransporte.TabIndex = 3;
            lblTransporte.Text = "Transporte: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(749, 519);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(749, 640);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(749, 601);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(749, 560);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // TelaRelatorio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 17, 17);
            ClientSize = new Size(1143, 750);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblTransporte);
            Controls.Add(lblParcelas);
            Controls.Add(lblLazer);
            Controls.Add(lblAluguel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "TelaRelatorio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaRelatorio";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAluguel;
        private Label lblLazer;
        private Label lblParcelas;
        private Label lblTransporte;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}