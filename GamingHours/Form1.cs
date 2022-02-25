using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

namespace GamingHours
{
    public partial class MainForm : Form
    {
        public bool ReceivedData;
        public SteamIdData steamIdData;
        public SteamPlayerData steamPlayerData;
        public SteamOwnedGamesData steamOwnedGamesData;

        public MainForm()
        {
            InitializeComponent();
            //receiveData();
            //receiveSteamIdData();
        }

        private string receiveSteamIdData(string name)
        {
            System.Net.WebClient downloader = new System.Net.WebClient();
            string dataJson = downloader.DownloadString("http://api.steampowered.com/ISteamUser/ResolveVanityURL/v0001/?key=61E6FF710E52D8C353B124A3BC175C22&vanityurl=" + name);
            //steamIdData = JsonConvert.DeserializeObject<SteamIdData>(dataJson);
            JObject o = JObject.Parse(dataJson);
            ReceivedData = true;

            steamIdData = JsonConvert.DeserializeObject<SteamIdData>(JsonConvert.SerializeObject(o["response"]));
            return steamIdData.steamid;
        }

        private void receiveSteamPlayerData(string steamId)
        {
            System.Net.WebClient downloader = new System.Net.WebClient();
            string dataJson = downloader.DownloadString("http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key=61E6FF710E52D8C353B124A3BC175C22&steamids=" + steamId);
            //data = JsonConvert.DeserializeObject<Data>(dataJson);
            JObject o = JObject.Parse(dataJson);
            ReceivedData = true;

            steamPlayerData = JsonConvert.DeserializeObject<SteamPlayerData>(JsonConvert.SerializeObject(o["response"]["players"][0]));
        }

        private void receiveSteamOwnedGamesData(string steamId)
        {
            System.Net.WebClient downloader = new System.Net.WebClient();
            string dataJson = downloader.DownloadString("http://api.steampowered.com/IPlayerService/GetOwnedGames/v0001/?key=61E6FF710E52D8C353B124A3BC175C22&steamid=" + steamId);
            //data = JsonConvert.DeserializeObject<Data>(dataJson);
            JObject o = JObject.Parse(dataJson);
            ReceivedData = true;

            steamOwnedGamesData = JsonConvert.DeserializeObject<SteamOwnedGamesData>(JsonConvert.SerializeObject(o["response"]));
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text != string.Empty)
            {
                string steamId = receiveSteamIdData(textBox.Text);
                receiveSteamPlayerData(steamId);
                receiveSteamOwnedGamesData(steamId);
                showUsernameLabel.Text = "Name: " + steamPlayerData.personaname;
                showProfileUrlLabel.Text = "ProfileUrl: " + steamPlayerData.profileurl;


                if (steamPlayerData.realname == null)
                {
                    showRealNameLabel.Text = "RealName: His/Her realname is set on private";
                }
                else
                {
                    showRealNameLabel.Text = "RealName: " + steamPlayerData.realname;
                }

                showGamesOwnedLabel.Text = "Games owned: " + steamOwnedGamesData.game_count;
            }
        }
    }
}
