namespace lion_finance_app
{
    partial class TelaCadastro
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
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            label3 = new Label();
            txtSenha = new TextBox();
            label4 = new Label();
            btnCriarConta = new Button();
            txtConfSenha = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(183, 57);
            label1.Name = "label1";
            label1.Size = new Size(299, 50);
            label1.TabIndex = 0;
            label1.Text = "Criar uma conta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(190, 143);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(190, 167);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(292, 23);
            txtNome.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(190, 231);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(292, 23);
            txtEmail.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(190, 207);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 3;
            label3.Text = "E-mail:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(190, 294);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(292, 23);
            txtSenha.TabIndex = 6;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(190, 270);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 5;
            label4.Text = "Senha:";
            // 
            // btnCriarConta
            // 
            btnCriarConta.BackColor = Color.FromArgb(201, 160, 80);
            btnCriarConta.FlatAppearance.BorderSize = 0;
            btnCriarConta.FlatStyle = FlatStyle.Flat;
            btnCriarConta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCriarConta.Location = new Point(278, 438);
            btnCriarConta.Name = "btnCriarConta";
            btnCriarConta.Size = new Size(120, 23);
            btnCriarConta.TabIndex = 9;
            btnCriarConta.Text = "Criar Conta";
            btnCriarConta.UseVisualStyleBackColor = false;
            btnCriarConta.Click += btnCriarConta_Click;
            // 
            // txtConfSenha
            // 
            txtConfSenha.Location = new Point(190, 355);
            txtConfSenha.Name = "txtConfSenha";
            txtConfSenha.Size = new Size(292, 23);
            txtConfSenha.TabIndex = 8;
            txtConfSenha.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(190, 331);
            label5.Name = "label5";
            label5.Size = new Size(135, 21);
            label5.TabIndex = 7;
            label5.Text = "Confirmar Senha:";
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 17, 17);
            ClientSize = new Size(679, 506);
            Controls.Add(txtConfSenha);
            Controls.Add(label5);
            Controls.Add(btnCriarConta);
            Controls.Add(txtSenha);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaCadastro";
            Load += TelaCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtSenha;
        private Label label4;
        private Button btnCriarConta;
        private TextBox txtConfSenha;
        private Label label5;
    }
}