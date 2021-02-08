namespace FacebookPoster
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label4;
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelPlik = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textHaslo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPost = new System.Windows.Forms.TextBox();
            this.btnZdjecie = new System.Windows.Forms.Button();
            this.btnWystaw = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(27, 270);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(89, 13);
            label4.TabIndex = 7;
            label4.Text = "Podaj treść posta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wczytaj grupy z pliku";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Wczytaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelPlik
            // 
            this.labelPlik.AutoSize = true;
            this.labelPlik.Location = new System.Drawing.Point(111, 44);
            this.labelPlik.Name = "labelPlik";
            this.labelPlik.Size = new System.Drawing.Size(0, 13);
            this.labelPlik.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email lub numer telefonu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textHaslo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textEmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(30, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 139);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaj dane logowania do swojego konta na Facebook\'u";
            // 
            // textHaslo
            // 
            this.textHaslo.Location = new System.Drawing.Point(134, 69);
            this.textHaslo.Name = "textHaslo";
            this.textHaslo.Size = new System.Drawing.Size(100, 20);
            this.textHaslo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hasło";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(134, 38);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(100, 20);
            this.textEmail.TabIndex = 7;
            // 
            // textPost
            // 
            this.textPost.Location = new System.Drawing.Point(30, 295);
            this.textPost.Name = "textPost";
            this.textPost.Size = new System.Drawing.Size(100, 20);
            this.textPost.TabIndex = 8;
            // 
            // btnZdjecie
            // 
            this.btnZdjecie.Location = new System.Drawing.Point(30, 516);
            this.btnZdjecie.Name = "btnZdjecie";
            this.btnZdjecie.Size = new System.Drawing.Size(104, 23);
            this.btnZdjecie.TabIndex = 9;
            this.btnZdjecie.Text = "Wczytaj zdjęcie";
            this.btnZdjecie.UseVisualStyleBackColor = true;
            this.btnZdjecie.Click += new System.EventHandler(this.btnZdjecie_Click);
            // 
            // btnWystaw
            // 
            this.btnWystaw.Location = new System.Drawing.Point(89, 569);
            this.btnWystaw.Name = "btnWystaw";
            this.btnWystaw.Size = new System.Drawing.Size(110, 45);
            this.btnWystaw.TabIndex = 10;
            this.btnWystaw.Text = "Wystaw post !";
            this.btnWystaw.UseVisualStyleBackColor = true;
            this.btnWystaw.Click += new System.EventHandler(this.btnWystaw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 626);
            this.Controls.Add(this.btnWystaw);
            this.Controls.Add(this.btnZdjecie);
            this.Controls.Add(this.textPost);
            this.Controls.Add(label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelPlik);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPlik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textHaslo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textPost;
        private System.Windows.Forms.Button btnZdjecie;
        private System.Windows.Forms.Button btnWystaw;
    }
}

