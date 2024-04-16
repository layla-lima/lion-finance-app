namespace lion_finance_app

{
    partial class TelaCadastroFinanceiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroFinanceiro));
            lblControl = new Label();
            pictureBox1 = new PictureBox();
            lblFixos = new Label();
            lblVari = new Label();
            lblRec = new Label();
            lblFinan = new Label();
            lblContas = new Label();
            lblParcela = new Label();
            lblAluguel = new Label();
            txtFinanc = new TextBox();
            lblCompras = new Label();
            lblLazer = new Label();
            txtConta = new TextBox();
            txtParc = new TextBox();
            txtAluguel = new TextBox();
            txtCompra = new TextBox();
            txtLazer = new TextBox();
            lblTransp = new Label();
            txtTransp = new TextBox();
            lblRecebimentoFixo = new Label();
            txtRendaFixa = new TextBox();
            btnProximo = new Button();
            lblRecebimentoVariavel = new Label();
            txtRendaVari = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblControl
            // 
            lblControl.AutoSize = true;
            lblControl.Font = new Font("Broadway", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblControl.ForeColor = Color.FromArgb(201, 160, 80);
            lblControl.Location = new Point(21, 25);
            lblControl.Name = "lblControl";
            lblControl.Size = new Size(469, 43);
            lblControl.TabIndex = 0;
            lblControl.Text = "Controle de Despesas";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(526, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblFixos
            // 
            lblFixos.AutoSize = true;
            lblFixos.Font = new Font("Arial Black", 13F, FontStyle.Bold);
            lblFixos.ForeColor = Color.White;
            lblFixos.Location = new Point(38, 95);
            lblFixos.Name = "lblFixos";
            lblFixos.Size = new Size(160, 26);
            lblFixos.TabIndex = 1;
            lblFixos.Text = "GASTOS FIXOS";
            // 
            // lblVari
            // 
            lblVari.AutoSize = true;
            lblVari.Font = new Font("Arial Black", 13F, FontStyle.Bold);
            lblVari.ForeColor = Color.White;
            lblVari.Location = new Point(38, 280);
            lblVari.Name = "lblVari";
            lblVari.Size = new Size(209, 26);
            lblVari.TabIndex = 10;
            lblVari.Text = "GASTOS VARIÁVEIS";
            // 
            // lblRec
            // 
            lblRec.AutoSize = true;
            lblRec.Font = new Font("Arial Black", 13F, FontStyle.Bold);
            lblRec.ForeColor = Color.White;
            lblRec.Location = new Point(480, 280);
            lblRec.Name = "lblRec";
            lblRec.Size = new Size(172, 26);
            lblRec.TabIndex = 17;
            lblRec.Text = "RECEBIMENTOS";
            // 
            // lblFinan
            // 
            lblFinan.AutoSize = true;
            lblFinan.Font = new Font("Arial Black", 9.75F, FontStyle.Bold);
            lblFinan.ForeColor = Color.White;
            lblFinan.Location = new Point(42, 144);
            lblFinan.Name = "lblFinan";
            lblFinan.Size = new Size(128, 18);
            lblFinan.TabIndex = 2;
            lblFinan.Text = "Financiamentos:";
            // 
            // lblContas
            // 
            lblContas.AutoSize = true;
            lblContas.Font = new Font("Arial Black", 9.75F, FontStyle.Bold);
            lblContas.ForeColor = Color.White;
            lblContas.Location = new Point(42, 177);
            lblContas.Name = "lblContas";
            lblContas.Size = new Size(170, 18);
            lblContas.TabIndex = 4;
            lblContas.Text = "Contas (Luz, Internet):";
            // 
            // lblParcela
            // 
            lblParcela.AutoSize = true;
            lblParcela.Font = new Font("Arial Black", 9.75F, FontStyle.Bold);
            lblParcela.ForeColor = Color.White;
            lblParcela.Location = new Point(42, 210);
            lblParcela.Name = "lblParcela";
            lblParcela.Size = new Size(121, 18);
            lblParcela.TabIndex = 6;
            lblParcela.Text = "Parcelamentos:";
            // 
            // lblAluguel
            // 
            lblAluguel.AutoSize = true;
            lblAluguel.Font = new Font("Arial Black", 9.75F, FontStyle.Bold);
            lblAluguel.ForeColor = Color.White;
            lblAluguel.Location = new Point(42, 246);
            lblAluguel.Name = "lblAluguel";
            lblAluguel.Size = new Size(121, 18);
            lblAluguel.TabIndex = 8;
            lblAluguel.Text = "Aluguel Mensal:";
            // 
            // txtFinanc
            // 
            txtFinanc.Location = new Point(254, 139);
            txtFinanc.Name = "txtFinanc";
            txtFinanc.Size = new Size(153, 23);
            txtFinanc.TabIndex = 3;
            // 
            // lblCompras
            // 
            lblCompras.AutoSize = true;
            lblCompras.Font = new Font("Arial Black", 9.75F, FontStyle.Bold);
            lblCompras.ForeColor = Color.White;
            lblCompras.Location = new Point(39, 316);
            lblCompras.Name = "lblCompras";
            lblCompras.Size = new Size(131, 18);
            lblCompras.TabIndex = 11;
            lblCompras.Text = "Compras do Mês:";
            // 
            // lblLazer
            // 
            lblLazer.AutoSize = true;
            lblLazer.Font = new Font("Arial Black", 9.75F, FontStyle.Bold);
            lblLazer.ForeColor = Color.White;
            lblLazer.Location = new Point(38, 350);
            lblLazer.Name = "lblLazer";
            lblLazer.Size = new Size(53, 18);
            lblLazer.TabIndex = 13;
            lblLazer.Text = "Lazer:";
            // 
            // txtConta
            // 
            txtConta.Location = new Point(254, 172);
            txtConta.Name = "txtConta";
            txtConta.Size = new Size(153, 23);
            txtConta.TabIndex = 5;
            // 
            // txtParc
            // 
            txtParc.Location = new Point(254, 205);
            txtParc.Name = "txtParc";
            txtParc.Size = new Size(153, 23);
            txtParc.TabIndex = 7;
            // 
            // txtAluguel
            // 
            txtAluguel.Location = new Point(254, 241);
            txtAluguel.Name = "txtAluguel";
            txtAluguel.Size = new Size(153, 23);
            txtAluguel.TabIndex = 9;
            // 
            // txtCompra
            // 
            txtCompra.Location = new Point(254, 315);
            txtCompra.Name = "txtCompra";
            txtCompra.Size = new Size(153, 23);
            txtCompra.TabIndex = 12;
            // 
            // txtLazer
            // 
            txtLazer.Location = new Point(254, 349);
            txtLazer.Name = "txtLazer";
            txtLazer.Size = new Size(153, 23);
            txtLazer.TabIndex = 14;
            // 
            // lblTransp
            // 
            lblTransp.AutoSize = true;
            lblTransp.Font = new Font("Arial Black", 9.75F, FontStyle.Bold);
            lblTransp.ForeColor = Color.White;
            lblTransp.Location = new Point(38, 387);
            lblTransp.Name = "lblTransp";
            lblTransp.Size = new Size(92, 18);
            lblTransp.TabIndex = 15;
            lblTransp.Text = "Transporte:";
            // 
            // txtTransp
            // 
            txtTransp.Location = new Point(254, 382);
            txtTransp.Name = "txtTransp";
            txtTransp.Size = new Size(153, 23);
            txtTransp.TabIndex = 16;
            // 
            // lblRecebimentoFixo
            // 
            lblRecebimentoFixo.AutoSize = true;
            lblRecebimentoFixo.Font = new Font("Arial Black", 9.75F, FontStyle.Bold);
            lblRecebimentoFixo.ForeColor = Color.White;
            lblRecebimentoFixo.Location = new Point(480, 317);
            lblRecebimentoFixo.Name = "lblRecebimentoFixo";
            lblRecebimentoFixo.Size = new Size(130, 18);
            lblRecebimentoFixo.TabIndex = 18;
            lblRecebimentoFixo.Text = "Rendimento fixo:";
            // 
            // txtRendaFixa
            // 
            txtRendaFixa.Location = new Point(663, 316);
            txtRendaFixa.Name = "txtRendaFixa";
            txtRendaFixa.Size = new Size(126, 23);
            txtRendaFixa.TabIndex = 19;
            // 
            // btnProximo
            // 
            btnProximo.BackColor = Color.FromArgb(201, 160, 80);
            btnProximo.FlatStyle = FlatStyle.Popup;
            btnProximo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnProximo.Location = new Point(672, 444);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(106, 25);
            btnProximo.TabIndex = 22;
            btnProximo.Text = "Proximo";
            btnProximo.UseVisualStyleBackColor = false;
            btnProximo.Click += btnProximo_Click;
            // 
            // lblRecebimentoVariavel
            // 
            lblRecebimentoVariavel.AutoSize = true;
            lblRecebimentoVariavel.Font = new Font("Arial Black", 9.75F, FontStyle.Bold);
            lblRecebimentoVariavel.ForeColor = Color.White;
            lblRecebimentoVariavel.Location = new Point(480, 352);
            lblRecebimentoVariavel.Name = "lblRecebimentoVariavel";
            lblRecebimentoVariavel.Size = new Size(160, 18);
            lblRecebimentoVariavel.TabIndex = 20;
            lblRecebimentoVariavel.Text = "Rendimento variavel:";
            // 
            // txtRendaVari
            // 
            txtRendaVari.Location = new Point(663, 349);
            txtRendaVari.Name = "txtRendaVari";
            txtRendaVari.Size = new Size(126, 23);
            txtRendaVari.TabIndex = 21;
            // 
            // TelaCadastroFinanceiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 17, 17);
            ClientSize = new Size(800, 494);
            Controls.Add(txtRendaVari);
            Controls.Add(lblRecebimentoVariavel);
            Controls.Add(btnProximo);
            Controls.Add(txtRendaFixa);
            Controls.Add(lblRecebimentoFixo);
            Controls.Add(txtTransp);
            Controls.Add(lblTransp);
            Controls.Add(txtLazer);
            Controls.Add(txtCompra);
            Controls.Add(txtAluguel);
            Controls.Add(txtParc);
            Controls.Add(txtConta);
            Controls.Add(lblLazer);
            Controls.Add(lblCompras);
            Controls.Add(txtFinanc);
            Controls.Add(lblAluguel);
            Controls.Add(lblParcela);
            Controls.Add(lblContas);
            Controls.Add(lblFinan);
            Controls.Add(lblRec);
            Controls.Add(lblVari);
            Controls.Add(lblFixos);
            Controls.Add(pictureBox1);
            Controls.Add(lblControl);
            Name = "TelaCadastroFinanceiro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDados";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblControl;
        private PictureBox pictureBox1;
        private Label lblFixos;
        private Label lblVari;
        private Label lblRec;
        private Label lblFinan;
        private Label lblContas;
        private Label lblParcela;
        private Label lblAluguel;
        private TextBox txtFinanc;
        private Label lblCompras;
        private Label lblLazer;
        private TextBox txtConta;
        private TextBox txtParc;
        private TextBox txtAluguel;
        private TextBox txtCompra;
        private TextBox txtLazer;
        private Label lblTransp;
        private TextBox txtTransp;
        private Label lblRecebimentoFixo;
        private TextBox txtRendaFixa;
        private Button btnProximo;
        private Label lblRecebimentoVariavel;
        private TextBox txtRendaVari;
    }
}
