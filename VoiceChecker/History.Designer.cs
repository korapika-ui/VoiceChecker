
namespace VoiceChecker
{
    partial class History
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
            this.listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listbox
            // 
            this.listbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 31;
            this.listbox.Location = new System.Drawing.Point(0, 0);
            this.listbox.Name = "listbox";
            this.listbox.ScrollAlwaysVisible = true;
            this.listbox.Size = new System.Drawing.Size(529, 450);
            this.listbox.TabIndex = 0;
            this.listbox.DoubleClick += new System.EventHandler(this.listbox_DoubleClick);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.Controls.Add(this.listbox);
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listbox;
    }
}