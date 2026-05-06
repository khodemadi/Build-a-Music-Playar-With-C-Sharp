 
namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BackPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.musicListBox = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.musicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.BackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // BackPanel
            // 
            this.BackPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackPanel.Controls.Add(this.label1);
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BackPanel.Location = new System.Drawing.Point(0, 0);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(839, 40);
            this.BackPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Music Player";
            // 
            // musicListBox
            // 
            this.musicListBox.FormattingEnabled = true;
            this.musicListBox.HorizontalScrollbar = true;
            this.musicListBox.ItemHeight = 16;
            this.musicListBox.Location = new System.Drawing.Point(24, 62);
            this.musicListBox.Name = "musicListBox";
            this.musicListBox.Size = new System.Drawing.Size(225, 340);
            this.musicListBox.TabIndex = 1;
            this.musicListBox.SelectedIndexChanged += new System.EventHandler(this.musicListBox_SelectedIndexChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSelect.Location = new System.Drawing.Point(24, 408);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(225, 54);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "پخش";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // musicPlayer
            // 
            this.musicPlayer.Enabled = true;
            this.musicPlayer.Location = new System.Drawing.Point(269, 62);
            this.musicPlayer.Name = "musicPlayer";
            this.musicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("musicPlayer.OcxState")));
            this.musicPlayer.Size = new System.Drawing.Size(336, 340);
            this.musicPlayer.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 496);
            this.Controls.Add(this.musicPlayer);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.musicListBox);
            this.Controls.Add(this.BackPanel);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Music Player App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BackPanel.ResumeLayout(false);
            this.BackPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox musicListBox;
        private System.Windows.Forms.Button btnSelect;
        private AxWMPLib.AxWindowsMediaPlayer musicPlayer;
    }
}

