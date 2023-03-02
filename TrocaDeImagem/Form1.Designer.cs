namespace TrocaDeImagem
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
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.pictureBoxMostrar = new System.Windows.Forms.PictureBox();
            this.pictureBoxMostrar2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonFechado = new System.Windows.Forms.Button();
            this.buttonAbrir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostrar2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostrar.Location = new System.Drawing.Point(95, 259);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(207, 23);
            this.buttonMostrar.TabIndex = 0;
            this.buttonMostrar.Text = "Clique para MOSTRAR a imagem";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApagar.Location = new System.Drawing.Point(95, 288);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(207, 23);
            this.buttonApagar.TabIndex = 1;
            this.buttonApagar.Text = "Clique para APAGAR a imagem";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // pictureBoxMostrar
            // 
            this.pictureBoxMostrar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMostrar.Image")));
            this.pictureBoxMostrar.Location = new System.Drawing.Point(30, 92);
            this.pictureBoxMostrar.Name = "pictureBoxMostrar";
            this.pictureBoxMostrar.Size = new System.Drawing.Size(343, 161);
            this.pictureBoxMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMostrar.TabIndex = 2;
            this.pictureBoxMostrar.TabStop = false;
            this.pictureBoxMostrar.Visible = false;
            // 
            // pictureBoxMostrar2
            // 
            this.pictureBoxMostrar2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMostrar2.Image")));
            this.pictureBoxMostrar2.Location = new System.Drawing.Point(389, 92);
            this.pictureBoxMostrar2.Name = "pictureBoxMostrar2";
            this.pictureBoxMostrar2.Size = new System.Drawing.Size(343, 161);
            this.pictureBoxMostrar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMostrar2.TabIndex = 3;
            this.pictureBoxMostrar2.TabStop = false;
            this.pictureBoxMostrar2.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(431, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Clique para MOSTRAR a segunda imagem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(431, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Clique para APAGAR a segunda imagem";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonFechado
            // 
            this.buttonFechado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechado.Location = new System.Drawing.Point(242, 364);
            this.buttonFechado.Name = "buttonFechado";
            this.buttonFechado.Size = new System.Drawing.Size(297, 23);
            this.buttonFechado.TabIndex = 6;
            this.buttonFechado.Text = "Fechar Tudo!";
            this.buttonFechado.UseVisualStyleBackColor = true;
            this.buttonFechado.Click += new System.EventHandler(this.buttonFechado_Click);
            // 
            // buttonAbrir
            // 
            this.buttonAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbrir.Location = new System.Drawing.Point(242, 335);
            this.buttonAbrir.Name = "buttonAbrir";
            this.buttonAbrir.Size = new System.Drawing.Size(297, 23);
            this.buttonAbrir.TabIndex = 7;
            this.buttonAbrir.Text = "Abrir Tudo!";
            this.buttonAbrir.UseVisualStyleBackColor = true;
            this.buttonAbrir.Click += new System.EventHandler(this.buttonAbrir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 405);
            this.Controls.Add(this.buttonAbrir);
            this.Controls.Add(this.buttonFechado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxMostrar2);
            this.Controls.Add(this.pictureBoxMostrar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonMostrar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostrar2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.PictureBox pictureBoxMostrar;
        private System.Windows.Forms.PictureBox pictureBoxMostrar2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonFechado;
        private System.Windows.Forms.Button buttonAbrir;
    }
}

