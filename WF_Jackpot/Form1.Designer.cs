namespace WF_Jackpot
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
            this.lbsolpre = new System.Windows.Forms.Label();
            this.lbluatent = new System.Windows.Forms.Label();
            this.lbtitulo = new System.Windows.Forms.Label();
            this.btnmoeda = new System.Windows.Forms.Button();
            this.lbpremio = new System.Windows.Forms.Label();
            this.lbtentativas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.btnresgatar = new System.Windows.Forms.Button();
            this.btninfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbsolpre
            // 
            this.lbsolpre.Image = ((System.Drawing.Image)(resources.GetObject("lbsolpre.Image")));
            this.lbsolpre.Location = new System.Drawing.Point(171, 470);
            this.lbsolpre.Name = "lbsolpre";
            this.lbsolpre.Size = new System.Drawing.Size(105, 98);
            this.lbsolpre.TabIndex = 3;
            this.lbsolpre.Click += new System.EventHandler(this.lbpremio_Click);
            // 
            // lbluatent
            // 
            this.lbluatent.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbluatent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbluatent.Image = ((System.Drawing.Image)(resources.GetObject("lbluatent.Image")));
            this.lbluatent.Location = new System.Drawing.Point(560, 470);
            this.lbluatent.Name = "lbluatent";
            this.lbluatent.Size = new System.Drawing.Size(105, 98);
            this.lbluatent.TabIndex = 4;
            this.lbluatent.Click += new System.EventHandler(this.lbtentativas_Click);
            // 
            // lbtitulo
            // 
            this.lbtitulo.AutoSize = true;
            this.lbtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitulo.Location = new System.Drawing.Point(331, 9);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(165, 37);
            this.lbtitulo.TabIndex = 5;
            this.lbtitulo.Text = "JACKPOT";
            this.lbtitulo.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnmoeda
            // 
            this.btnmoeda.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnmoeda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmoeda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnmoeda.Image = ((System.Drawing.Image)(resources.GetObject("btnmoeda.Image")));
            this.btnmoeda.Location = new System.Drawing.Point(240, 357);
            this.btnmoeda.Name = "btnmoeda";
            this.btnmoeda.Size = new System.Drawing.Size(340, 101);
            this.btnmoeda.TabIndex = 6;
            this.btnmoeda.Text = "Inserir Moeda";
            this.btnmoeda.UseVisualStyleBackColor = false;
            this.btnmoeda.Click += new System.EventHandler(this.btnmoeda_Click);
            // 
            // lbpremio
            // 
            this.lbpremio.AutoSize = true;
            this.lbpremio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpremio.Location = new System.Drawing.Point(189, 509);
            this.lbpremio.Name = "lbpremio";
            this.lbpremio.Size = new System.Drawing.Size(65, 20);
            this.lbpremio.TabIndex = 8;
            this.lbpremio.Text = "R$ 0.00";
            this.lbpremio.Click += new System.EventHandler(this.lbpremio_Click_1);
            // 
            // lbtentativas
            // 
            this.lbtentativas.AutoSize = true;
            this.lbtentativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtentativas.Location = new System.Drawing.Point(598, 504);
            this.lbtentativas.Name = "lbtentativas";
            this.lbtentativas.Size = new System.Drawing.Size(31, 33);
            this.lbtentativas.TabIndex = 9;
            this.lbtentativas.Text = "0";
            this.lbtentativas.Click += new System.EventHandler(this.lbtentativas_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(436, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tentativas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Premio:";
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(132, 154);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(156, 151);
            this.pb1.TabIndex = 12;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(538, 154);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(156, 151);
            this.pb3.TabIndex = 13;
            this.pb3.TabStop = false;
            this.pb3.Click += new System.EventHandler(this.pb3_Click);
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(340, 154);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(156, 151);
            this.pb2.TabIndex = 13;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.pb2_Click);
            // 
            // btnresgatar
            // 
            this.btnresgatar.Location = new System.Drawing.Point(586, 389);
            this.btnresgatar.Name = "btnresgatar";
            this.btnresgatar.Size = new System.Drawing.Size(142, 43);
            this.btnresgatar.TabIndex = 14;
            this.btnresgatar.Text = "Resgatar";
            this.btnresgatar.UseVisualStyleBackColor = true;
            this.btnresgatar.Click += new System.EventHandler(this.btnresgatar_Click);
            // 
            // btninfo
            // 
            this.btninfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btninfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btninfo.Location = new System.Drawing.Point(12, 9);
            this.btninfo.Name = "btninfo";
            this.btninfo.Size = new System.Drawing.Size(22, 24);
            this.btninfo.TabIndex = 15;
            this.btninfo.Text = "?";
            this.btninfo.UseVisualStyleBackColor = false;
            this.btninfo.Click += new System.EventHandler(this.btninfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(831, 623);
            this.Controls.Add(this.btninfo);
            this.Controls.Add(this.btnresgatar);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbtentativas);
            this.Controls.Add(this.lbpremio);
            this.Controls.Add(this.btnmoeda);
            this.Controls.Add(this.lbtitulo);
            this.Controls.Add(this.lbluatent);
            this.Controls.Add(this.lbsolpre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbsolpre;
        private System.Windows.Forms.Label lbluatent;
        private System.Windows.Forms.Label lbtitulo;
        private System.Windows.Forms.Button btnmoeda;
        private System.Windows.Forms.Label lbpremio;
        private System.Windows.Forms.Label lbtentativas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Button btnresgatar;
        private System.Windows.Forms.Button btninfo;
    }
}

