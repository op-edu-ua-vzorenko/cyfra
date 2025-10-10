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
            buttonConvert = new Button();
            pictureBoxOriginal = new PictureBox();
            buttonLoad = new Button();
            layoutChannels = new TableLayoutPanel();
            pictureBoxR = new PictureBox();
            pictureBoxG = new PictureBox();
            pictureBoxB = new PictureBox();
            panelBottomLeft = new Panel();
            buttonSaveR = new Button();
            labelR = new Label();
            panelBottomCenter = new Panel();
            buttonSaveG = new Button();
            labelG = new Label();
            panelBottomRight = new Panel();
            buttonSaveB = new Button();
            labelB = new Label();
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
            buttonConvert.Click += buttonConvert_Click;
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
            buttonLoad.Click += buttonLoad_Click;
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
            panelBottomLeft.Controls.Add(buttonSaveR);
            panelBottomLeft.Controls.Add(labelR);
            panelBottomLeft.Dock = DockStyle.Fill;
            panelBottomLeft.Location = new Point(3, 445);
            panelBottomLeft.Name = "panelBottomLeft";
            panelBottomLeft.Size = new Size(282, 105);
            panelBottomLeft.TabIndex = 3;
            // 
            // buttonSaveR
            // 
            buttonSaveR.Dock = DockStyle.Top;
            buttonSaveR.Enabled = false;
            buttonSaveR.Location = new Point(0, 32);
            buttonSaveR.Name = "buttonSaveR";
            buttonSaveR.Size = new Size(282, 46);
            buttonSaveR.TabIndex = 1;
            buttonSaveR.Text = "Download R";
            buttonSaveR.UseVisualStyleBackColor = true;
            buttonSaveR.Click += buttonSaveR_Click;
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
            // panelBottomCenter
            // 
            panelBottomCenter.Controls.Add(buttonSaveG);
            panelBottomCenter.Controls.Add(labelG);
            panelBottomCenter.Dock = DockStyle.Fill;
            panelBottomCenter.Location = new Point(291, 445);
            panelBottomCenter.Name = "panelBottomCenter";
            panelBottomCenter.Size = new Size(283, 105);
            panelBottomCenter.TabIndex = 4;
            // 
            // buttonSaveG
            // 
            buttonSaveG.Dock = DockStyle.Top;
            buttonSaveG.Enabled = false;
            buttonSaveG.Location = new Point(0, 32);
            buttonSaveG.Name = "buttonSaveG";
            buttonSaveG.Size = new Size(283, 46);
            buttonSaveG.TabIndex = 1;
            buttonSaveG.Text = "Download G";
            buttonSaveG.UseVisualStyleBackColor = true;
            buttonSaveG.Click += buttonSaveG_Click;
            // 
            // labelG
            // 
            labelG.AutoSize = true;
            labelG.Dock = DockStyle.Top;
            labelG.Location = new Point(0, 0);
            labelG.Name = "labelG";
            labelG.Size = new Size(115, 32);
            labelG.TabIndex = 0;
            labelG.Text = "Green (G)";
            labelG.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelBottomRight
            // 
            panelBottomRight.Controls.Add(buttonSaveB);
            panelBottomRight.Controls.Add(labelB);
            panelBottomRight.Dock = DockStyle.Fill;
            panelBottomRight.Location = new Point(580, 445);
            panelBottomRight.Name = "panelBottomRight";
            panelBottomRight.Size = new Size(284, 105);
            panelBottomRight.TabIndex = 5;
            // 
            // buttonSaveB
            // 
            buttonSaveB.Dock = DockStyle.Top;
            buttonSaveB.Enabled = false;
            buttonSaveB.Location = new Point(0, 32);
            buttonSaveB.Name = "buttonSaveB";
            buttonSaveB.Size = new Size(284, 46);
            buttonSaveB.TabIndex = 1;
            buttonSaveB.Text = "Download B";
            buttonSaveB.UseVisualStyleBackColor = true;
            buttonSaveB.Click += buttonSaveB_Click;
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Dock = DockStyle.Top;
            labelB.Location = new Point(0, 0);
            labelB.Name = "labelB";
            labelB.Size = new Size(96, 32);
            labelB.TabIndex = 0;
            labelB.Text = "Blue (B)";
            labelB.TextAlign = ContentAlignment.MiddleCenter;
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
        private Label labelG;
        private Label labelB;
        private Button buttonSaveR;
        private Button buttonSaveG;
        private Button buttonSaveB;
    }
}
