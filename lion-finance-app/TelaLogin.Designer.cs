
namespace lion_finance_app
{
    partial class TelaLogin
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            label2 = new Label();
            btnEntrar = new Button();
            lblCadastrar = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LionIcon__700_x_400_px_;
            pictureBox1.Location = new Point(215, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(382, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(262, 234);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 1;
            label1.Text = "Login:";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(262, 258);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(291, 23);
            txtLogin.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(262, 324);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(291, 23);
            txtSenha.TabIndex = 4;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(262, 300);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 3;
            label2.Text = "Senha:";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(201, 160, 80);
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(262, 384);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(291, 28);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lblCadastrar
            // 
            lblCadastrar.AutoSize = true;
            lblCadastrar.Cursor = Cursors.Hand;
            lblCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblCadastrar.ForeColor = SystemColors.ButtonFace;
            lblCadastrar.Location = new Point(354, 433);
            lblCadastrar.Name = "lblCadastrar";
            lblCadastrar.Size = new Size(104, 15);
            lblCadastrar.TabIndex = 6;
            lblCadastrar.Text = "Não possui conta?";
            lblCadastrar.Click += lblCadastrar_Click;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 17, 17);
            ClientSize = new Size(800, 496);
            Controls.Add(lblCadastrar);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(label2);
            Controls.Add(txtLogin);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "TelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Login - Lion Finance      ";
            Load += TelaLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
           
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Label label2;
        private Button btnEntrar;
        private Label lblCadastrar;
    }
}
