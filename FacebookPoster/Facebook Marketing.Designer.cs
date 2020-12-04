namespace FacebookMarketing
{
    partial class frmFacebookMarketing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacebookMarketing));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.tabFunction = new System.Windows.Forms.TabPage();
            this.tabPostNews = new System.Windows.Forms.TabPage();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.tabExpire = new System.Windows.Forms.TabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabHome);
            this.tabControl.Controls.Add(this.tabLogin);
            this.tabControl.Controls.Add(this.tabFunction);
            this.tabControl.Controls.Add(this.tabPostNews);
            this.tabControl.Controls.Add(this.tabProfile);
            this.tabControl.Controls.Add(this.tabExpire);
            this.tabControl.Location = new System.Drawing.Point(11, 35);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 1;
            this.tabControl.Size = new System.Drawing.Size(684, 397);
            this.tabControl.Style = MetroFramework.MetroColorStyle.Blue;
            this.tabControl.TabIndex = 0;
            this.tabControl.UseSelectable = true;
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.Transparent;
            this.tabHome.Location = new System.Drawing.Point(4, 38);
            this.tabHome.Name = "tabHome";
            this.tabHome.Size = new System.Drawing.Size(676, 355);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            // 
            // tabLogin
            // 
            this.tabLogin.Location = new System.Drawing.Point(4, 38);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Size = new System.Drawing.Size(676, 355);
            this.tabLogin.TabIndex = 1;
            this.tabLogin.Text = "Đăng Nhập";
            // 
            // tabFunction
            // 
            this.tabFunction.Location = new System.Drawing.Point(4, 35);
            this.tabFunction.Name = "tabFunction";
            this.tabFunction.Size = new System.Drawing.Size(676, 358);
            this.tabFunction.TabIndex = 2;
            this.tabFunction.Text = "Các Chức Năng";
            // 
            // tabPostNews
            // 
            this.tabPostNews.Location = new System.Drawing.Point(4, 35);
            this.tabPostNews.Name = "tabPostNews";
            this.tabPostNews.Size = new System.Drawing.Size(676, 358);
            this.tabPostNews.TabIndex = 3;
            this.tabPostNews.Text = "Đăng Tin";
            // 
            // tabProfile
            // 
            this.tabProfile.Location = new System.Drawing.Point(4, 35);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Size = new System.Drawing.Size(676, 358);
            this.tabProfile.TabIndex = 4;
            this.tabProfile.Text = "Hồ Sơ";
            // 
            // tabExpire
            // 
            this.tabExpire.Location = new System.Drawing.Point(4, 35);
            this.tabExpire.Name = "tabExpire";
            this.tabExpire.Size = new System.Drawing.Size(676, 358);
            this.tabExpire.TabIndex = 5;
            this.tabExpire.Text = "Gia Hạn";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(15, 7);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(471, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Facebook Marketing - Phần mềm tự động đăng tin facebook";
            // 
            // frmFacebookMarketing
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(706, 455);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tabControl);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFacebookMarketing";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Text = "Facebook Poster";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.frmFacebookPoster_Load);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTabControl tabControl;
        private System.Windows.Forms.TabPage tabHome;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabFunction;
        private System.Windows.Forms.TabPage tabPostNews;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.TabPage tabExpire;
    }
}

