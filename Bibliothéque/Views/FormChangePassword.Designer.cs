namespace Bibliothéque.Views
{
    partial class FormChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangePassword));
            this.checkBox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblshow = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtConfirmPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtNewPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCurrentPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcbxpassword = new System.Windows.Forms.PictureBox();
            this.btbchange = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxpassword)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkBox1.Checked = false;
            this.checkBox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(54, 363);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(20, 20);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.OnChange += new System.EventHandler(this.checkBox1_OnChange);
            // 
            // lblshow
            // 
            this.lblshow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblshow.AutoSize = true;
            this.lblshow.Font = new System.Drawing.Font("Engravers MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.lblshow.Location = new System.Drawing.Point(80, 365);
            this.lblshow.Name = "lblshow";
            this.lblshow.Size = new System.Drawing.Size(203, 17);
            this.lblshow.TabIndex = 26;
            this.lblshow.Text = "Show Password ";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Engravers MT", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(50, 255);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(315, 22);
            this.bunifuCustomLabel4.TabIndex = 27;
            this.bunifuCustomLabel4.Text = "Confirm Password : ";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(47)))), ((int)(((byte)(2)))));
            this.txtConfirmPassword.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(47)))), ((int)(((byte)(2)))));
            this.txtConfirmPassword.HintText = "";
            this.txtConfirmPassword.isPassword = true;
            this.txtConfirmPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.txtConfirmPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            this.txtConfirmPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.txtConfirmPassword.LineThickness = 5;
            this.txtConfirmPassword.Location = new System.Drawing.Point(127, 284);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(329, 58);
            this.txtConfirmPassword.TabIndex = 2;
            this.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtConfirmPassword.OnValueChanged += new System.EventHandler(this.txtConfirmPassword_OnValueChanged);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Engravers MT", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(50, 151);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(182, 22);
            this.bunifuCustomLabel3.TabIndex = 24;
            this.bunifuCustomLabel3.Text = "Password : ";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(47)))), ((int)(((byte)(2)))));
            this.txtNewPassword.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(47)))), ((int)(((byte)(2)))));
            this.txtNewPassword.HintText = "";
            this.txtNewPassword.isPassword = true;
            this.txtNewPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.txtNewPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            this.txtNewPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.txtNewPassword.LineThickness = 5;
            this.txtNewPassword.Location = new System.Drawing.Point(127, 180);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(329, 58);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNewPassword.OnValueChanged += new System.EventHandler(this.txtPassword_OnValueChanged);
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCurrentPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrentPassword.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(47)))), ((int)(((byte)(2)))));
            this.txtCurrentPassword.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(47)))), ((int)(((byte)(2)))));
            this.txtCurrentPassword.HintText = "";
            this.txtCurrentPassword.isPassword = true;
            this.txtCurrentPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.txtCurrentPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            this.txtCurrentPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.txtCurrentPassword.LineThickness = 5;
            this.txtCurrentPassword.Location = new System.Drawing.Point(127, 77);
            this.txtCurrentPassword.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(329, 58);
            this.txtCurrentPassword.TabIndex = 0;
            this.txtCurrentPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCurrentPassword.OnValueChanged += new System.EventHandler(this.txtcurrentpassword_OnValueChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Engravers MT", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(50, 48);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(314, 22);
            this.bunifuCustomLabel1.TabIndex = 24;
            this.bunifuCustomLabel1.Text = "Current Password :";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Image = global::Bibliothéque.Properties.Resources.add__1_;
            this.pictureBox4.Location = new System.Drawing.Point(54, 284);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Bibliothéque.Properties.Resources.padlock;
            this.pictureBox1.Location = new System.Drawing.Point(54, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pcbxpassword
            // 
            this.pcbxpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbxpassword.Image = global::Bibliothéque.Properties.Resources.add;
            this.pcbxpassword.Location = new System.Drawing.Point(54, 180);
            this.pcbxpassword.Name = "pcbxpassword";
            this.pcbxpassword.Size = new System.Drawing.Size(52, 50);
            this.pcbxpassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxpassword.TabIndex = 23;
            this.pcbxpassword.TabStop = false;
            // 
            // btbchange
            // 
            this.btbchange.ActiveBorderThickness = 1;
            this.btbchange.ActiveCornerRadius = 20;
            this.btbchange.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            this.btbchange.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btbchange.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.btbchange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btbchange.BackColor = System.Drawing.SystemColors.Control;
            this.btbchange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btbchange.BackgroundImage")));
            this.btbchange.ButtonText = "Change";
            this.btbchange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbchange.Font = new System.Drawing.Font("Engravers MT", 14.25F, System.Drawing.FontStyle.Bold);
            this.btbchange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(47)))), ((int)(((byte)(2)))));
            this.btbchange.IdleBorderThickness = 1;
            this.btbchange.IdleCornerRadius = 20;
            this.btbchange.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.btbchange.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(47)))), ((int)(((byte)(2)))));
            this.btbchange.IdleLineColor = System.Drawing.Color.Honeydew;
            this.btbchange.Location = new System.Drawing.Point(54, 405);
            this.btbchange.Margin = new System.Windows.Forms.Padding(5);
            this.btbchange.Name = "btbchange";
            this.btbchange.Size = new System.Drawing.Size(402, 57);
            this.btbchange.TabIndex = 3;
            this.btbchange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btbchange.Click += new System.EventHandler(this.btnsingup_Click);
            // 
            // FormChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 518);
            this.ControlBox = false;
            this.Controls.Add(this.btbchange);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblshow);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pcbxpassword);
            this.Controls.Add(this.txtNewPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChangePassword";
            this.Text = "FormChangePassword";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxpassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCheckbox checkBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblshow;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtConfirmPassword;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.PictureBox pcbxpassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNewPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCurrentPassword;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btbchange;
    }
}