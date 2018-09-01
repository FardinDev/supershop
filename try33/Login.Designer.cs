namespace try33
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.loginpanel = new System.Windows.Forms.Panel();
            this.signinbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PassBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuFlatButton8 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.UserBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // loginpanel
            // 
            this.loginpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(59)))));
            this.loginpanel.Controls.Add(this.signinbutton);
            this.loginpanel.Controls.Add(this.PassBox);
            this.loginpanel.Controls.Add(this.bunifuFlatButton8);
            this.loginpanel.Controls.Add(this.UserBox);
            this.loginpanel.Controls.Add(this.bunifuCustomLabel2);
            this.loginpanel.Controls.Add(this.bunifuCustomLabel1);
            this.loginpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginpanel.Location = new System.Drawing.Point(0, 0);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(485, 272);
            this.loginpanel.TabIndex = 0;
            // 
            // signinbutton
            // 
            this.signinbutton.Activecolor = System.Drawing.Color.SeaGreen;
            this.signinbutton.BackColor = System.Drawing.Color.SeaGreen;
            this.signinbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signinbutton.BorderRadius = 5;
            this.signinbutton.ButtonText = "Sign In";
            this.signinbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signinbutton.DisabledColor = System.Drawing.Color.Gray;
            this.signinbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinbutton.ForeColor = System.Drawing.Color.SeaGreen;
            this.signinbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.signinbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("signinbutton.Iconimage")));
            this.signinbutton.Iconimage_right = null;
            this.signinbutton.Iconimage_right_Selected = null;
            this.signinbutton.Iconimage_Selected = null;
            this.signinbutton.IconMarginLeft = 0;
            this.signinbutton.IconMarginRight = 0;
            this.signinbutton.IconRightVisible = false;
            this.signinbutton.IconRightZoom = 0D;
            this.signinbutton.IconVisible = false;
            this.signinbutton.IconZoom = 90D;
            this.signinbutton.IsTab = true;
            this.signinbutton.Location = new System.Drawing.Point(318, 190);
            this.signinbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signinbutton.Name = "signinbutton";
            this.signinbutton.Normalcolor = System.Drawing.Color.SeaGreen;
            this.signinbutton.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.signinbutton.OnHoverTextColor = System.Drawing.Color.Black;
            this.signinbutton.selected = true;
            this.signinbutton.Size = new System.Drawing.Size(68, 32);
            this.signinbutton.TabIndex = 25;
            this.signinbutton.Text = "Sign In";
            this.signinbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signinbutton.Textcolor = System.Drawing.Color.Black;
            this.signinbutton.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinbutton.Click += new System.EventHandler(this.signinbutton_Click);
            // 
            // PassBox
            // 
            this.PassBox.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.PassBox.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.PassBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.PassBox.BorderThickness = 1;
            this.PassBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PassBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassBox.ForeColor = System.Drawing.Color.SeaGreen;
            this.PassBox.isPassword = true;
            this.PassBox.Location = new System.Drawing.Point(172, 133);
            this.PassBox.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(214, 37);
            this.PassBox.TabIndex = 22;
            this.PassBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuFlatButton8
            // 
            this.bunifuFlatButton8.Activecolor = System.Drawing.Color.Red;
            this.bunifuFlatButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton8.BorderRadius = 6;
            this.bunifuFlatButton8.ButtonText = "Cancel";
            this.bunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton8.Iconimage")));
            this.bunifuFlatButton8.Iconimage_right = null;
            this.bunifuFlatButton8.Iconimage_right_Selected = null;
            this.bunifuFlatButton8.Iconimage_Selected = null;
            this.bunifuFlatButton8.IconMarginLeft = 0;
            this.bunifuFlatButton8.IconMarginRight = 0;
            this.bunifuFlatButton8.IconRightVisible = false;
            this.bunifuFlatButton8.IconRightZoom = 0D;
            this.bunifuFlatButton8.IconVisible = false;
            this.bunifuFlatButton8.IconZoom = 90D;
            this.bunifuFlatButton8.IsTab = true;
            this.bunifuFlatButton8.Location = new System.Drawing.Point(172, 190);
            this.bunifuFlatButton8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bunifuFlatButton8.Name = "bunifuFlatButton8";
            this.bunifuFlatButton8.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton8.OnHovercolor = System.Drawing.Color.Red;
            this.bunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton8.selected = false;
            this.bunifuFlatButton8.Size = new System.Drawing.Size(69, 32);
            this.bunifuFlatButton8.TabIndex = 24;
            this.bunifuFlatButton8.Text = "Cancel";
            this.bunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton8.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuFlatButton8.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton8.Click += new System.EventHandler(this.bunifuFlatButton8_Click);
            // 
            // UserBox
            // 
            this.UserBox.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.UserBox.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.UserBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.UserBox.BorderThickness = 1;
            this.UserBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UserBox.ForeColor = System.Drawing.Color.SeaGreen;
            this.UserBox.isPassword = false;
            this.UserBox.Location = new System.Drawing.Point(172, 84);
            this.UserBox.Margin = new System.Windows.Forms.Padding(4);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(214, 39);
            this.UserBox.TabIndex = 20;
            this.UserBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(64, 141);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(101, 19);
            this.bunifuCustomLabel2.TabIndex = 23;
            this.bunifuCustomLabel2.Text = "PASSWORD :";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(64, 93);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(102, 19);
            this.bunifuCustomLabel1.TabIndex = 21;
            this.bunifuCustomLabel1.Text = "USER NAME :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 43);
            this.panel1.TabIndex = 1;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 272);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.loginpanel.ResumeLayout(false);
            this.loginpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel loginpanel;
        private Bunifu.Framework.UI.BunifuFlatButton signinbutton;
        private Bunifu.Framework.UI.BunifuMetroTextbox PassBox;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton8;
        public Bunifu.Framework.UI.BunifuMetroTextbox UserBox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel1;
    }
}

