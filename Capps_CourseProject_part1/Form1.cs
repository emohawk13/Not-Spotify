using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Web.WebView2.Core;

namespace Capps_CourseProject_part1
{
    public partial class mainForm : Form
    {
        string[] titleArray = new string[5]; // song title
        string[] artistArray = new string[5]; // artist
        string[] genreArray = new string[5]; // genre
        int[] yearArray = new int[5];         //year
        string[] urlArray = new string[5];    //url
        string[] playlistArray = new string[5];     // Playlist identifyer 

        int songCount = 0;


        public mainForm()
        {
            InitializeComponent();
        }
        public void addButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(outputText.Text);
            string nl = "\r\n";
            if(songCount == titleArray.Length)
            {
                MessageBox.Show("Song list full");
            }

            if (string.IsNullOrEmpty(titleText.Text))
            {
                MessageBox.Show("The song title may be blank");
            }
            else if (string.IsNullOrEmpty(artistText.Text))
            {
                MessageBox.Show("The song artist may be blank");
            }
            else if (string.IsNullOrEmpty(genreComboBox.SelectedItem.ToString()))
            {
                MessageBox.Show("The song genre may be blank");
            }
            else if (string.IsNullOrEmpty(yearText.Text))
            {
                MessageBox.Show("The song year may be blank");
            }
            else if (string.IsNullOrEmpty(urlText.Text))
            {
                MessageBox.Show("The song URL may be blank");
            }

            else
            {
                titleArray[songCount] = titleText.Text;
                artistArray[songCount] = artistText.Text;
                genreArray[songCount] = genreComboBox.SelectedItem.ToString();
                yearArray[songCount] = int.Parse(yearText.Text);
                urlArray[songCount] = urlText.Text;
                playlistArray[songCount] = playlistText.Text;
                songCount++;

                songList.Items.Add(titleText.Text);
                sb.Append(titleText.Text);
                sb.Append(nl);
                sb.Append(artistText.Text);
                sb.Append(nl);
                sb.Append(genreComboBox.SelectedItem.ToString());
                sb.Append(nl);
                sb.Append(yearText.Text);
                sb.Append(nl);
                sb.Append(urlText.Text);
                sb.Append(nl);
                sb.Append(playlistText.Text);
                sb.Append(nl);
                sb.Append(nl);
                titleText.Text = "";
                artistText.Text = "";
                yearText.Text = "";
                urlText.Text = "";
                genreComboBox.ResetText();
                playlistText.Text = "";
                outputText.Text = sb.ToString();
                AppendToCSV();
                
            }

        }
        public void allSongsFunction()
        {
            //Change to All songs to All Playlists
            MessageBox.Show("Under Construction");

           // StringBuilder sb = new StringBuilder(string.Empty);
           // string nl = "\r\n";

            // To build the output text for allSongsButton_Click
            //foreach (var item in MasterData())
           // {
             //   sb.Append(item.ToString());
               // sb.Append(nl);
           // }
            // To put the output text into the output textbox
           // outputText.Text = sb.ToString();
        }
        private void allSongsButton_Click(object sender, EventArgs e) =>
            //collect all songs from the TestData.csv (with new songs added from the user)
            MessageBox.Show("Under Construction");
        private bool SongInList(string SongTitle) // may delete
        {
            bool ReadCSVFile = false;
            foreach (var item in songList.Items)
            {
                string currentSong = item as string;
                if (SongTitle == currentSong)
                {
                    ReadCSVFile = true;
                }
            }
            return ReadCSVFile;
        }
        private void findSong_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(outputText.Text);
            string n2 = "\r\n";
            int songIndex = 0;

            //change find songs to show Playlists and have a way to open them.

            if (SongInList(titleText.Text))
                MessageBox.Show("Song found");
                if (SongInList(titleText.Text))
                {
                    songIndex = GetSongIndex(titleText.Text);
                    sb.Append(titleText.Text);
                    sb.Append(n2);
                    sb.Append(artistArray[songIndex]);
                    sb.Append(n2);
                    sb.Append(genreArray[songIndex]);
                    sb.Append(n2);
                    sb.Append(yearArray[songIndex]);
                    sb.Append(n2);
                    sb.Append(urlArray[songIndex]);
                    sb.Append(n2);
                    sb.Append(playlistArray[songIndex]);
                    sb.Append(n2);
                    outputText.Text = sb.ToString();
            }
            else
            {
                MessageBox.Show("Song not in list");
            }
        } // find song button
        private void removeSong_Click(object sender, EventArgs e) // needs fixed - remove song not append
        {
            if (SongInList(titleText.Text)) 
            {
                if (SongInList(titleText.Text))
                    MessageBox.Show("Song found");

                {
                    string[] values = File.ReadAllText("TestData.csv").Split(new char[] { ',' });
                    StringBuilder ObjStringBuilder = new StringBuilder();

                    for (int i = 0; i < values.Length; i++)
                    {
                        if (values[i] == titleText.Text)
                            continue;
                        ObjStringBuilder.Append(values[i] + ",");
                    }
                    ObjStringBuilder.ToString().Remove(ObjStringBuilder.Length - 1);
                    File.WriteAllText("C:\\YourLibary.csv", ObjStringBuilder.ToString());

                    MessageBox.Show("Song removed");
                }
            }

            else
            {
                MessageBox.Show("Song not in list");
            }
        }
        private void testData_Click(object sender, EventArgs e) // needs to call dat from LabelDef
        {
            titleText.Text = "Title1";
            artistText.Text = "Artist1";
            yearText.Text = "9999";
            urlText.Text = "URL1";
            playlistText.Text = "999";
            AppendToCSV();
        }
        public static void ReadCSVFile() // needs to import CSV data to act as save data
        {
            var lines = File.ReadAllLines("TestData.csv");
            var list = new List<LabelDef>();
            list.ForEach(x => Console.WriteLine($"{x.Title}\t{x.Artist}\t{x.Genre}\t{x.Year}\t{x.Playlist}\t{x.URL}"));
            Console.ReadLine();
            
            
            //GetSongIndex



        }
        public class LabelDef // Home of the Labels and Tables for CSV
        {
            public string Title { get; set; }
            public string Artist { get; set; }
            public string Genre { get; set; }
            public string Year { get; set; }
            public string URL { get; set; }
            public string Playlist { get; set; }
            public static List<LabelDef> GetDefs()
            {
                return new List<LabelDef>()
                {
                    new LabelDef(){Title="Title1",Artist="Artist1",Genre="Classic Rock",Year="1995",Playlist="1",URL="www.youtube.com/Title1"},
                    new LabelDef(){Title="Title2",Artist="Artist2",Genre="Jazz",Year="2012",Playlist="2",URL="www.youtube.com/Title2"},
                    new LabelDef(){Title="Title3",Artist="Artist3",Genre="Hip-hop",Year="2014",Playlist="3",URL="www.youtube.com/Title3"},
                    new LabelDef(){Title="Title4",Artist="Artist4",Genre="Classic Rock",Year="1985",Playlist="1",URL="www.youtube.com/Title1"},
                    new LabelDef(){Title="Title5",Artist="Artist5",Genre="Jazz",Year="2004",Playlist="2",URL="www.youtube.com/Title2"},
                    new LabelDef(){Title="Title6",Artist="Artist6",Genre="Hip-hop",Year="2006",Playlist="3",URL="www.youtube.com/Title3"},
                    new LabelDef(){Title="Title7",Artist="Artist7",Genre="Classic Rock",Year="1990",Playlist="1",URL="www.youtube.com/Title1"},
                    new LabelDef(){Title="Title8",Artist="Artist8",Genre="Jazz",Year="2007",Playlist="2",URL="www.youtube.com/Title2"},
                    new LabelDef(){Title="Title9",Artist="Artist9",Genre="Hip-hop",Year="2010",Playlist="3", URL="www.youtube.com/Title3"},
                    new LabelDef(){Title="Title10",Artist="Artist10",Genre="Jazz",Year="2008",Playlist="2", URL="www.youtube.com/Title2"},
                }; // Test Data for CSV - used to show proff of import
            }
            internal static LabelDef ParseRow(string row)
            {
                var columns = row.Split(',');
                return new LabelDef()
                {
                    Title = columns[0],
                    Artist = columns[1],
                    Genre = columns[3],
                    Year = columns[4],
                    URL = columns[5],
                    Playlist = columns[6]
                };
            }
        }
        private static void AppendToCSV() // use to call LabelDef
        {
            var list = LabelDef.GetDefs();
            foreach (var c in list)
            {
                File.AppendAllText("TestData.csv", $"{ c.Title},{ c.Artist},{ c.Genre},{ c.Year},{ c.URL},{ c.Playlist}\n");
            }
        }
        private void findArtist_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Construction");
        } // needs fixed
        private void findGenre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Construction");
        } // needs fixed
        private void savePlaylist_Click(object sender, EventArgs e) // establish Playlists by catorgizing data from songList
        {
            //add a way to make sure there isn't a copy of a song title and require the user to enter a playlist number. 
            
            AppendToCSV();
            MessageBox.Show("PlayList Saved");
        }
        private void loadPlaylist_Click(object sender, EventArgs e)
        {
            ReadCSVFile();
            Console.ReadLine();
            // add way to open a spesific playlist inside of the CSV and or create a new CSV per new Playlist.
        }
        public int GetSongIndex(String songTitle)
        {
            int songIndex = 0;
            songIndex = songList.Items.IndexOf(songTitle);
            return songIndex;
        }
        private void songList_SelectedIndexChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(string.Empty);
            string n2 = "\r\n";
            int songIndex = -1;
            songIndex = songList.SelectedIndex;
            sb.Append(titleText.Text);
            sb.Append(n2);
            sb.Append(artistArray[songIndex]);
            sb.Append(n2);
            sb.Append(genreArray[songIndex]);
            sb.Append(n2);
            sb.Append(yearArray[songIndex].ToString());
            sb.Append(n2);
            sb.Append(urlArray[songIndex]);
            sb.Append(n2);
            sb.Append(playlistArray[songIndex]);
            sb.Append(n2);
        }
        private void playButton_Click(object sender, EventArgs e)
        {
            int songIndex = 0;
            songIndex = songList.SelectedIndex;
            string url = urlArray[songIndex];
            webViewDisplay.CoreWebView2.Navigate(url);
        }
    }

}




// C:\Users\capps\Documents\School\DeVry\Ceis209\Week 3\Project_adding more event handlers to your controls\Capps_CourseProject_part1\Capps_CourseProject_part1\bin\Debug\TestData.csv