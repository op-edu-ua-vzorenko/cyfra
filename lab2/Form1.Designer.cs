namespace lab2
{
    partial class FormPicConvertGrayscale
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
            this.pictureBoxSrc = new System.Windows.Forms.PictureBox();
            this.pictureBoxGrayscale = new System.Windows.Forms.PictureBox();
            this.pictureBoxGrayscaleCustom = new System.Windows.Forms.PictureBox();
            this.buttonLoadPicture = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonSaveGrayscale = new System.Windows.Forms.Button();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.buttonSaveGrayscaleCustom = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonRefreshPicture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrayscale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrayscaleCustom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSrc
            // 
            this.pictureBoxSrc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSrc.Location = new System.Drawing.Point(45, 51);
            this.pictureBoxSrc.Name = "pictureBoxSrc";
            this.pictureBoxSrc.Size = new System.Drawing.Size(400, 300);
            this.pictureBoxSrc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSrc.TabIndex = 0;
            this.pictureBoxSrc.TabStop = false;
            this.pictureBoxSrc.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxGrayscale
            // 
            this.pictureBoxGrayscale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxGrayscale.Location = new System.Drawing.Point(604, 51);
            this.pictureBoxGrayscale.Name = "pictureBoxGrayscale";
            this.pictureBoxGrayscale.Size = new System.Drawing.Size(400, 300);
            this.pictureBoxGrayscale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGrayscale.TabIndex = 1;
            this.pictureBoxGrayscale.TabStop = false;
            // 
            // pictureBoxGrayscaleCustom
            // 
            this.pictureBoxGrayscaleCustom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxGrayscaleCustom.Location = new System.Drawing.Point(1162, 51);
            this.pictureBoxGrayscaleCustom.Name = "pictureBoxGrayscaleCustom";
            this.pictureBoxGrayscaleCustom.Size = new System.Drawing.Size(400, 300);
            this.pictureBoxGrayscaleCustom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGrayscaleCustom.TabIndex = 2;
            this.pictureBoxGrayscaleCustom.TabStop = false;
            // 
            // buttonLoadPicture
            // 
            this.buttonLoadPicture.Location = new System.Drawing.Point(166, 381);
            this.buttonLoadPicture.Name = "buttonLoadPicture";
            this.buttonLoadPicture.Size = new System.Drawing.Size(150, 30);
            this.buttonLoadPicture.TabIndex = 4;
            this.buttonLoadPicture.Text = "Load Picture";
            this.buttonLoadPicture.UseVisualStyleBackColor = true;
            this.buttonLoadPicture.Click += new System.EventHandler(this.buttonLoadPicture_Click);
            // 
            // buttonConvert
            // 
            this.buttonConvert.Enabled = false;
            this.buttonConvert.Location = new System.Drawing.Point(166, 440);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(150, 30);
            this.buttonConvert.TabIndex = 5;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonSaveGrayscale
            // 
            this.buttonSaveGrayscale.Enabled = false;
            this.buttonSaveGrayscale.Location = new System.Drawing.Point(737, 381);
            this.buttonSaveGrayscale.Name = "buttonSaveGrayscale";
            this.buttonSaveGrayscale.Size = new System.Drawing.Size(150, 30);
            this.buttonSaveGrayscale.TabIndex = 6;
            this.buttonSaveGrayscale.Text = "Save picture";
            this.buttonSaveGrayscale.UseVisualStyleBackColor = true;
            this.buttonSaveGrayscale.Click += new System.EventHandler(this.buttonSaveGrayscale_Click);
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(1266, 447);
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(296, 69);
            this.trackBarRed.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(1164, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(1164, 522);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 46);
            this.label2.TabIndex = 9;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(1164, 597);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 46);
            this.label3.TabIndex = 10;
            this.label3.Text = "B";
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(1266, 522);
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(296, 69);
            this.trackBarGreen.TabIndex = 11;
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(1266, 597);
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(296, 69);
            this.trackBarBlue.TabIndex = 12;
            // 
            // buttonSaveGrayscaleCustom
            // 
            this.buttonSaveGrayscaleCustom.Enabled = false;
            this.buttonSaveGrayscaleCustom.Location = new System.Drawing.Point(1294, 381);
            this.buttonSaveGrayscaleCustom.Name = "buttonSaveGrayscaleCustom";
            this.buttonSaveGrayscaleCustom.Size = new System.Drawing.Size(150, 30);
            this.buttonSaveGrayscaleCustom.TabIndex = 13;
            this.buttonSaveGrayscaleCustom.Text = "Save picture";
            this.buttonSaveGrayscaleCustom.UseVisualStyleBackColor = true;
            this.buttonSaveGrayscaleCustom.Click += new System.EventHandler(this.buttonSaveGrayscaleCustom_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(1204, 672);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(150, 30);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonRefreshPicture
            // 
            this.buttonRefreshPicture.Location = new System.Drawing.Point(1370, 672);
            this.buttonRefreshPicture.Name = "buttonRefreshPicture";
            this.buttonRefreshPicture.Size = new System.Drawing.Size(150, 30);
            this.buttonRefreshPicture.TabIndex = 15;
            this.buttonRefreshPicture.Text = "Refresh picture";
            this.buttonRefreshPicture.UseVisualStyleBackColor = true;
            this.buttonRefreshPicture.Click += new System.EventHandler(this.buttonResreshPicture_Click);
            // 
            // FormPicConvertGrayscale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1619, 769);
            this.Controls.Add(this.buttonRefreshPicture);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSaveGrayscaleCustom);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarRed);
            this.Controls.Add(this.buttonSaveGrayscale);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.buttonLoadPicture);
            this.Controls.Add(this.pictureBoxGrayscaleCustom);
            this.Controls.Add(this.pictureBoxGrayscale);
            this.Controls.Add(this.pictureBoxSrc);
            this.Name = "FormPicConvertGrayscale";
            this.Text = "Image converter to grayscale";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrayscale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrayscaleCustom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSrc;
        private System.Windows.Forms.PictureBox pictureBoxGrayscale;
        private System.Windows.Forms.PictureBox pictureBoxGrayscaleCustom;
        private System.Windows.Forms.Button buttonLoadPicture;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonSaveGrayscale;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.Button buttonSaveGrayscaleCustom;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonRefreshPicture;
    }
}

