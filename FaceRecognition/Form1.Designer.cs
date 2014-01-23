namespace train
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
            this.imgTrain = new Emgu.CV.UI.ImageBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.lblFoundFaces = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadTrainImage = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgTrain)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgTrain
            // 
            this.imgTrain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgTrain.Location = new System.Drawing.Point(12, 12);
            this.imgTrain.Name = "imgTrain";
            this.imgTrain.Size = new System.Drawing.Size(616, 405);
            this.imgTrain.TabIndex = 11;
            this.imgTrain.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInfo);
            this.groupBox1.Controls.Add(this.lblFoundFaces);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnLoadTrainImage);
            this.groupBox1.Controls.Add(this.btnTrain);
            this.groupBox1.Location = new System.Drawing.Point(12, 423);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 118);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Training";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(132, 18);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(230, 94);
            this.txtInfo.TabIndex = 4;
            // 
            // lblFoundFaces
            // 
            this.lblFoundFaces.AutoSize = true;
            this.lblFoundFaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFoundFaces.Location = new System.Drawing.Point(102, 29);
            this.lblFoundFaces.Name = "lblFoundFaces";
            this.lblFoundFaces.Size = new System.Drawing.Size(24, 25);
            this.lblFoundFaces.TabIndex = 3;
            this.lblFoundFaces.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Znalezione twrze:";
            // 
            // btnLoadTrainImage
            // 
            this.btnLoadTrainImage.Location = new System.Drawing.Point(368, 18);
            this.btnLoadTrainImage.Name = "btnLoadTrainImage";
            this.btnLoadTrainImage.Size = new System.Drawing.Size(242, 36);
            this.btnLoadTrainImage.TabIndex = 0;
            this.btnLoadTrainImage.Text = "Wczytaj obraz";
            this.btnLoadTrainImage.UseVisualStyleBackColor = true;
            this.btnLoadTrainImage.Click += new System.EventHandler(this.btnLoadTrainImage_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(368, 71);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(242, 41);
            this.btnTrain.TabIndex = 1;
            this.btnTrain.Text = "Trenuj";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 553);
            this.Controls.Add(this.imgTrain);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "FaceRecognition";
            ((System.ComponentModel.ISupportInitialize)(this.imgTrain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox imgTrain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Label lblFoundFaces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadTrainImage;
        private System.Windows.Forms.TextBox txtInfo;


    }
}

