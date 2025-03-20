namespace LeituradeSolicitaçãodeCliente
{
    partial class FrmPerfildoCliente
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
            dataGridView1 = new DataGridView();
            LblFotodoCliente = new Label();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(143, 145);
            dataGridView1.TabIndex = 0;
            // 
            // LblFotodoCliente
            // 
            LblFotodoCliente.AutoSize = true;
            LblFotodoCliente.BackColor = Color.BlueViolet;
            LblFotodoCliente.ForeColor = Color.White;
            LblFotodoCliente.Location = new Point(58, 19);
            LblFotodoCliente.Name = "LblFotodoCliente";
            LblFotodoCliente.Size = new Size(106, 14);
            LblFotodoCliente.TabIndex = 1;
            LblFotodoCliente.Text = "Foto do Cliente";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(329, 156);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(240, 150);
            dataGridView2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.BlueViolet;
            label1.ForeColor = Color.White;
            label1.Location = new Point(383, 128);
            label1.Name = "label1";
            label1.Size = new Size(144, 14);
            label1.TabIndex = 3;
            label1.Text = "Informações Básicas";
            // 
            // FrmPerfildoCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(742, 387);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(LblFotodoCliente);
            Controls.Add(dataGridView1);
            Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "FrmPerfildoCliente";
            Text = "Perfil do Cliente";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label LblFotodoCliente;
        private DataGridView dataGridView2;
        private Label label1;
    }
}