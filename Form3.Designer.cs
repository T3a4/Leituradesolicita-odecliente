namespace LeituradeSolicitaçãodeCliente
{
    partial class FrmConsultadeClientes
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
            DtgListadeClientes = new DataGridView();
            BtnPáginaInicial = new Button();
            BtnConsultaaoCliente = new Button();
            TxtNome = new TextBox();
            CboRegião = new ComboBox();
            TxtEmail = new TextBox();
            CboDatadosAniversariantesdoMês = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DtgListadeClientes).BeginInit();
            SuspendLayout();
            // 
            // DtgListadeClientes
            // 
            DtgListadeClientes.BackgroundColor = Color.White;
            DtgListadeClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgListadeClientes.Location = new Point(111, 42);
            DtgListadeClientes.Name = "DtgListadeClientes";
            DtgListadeClientes.Size = new Size(523, 309);
            DtgListadeClientes.TabIndex = 1;
            // 
            // BtnPáginaInicial
            // 
            BtnPáginaInicial.BackColor = Color.BlueViolet;
            BtnPáginaInicial.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPáginaInicial.ForeColor = Color.White;
            BtnPáginaInicial.Location = new Point(327, 375);
            BtnPáginaInicial.Name = "BtnPáginaInicial";
            BtnPáginaInicial.Size = new Size(129, 26);
            BtnPáginaInicial.TabIndex = 2;
            BtnPáginaInicial.Text = "Página Inicial";
            BtnPáginaInicial.UseVisualStyleBackColor = false;
            // 
            // BtnConsultaaoCliente
            // 
            BtnConsultaaoCliente.BackColor = Color.BlueViolet;
            BtnConsultaaoCliente.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnConsultaaoCliente.ForeColor = Color.White;
            BtnConsultaaoCliente.Location = new Point(672, 113);
            BtnConsultaaoCliente.Name = "BtnConsultaaoCliente";
            BtnConsultaaoCliente.Size = new Size(176, 24);
            BtnConsultaaoCliente.TabIndex = 3;
            BtnConsultaaoCliente.Text = "Consulta ao Cliente";
            BtnConsultaaoCliente.UseVisualStyleBackColor = false;
            // 
            // TxtNome
            // 
            TxtNome.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNome.ForeColor = SystemColors.WindowText;
            TxtNome.Location = new Point(640, 143);
            TxtNome.Name = "TxtNome";
            TxtNome.PlaceholderText = "Nome";
            TxtNome.Size = new Size(251, 22);
            TxtNome.TabIndex = 4;
            // 
            // CboRegião
            // 
            CboRegião.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CboRegião.FormattingEnabled = true;
            CboRegião.Location = new Point(640, 171);
            CboRegião.Name = "CboRegião";
            CboRegião.Size = new Size(251, 22);
            CboRegião.TabIndex = 5;
            CboRegião.Text = "Região";
            // 
            // TxtEmail
            // 
            TxtEmail.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtEmail.Location = new Point(640, 199);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.PlaceholderText = "Email";
            TxtEmail.Size = new Size(251, 22);
            TxtEmail.TabIndex = 6;
            // 
            // CboDatadosAniversariantesdoMês
            // 
            CboDatadosAniversariantesdoMês.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CboDatadosAniversariantesdoMês.FormattingEnabled = true;
            CboDatadosAniversariantesdoMês.Location = new Point(640, 227);
            CboDatadosAniversariantesdoMês.Name = "CboDatadosAniversariantesdoMês";
            CboDatadosAniversariantesdoMês.Size = new Size(251, 22);
            CboDatadosAniversariantesdoMês.TabIndex = 7;
            CboDatadosAniversariantesdoMês.Text = "Data dos Aniversariantes do Mês";
            // 
            // FrmConsultadeClientes
            // 
            AutoScaleDimensions = new SizeF(9F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(954, 413);
            Controls.Add(CboDatadosAniversariantesdoMês);
            Controls.Add(TxtEmail);
            Controls.Add(CboRegião);
            Controls.Add(TxtNome);
            Controls.Add(BtnConsultaaoCliente);
            Controls.Add(BtnPáginaInicial);
            Controls.Add(DtgListadeClientes);
            Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmConsultadeClientes";
            Text = "Consulta de Clientes";
            ((System.ComponentModel.ISupportInitialize)DtgListadeClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView DtgListadeClientes;
        private Button BtnPáginaInicial;
        private Button BtnConsultaaoCliente;
        private TextBox TxtNome;
        private ComboBox CboRegião;
        private TextBox TxtEmail;
        private ComboBox CboDatadosAniversariantesdoMês;
    }
}