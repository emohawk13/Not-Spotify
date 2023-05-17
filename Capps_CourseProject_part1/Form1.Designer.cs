
namespace Capps_CourseProject_part1
{
    partial class mainForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.artistLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.artistText = new System.Windows.Forms.TextBox();
            this.yearText = new System.Windows.Forms.TextBox();
            this.urlText = new System.Windows.Forms.TextBox();
            this.outputText = new System.Windows.Forms.TextBox();
            this.songList = new System.Windows.Forms.ListBox();
            this.allSongsButton = new System.Windows.Forms.Button();
            this.songListLabel = new System.Windows.Forms.Label();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.findSongButton = new System.Windows.Forms.Button();
            this.removeSongButton = new System.Windows.Forms.Button();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.testDataButton = new System.Windows.Forms.Button();
            this.findArtistButton = new System.Windows.Forms.Button();
            this.findGenreButton = new System.Windows.Forms.Button();
            this.savePlaylistButton = new System.Windows.Forms.Button();
            this.loadPlaylistButton = new System.Windows.Forms.Button();
            this.playlistText = new System.Windows.Forms.TextBox();
            this.playlistLabel = new System.Windows.Forms.Label();
            this.webViewDisplay = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.playButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webViewDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.addButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addButton.Location = new System.Drawing.Point(69, 329);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(265, 64);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add Song";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(65, 46);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(41, 20);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title";
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistLabel.Location = new System.Drawing.Point(65, 86);
            this.artistLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(49, 20);
            this.artistLabel.TabIndex = 2;
            this.artistLabel.Text = "Artist";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.Location = new System.Drawing.Point(65, 125);
            this.genreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(55, 20);
            this.genreLabel.TabIndex = 3;
            this.genreLabel.Text = "Genre";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(65, 164);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(43, 20);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "Year";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLabel.Location = new System.Drawing.Point(65, 203);
            this.urlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(43, 20);
            this.urlLabel.TabIndex = 5;
            this.urlLabel.Text = "URL";
            // 
            // titleText
            // 
            this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.Location = new System.Drawing.Point(169, 46);
            this.titleText.Margin = new System.Windows.Forms.Padding(4);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(330, 26);
            this.titleText.TabIndex = 1;
            // 
            // artistText
            // 
            this.artistText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistText.Location = new System.Drawing.Point(169, 86);
            this.artistText.Margin = new System.Windows.Forms.Padding(4);
            this.artistText.Name = "artistText";
            this.artistText.Size = new System.Drawing.Size(330, 26);
            this.artistText.TabIndex = 2;
            // 
            // yearText
            // 
            this.yearText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearText.Location = new System.Drawing.Point(169, 164);
            this.yearText.Margin = new System.Windows.Forms.Padding(4);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(330, 26);
            this.yearText.TabIndex = 4;
            // 
            // urlText
            // 
            this.urlText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlText.Location = new System.Drawing.Point(169, 203);
            this.urlText.Margin = new System.Windows.Forms.Padding(4);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(330, 26);
            this.urlText.TabIndex = 5;
            // 
            // outputText
            // 
            this.outputText.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.outputText.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputText.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.outputText.Location = new System.Drawing.Point(542, 374);
            this.outputText.Margin = new System.Windows.Forms.Padding(4);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputText.Size = new System.Drawing.Size(499, 299);
            this.outputText.TabIndex = 16;
            this.outputText.TabStop = false;
            // 
            // songList
            // 
            this.songList.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.songList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songList.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.songList.FormattingEnabled = true;
            this.songList.HorizontalScrollbar = true;
            this.songList.ItemHeight = 16;
            this.songList.Location = new System.Drawing.Point(542, 46);
            this.songList.Name = "songList";
            this.songList.ScrollAlwaysVisible = true;
            this.songList.Size = new System.Drawing.Size(499, 276);
            this.songList.TabIndex = 17;
            this.songList.TabStop = false;
            this.songList.SelectedIndexChanged += new System.EventHandler(this.songList_SelectedIndexChanged);
            // 
            // allSongsButton
            // 
            this.allSongsButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.allSongsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.allSongsButton.Location = new System.Drawing.Point(69, 400);
            this.allSongsButton.Name = "allSongsButton";
            this.allSongsButton.Size = new System.Drawing.Size(265, 66);
            this.allSongsButton.TabIndex = 8;
            this.allSongsButton.Text = "Show All Songs";
            this.allSongsButton.UseVisualStyleBackColor = false;
            this.allSongsButton.Click += new System.EventHandler(this.allSongsButton_Click);
            // 
            // songListLabel
            // 
            this.songListLabel.AutoSize = true;
            this.songListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songListLabel.Location = new System.Drawing.Point(757, 23);
            this.songListLabel.Name = "songListLabel";
            this.songListLabel.Size = new System.Drawing.Size(80, 20);
            this.songListLabel.TabIndex = 19;
            this.songListLabel.Text = "Song List";
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsLabel.Location = new System.Drawing.Point(757, 350);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(62, 20);
            this.detailsLabel.TabIndex = 20;
            this.detailsLabel.Text = "Details";
            // 
            // findSongButton
            // 
            this.findSongButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.findSongButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.findSongButton.Location = new System.Drawing.Point(69, 472);
            this.findSongButton.Name = "findSongButton";
            this.findSongButton.Size = new System.Drawing.Size(74, 58);
            this.findSongButton.TabIndex = 9;
            this.findSongButton.Text = "Find Song";
            this.findSongButton.UseVisualStyleBackColor = false;
            this.findSongButton.Click += new System.EventHandler(this.findSong_Click);
            // 
            // removeSongButton
            // 
            this.removeSongButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removeSongButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeSongButton.Location = new System.Drawing.Point(69, 536);
            this.removeSongButton.Name = "removeSongButton";
            this.removeSongButton.Size = new System.Drawing.Size(265, 60);
            this.removeSongButton.TabIndex = 12;
            this.removeSongButton.Text = "Remove Song";
            this.removeSongButton.UseVisualStyleBackColor = false;
            this.removeSongButton.Click += new System.EventHandler(this.removeSong_Click);
            // 
            // genreComboBox
            // 
            this.genreComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Blues",
            "Classic Rock",
            "Country",
            "Easy listening",
            "Electronic",
            "Folk",
            "Hip-hop",
            "Jazz",
            "Pop",
            "R&B",
            "Rock",
            "Metal",
            "Punk"});
            this.genreComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.genreComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Items.AddRange(new object[] {
            "Blues",
            "Classic Rock",
            "Country",
            "Easy listening",
            "Electronic",
            "Folk",
            "Hip-hop",
            "Jazz",
            "Pop",
            "R&B",
            "Rock",
            "Metal",
            "Punk"});
            this.genreComboBox.Location = new System.Drawing.Point(169, 125);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(330, 24);
            this.genreComboBox.TabIndex = 3;
            // 
            // testDataButton
            // 
            this.testDataButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.testDataButton.Location = new System.Drawing.Point(459, 622);
            this.testDataButton.Name = "testDataButton";
            this.testDataButton.Size = new System.Drawing.Size(67, 66);
            this.testDataButton.TabIndex = 15;
            this.testDataButton.Text = "Create Test Data";
            this.testDataButton.UseVisualStyleBackColor = false;
            this.testDataButton.Click += new System.EventHandler(this.testData_Click);
            // 
            // findArtistButton
            // 
            this.findArtistButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.findArtistButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.findArtistButton.Location = new System.Drawing.Point(160, 473);
            this.findArtistButton.Name = "findArtistButton";
            this.findArtistButton.Size = new System.Drawing.Size(75, 57);
            this.findArtistButton.TabIndex = 10;
            this.findArtistButton.Text = "Find Artist";
            this.findArtistButton.UseVisualStyleBackColor = false;
            this.findArtistButton.Click += new System.EventHandler(this.findArtist_Click);
            // 
            // findGenreButton
            // 
            this.findGenreButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.findGenreButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.findGenreButton.Location = new System.Drawing.Point(259, 473);
            this.findGenreButton.Name = "findGenreButton";
            this.findGenreButton.Size = new System.Drawing.Size(75, 57);
            this.findGenreButton.TabIndex = 11;
            this.findGenreButton.Text = "Find Genre";
            this.findGenreButton.UseVisualStyleBackColor = false;
            this.findGenreButton.Click += new System.EventHandler(this.findGenre_Click);
            // 
            // savePlaylistButton
            // 
            this.savePlaylistButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.savePlaylistButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.savePlaylistButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.savePlaylistButton.Location = new System.Drawing.Point(76, 607);
            this.savePlaylistButton.Name = "savePlaylistButton";
            this.savePlaylistButton.Size = new System.Drawing.Size(67, 66);
            this.savePlaylistButton.TabIndex = 13;
            this.savePlaylistButton.Text = "Save Playlist";
            this.savePlaylistButton.UseVisualStyleBackColor = false;
            this.savePlaylistButton.Click += new System.EventHandler(this.savePlaylist_Click);
            // 
            // loadPlaylistButton
            // 
            this.loadPlaylistButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.loadPlaylistButton.Location = new System.Drawing.Point(149, 607);
            this.loadPlaylistButton.Name = "loadPlaylistButton";
            this.loadPlaylistButton.Size = new System.Drawing.Size(67, 66);
            this.loadPlaylistButton.TabIndex = 14;
            this.loadPlaylistButton.Text = "Load Playlist";
            this.loadPlaylistButton.UseVisualStyleBackColor = false;
            this.loadPlaylistButton.Click += new System.EventHandler(this.loadPlaylist_Click);
            // 
            // playlistText
            // 
            this.playlistText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistText.Location = new System.Drawing.Point(169, 242);
            this.playlistText.Margin = new System.Windows.Forms.Padding(4);
            this.playlistText.Name = "playlistText";
            this.playlistText.Size = new System.Drawing.Size(330, 26);
            this.playlistText.TabIndex = 6;
            // 
            // playlistLabel
            // 
            this.playlistLabel.AutoSize = true;
            this.playlistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistLabel.Location = new System.Drawing.Point(65, 242);
            this.playlistLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playlistLabel.Name = "playlistLabel";
            this.playlistLabel.Size = new System.Drawing.Size(63, 20);
            this.playlistLabel.TabIndex = 29;
            this.playlistLabel.Text = "Playlist";
            // 
            // webViewDisplay
            // 
            this.webViewDisplay.AllowExternalDrop = true;
            this.webViewDisplay.CreationProperties = null;
            this.webViewDisplay.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webViewDisplay.Location = new System.Drawing.Point(1086, 42);
            this.webViewDisplay.Name = "webViewDisplay";
            this.webViewDisplay.Size = new System.Drawing.Size(534, 538);
            this.webViewDisplay.Source = new System.Uri("https://www.youtube.com/", System.UriKind.Absolute);
            this.webViewDisplay.TabIndex = 30;
            this.webViewDisplay.ZoomFactor = 1D;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(1288, 615);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(109, 51);
            this.playButton.TabIndex = 17;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1108, 607);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1493, 615);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1632, 700);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.webViewDisplay);
            this.Controls.Add(this.playlistText);
            this.Controls.Add(this.playlistLabel);
            this.Controls.Add(this.loadPlaylistButton);
            this.Controls.Add(this.savePlaylistButton);
            this.Controls.Add(this.findGenreButton);
            this.Controls.Add(this.findArtistButton);
            this.Controls.Add(this.testDataButton);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.removeSongButton);
            this.Controls.Add(this.findSongButton);
            this.Controls.Add(this.detailsLabel);
            this.Controls.Add(this.songListLabel);
            this.Controls.Add(this.allSongsButton);
            this.Controls.Add(this.songList);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.artistText);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.addButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.Text = "Video Manager";
            ((System.ComponentModel.ISupportInitialize)(this.webViewDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox artistText;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.ListBox songList;
        private System.Windows.Forms.Button allSongsButton;
        private System.Windows.Forms.Label songListLabel;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.Button findSongButton;
        private System.Windows.Forms.Button removeSongButton;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.Button testDataButton;
        private System.Windows.Forms.Button findArtistButton;
        private System.Windows.Forms.Button findGenreButton;
        private System.Windows.Forms.Button savePlaylistButton;
        private System.Windows.Forms.Button loadPlaylistButton;
        private System.Windows.Forms.TextBox playlistText;
        private System.Windows.Forms.Label playlistLabel;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewDisplay;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

