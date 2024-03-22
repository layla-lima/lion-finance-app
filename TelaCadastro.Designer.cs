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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            btnCriarConta = new Button();
            textBox4 = new TextBox();
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
            // textBox1
            // 
            textBox1.Location = new Point(190, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(190, 231);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(292, 23);
            textBox2.TabIndex = 4;
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
            // textBox3
            // 
            textBox3.Location = new Point(190, 294);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(292, 23);
            textBox3.TabIndex = 6;
            textBox3.UseSystemPasswordChar = true;
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
            btnCriarConta.TabIndex = 7;
            btnCriarConta.Text = "Criar Conta";
            btnCriarConta.UseVisualStyleBackColor = false;
            btnCriarConta.Click += btnCriarConta_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(190, 355);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(292, 23);
            textBox4.TabIndex = 9;
            textBox4.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(190, 331);
            label5.Name = "label5";
            label5.Size = new Size(135, 21);
            label5.TabIndex = 8;
            label5.Text = "Confirmar Senha:";
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 17, 17);
            ClientSize = new Size(679, 506);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(btnCriarConta);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Button btnCriarConta;
        private TextBox textBox4;
        private Label label5;
    }
}