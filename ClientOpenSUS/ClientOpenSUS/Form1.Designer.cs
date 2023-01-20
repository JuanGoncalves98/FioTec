namespace ClientOpenSUS
{
    partial class Form1
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
            this.tabOpenSUS = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnConsultarOpenSUS = new System.Windows.Forms.Button();
            this.lblAplicacao = new System.Windows.Forms.Label();
            this.dtpDataAplicacao = new System.Windows.Forms.DateTimePicker();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabOpenSUS.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOpenSUS
            // 
            this.tabOpenSUS.Controls.Add(this.tabPage1);
            this.tabOpenSUS.Controls.Add(this.tabPage2);
            this.tabOpenSUS.Location = new System.Drawing.Point(12, 12);
            this.tabOpenSUS.Name = "tabOpenSUS";
            this.tabOpenSUS.SelectedIndex = 0;
            this.tabOpenSUS.Size = new System.Drawing.Size(1032, 529);
            this.tabOpenSUS.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblResultado);
            this.tabPage1.Controls.Add(this.txtResultado);
            this.tabPage1.Controls.Add(this.btnConsultarOpenSUS);
            this.tabPage1.Controls.Add(this.lblAplicacao);
            this.tabPage1.Controls.Add(this.dtpDataAplicacao);
            this.tabPage1.Controls.Add(this.lblCPF);
            this.tabPage1.Controls.Add(this.txtCPF);
            this.tabPage1.Controls.Add(this.lblNome);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1024, 501);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "OpenSUS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(17, 84);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(59, 15);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(19, 104);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(984, 376);
            this.txtResultado.TabIndex = 7;
            // 
            // btnConsultarOpenSUS
            // 
            this.btnConsultarOpenSUS.Location = new System.Drawing.Point(719, 41);
            this.btnConsultarOpenSUS.Name = "btnConsultarOpenSUS";
            this.btnConsultarOpenSUS.Size = new System.Drawing.Size(120, 25);
            this.btnConsultarOpenSUS.TabIndex = 6;
            this.btnConsultarOpenSUS.Text = "Consultar OpenSUS";
            this.btnConsultarOpenSUS.UseVisualStyleBackColor = true;
            this.btnConsultarOpenSUS.Click += new System.EventHandler(this.btnConsultarOpenSUS_Click);
            // 
            // lblAplicacao
            // 
            this.lblAplicacao.AutoSize = true;
            this.lblAplicacao.Location = new System.Drawing.Point(571, 23);
            this.lblAplicacao.Name = "lblAplicacao";
            this.lblAplicacao.Size = new System.Drawing.Size(100, 15);
            this.lblAplicacao.TabIndex = 5;
            this.lblAplicacao.Text = "Data da aplicação";
            // 
            // dtpDataAplicacao
            // 
            this.dtpDataAplicacao.CustomFormat = "yyyy-MM-dd";
            this.dtpDataAplicacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataAplicacao.Location = new System.Drawing.Point(571, 41);
            this.dtpDataAplicacao.Name = "dtpDataAplicacao";
            this.dtpDataAplicacao.Size = new System.Drawing.Size(132, 23);
            this.dtpDataAplicacao.TabIndex = 4;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(306, 23);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(28, 15);
            this.lblCPF.TabIndex = 3;
            this.lblCPF.Text = "CPF";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(306, 41);
            this.txtCPF.MaxLength = 11;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.PlaceholderText = "Digite seu CPF";
            this.txtCPF.Size = new System.Drawing.Size(249, 23);
            this.txtCPF.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(19, 23);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(19, 41);
            this.txtNome.MaxLength = 300;
            this.txtNome.Name = "txtNome";
            this.txtNome.PlaceholderText = "Digite seu nome";
            this.txtNome.Size = new System.Drawing.Size(277, 23);
            this.txtNome.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1024, 501);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 547);
            this.Controls.Add(this.tabOpenSUS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabOpenSUS.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabOpenSUS;
        private TabPage tabPage1;
        private Label lblCPF;
        private TextBox txtCPF;
        private Label lblNome;
        private TextBox txtNome;
        private TabPage tabPage2;
        private DateTimePicker dtpDataAplicacao;
        private Label lblAplicacao;
        private Button btnConsultarOpenSUS;
        private TextBox txtResultado;
        private Label lblResultado;
    }
}