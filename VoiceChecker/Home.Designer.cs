
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnChangeFolder = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.Label();
            this.txtCurrentFolder = new System.Windows.Forms.Label();
            this.btnRepeat = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnTrash = new System.Windows.Forms.Button();
            this.btnGood = new System.Windows.Forms.Button();
            this.btnSus = new System.Windows.Forms.Button();
            this.mainTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnInfo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.btnChangeFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.txtInfo.Location = new System.Drawing.Point(9, 87);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(788, 96);
            this.txtInfo.TabIndex = 20;
            // 
            // txtCurrentFolder
            // 
            this.txtCurrentFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCurrentFolder.Location = new System.Drawing.Point(9, 46);
            this.txtCurrentFolder.Name = "txtCurrentFolder";
            this.txtCurrentFolder.Size = new System.Drawing.Size(788, 24);
            this.txtCurrentFolder.TabIndex = 19;
            // 
            // btnRepeat
            // 
            this.btnRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepeat.Font = new System.Drawing.Font("K24 Kurdish Light Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRepeat.Location = new System.Drawing.Point(13, 6);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(104, 26);
            this.btnRepeat.TabIndex = 18;
            this.btnRepeat.Text = "دووبارەکردنەوە";
            this.btnRepeat.UseVisualStyleBackColor = true;
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Red;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("K24 Kurdish Light Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
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
            this.btnTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrash.Font = new System.Drawing.Font("K24 Kurdish Light Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnTrash.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTrash.Location = new System.Drawing.Point(131, 234);
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
            this.btnGood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGood.Font = new System.Drawing.Font("K24 Kurdish Light Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnGood.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGood.Location = new System.Drawing.Point(507, 234);
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
            this.btnSus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSus.Font = new System.Drawing.Font("K24 Kurdish Light Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSus.Location = new System.Drawing.Point(319, 234);
            this.btnSus.Name = "btnSus";
            this.btnSus.Size = new System.Drawing.Size(182, 50);
            this.btnSus.TabIndex = 14;
            this.btnSus.Text = "جێگای گومانە";
            this.btnSus.UseVisualStyleBackColor = false;
            this.btnSus.Click += new System.EventHandler(this.btnSus_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("K24 Kurdish Light Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnInfo.Location = new System.Drawing.Point(278, 6);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(148, 26);
            this.btnInfo.TabIndex = 22;
            this.btnInfo.Text = "چۆنیەتی بەکارهێنان";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.ResumeLayout(false);

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
    }
}

