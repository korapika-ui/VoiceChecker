
namespace VoiceChecker
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnChangeFolder = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.Label();
            this.txtCurrentFolder = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnTrash = new System.Windows.Forms.Button();
            this.btnGood = new System.Windows.Forms.Button();
            this.btnSus = new System.Windows.Forms.Button();
            this.mainTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnInfo = new System.Windows.Forms.Button();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnSlow = new System.Windows.Forms.Button();
            this.btnFast = new System.Windows.Forms.Button();
            this.btnRepeat = new System.Windows.Forms.Button();
            this.txtSpeed = new System.Windows.Forms.Label();
            this.btnHistory = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Location = new System.Drawing.Point(4, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 144);
            this.panel1.TabIndex = 13;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("K24 Kurdish Light Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtTitle.Location = new System.Drawing.Point(9, 3);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(776, 129);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTitle.Click += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // btnChangeFolder
            // 
            this.btnChangeFolder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnChangeFolder.Font = new System.Drawing.Font("K24 Kurdish Light Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnChangeFolder.Location = new System.Drawing.Point(693, 6);
            this.btnChangeFolder.Name = "btnChangeFolder";
            this.btnChangeFolder.Size = new System.Drawing.Size(104, 26);
            this.btnChangeFolder.TabIndex = 12;
            this.btnChangeFolder.Text = "گۆرینی فۆڵدەر";
            this.btnChangeFolder.UseVisualStyleBackColor = true;
            this.btnChangeFolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpen.Font = new System.Drawing.Font("K24 Kurdish Light Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnOpen.Location = new System.Drawing.Point(693, 48);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(104, 26);
            this.btnOpen.TabIndex = 21;
            this.btnOpen.Text = "بیکەوە";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtInfo.Location = new System.Drawing.Point(4, 92);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(788, 96);
            this.txtInfo.TabIndex = 20;
            // 
            // txtCurrentFolder
            // 
            this.txtCurrentFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCurrentFolder.Location = new System.Drawing.Point(9, 50);
            this.txtCurrentFolder.Name = "txtCurrentFolder";
            this.txtCurrentFolder.Size = new System.Drawing.Size(788, 24);
            this.txtCurrentFolder.TabIndex = 19;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Red;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLoad.Font = new System.Drawing.Font("K24 Kurdish Light Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnLoad.Location = new System.Drawing.Point(578, 6);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(104, 26);
            this.btnLoad.TabIndex = 17;
            this.btnLoad.Text = "دواتر";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnTrash
            // 
            this.btnTrash.BackColor = System.Drawing.Color.Red;
            this.btnTrash.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTrash.Font = new System.Drawing.Font("K24 Kurdish Light Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnTrash.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTrash.Location = new System.Drawing.Point(137, 244);
            this.btnTrash.Name = "btnTrash";
            this.btnTrash.Size = new System.Drawing.Size(182, 50);
            this.btnTrash.TabIndex = 16;
            this.btnTrash.Text = "بەکەڵک ناهێ";
            this.btnTrash.UseVisualStyleBackColor = false;
            this.btnTrash.Click += new System.EventHandler(this.btnTrash_Click);
            // 
            // btnGood
            // 
            this.btnGood.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnGood.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGood.Font = new System.Drawing.Font("K24 Kurdish Light Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnGood.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGood.Location = new System.Drawing.Point(513, 244);
            this.btnGood.Name = "btnGood";
            this.btnGood.Size = new System.Drawing.Size(182, 50);
            this.btnGood.TabIndex = 15;
            this.btnGood.Text = "تەواوە";
            this.btnGood.UseVisualStyleBackColor = false;
            this.btnGood.Click += new System.EventHandler(this.btnGood_Click);
            // 
            // btnSus
            // 
            this.btnSus.BackColor = System.Drawing.Color.Gold;
            this.btnSus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSus.Font = new System.Drawing.Font("K24 Kurdish Light Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSus.Location = new System.Drawing.Point(325, 244);
            this.btnSus.Name = "btnSus";
            this.btnSus.Size = new System.Drawing.Size(182, 50);
            this.btnSus.TabIndex = 14;
            this.btnSus.Text = "جێگای گومانە";
            this.btnSus.UseVisualStyleBackColor = false;
            this.btnSus.Click += new System.EventHandler(this.btnSus_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnInfo.Font = new System.Drawing.Font("K24 Kurdish Light Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnInfo.Location = new System.Drawing.Point(424, 6);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(148, 26);
            this.btnInfo.TabIndex = 22;
            this.btnInfo.Text = "چۆنیەتی بەکارهێنان";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(137, 191);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(558, 47);
            this.mediaPlayer.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("K24 Kurdish Light Light", 14F);
            this.label1.Location = new System.Drawing.Point(12, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "دووبارەکردنەوە";
            // 
            // btnNormal
            // 
            this.btnNormal.BackgroundImage = global::VoiceChecker.Properties.Resources.back;
            this.btnNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNormal.FlatAppearance.BorderSize = 0;
            this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormal.Font = new System.Drawing.Font("K24 Kurdish Light Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNormal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNormal.Location = new System.Drawing.Point(513, 155);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(40, 30);
            this.btnNormal.TabIndex = 27;
            this.btnNormal.Text = "نۆرماڵ";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnSlow_Click);
            // 
            // btnSlow
            // 
            this.btnSlow.BackgroundImage = global::VoiceChecker.Properties.Resources.reset;
            this.btnSlow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSlow.FlatAppearance.BorderSize = 0;
            this.btnSlow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlow.Font = new System.Drawing.Font("K24 Kurdish Light Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSlow.Location = new System.Drawing.Point(588, 155);
            this.btnSlow.Name = "btnSlow";
            this.btnSlow.Size = new System.Drawing.Size(33, 33);
            this.btnSlow.TabIndex = 26;
            this.btnSlow.UseVisualStyleBackColor = true;
            this.btnSlow.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnFast
            // 
            this.btnFast.BackgroundImage = global::VoiceChecker.Properties.Resources.fatforward;
            this.btnFast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFast.FlatAppearance.BorderSize = 0;
            this.btnFast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFast.Font = new System.Drawing.Font("K24 Kurdish Light Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFast.Location = new System.Drawing.Point(655, 155);
            this.btnFast.Name = "btnFast";
            this.btnFast.Size = new System.Drawing.Size(40, 30);
            this.btnFast.TabIndex = 25;
            this.btnFast.UseVisualStyleBackColor = true;
            this.btnFast.Click += new System.EventHandler(this.btnFast_Click);
            // 
            // btnRepeat
            // 
            this.btnRepeat.BackColor = System.Drawing.Color.Transparent;
            this.btnRepeat.BackgroundImage = global::VoiceChecker.Properties.Resources.replay_icon;
            this.btnRepeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRepeat.FlatAppearance.BorderSize = 0;
            this.btnRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepeat.Font = new System.Drawing.Font("K24 Kurdish Light Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRepeat.ForeColor = System.Drawing.Color.Black;
            this.btnRepeat.Location = new System.Drawing.Point(44, 198);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(40, 40);
            this.btnRepeat.TabIndex = 18;
            this.btnRepeat.UseVisualStyleBackColor = false;
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
            // 
            // txtSpeed
            // 
            this.txtSpeed.AutoSize = true;
            this.txtSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSpeed.Location = new System.Drawing.Point(719, 154);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(52, 31);
            this.txtSpeed.TabIndex = 28;
            this.txtSpeed.Text = "1.0";
            // 
            // btnHistory
            // 
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHistory.Font = new System.Drawing.Font("K24 Kurdish Light Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnHistory.Location = new System.Drawing.Point(702, 256);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(95, 30);
            this.btnHistory.TabIndex = 29;
            this.btnHistory.Text = "هیستۆری";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnSlow);
            this.Controls.Add(this.btnFast);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnChangeFolder);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtCurrentFolder);
            this.Controls.Add(this.btnRepeat);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnTrash);
            this.Controls.Add(this.btnGood);
            this.Controls.Add(this.btnSus);
            this.Controls.Add(this.btnInfo);
            this.Name = "Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnChangeFolder;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label txtInfo;
        private System.Windows.Forms.Label txtCurrentFolder;
        private System.Windows.Forms.Button btnRepeat;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnTrash;
        private System.Windows.Forms.Button btnGood;
        private System.Windows.Forms.Button btnSus;
        private System.Windows.Forms.ToolTip mainTip;
        private System.Windows.Forms.Button btnInfo;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFast;
        private System.Windows.Forms.Button btnSlow;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Label txtSpeed;
        private System.Windows.Forms.Button btnHistory;
    }
}

