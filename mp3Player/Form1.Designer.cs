
namespace mp3Player
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.VolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFolder_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousButton = new System.Windows.Forms.Button();
            this.playPauseButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.currentTimeTrackBar = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.albumLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentTimeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // VolumeTrackBar
            // 
            this.VolumeTrackBar.Location = new System.Drawing.Point(275, 191);
            this.VolumeTrackBar.Maximum = 100;
            this.VolumeTrackBar.Name = "VolumeTrackBar";
            this.VolumeTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.VolumeTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VolumeTrackBar.Size = new System.Drawing.Size(45, 102);
            this.VolumeTrackBar.TabIndex = 1;
            this.VolumeTrackBar.TickFrequency = 10;
            this.VolumeTrackBar.Value = 100;
            this.VolumeTrackBar.Scroll += new System.EventHandler(this.VolumeTrackBar_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(29, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 231);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(275, 70);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(23, 13);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "title";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFolder_ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 26);
            // 
            // openFolder_ToolStripMenuItem
            // 
            this.openFolder_ToolStripMenuItem.Name = "openFolder_ToolStripMenuItem";
            this.openFolder_ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.openFolder_ToolStripMenuItem.Text = "открыть папку";
            this.openFolder_ToolStripMenuItem.Click += new System.EventHandler(this.openFolder_ToolStripMenuItem_Click);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(29, 363);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(55, 27);
            this.previousButton.TabIndex = 6;
            this.previousButton.Text = "previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // playPauseButton
            // 
            this.playPauseButton.Location = new System.Drawing.Point(90, 354);
            this.playPauseButton.Name = "playPauseButton";
            this.playPauseButton.Size = new System.Drawing.Size(48, 45);
            this.playPauseButton.TabIndex = 7;
            this.playPauseButton.Text = "play/ pause";
            this.playPauseButton.UseVisualStyleBackColor = true;
            this.playPauseButton.Click += new System.EventHandler(this.playPauseButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(198, 363);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(55, 27);
            this.nextButton.TabIndex = 7;
            this.nextButton.Text = "next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(144, 354);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(48, 45);
            this.stopButton.TabIndex = 8;
            this.stopButton.Text = "stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // currentTimeTrackBar
            // 
            this.currentTimeTrackBar.LargeChange = 10;
            this.currentTimeTrackBar.Location = new System.Drawing.Point(29, 299);
            this.currentTimeTrackBar.Maximum = 100;
            this.currentTimeTrackBar.Name = "currentTimeTrackBar";
            this.currentTimeTrackBar.Size = new System.Drawing.Size(240, 45);
            this.currentTimeTrackBar.TabIndex = 9;
            this.currentTimeTrackBar.Scroll += new System.EventHandler(this.currentTimeTrackBar_Scroll);
            this.currentTimeTrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.currentTimeTrackBar_MouseDown);
            this.currentTimeTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.currentTimeTrackBar_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // albumLabel
            // 
            this.albumLabel.AutoSize = true;
            this.albumLabel.Location = new System.Drawing.Point(275, 92);
            this.albumLabel.Name = "albumLabel";
            this.albumLabel.Size = new System.Drawing.Size(35, 13);
            this.albumLabel.TabIndex = 11;
            this.albumLabel.Text = "album";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(457, 56);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(275, 299);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(52, 13);
            this.timeLabel.TabIndex = 10;
            this.timeLabel.Text = "timeLabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 409);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.albumLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.currentTimeTrackBar);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.playPauseButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.VolumeTrackBar);
            this.MaximumSize = new System.Drawing.Size(473, 448);
            this.MinimumSize = new System.Drawing.Size(473, 448);
            this.Name = "Form1";
            this.Text = "s";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currentTimeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar VolumeTrackBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openFolder_ToolStripMenuItem;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button playPauseButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TrackBar currentTimeTrackBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label albumLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label timeLabel;
    }
}

