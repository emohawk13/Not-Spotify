
namespace Capps_CourseProject_part1
{
    partial class playlistForm
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
            this.playlistListBox = new System.Windows.Forms.ListBox();
            this.editPlaylistTitleLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.selectPlaylistLabel = new System.Windows.Forms.Label();
            this.removeSongButton = new System.Windows.Forms.Button();
            this.selectSongLabel = new System.Windows.Forms.Label();
            this.selectSongText = new System.Windows.Forms.TextBox();
            this.editSongButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playlistListBox
            // 
            this.playlistListBox.FormattingEnabled = true;
            this.playlistListBox.ItemHeight = 16;
            this.playlistListBox.Location = new System.Drawing.Point(494, 12);
            this.playlistListBox.Name = "playlistListBox";
            this.playlistListBox.Size = new System.Drawing.Size(294, 420);
            this.playlistListBox.TabIndex = 0;
            // 
            // editPlaylistTitleLabel
            // 
            this.editPlaylistTitleLabel.AutoSize = true;
            this.editPlaylistTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.editPlaylistTitleLabel.Location = new System.Drawing.Point(13, 13);
            this.editPlaylistTitleLabel.Name = "editPlaylistTitleLabel";
            this.editPlaylistTitleLabel.Size = new System.Drawing.Size(146, 29);
            this.editPlaylistTitleLabel.TabIndex = 1;
            this.editPlaylistTitleLabel.Text = "Edit Playlist";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(120, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(280, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // selectPlaylistLabel
            // 
            this.selectPlaylistLabel.AutoSize = true;
            this.selectPlaylistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.selectPlaylistLabel.Location = new System.Drawing.Point(15, 84);
            this.selectPlaylistLabel.Name = "selectPlaylistLabel";
            this.selectPlaylistLabel.Size = new System.Drawing.Size(99, 18);
            this.selectPlaylistLabel.TabIndex = 3;
            this.selectPlaylistLabel.Text = "Select Playlist";
            // 
            // removeSongButton
            // 
            this.removeSongButton.Location = new System.Drawing.Point(127, 160);
            this.removeSongButton.Name = "removeSongButton";
            this.removeSongButton.Size = new System.Drawing.Size(104, 49);
            this.removeSongButton.TabIndex = 4;
            this.removeSongButton.Text = "Remove Song";
            this.removeSongButton.UseVisualStyleBackColor = true;
            this.removeSongButton.Click += new System.EventHandler(this.removeSongButton_Click);
            // 
            // selectSongLabel
            // 
            this.selectSongLabel.AutoSize = true;
            this.selectSongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.selectSongLabel.Location = new System.Drawing.Point(18, 123);
            this.selectSongLabel.Name = "selectSongLabel";
            this.selectSongLabel.Size = new System.Drawing.Size(84, 17);
            this.selectSongLabel.TabIndex = 5;
            this.selectSongLabel.Text = "Select Song";
            // 
            // selectSongText
            // 
            this.selectSongText.Location = new System.Drawing.Point(120, 123);
            this.selectSongText.Name = "selectSongText";
            this.selectSongText.Size = new System.Drawing.Size(280, 22);
            this.selectSongText.TabIndex = 6;
            // 
            // editSongButton
            // 
            this.editSongButton.Location = new System.Drawing.Point(21, 160);
            this.editSongButton.Name = "editSongButton";
            this.editSongButton.Size = new System.Drawing.Size(100, 49);
            this.editSongButton.TabIndex = 7;
            this.editSongButton.Text = "Edit Song";
            this.editSongButton.UseVisualStyleBackColor = true;
            this.editSongButton.Click += new System.EventHandler(this.editSongButton_Click);
            // 
            // playlistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editSongButton);
            this.Controls.Add(this.selectSongText);
            this.Controls.Add(this.selectSongLabel);
            this.Controls.Add(this.removeSongButton);
            this.Controls.Add(this.selectPlaylistLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.editPlaylistTitleLabel);
            this.Controls.Add(this.playlistListBox);
            this.Name = "playlistForm";
            this.Text = "playlistForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox playlistListBox;
        private System.Windows.Forms.Label editPlaylistTitleLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label selectPlaylistLabel;
        private System.Windows.Forms.Button removeSongButton;
        private System.Windows.Forms.Label selectSongLabel;
        private System.Windows.Forms.TextBox selectSongText;
        private System.Windows.Forms.Button editSongButton;
    }
}