namespace SpotifyBot_vIII
{
    partial class MainForm
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
            this.panLeft = new System.Windows.Forms.Panel();
            this.btnUpgrade = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.labUserTier = new System.Windows.Forms.Label();
            this.labUsername = new System.Windows.Forms.Label();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.panHeader = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLaunchSpotify = new System.Windows.Forms.Button();
            this.btnConnectOpenvpn = new System.Windows.Forms.Button();
            this.tbChanson = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRechercherChanson = new System.Windows.Forms.Button();
            this.btnStopRepeter = new System.Windows.Forms.Button();
            this.btnAddChanson = new System.Windows.Forms.Button();
            this.btnRemoveChanson = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lbChansons = new System.Windows.Forms.ListBox();
            this.tbInterval = new System.Windows.Forms.TrackBar();
            this.lbInterval = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lbComptes = new System.Windows.Forms.ListBox();
            this.button10 = new System.Windows.Forms.Button();
            this.btnRemoveCompte = new System.Windows.Forms.Button();
            this.btnAddComptes = new System.Windows.Forms.Button();
            this.cbRepeat = new System.Windows.Forms.CheckBox();
            this.panLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.panHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbInterval)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panLeft
            // 
            this.panLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panLeft.Controls.Add(this.btnUpgrade);
            this.panLeft.Controls.Add(this.label10);
            this.panLeft.Controls.Add(this.labUserTier);
            this.panLeft.Controls.Add(this.labUsername);
            this.panLeft.Controls.Add(this.pbUser);
            this.panLeft.Location = new System.Drawing.Point(0, 0);
            this.panLeft.Name = "panLeft";
            this.panLeft.Size = new System.Drawing.Size(200, 622);
            this.panLeft.TabIndex = 0;
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.btnUpgrade.FlatAppearance.BorderSize = 0;
            this.btnUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpgrade.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpgrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnUpgrade.Location = new System.Drawing.Point(49, 261);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpgrade.Size = new System.Drawing.Size(95, 38);
            this.btnUpgrade.TabIndex = 19;
            this.btnUpgrade.Text = "Upgrade";
            this.btnUpgrade.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label10.Location = new System.Drawing.Point(0, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(199, 65);
            this.label10.TabIndex = 19;
            this.label10.Text = "Tiers :\r\n    -Basic : 5 instances\r\n    -Tier I : 10 instances\r\n    -Tier II : 30 " +
    "instances\r\n    -Unlimited : unlimited instances\r\n";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labUserTier
            // 
            this.labUserTier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labUserTier.AutoSize = true;
            this.labUserTier.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labUserTier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.labUserTier.Location = new System.Drawing.Point(68, 129);
            this.labUserTier.Margin = new System.Windows.Forms.Padding(0);
            this.labUserTier.Name = "labUserTier";
            this.labUserTier.Size = new System.Drawing.Size(55, 12);
            this.labUserTier.TabIndex = 4;
            this.labUserTier.Text = "Tier Basic";
            this.labUserTier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labUsername
            // 
            this.labUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labUsername.AutoSize = true;
            this.labUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labUsername.Location = new System.Drawing.Point(59, 100);
            this.labUsername.Name = "labUsername";
            this.labUsername.Size = new System.Drawing.Size(85, 16);
            this.labUsername.TabIndex = 3;
            this.labUsername.Text = "User Name";
            this.labUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbUser
            // 
            this.pbUser.Image = global::SpotifyBot_vIII.Properties.Resources.User;
            this.pbUser.Location = new System.Drawing.Point(68, 22);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(63, 63);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 2;
            this.pbUser.TabStop = false;
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(62)))));
            this.panHeader.Controls.Add(this.label11);
            this.panHeader.Controls.Add(this.btnExit);
            this.panHeader.Location = new System.Drawing.Point(200, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(1176, 50);
            this.panHeader.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label11.Location = new System.Drawing.Point(30, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 32);
            this.label11.TabIndex = 20;
            this.label11.Text = "Music";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnExit.Image = global::SpotifyBot_vIII.Properties.Resources.Exit;
            this.btnExit.Location = new System.Drawing.Point(1065, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExit.Size = new System.Drawing.Size(95, 38);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLaunchSpotify
            // 
            this.btnLaunchSpotify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.btnLaunchSpotify.FlatAppearance.BorderSize = 0;
            this.btnLaunchSpotify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaunchSpotify.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLaunchSpotify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLaunchSpotify.Location = new System.Drawing.Point(15, 22);
            this.btnLaunchSpotify.Name = "btnLaunchSpotify";
            this.btnLaunchSpotify.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLaunchSpotify.Size = new System.Drawing.Size(238, 38);
            this.btnLaunchSpotify.TabIndex = 1;
            this.btnLaunchSpotify.Text = "Launch Spotify";
            this.btnLaunchSpotify.UseVisualStyleBackColor = false;
            this.btnLaunchSpotify.Click += new System.EventHandler(this.btnLaunchSpotify_Click);
            // 
            // btnConnectOpenvpn
            // 
            this.btnConnectOpenvpn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.btnConnectOpenvpn.FlatAppearance.BorderSize = 0;
            this.btnConnectOpenvpn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnectOpenvpn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConnectOpenvpn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnConnectOpenvpn.Location = new System.Drawing.Point(15, 73);
            this.btnConnectOpenvpn.Name = "btnConnectOpenvpn";
            this.btnConnectOpenvpn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConnectOpenvpn.Size = new System.Drawing.Size(238, 38);
            this.btnConnectOpenvpn.TabIndex = 2;
            this.btnConnectOpenvpn.Text = "Connect to OpenVPN";
            this.btnConnectOpenvpn.UseVisualStyleBackColor = false;
            this.btnConnectOpenvpn.Click += new System.EventHandler(this.btnConnectOpenvpn_Click);
            // 
            // tbChanson
            // 
            this.tbChanson.Location = new System.Drawing.Point(15, 143);
            this.tbChanson.Name = "tbChanson";
            this.tbChanson.Size = new System.Drawing.Size(238, 23);
            this.tbChanson.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(40, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Entrez l\'url de la chanson :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRechercherChanson
            // 
            this.btnRechercherChanson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.btnRechercherChanson.FlatAppearance.BorderSize = 0;
            this.btnRechercherChanson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechercherChanson.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRechercherChanson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnRechercherChanson.Location = new System.Drawing.Point(15, 183);
            this.btnRechercherChanson.Name = "btnRechercherChanson";
            this.btnRechercherChanson.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRechercherChanson.Size = new System.Drawing.Size(238, 38);
            this.btnRechercherChanson.TabIndex = 4;
            this.btnRechercherChanson.Text = "Rechercher Chanson";
            this.btnRechercherChanson.UseVisualStyleBackColor = false;
            this.btnRechercherChanson.Click += new System.EventHandler(this.btnRechercherChanson_Click);
            // 
            // btnStopRepeter
            // 
            this.btnStopRepeter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.btnStopRepeter.FlatAppearance.BorderSize = 0;
            this.btnStopRepeter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopRepeter.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStopRepeter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnStopRepeter.Location = new System.Drawing.Point(15, 227);
            this.btnStopRepeter.Name = "btnStopRepeter";
            this.btnStopRepeter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStopRepeter.Size = new System.Drawing.Size(238, 38);
            this.btnStopRepeter.TabIndex = 5;
            this.btnStopRepeter.Text = "Stop répeter";
            this.btnStopRepeter.UseVisualStyleBackColor = false;
            // 
            // btnAddChanson
            // 
            this.btnAddChanson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.btnAddChanson.FlatAppearance.BorderSize = 0;
            this.btnAddChanson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddChanson.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddChanson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddChanson.Image = global::SpotifyBot_vIII.Properties.Resources.Add;
            this.btnAddChanson.Location = new System.Drawing.Point(107, 271);
            this.btnAddChanson.Name = "btnAddChanson";
            this.btnAddChanson.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddChanson.Size = new System.Drawing.Size(70, 38);
            this.btnAddChanson.TabIndex = 7;
            this.btnAddChanson.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddChanson.UseVisualStyleBackColor = false;
            this.btnAddChanson.Click += new System.EventHandler(this.btnAddChanson_Click);
            // 
            // btnRemoveChanson
            // 
            this.btnRemoveChanson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.btnRemoveChanson.FlatAppearance.BorderSize = 0;
            this.btnRemoveChanson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveChanson.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveChanson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnRemoveChanson.Image = global::SpotifyBot_vIII.Properties.Resources.remove;
            this.btnRemoveChanson.Location = new System.Drawing.Point(183, 271);
            this.btnRemoveChanson.Name = "btnRemoveChanson";
            this.btnRemoveChanson.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRemoveChanson.Size = new System.Drawing.Size(70, 38);
            this.btnRemoveChanson.TabIndex = 8;
            this.btnRemoveChanson.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRemoveChanson.UseVisualStyleBackColor = false;
            this.btnRemoveChanson.Click += new System.EventHandler(this.btnRemoveChanson_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPlay.Image = global::SpotifyBot_vIII.Properties.Resources.Play;
            this.btnPlay.Location = new System.Drawing.Point(15, 271);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPlay.Size = new System.Drawing.Size(70, 38);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lbChansons
            // 
            this.lbChansons.FormattingEnabled = true;
            this.lbChansons.ItemHeight = 15;
            this.lbChansons.Location = new System.Drawing.Point(15, 315);
            this.lbChansons.Name = "lbChansons";
            this.lbChansons.Size = new System.Drawing.Size(238, 124);
            this.lbChansons.TabIndex = 9;
            // 
            // tbInterval
            // 
            this.tbInterval.Location = new System.Drawing.Point(15, 461);
            this.tbInterval.Minimum = 1;
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(213, 45);
            this.tbInterval.TabIndex = 10;
            this.tbInterval.Value = 1;
            this.tbInterval.Scroll += new System.EventHandler(this.tbInterval_Scroll);
            // 
            // lbInterval
            // 
            this.lbInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInterval.AutoSize = true;
            this.lbInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbInterval.Location = new System.Drawing.Point(224, 461);
            this.lbInterval.Name = "lbInterval";
            this.lbInterval.Size = new System.Drawing.Size(15, 16);
            this.lbInterval.TabIndex = 12;
            this.lbInterval.Text = "1";
            this.lbInterval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(6, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Temps entre chaque chanson (min) :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnLaunchSpotify);
            this.panel1.Controls.Add(this.lbInterval);
            this.panel1.Controls.Add(this.btnConnectOpenvpn);
            this.panel1.Controls.Add(this.tbInterval);
            this.panel1.Controls.Add(this.tbChanson);
            this.panel1.Controls.Add(this.lbChansons);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.btnRechercherChanson);
            this.panel1.Controls.Add(this.btnRemoveChanson);
            this.panel1.Controls.Add(this.btnStopRepeter);
            this.panel1.Controls.Add(this.btnAddChanson);
            this.panel1.Location = new System.Drawing.Point(230, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 507);
            this.panel1.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button7.Image = global::SpotifyBot_vIII.Properties.Resources.Exit;
            this.button7.Location = new System.Drawing.Point(1065, 6);
            this.button7.Name = "button7";
            this.button7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button7.Size = new System.Drawing.Size(95, 38);
            this.button7.TabIndex = 0;
            this.button7.Text = "Exit";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.tbPassword);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tbUsername);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(601, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 140);
            this.panel2.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label9.Location = new System.Drawing.Point(20, 6);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "Ajout de comptes";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(26, 96);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(238, 23);
            this.tbPassword.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label7.Location = new System.Drawing.Point(51, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Password";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(26, 41);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(238, 23);
            this.tbUsername.TabIndex = 11;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button8.Image = global::SpotifyBot_vIII.Properties.Resources.Exit;
            this.button8.Location = new System.Drawing.Point(1065, 6);
            this.button8.Name = "button8";
            this.button8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button8.Size = new System.Drawing.Size(95, 38);
            this.button8.TabIndex = 0;
            this.button8.Text = "Exit";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label6.Location = new System.Drawing.Point(51, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Username";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.btnTest.FlatAppearance.BorderSize = 0;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnTest.Location = new System.Drawing.Point(692, 527);
            this.btnTest.Name = "btnTest";
            this.btnTest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTest.Size = new System.Drawing.Size(95, 38);
            this.btnTest.TabIndex = 16;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(62)))));
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lbComptes);
            this.panel3.Controls.Add(this.button10);
            this.panel3.Controls.Add(this.btnRemoveCompte);
            this.panel3.Controls.Add(this.btnAddComptes);
            this.panel3.Location = new System.Drawing.Point(601, 247);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 250);
            this.panel3.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label8.Location = new System.Drawing.Point(23, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "Queue des Comptes";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbComptes
            // 
            this.lbComptes.FormattingEnabled = true;
            this.lbComptes.ItemHeight = 15;
            this.lbComptes.Location = new System.Drawing.Point(24, 73);
            this.lbComptes.Name = "lbComptes";
            this.lbComptes.Size = new System.Drawing.Size(238, 154);
            this.lbComptes.TabIndex = 15;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button10.Image = global::SpotifyBot_vIII.Properties.Resources.Exit;
            this.button10.Location = new System.Drawing.Point(1065, 6);
            this.button10.Name = "button10";
            this.button10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button10.Size = new System.Drawing.Size(95, 38);
            this.button10.TabIndex = 0;
            this.button10.Text = "Exit";
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // btnRemoveCompte
            // 
            this.btnRemoveCompte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.btnRemoveCompte.FlatAppearance.BorderSize = 0;
            this.btnRemoveCompte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCompte.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveCompte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnRemoveCompte.Image = global::SpotifyBot_vIII.Properties.Resources.Exit;
            this.btnRemoveCompte.Location = new System.Drawing.Point(192, 29);
            this.btnRemoveCompte.Name = "btnRemoveCompte";
            this.btnRemoveCompte.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRemoveCompte.Size = new System.Drawing.Size(70, 38);
            this.btnRemoveCompte.TabIndex = 14;
            this.btnRemoveCompte.Text = "Remove";
            this.btnRemoveCompte.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRemoveCompte.UseVisualStyleBackColor = false;
            this.btnRemoveCompte.Click += new System.EventHandler(this.btnRemoveCompte_Click);
            // 
            // btnAddComptes
            // 
            this.btnAddComptes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.btnAddComptes.FlatAppearance.BorderSize = 0;
            this.btnAddComptes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddComptes.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddComptes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddComptes.Image = global::SpotifyBot_vIII.Properties.Resources.Exit;
            this.btnAddComptes.Location = new System.Drawing.Point(116, 29);
            this.btnAddComptes.Name = "btnAddComptes";
            this.btnAddComptes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddComptes.Size = new System.Drawing.Size(70, 38);
            this.btnAddComptes.TabIndex = 13;
            this.btnAddComptes.Text = "Add";
            this.btnAddComptes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddComptes.UseVisualStyleBackColor = false;
            this.btnAddComptes.Click += new System.EventHandler(this.btnAddComptes_Click);
            // 
            // cbRepeat
            // 
            this.cbRepeat.AutoSize = true;
            this.cbRepeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.cbRepeat.Location = new System.Drawing.Point(519, 401);
            this.cbRepeat.Name = "cbRepeat";
            this.cbRepeat.Size = new System.Drawing.Size(62, 19);
            this.cbRepeat.TabIndex = 19;
            this.cbRepeat.Text = "Repeat";
            this.cbRepeat.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1372, 622);
            this.Controls.Add(this.cbRepeat);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panHeader);
            this.Controls.Add(this.panLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.panLeft.ResumeLayout(false);
            this.panLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.panHeader.ResumeLayout(false);
            this.panHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbInterval)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panLeft;
        private Panel panHeader;
        private Button btnExit;
        private PictureBox pbUser;
        private Label labUserTier;
        private Label labUsername;
        private Button btnLaunchSpotify;
        private Button btnConnectOpenvpn;
        private TextBox tbChanson;
        private Label label3;
        private Button btnRechercherChanson;
        private Button btnStopRepeter;
        private Button btnAddChanson;
        private Button btnRemoveChanson;
        private Button btnPlay;
        private ListBox lbChansons;
        private TrackBar tbInterval;
        private Label lbInterval;
        private Label label5;
        private Panel panel1;
        private Button button7;
        private Panel panel2;
        private TextBox tbPassword;
        private Label label7;
        private TextBox tbUsername;
        private Button button8;
        private Label label6;
        private Button btnTest;
        private Panel panel3;
        private ListBox lbComptes;
        private Button button10;
        private Button btnRemoveCompte;
        private Button btnAddComptes;
        private Label label9;
        private Label label8;
        private Label label10;
        private Button btnUpgrade;
        private Label label11;
        private CheckBox cbRepeat;
    }
}