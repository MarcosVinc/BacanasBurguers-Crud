
namespace BacanaBurguesCrud
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeAlterar = new System.Windows.Forms.TextBox();
            this.txtPrecoAlterar = new System.Windows.Forms.TextBox();
            this.cbQuantidadeAlterar = new System.Windows.Forms.TextBox();
            this.cbTipoAlterar = new System.Windows.Forms.ComboBox();
            this.cbLucroAlterar = new System.Windows.Forms.ComboBox();
            this.btAlterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lucro";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantidade";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtNomeAlterar
            // 
            this.txtNomeAlterar.Location = new System.Drawing.Point(61, 90);
            this.txtNomeAlterar.Name = "txtNomeAlterar";
            this.txtNomeAlterar.Size = new System.Drawing.Size(308, 20);
            this.txtNomeAlterar.TabIndex = 5;
            // 
            // txtPrecoAlterar
            // 
            this.txtPrecoAlterar.Location = new System.Drawing.Point(61, 261);
            this.txtPrecoAlterar.Name = "txtPrecoAlterar";
            this.txtPrecoAlterar.Size = new System.Drawing.Size(121, 20);
            this.txtPrecoAlterar.TabIndex = 7;
            // 
            // cbQuantidadeAlterar
            // 
            this.cbQuantidadeAlterar.Location = new System.Drawing.Point(78, 129);
            this.cbQuantidadeAlterar.Name = "cbQuantidadeAlterar";
            this.cbQuantidadeAlterar.Size = new System.Drawing.Size(104, 20);
            this.cbQuantidadeAlterar.TabIndex = 9;
            // 
            // cbTipoAlterar
            // 
            this.cbTipoAlterar.FormattingEnabled = true;
            this.cbTipoAlterar.Location = new System.Drawing.Point(61, 176);
            this.cbTipoAlterar.Name = "cbTipoAlterar";
            this.cbTipoAlterar.Size = new System.Drawing.Size(121, 21);
            this.cbTipoAlterar.TabIndex = 10;
            // 
            // cbLucroAlterar
            // 
            this.cbLucroAlterar.FormattingEnabled = true;
            this.cbLucroAlterar.Location = new System.Drawing.Point(61, 221);
            this.cbLucroAlterar.Name = "cbLucroAlterar";
            this.cbLucroAlterar.Size = new System.Drawing.Size(121, 21);
            this.cbLucroAlterar.TabIndex = 18;
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(270, 323);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 19;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 369);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.cbLucroAlterar);
            this.Controls.Add(this.cbTipoAlterar);
            this.Controls.Add(this.cbQuantidadeAlterar);
            this.Controls.Add(this.txtPrecoAlterar);
            this.Controls.Add(this.txtNomeAlterar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Atualizar Cadastro";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtNomeAlterar;
        public System.Windows.Forms.TextBox txtPrecoAlterar;
        public System.Windows.Forms.TextBox cbQuantidadeAlterar;
        private System.Windows.Forms.Button btAlterar;
        public System.Windows.Forms.ComboBox cbLucroAlterar;
        public System.Windows.Forms.ComboBox cbTipoAlterar;
    }
}