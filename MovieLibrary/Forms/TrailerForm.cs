using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLibrary.Forms
{
    public partial class TrailerForm : Form
    {
        public TrailerForm()
        {
            InitializeComponent();
        }

        public string movieName { get; set; }
        public string year { get; set; }

        public TrailerForm(string movieName, string year)
        {
            this.movieName = movieName;
            this.year = year;
            InitializeComponent();
        }

        private async void TrailerForm_Load(object sender, EventArgs e)
        {
            await Search(movieName, year);
        }

        public async Task Search(string movieName, string year)
        {

            //Burada api'ın yeni sürümünden kaynaklanan bir uyum sorunu giderilmiştir.
            var appName = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe";

            using (var Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true))
                Key.SetValue(appName, 99999, RegistryValueKind.DWord);

            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyA51Ttqhd9_nkWVVpJWwXvmDMIIvINOPCM",
                ApplicationName = this.GetType().ToString()
            });

            //Anahtar Kelimeye Göre Youtube Araması Gerçekleştirilmektedir
            var searchListRequest = youtubeService.Search.List("snippet");
            searchListRequest.Q = $"{movieName} {year} Official Trailer"; 

            //Sadece bir video'ya ihtiyacımız var
            searchListRequest.MaxResults = 1;

            var searchListResponse = await searchListRequest.ExecuteAsync();

            List<string> videos = new List<string>();
            List<string> channels = new List<string>();
            List<string> playlists = new List<string>();

            string v = "";

            
            foreach (var searchResult in searchListResponse.Items)
            {
                switch (searchResult.Id.Kind)
                {
                    case "youtube#video":
                        videos.Add(searchResult.Id.VideoId);
                        break;

                    case "youtube#channel":
                        channels.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.ChannelId));
                        break;

                    case "youtube#playlist":
                        playlists.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.PlaylistId));
                        break;
                }
            }

            //url'i parametre olarak aktarıyoruz
            v = videos[0];
            string navigateUrl = $@"https://www.youtube.com/embed/{v}";

            //web browser componentini belirtilen adrese gönderiyoruz
            webBrowser1.Navigate(navigateUrl);

        }

        
    }
}
