namespace LeituradeSolicitaçãodeCliente
{
    partial class FrmTelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaInicial));
            LblMarca = new Label();
            LblSlogan = new Label();
            BtnCadastrodeClientes = new Button();
            BtnConsultadeClientes = new Button();
            LblBoasVindas = new Label();
            BtnSair = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // LblMarca
            // 
            LblMarca.AutoSize = true;
            LblMarca.BackColor = Color.DarkViolet;
            LblMarca.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblMarca.ForeColor = Color.White;
            LblMarca.Location = new Point(277, 19);
            LblMarca.Name = "LblMarca";
            LblMarca.Padding = new Padding(10, 8, 10, 8);
            LblMarca.Size = new Size(202, 48);
            LblMarca.TabIndex = 0;
            LblMarca.Text = "Cliente Fiel";
            // 
            // LblSlogan
            // 
            LblSlogan.AutoSize = true;
            LblSlogan.BackColor = Color.DarkViolet;
            LblSlogan.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSlogan.ForeColor = Color.White;
            LblSlogan.Location = new Point(135, 90);
            LblSlogan.Name = "LblSlogan";
            LblSlogan.Size = new Size(508, 18);
            LblSlogan.TabIndex = 1;
            LblSlogan.Text = "\"Parceira de confiança para um atendimento acolhedor.\"";
            // 
            // BtnCadastrodeClientes
            // 
            BtnCadastrodeClientes.BackColor = Color.White;
            BtnCadastrodeClientes.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCadastrodeClientes.ForeColor = Color.DarkOrange;
            BtnCadastrodeClientes.Location = new Point(172, 209);
            BtnCadastrodeClientes.Name = "BtnCadastrodeClientes";
            BtnCadastrodeClientes.Size = new Size(182, 45);
            BtnCadastrodeClientes.TabIndex = 2;
            BtnCadastrodeClientes.Text = "Cadastro de Clientes";
            BtnCadastrodeClientes.UseVisualStyleBackColor = false;
            // 
            // BtnConsultadeClientes
            // 
            BtnConsultadeClientes.BackColor = Color.White;
            BtnConsultadeClientes.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnConsultadeClientes.ForeColor = Color.DarkOrange;
            BtnConsultadeClientes.Location = new Point(408, 209);
            BtnConsultadeClientes.Name = "BtnConsultadeClientes";
            BtnConsultadeClientes.Size = new Size(168, 45);
            BtnConsultadeClientes.TabIndex = 3;
            BtnConsultadeClientes.Text = "Consulta de Clientes";
            BtnConsultadeClientes.UseVisualStyleBackColor = false;
            // 
            // LblBoasVindas
            // 
            LblBoasVindas.AutoSize = true;
            LblBoasVindas.BackColor = Color.DarkViolet;
            LblBoasVindas.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblBoasVindas.ForeColor = Color.White;
            LblBoasVindas.Location = new Point(308, 67);
            LblBoasVindas.Name = "LblBoasVindas";
            LblBoasVindas.Size = new Size(141, 23);
            LblBoasVindas.TabIndex = 5;
            LblBoasVindas.Text = "Boas Vindas";
            // 
            // BtnSair
            // 
            BtnSair.BackColor = Color.White;
            BtnSair.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSair.ForeColor = Color.DarkOrange;
            BtnSair.Location = new Point(650, 347);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(80, 28);
            BtnSair.TabIndex = 6;
            BtnSair.Text = "Sair";
            BtnSair.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(578, 117);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 8, 10, 8);
            label1.Size = new Size(20, 30);
            label1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(614, 117);
            label2.Name = "label2";
            label2.Padding = new Padding(10, 8, 10, 8);
            label2.Size = new Size(20, 30);
            label2.TabIndex = 8;
            // 
            // FrmTelaInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(742, 387);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnSair);
            Controls.Add(LblBoasVindas);
            Controls.Add(BtnConsultadeClientes);
            Controls.Add(BtnCadastrodeClientes);
            Controls.Add(LblSlogan);
            Controls.Add(LblMarca);
            Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "FrmTelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Inicial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblMarca;
        private Label LblSlogan;
        private Button BtnCadastrodeClientes;
        private Button BtnConsultadeClientes;
        private Label LblBoasVindas;
        private Button BtnSair;
        private Label label1;
        private Label label2;
    }
}
