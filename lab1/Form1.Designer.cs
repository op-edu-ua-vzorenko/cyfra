namespace lab1
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
            layoutRoot = new TableLayoutPanel();
            panelLeft = new Panel();
            buttonLoad = new Button();
            pictureBoxOriginal = new PictureBox();
            buttonConvert = new Button();
            layoutChannels = new TableLayoutPanel();
            pictureBoxR = new PictureBox();
            pictureBoxG = new PictureBox();
            pictureBoxB = new PictureBox();
            panelBottomLeft = new Panel();
            panelBottomCenter = new Panel();
            panelBottomRight = new Panel();
            labelR = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            layoutRoot.SuspendLayout();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOriginal).BeginInit();
            layoutChannels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxB).BeginInit();
            panelBottomLeft.SuspendLayout();
            panelBottomCenter.SuspendLayout();
            panelBottomRight.SuspendLayout();
            SuspendLayout();
            // 
            // layoutRoot
            // 
            layoutRoot.AccessibleName = "";
            layoutRoot.ColumnCount = 2;
            layoutRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            layoutRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            layoutRoot.Controls.Add(panelLeft, 0, 0);
            layoutRoot.Controls.Add(layoutChannels, 1, 0);
            layoutRoot.Dock = DockStyle.Fill;
            layoutRoot.Location = new Point(10, 10);
            layoutRoot.Name = "layoutRoot";
            layoutRoot.RowCount = 1;
            layoutRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutRoot.Size = new Size(1343, 559);
            layoutRoot.TabIndex = 0;
            layoutRoot.Paint += tableLayoutPanel1_Paint;
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(buttonConvert);
            panelLeft.Controls.Add(pictureBoxOriginal);
            panelLeft.Controls.Add(buttonLoad);
            panelLeft.Dock = DockStyle.Fill;
            panelLeft.Location = new Point(3, 3);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(464, 553);
            panelLeft.TabIndex = 0;
            // 
            // buttonLoad
            // 
            buttonLoad.Dock = DockStyle.Top;
            buttonLoad.Location = new Point(0, 0);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(464, 40);
            buttonLoad.TabIndex = 0;
            buttonLoad.Text = "Load picture";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += button1_Click;
            // 
            // pictureBoxOriginal
            // 
            pictureBoxOriginal.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxOriginal.Dock = DockStyle.Top;
            pictureBoxOriginal.Location = new Point(0, 40);
            pictureBoxOriginal.Name = "pictureBoxOriginal";
            pictureBoxOriginal.Size = new Size(464, 300);
            pictureBoxOriginal.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxOriginal.TabIndex = 1;
            pictureBoxOriginal.TabStop = false;
            pictureBoxOriginal.Click += pictureBox1_Click;
            // 
            // buttonConvert
            // 
            buttonConvert.Dock = DockStyle.Top;
            buttonConvert.Enabled = false;
            buttonConvert.Location = new Point(0, 340);
            buttonConvert.Name = "buttonConvert";
            buttonConvert.Size = new Size(464, 40);
            buttonConvert.TabIndex = 2;
            buttonConvert.Text = "Convert to channels";
            buttonConvert.UseVisualStyleBackColor = true;
            // 
            // layoutChannels
            // 
            layoutChannels.ColumnCount = 3;
            layoutChannels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            layoutChannels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            layoutChannels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            layoutChannels.Controls.Add(pictureBoxR, 0, 0);
            layoutChannels.Controls.Add(pictureBoxG, 1, 0);
            layoutChannels.Controls.Add(pictureBoxB, 2, 0);
            layoutChannels.Controls.Add(panelBottomLeft, 0, 1);
            layoutChannels.Controls.Add(panelBottomCenter, 1, 1);
            layoutChannels.Controls.Add(panelBottomRight, 2, 1);
            layoutChannels.Dock = DockStyle.Fill;
            layoutChannels.Location = new Point(473, 3);
            layoutChannels.Name = "layoutChannels";
            layoutChannels.RowCount = 2;
            layoutChannels.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            layoutChannels.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            layoutChannels.Size = new Size(867, 553);
            layoutChannels.TabIndex = 1;
            // 
            // pictureBoxR
            // 
            pictureBoxR.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxR.Dock = DockStyle.Fill;
            pictureBoxR.Location = new Point(3, 3);
            pictureBoxR.Name = "pictureBoxR";
            pictureBoxR.Size = new Size(282, 436);
            pictureBoxR.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxR.TabIndex = 0;
            pictureBoxR.TabStop = false;
            // 
            // pictureBoxG
            // 
            pictureBoxG.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxG.Dock = DockStyle.Fill;
            pictureBoxG.Location = new Point(291, 3);
            pictureBoxG.Name = "pictureBoxG";
            pictureBoxG.Size = new Size(283, 436);
            pictureBoxG.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxG.TabIndex = 1;
            pictureBoxG.TabStop = false;
            pictureBoxG.Click += pictureBox2_Click;
            // 
            // pictureBoxB
            // 
            pictureBoxB.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxB.Dock = DockStyle.Fill;
            pictureBoxB.Location = new Point(580, 3);
            pictureBoxB.Name = "pictureBoxB";
            pictureBoxB.Size = new Size(284, 436);
            pictureBoxB.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxB.TabIndex = 2;
            pictureBoxB.TabStop = false;
            // 
            // panelBottomLeft
            // 
            panelBottomLeft.Controls.Add(button1);
            panelBottomLeft.Controls.Add(labelR);
            panelBottomLeft.Dock = DockStyle.Fill;
            panelBottomLeft.Location = new Point(3, 445);
            panelBottomLeft.Name = "panelBottomLeft";
            panelBottomLeft.Size = new Size(282, 105);
            panelBottomLeft.TabIndex = 3;
            // 
            // panelBottomCenter
            // 
            panelBottomCenter.Controls.Add(button2);
            panelBottomCenter.Controls.Add(label2);
            panelBottomCenter.Dock = DockStyle.Fill;
            panelBottomCenter.Location = new Point(291, 445);
            panelBottomCenter.Name = "panelBottomCenter";
            panelBottomCenter.Size = new Size(283, 105);
            panelBottomCenter.TabIndex = 4;
            // 
            // panelBottomRight
            // 
            panelBottomRight.Controls.Add(button3);
            panelBottomRight.Controls.Add(label3);
            panelBottomRight.Dock = DockStyle.Fill;
            panelBottomRight.Location = new Point(580, 445);
            panelBottomRight.Name = "panelBottomRight";
            panelBottomRight.Size = new Size(284, 105);
            panelBottomRight.TabIndex = 5;
            panelBottomRight.Paint += panel3_Paint;
            // 
            // labelR
            // 
            labelR.AutoSize = true;
            labelR.Dock = DockStyle.Top;
            labelR.Location = new Point(0, 0);
            labelR.Name = "labelR";
            labelR.Size = new Size(89, 32);
            labelR.TabIndex = 0;
            labelR.Text = "Red (R)";
            labelR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 0;
            label2.Text = "Green (G)";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 32);
            label3.TabIndex = 0;
            label3.Text = "Blue (B)";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Enabled = false;
            button1.Location = new Point(0, 32);
            button1.Name = "button1";
            button1.Size = new Size(282, 46);
            button1.TabIndex = 1;
            button1.Text = "Download R";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.Enabled = false;
            button2.Location = new Point(0, 32);
            button2.Name = "button2";
            button2.Size = new Size(283, 46);
            button2.TabIndex = 1;
            button2.Text = "Download G";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.Enabled = false;
            button3.Location = new Point(0, 32);
            button3.Name = "button3";
            button3.Size = new Size(284, 46);
            button3.TabIndex = 1;
            button3.Text = "Download B";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1363, 579);
            Controls.Add(layoutRoot);
            MinimumSize = new Size(1000, 650);
            Name = "Form1";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab 1 — RGB Splitter";
            layoutRoot.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxOriginal).EndInit();
            layoutChannels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxR).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxG).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxB).EndInit();
            panelBottomLeft.ResumeLayout(false);
            panelBottomLeft.PerformLayout();
            panelBottomCenter.ResumeLayout(false);
            panelBottomCenter.PerformLayout();
            panelBottomRight.ResumeLayout(false);
            panelBottomRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel layoutRoot;
        private Panel panelLeft;
        private Button buttonLoad;
        private Button buttonConvert;
        private PictureBox pictureBoxOriginal;
        private TableLayoutPanel layoutChannels;
        private PictureBox pictureBoxR;
        private PictureBox pictureBoxG;
        private PictureBox pictureBoxB;
        private Panel panelBottomLeft;
        private Panel panelBottomCenter;
        private Panel panelBottomRight;
        private Label labelR;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
