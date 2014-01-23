namespace train
{
    partial class TrainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgTrain)).BeginInit();
            this.SuspendLayout();
            // 
            // imgTrain
            // 
            this.imgTrain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgTrain.Location = new System.Drawing.Point(28, 25);
            this.imgTrain.Name = "imgTrain";
            this.imgTrain.Size = new System.Drawing.Size(163, 147);
            this.imgTrain.TabIndex = 11;
            this.imgTrain.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nazwij tą osobę:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(28, 178);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(163, 20);
            this.txtName.TabIndex = 13;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(28, 204);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(82, 23);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSkip.Location = new System.Drawing.Point(116, 204);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(75, 23);
            this.btnSkip.TabIndex = 15;
            this.btnSkip.Text = "Pomiń";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // TrainForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSkip;
            this.ClientSize = new System.Drawing.Size(220, 242);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgTrain);
            this.Name = "TrainForm";
            this.Text = "Trenowanie";
            ((System.ComponentModel.ISupportInitialize)(this.imgTrain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imgTrain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnSkip;
    }
}