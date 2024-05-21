namespace EuromilhoesForm
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblResultChaves = new System.Windows.Forms.Label();
            this.cBLChave = new System.Windows.Forms.CheckedListBox();
            this.cLBEstrela = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblChaves = new System.Windows.Forms.Label();
            this.btnGerarChave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResultChaves
            // 
            this.lblResultChaves.AutoSize = true;
            this.lblResultChaves.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblResultChaves.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultChaves.ForeColor = System.Drawing.Color.Yellow;
            this.lblResultChaves.Location = new System.Drawing.Point(22, 20);
            this.lblResultChaves.Name = "lblResultChaves";
            this.lblResultChaves.Size = new System.Drawing.Size(231, 33);
            this.lblResultChaves.TabIndex = 0;
            this.lblResultChaves.Text = "Euromilhões";
            this.lblResultChaves.Click += new System.EventHandler(this.lblResultChaves_Click);
            // 
            // cBLChave
            // 
            this.cBLChave.FormattingEnabled = true;
            this.cBLChave.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.cBLChave.Location = new System.Drawing.Point(12, 195);
            this.cBLChave.MultiColumn = true;
            this.cBLChave.Name = "cBLChave";
            this.cBLChave.Size = new System.Drawing.Size(664, 225);
            this.cBLChave.TabIndex = 1;
            this.cBLChave.UseCompatibleTextRendering = true;
            this.cBLChave.SelectedIndexChanged += new System.EventHandler(this.cBLChave_SelectedIndexChanged);
            // 
            // cLBEstrela
            // 
            this.cLBEstrela.FormattingEnabled = true;
            this.cLBEstrela.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cLBEstrela.Location = new System.Drawing.Point(699, 195);
            this.cLBEstrela.Name = "cLBEstrela";
            this.cLBEstrela.Size = new System.Drawing.Size(89, 208);
            this.cLBEstrela.TabIndex = 2;
            this.cLBEstrela.SelectedIndexChanged += new System.EventHandler(this.cLBEstrela_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(712, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Estrelas";
            // 
            // lblChaves
            // 
            this.lblChaves.AutoSize = true;
            this.lblChaves.BackColor = System.Drawing.Color.Lavender;
            this.lblChaves.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChaves.Location = new System.Drawing.Point(276, 152);
            this.lblChaves.Name = "lblChaves";
            this.lblChaves.Size = new System.Drawing.Size(78, 27);
            this.lblChaves.TabIndex = 5;
            this.lblChaves.Text = "Chaves";
            this.lblChaves.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnGerarChave
            // 
            this.btnGerarChave.Location = new System.Drawing.Point(442, 85);
            this.btnGerarChave.Name = "btnGerarChave";
            this.btnGerarChave.Size = new System.Drawing.Size(186, 37);
            this.btnGerarChave.TabIndex = 7;
            this.btnGerarChave.Text = "Gerar chave";
            this.btnGerarChave.UseVisualStyleBackColor = true;
            this.btnGerarChave.Click += new System.EventHandler(this.btnGerarChave_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(863, 450);
            this.Controls.Add(this.btnGerarChave);
            this.Controls.Add(this.lblChaves);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cLBEstrela);
            this.Controls.Add(this.cBLChave);
            this.Controls.Add(this.lblResultChaves);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultChaves;
        private System.Windows.Forms.CheckedListBox cBLChave;
        private System.Windows.Forms.CheckedListBox cLBEstrela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChaves;
        private System.Windows.Forms.Button btnGerarChave;
    }
}

