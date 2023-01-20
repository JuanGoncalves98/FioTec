namespace FileReaderTest
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblNomeArquivo = new System.Windows.Forms.Label();
            this.btnLocalizarArquivo = new System.Windows.Forms.Button();
            this.lblConteudoArquivo = new System.Windows.Forms.Label();
            this.fileDialogLocalizar = new System.Windows.Forms.OpenFileDialog();
            this.btnCarregarArquivo = new System.Windows.Forms.Button();
            this.btnInserirBD = new System.Windows.Forms.Button();
            this.lstConteudoLido = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(109, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(396, 23);
            this.txtPath.TabIndex = 0;
            // 
            // lblNomeArquivo
            // 
            this.lblNomeArquivo.AutoSize = true;
            this.lblNomeArquivo.Location = new System.Drawing.Point(12, 15);
            this.lblNomeArquivo.Name = "lblNomeArquivo";
            this.lblNomeArquivo.Size = new System.Drawing.Size(91, 15);
            this.lblNomeArquivo.TabIndex = 1;
            this.lblNomeArquivo.Text = "Path do arquivo";
            // 
            // btnLocalizarArquivo
            // 
            this.btnLocalizarArquivo.Location = new System.Drawing.Point(511, 11);
            this.btnLocalizarArquivo.Name = "btnLocalizarArquivo";
            this.btnLocalizarArquivo.Size = new System.Drawing.Size(115, 25);
            this.btnLocalizarArquivo.TabIndex = 2;
            this.btnLocalizarArquivo.Text = "Localizar arquivo";
            this.btnLocalizarArquivo.UseVisualStyleBackColor = true;
            this.btnLocalizarArquivo.Click += new System.EventHandler(this.btnLocalizarArquivo_Click);
            // 
            // lblConteudoArquivo
            // 
            this.lblConteudoArquivo.AutoSize = true;
            this.lblConteudoArquivo.Location = new System.Drawing.Point(12, 49);
            this.lblConteudoArquivo.Name = "lblConteudoArquivo";
            this.lblConteudoArquivo.Size = new System.Drawing.Size(83, 15);
            this.lblConteudoArquivo.TabIndex = 4;
            this.lblConteudoArquivo.Text = "Conteúdo lido";
            // 
            // fileDialogLocalizar
            // 
            this.fileDialogLocalizar.Title = "Localizar arquivo";
            // 
            // btnCarregarArquivo
            // 
            this.btnCarregarArquivo.Enabled = false;
            this.btnCarregarArquivo.Location = new System.Drawing.Point(784, 9);
            this.btnCarregarArquivo.Name = "btnCarregarArquivo";
            this.btnCarregarArquivo.Size = new System.Drawing.Size(125, 26);
            this.btnCarregarArquivo.TabIndex = 5;
            this.btnCarregarArquivo.Text = "Carregar arquivo";
            this.btnCarregarArquivo.UseVisualStyleBackColor = true;
            this.btnCarregarArquivo.Click += new System.EventHandler(this.btnCarregarArquivo_Click);
            // 
            // btnInserirBD
            // 
            this.btnInserirBD.Location = new System.Drawing.Point(789, 510);
            this.btnInserirBD.Name = "btnInserirBD";
            this.btnInserirBD.Size = new System.Drawing.Size(120, 30);
            this.btnInserirBD.TabIndex = 7;
            this.btnInserirBD.Text = "Inserir no banco";
            this.btnInserirBD.UseVisualStyleBackColor = true;
            this.btnInserirBD.Click += new System.EventHandler(this.btnInserirBD_Click);
            // 
            // lstConteudoLido
            // 
            this.lstConteudoLido.FormattingEnabled = true;
            this.lstConteudoLido.ItemHeight = 15;
            this.lstConteudoLido.Location = new System.Drawing.Point(19, 76);
            this.lstConteudoLido.Name = "lstConteudoLido";
            this.lstConteudoLido.Size = new System.Drawing.Size(888, 424);
            this.lstConteudoLido.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 552);
            this.Controls.Add(this.lstConteudoLido);
            this.Controls.Add(this.btnInserirBD);
            this.Controls.Add(this.btnCarregarArquivo);
            this.Controls.Add(this.lblConteudoArquivo);
            this.Controls.Add(this.btnLocalizarArquivo);
            this.Controls.Add(this.lblNomeArquivo);
            this.Controls.Add(this.txtPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPath;
        private Label lblNomeArquivo;
        private Button btnLocalizarArquivo;
        private Label lblConteudoArquivo;
        private OpenFileDialog fileDialogLocalizar;
        private Button btnCarregarArquivo;
        private Button btnInserirBD;
        private ListBox lstConteudoLido;
    }
}