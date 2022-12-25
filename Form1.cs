using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace SpotifyBot_vIII
{
    public partial class MainForm : Form
    {

        #region variables
        readonly string spotifyPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Spotify\\Spotify.exe";
        int milliSecTimeBetweenMusic;
        readonly string openVpnPath = "C:\\Program Files\\OpenVPN\\bin\\openvpn-gui.exe";
        readonly string sandboxiePath = "C:\\Program Files\\Sandboxie-Plus\\Start.exe";
        readonly string sandboxieSbiePath = "C:\\Program Files\\Sandboxie-Plus\\SbieIni.exe";
        readonly string jsonCompteSaveFileName = "Comptes.txt";
        public static int Tier; // 0 = basic (5 sandbox), 1 = premier tier (10 sandbox), 2 = deuxieme tier (30 sandbox), 3 = illimité
        public int sandboxNumber = 0;
        BindingList<Comptes> listComptes;
        #endregion variables
        public MainForm()
        {
            InitializeComponent();
            VerifyFiles();
            listComptes = DeserializeCompte();
            lbComptes.DataSource = listComptes;
            lbComptes.DataContext = "ComptesUser";
            milliSecTimeBetweenMusic = tbInterval.Value * 60 *1000;
            lbInterval.Text = tbInterval.Value.ToString();
            
        }

        private BindingList<Comptes>? DeserializeCompte()
        {
            string jsonString = File.ReadAllText(jsonCompteSaveFileName);
            BindingList<Comptes>? listComptes = JsonSerializer.Deserialize<BindingList<Comptes>>(jsonString);
            return listComptes;
        }

        public void VerifyFiles()
        {
            if (!File.Exists(spotifyPath))
            {
                InstallSpotify();
            }
            if (!File.Exists(jsonCompteSaveFileName))
            {
                SerializeCompte();
            }
            if (!File.Exists(openVpnPath))
            {
                InstallOpenVpn();
            }
            if (!File.Exists(sandboxiePath))
            {
                InstallSandboxie();
                MessageBox.Show("Please restart the app ...");
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    sandboxNumber++;
                    Process enableSandoxInstance = new();
                    //enableSandoxInstance.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    enableSandoxInstance.StartInfo.UseShellExecute = false;
                    enableSandoxInstance.StartInfo.CreateNoWindow = true;
                    enableSandoxInstance.StartInfo.FileName = sandboxieSbiePath;
                    enableSandoxInstance.StartInfo.Arguments = $"set spotify{i} Enabled y";
                    //Process.Start(sandboxieSbiePath, $"set spotify{i} Enabled y", UseSh);
                    enableSandoxInstance.Start();
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLaunchSpotify_Click(object sender, EventArgs e)
        {
            Process.Start(spotifyPath);
        }

        private void tbInterval_Scroll(object sender, EventArgs e)
        {
            milliSecTimeBetweenMusic = tbInterval.Value * 60 * 1000;
            lbInterval.Text = tbInterval.Value.ToString();
        }

        private void btnConnectOpenvpn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new()
            {
                InitialDirectory = "C:\\Program Files\\OpenVPN\\config",
                Filter = "Fichier ovpn | *.ovpn",
                FilterIndex = 0,
                RestoreDirectory = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;

                var proc = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "C:\\Program Files\\OpenVPN\\bin\\openvpn-gui.exe",
                        Arguments = "--connect " + Path.GetFileName(selectedFileName),
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = false,
                        WorkingDirectory = Path.GetDirectoryName(selectedFileName)
                    }
                };
                proc.Start();
            }
        }

        private void btnRechercherChanson_Click(object sender, EventArgs e)
        {
            PlaySong(tbChanson.Text);
        }
        public void PlaySong(string song)
        {
            if (lbComptes.Items.Count == 0 || lbComptes.SelectedIndex == -1)
            {
                MessageBox.Show("Veulliez ajouter un compte Spotify et le selectionner pour l'utiliser");
                return;
            }
            System.Diagnostics.Process.Start(sandboxiePath, $"/box:spotify{lbComptes.SelectedIndex} {spotifyPath} --uri={tbChanson.Text} --username={lbComptes.GetItemText(lbComptes.SelectedItem)} --password={listComptes[lbComptes.SelectedIndex].ComptesPassword}");
            //C:\\Program Files\\Sandboxie-Plus\\Start.exe /box:spotify1 C:\\Users\\Volko\\AppData\\Roaming\\Spotify\\Spotify.exe -uri=Mika -username=volkovolko76@gmail.com -password=S.Bou7Chou
        }
        #region installations
        static void InstallSpotify()
        {
            MessageBox.Show("Nous allons installer Spotify dans le bon répertoire pour le bon fonctionnement du programme...");
            using (var client = new System.Net.Http.HttpClient())
            {
                client.GetAsync("https://download.scdn.co/SpotifySetup.exe");
                //client.DownloadFile("https://download.scdn.co/SpotifySetup.exe", "spotifyInstaller.exe");
            }
            Process.Start("spotifyInstaller.exe");
        }

        void InstallOpenVpn()
        {
            MessageBox.Show("Nous allons installer OpenVPN dans le bon répertoire pour le bon fonctionnement du programme...");
            using (var client = new System.Net.Http.HttpClient())
            {
                client.GetAsync("https://swupdate.openvpn.org/community/releases/OpenVPN-2.5.7-I602-amd64.msi");
                //client.DownloadFile("https://swupdate.openvpn.org/community/releases/OpenVPN-2.5.7-I602-amd64.msi", "openvpnInstaller.msi");
            }
            Process.Start("openvpnInstaller.msi");
            Thread.Sleep(1000);
            SendKeys.SendWait("{ENTER}");
            Thread.Sleep(30000);
            ActivateApp("OpenVPN 2.5.7-I602");
            SendKeys.SendWait("{ENTER}");

            //Setup OpenVPN 2.5.7-I602
        }
        void InstallSandboxie()
        {
            MessageBox.Show("Nous allons installer Sandboxie dans le bon répertoire pour le bon fonctionnement du programme...");
            using (var client = new System.Net.Http.HttpClient())
            {
                client.GetAsync("https://github.com/sandboxie-plus/Sandboxie/releases/download/v1.3.2/Sandboxie-Plus-x64-v1.3.2.exe");
                //client.DownloadFile("https://github.com/sandboxie-plus/Sandboxie/releases/download/v1.3.2/Sandboxie-Plus-x64-v1.3.2.exe", "sandboxieInstaller.exe");
            }
            Process.Start("sandboxieInstaller.exe", "/S");
        }
        #endregion installations
        #region activateApp
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        void ActivateApp(string processName)
        {
            Process[] p = Process.GetProcessesByName(processName);
            // Activate the first application we find with this name
            if (p.Length > 0)
                SetForegroundWindow(p[0].MainWindowHandle);
        }
        #endregion activateApp

        #region tools
        public void ViewProcess()
        {
            //_ = Process.GetCurrentProcess();
            Process[] list = Process.GetProcessesByName("Spotify");
            foreach (var process in list)
            {
                MessageBox.Show(process.ProcessName + process.Id.ToString());
            }
        }

        /*
        public void RecreateImageInProjectFolder(Image img, string name)
        {
            img.Save(Directory.GetCurrentDirectory() + $"//{name}.png");
        }*/
        #endregion tools

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
 
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        public void btnPlay_Click(object sender, EventArgs e)
        {
            _ = Repeat();
        }
        public async Task<int> Repeat()
        {
            do
            {
                foreach (string item in lbChansons.Items)
                {
                    PlaySong(item);
                    Thread.Sleep(milliSecTimeBetweenMusic);
                }
            } while (cbRepeat.Checked);
            return 1;
        }

        private void btnAddChanson_Click(object sender, EventArgs e)
        {
            lbChansons.Items.Add(tbChanson.Text.ToString());
        }

        private void btnRemoveChanson_Click(object sender, EventArgs e)
        {
            foreach (string s in lbChansons.SelectedItems.OfType<string>().ToList())
                lbChansons.Items.Remove(s);
        }

        private void btnAddComptes_Click(object sender, EventArgs e)
        {
            int i = lbComptes.Items.Count;
            if (Tier == 0)
            {
                if (i < 5)
                {
                    AddInstance(sandboxNumber + 1);
                }
            }
            else if (Tier == 1)
            {
                if (i < 10)
                {
                    AddInstance(sandboxNumber + 1);
                }
            }
            else if (Tier == 2)
            {
                if (i < 30)
                {
                    AddInstance(sandboxNumber + 1);
                }
            }
            else if (Tier == 3)
            {
                AddInstance(sandboxNumber + 1);
            }
        }
        void AddInstance(int i)
        {
            Process.Start(sandboxieSbiePath, $"set spotify{i} Enabled y");
            sandboxNumber++;
        }
        public void AddAccount()
        {
            listComptes = DeserializeCompte();
            listComptes.Add(new Comptes(tbUsername.Text, tbPassword.Text));
            lbComptes.DataSource = listComptes;
            lbComptes.DataContext = "ComptesUser";
            SerializeCompte();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            foreach (Comptes compte in listComptes)
            {
                MessageBox.Show(compte.ToString());
            }
        }

        private void btnRemoveCompte_Click(object sender, EventArgs e)
        {
            listComptes.Remove(listComptes[lbComptes.SelectedIndex]);
            SerializeCompte();
        }
        public void SerializeCompte()
        {
            string jsonString = JsonSerializer.Serialize(listComptes);
            File.WriteAllText(jsonCompteSaveFileName, jsonString);
        }
    }
}