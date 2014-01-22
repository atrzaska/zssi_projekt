namespace test
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
            this.imgTest = new Emgu.CV.UI.ImageBox();
            this.btnWczytaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgTest)).BeginInit();
            this.SuspendLayout();
            // 
            // imgTest
            // 
            this.imgTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgTest.Location = new System.Drawing.Point(12, 12);
            this.imgTest.Name = "imgTest";
            this.imgTest.Size = new System.Drawing.Size(407, 302);
            this.imgTest.TabIndex = 10;
            this.imgTest.TabStop = false;
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(12, 320);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(407, 23);
            this.btnWczytaj.TabIndex = 11;
            this.btnWczytaj.Text = "Wczytaj obraz";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 352);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.imgTest);
            this.Name = "Form1";
            this.Text = "Face Recognition - Test";
            ((System.ComponentModel.ISupportInitialize)(this.imgTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox imgTest;
        private System.Windows.Forms.Button btnWczytaj;
    }
}

