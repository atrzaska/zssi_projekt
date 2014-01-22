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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTrain = new System.Windows.Forms.TabPage();
            this.imgTrain = new Emgu.CV.UI.ImageBox();
            this.btnDetectFaces = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadTrainImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnTrain = new System.Windows.Forms.Button();
            this.tabTest = new System.Windows.Forms.TabPage();
            this.imgTest = new Emgu.CV.UI.ImageBox();
            this.btnLoadTestImage = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabTrain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTrain)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTest)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTrain);
            this.tabControl1.Controls.Add(this.tabTest);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(427, 502);
            this.tabControl1.TabIndex = 5;
            // 
            // tabTrain
            // 
            this.tabTrain.Controls.Add(this.imgTrain);
            this.tabTrain.Controls.Add(this.btnDetectFaces);
            this.tabTrain.Controls.Add(this.groupBox1);
            this.tabTrain.Location = new System.Drawing.Point(4, 22);
            this.tabTrain.Name = "tabTrain";
            this.tabTrain.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrain.Size = new System.Drawing.Size(419, 476);
            this.tabTrain.TabIndex = 0;
            this.tabTrain.Text = "Train";
            this.tabTrain.UseVisualStyleBackColor = true;
            // 
            // imgTrain
            // 
            this.imgTrain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgTrain.Location = new System.Drawing.Point(6, 6);
            this.imgTrain.Name = "imgTrain";
            this.imgTrain.Size = new System.Drawing.Size(407, 302);
            this.imgTrain.TabIndex = 8;
            this.imgTrain.TabStop = false;
            // 
            // btnDetectFaces
            // 
            this.btnDetectFaces.Location = new System.Drawing.Point(318, 334);
            this.btnDetectFaces.Name = "btnDetectFaces";
            this.btnDetectFaces.Size = new System.Drawing.Size(89, 23);
            this.btnDetectFaces.TabIndex = 7;
            this.btnDetectFaces.Text = "Detect faces";
            this.btnDetectFaces.UseVisualStyleBackColor = true;
            this.btnDetectFaces.Click += new System.EventHandler(this.btnDetectFaces_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoadTrainImage);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.btnTrain);
            this.groupBox1.Location = new System.Drawing.Point(6, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 105);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Training";
            // 
            // btnLoadTrainImage
            // 
            this.btnLoadTrainImage.Location = new System.Drawing.Point(47, 19);
            this.btnLoadTrainImage.Name = "btnLoadTrainImage";
            this.btnLoadTrainImage.Size = new System.Drawing.Size(348, 23);
            this.btnLoadTrainImage.TabIndex = 0;
            this.btnLoadTrainImage.Text = "Load Image";
            this.btnLoadTrainImage.UseVisualStyleBackColor = true;
            this.btnLoadTrainImage.Click += new System.EventHandler(this.btnLoadTrainImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(47, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(348, 20);
            this.txtName.TabIndex = 2;
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(47, 74);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(348, 23);
            this.btnTrain.TabIndex = 1;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // tabTest
            // 
            this.tabTest.Controls.Add(this.imgTest);
            this.tabTest.Controls.Add(this.btnLoadTestImage);
            this.tabTest.Location = new System.Drawing.Point(4, 22);
            this.tabTest.Name = "tabTest";
            this.tabTest.Padding = new System.Windows.Forms.Padding(3);
            this.tabTest.Size = new System.Drawing.Size(419, 476);
            this.tabTest.TabIndex = 1;
            this.tabTest.Text = "Test";
            this.tabTest.UseVisualStyleBackColor = true;
            // 
            // imgTest
            // 
            this.imgTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgTest.Location = new System.Drawing.Point(6, 6);
            this.imgTest.Name = "imgTest";
            this.imgTest.Size = new System.Drawing.Size(407, 302);
            this.imgTest.TabIndex = 9;
            this.imgTest.TabStop = false;
            // 
            // btnLoadTestImage
            // 
            this.btnLoadTestImage.Location = new System.Drawing.Point(6, 447);
            this.btnLoadTestImage.Name = "btnLoadTestImage";
            this.btnLoadTestImage.Size = new System.Drawing.Size(407, 23);
            this.btnLoadTestImage.TabIndex = 7;
            this.btnLoadTestImage.Text = "Load Image";
            this.btnLoadTestImage.UseVisualStyleBackColor = true;
            this.btnLoadTestImage.Click += new System.EventHandler(this.btnLoadTestImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 521);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "FaceRecognition - Train";
            this.tabControl1.ResumeLayout(false);
            this.tabTrain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgTrain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTrain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoadTrainImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.TabPage tabTest;
        private System.Windows.Forms.Button btnLoadTestImage;
        private System.Windows.Forms.Button btnDetectFaces;
        private Emgu.CV.UI.ImageBox imgTrain;
        private Emgu.CV.UI.ImageBox imgTest;

    }
}

