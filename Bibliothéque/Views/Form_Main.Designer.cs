namespace Bibliothéque.Views
{
    partial class Form_Main
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.elipsebtnemail = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtemail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.elipsebtnpassword = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtpassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.elipseform_main = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlmove = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Show = new System.Windows.Forms.PictureBox();
            this.notShow = new System.Windows.Forms.PictureBox();
            this.pcbxpassword = new System.Windows.Forms.PictureBox();
            this.pcbxemail = new System.Windows.Forms.PictureBox();
            this.lblclose = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bntlogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlmove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxpassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxemail)).BeginInit();
            this.SuspendLayout();
            // 
            // elipsebtnemail
            // 
            this.elipsebtnemail.ElipseRadius = 20;
            this.elipsebtnemail.TargetControl = this.txtemail;
            // 
            // txtemail
            // 
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.txtemail, BunifuAnimatorNS.DecorationType.None);
            this.txtemail.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(47)))), ((int)(((byte)(2)))));
            this.txtemail.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(47)))), ((int)(((byte)(2)))));
            this.txtemail.HintText = "";
            this.txtemail.isPassword = false;
            this.txtemail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.txtemail.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            this.txtemail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.txtemail.LineThickness = 5;
            this.txtemail.Location = new System.Drawing.Point(441, 78);
            this.txtemail.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(378, 67);
            this.txtemail.TabIndex = 0;
            this.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // elipsebtnpassword
            // 
            this.elipsebtnpassword.ElipseRadius = 20;
            this.elipsebtnpassword.TargetControl = this.txtpassword;
            // 
            // txtpassword
            // 
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.txtpassword, BunifuAnimatorNS.DecorationType.None);
            this.txtpassword.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(47)))), ((int)(((byte)(2)))));
            this.txtpassword.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(47)))), ((int)(((byte)(2)))));
            this.txtpassword.HintText = "";
            this.txtpassword.isPassword = true;
            this.txtpassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.txtpassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            this.txtpassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.txtpassword.LineThickness = 5;
            this.txtpassword.Location = new System.Drawing.Point(441, 198);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(378, 58);
            this.txtpassword.TabIndex = 1;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtpassword.OnValueChanged += new System.EventHandler(this.txtpassword_OnValueChanged);
            // 
            // elipseform_main
            // 
            this.elipseform_main.ElipseRadius = 20;
            this.elipseform_main.TargetControl = this;
            // 
            // pnlmove
            // 
            this.pnlmove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlmove.BackgroundImage")));
            this.pnlmove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlmove.Controls.Add(this.bunifuCustomLabel3);
            this.pnlmove.Controls.Add(this.bunifuCustomLabel2);
            this.pnlmove.Controls.Add(this.pictureBox1);
            this.pnlmove.Controls.Add(this.Show);
            this.pnlmove.Controls.Add(this.notShow);
            this.pnlmove.Controls.Add(this.pcbxpassword);
            this.pnlmove.Controls.Add(this.pcbxemail);
            this.pnlmove.Controls.Add(this.lblclose);
            this.pnlmove.Controls.Add(this.txtpassword);
            this.pnlmove.Controls.Add(this.txtemail);
            this.pnlmove.Controls.Add(this.bntlogin);
            this.bunifuTransition1.SetDecoration(this.pnlmove, BunifuAnimatorNS.DecorationType.None);
            this.pnlmove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlmove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(47)))), ((int)(((byte)(2)))));
            this.pnlmove.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlmove.GradientBottomRight = System.Drawing.Color.White;
            this.pnlmove.GradientTopLeft = System.Drawing.Color.White;
            this.pnlmove.GradientTopRight = System.Drawing.Color.White;
            this.pnlmove.Location = new System.Drawing.Point(0, 0);
            this.pnlmove.Name = "pnlmove";
            this.pnlmove.Quality = 10;
            this.pnlmove.Size = new System.Drawing.Size(883, 444);
            this.pnlmove.TabIndex = 0;
            this.pnlmove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlmove_MouseDown);
            this.pnlmove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlmove_MouseMove);
            this.pnlmove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlmove_MouseUp);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Engravers MT", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(380, 169);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(182, 22);
            this.bunifuCustomLabel3.TabIndex = 17;
            this.bunifuCustomLabel3.Text = "Password : ";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Engravers MT", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(380, 49);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(118, 22);
            this.bunifuCustomLabel2.TabIndex = 16;
            this.bunifuCustomLabel2.Text = "Email : ";
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Bibliothéque.Properties.Resources.a_book_g44ef89e3d_640;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 444);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Show
            // 
            this.bunifuTransition1.SetDecoration(this.Show, BunifuAnimatorNS.DecorationType.None);
            this.Show.Image = global::Bibliothéque.Properties.Resources.padlock__2_;
            this.Show.Location = new System.Drawing.Point(821, 203);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(47, 42);
            this.Show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Show.TabIndex = 10;
            this.Show.TabStop = false;
            this.Show.Visible = false;
            this.Show.Click += new System.EventHandler(this.notshow_Click);
            // 
            // notShow
            // 
            this.bunifuTransition1.SetDecoration(this.notShow, BunifuAnimatorNS.DecorationType.None);
            this.notShow.Image = global::Bibliothéque.Properties.Resources.padlock__1_;
            this.notShow.Location = new System.Drawing.Point(821, 203);
            this.notShow.Name = "notShow";
            this.notShow.Size = new System.Drawing.Size(47, 42);
            this.notShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.notShow.TabIndex = 10;
            this.notShow.TabStop = false;
            this.notShow.Visible = false;
            this.notShow.Click += new System.EventHandler(this.Show_Click);
            // 
            // pcbxpassword
            // 
            this.bunifuTransition1.SetDecoration(this.pcbxpassword, BunifuAnimatorNS.DecorationType.None);
            this.pcbxpassword.Image = global::Bibliothéque.Properties.Resources.padlock;
            this.pcbxpassword.Location = new System.Drawing.Point(380, 198);
            this.pcbxpassword.Name = "pcbxpassword";
            this.pcbxpassword.Size = new System.Drawing.Size(52, 50);
            this.pcbxpassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxpassword.TabIndex = 9;
            this.pcbxpassword.TabStop = false;
            // 
            // pcbxemail
            // 
            this.bunifuTransition1.SetDecoration(this.pcbxemail, BunifuAnimatorNS.DecorationType.None);
            this.pcbxemail.Image = global::Bibliothéque.Properties.Resources.email;
            this.pcbxemail.Location = new System.Drawing.Point(380, 78);
            this.pcbxemail.Name = "pcbxemail";
            this.pcbxemail.Size = new System.Drawing.Size(52, 50);
            this.pcbxemail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxemail.TabIndex = 9;
            this.pcbxemail.TabStop = false;
            // 
            // lblclose
            // 
            this.lblclose.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblclose, BunifuAnimatorNS.DecorationType.None);
            this.lblclose.Font = new System.Drawing.Font("Engravers MT", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblclose.ForeColor = System.Drawing.Color.Red;
            this.lblclose.Location = new System.Drawing.Point(578, 371);
            this.lblclose.Name = "lblclose";
            this.lblclose.Size = new System.Drawing.Size(76, 22);
            this.lblclose.TabIndex = 3;
            this.lblclose.Text = "Exit";
            this.lblclose.Click += new System.EventHandler(this.lblclose_Click);
            // 
            // bntlogin
            // 
            this.bntlogin.ActiveBorderThickness = 1;
            this.bntlogin.ActiveCornerRadius = 20;
            this.bntlogin.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            this.bntlogin.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bntlogin.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.bntlogin.BackColor = System.Drawing.Color.White;
            this.bntlogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntlogin.BackgroundImage")));
            this.bntlogin.ButtonText = "LOG IN";
            this.bntlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bntlogin, BunifuAnimatorNS.DecorationType.None);
            this.bntlogin.Font = new System.Drawing.Font("Engravers MT", 14.25F, System.Drawing.FontStyle.Bold);
            this.bntlogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(47)))), ((int)(((byte)(2)))));
            this.bntlogin.IdleBorderThickness = 1;
            this.bntlogin.IdleCornerRadius = 20;
            this.bntlogin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.bntlogin.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(47)))), ((int)(((byte)(2)))));
            this.bntlogin.IdleLineColor = System.Drawing.Color.Honeydew;
            this.bntlogin.Location = new System.Drawing.Point(397, 266);
            this.bntlogin.Margin = new System.Windows.Forms.Padding(5);
            this.bntlogin.Name = "bntlogin";
            this.bntlogin.Size = new System.Drawing.Size(422, 72);
            this.bntlogin.TabIndex = 2;
            this.bntlogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bntlogin.Click += new System.EventHandler(this.bntlogin_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0.5F;
            animation1.RotateLimit = 0.2F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.MaxAnimationTime = 100;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(883, 444);
            this.Controls.Add(this.pnlmove);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(99)))), ((int)(((byte)(203)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOG IN ";
            this.pnlmove.ResumeLayout(false);
            this.pnlmove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxpassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxemail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse elipsebtnemail;
        private Bunifu.Framework.UI.BunifuElipse elipsebtnpassword;
        private Bunifu.Framework.UI.BunifuElipse elipseform_main;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlmove;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtpassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtemail;
        private Bunifu.Framework.UI.BunifuThinButton2 bntlogin;
        private Bunifu.Framework.UI.BunifuCustomLabel lblclose;
        private System.Windows.Forms.PictureBox pcbxpassword;
        private System.Windows.Forms.PictureBox pcbxemail;
        private System.Windows.Forms.PictureBox notShow;
        private System.Windows.Forms.PictureBox Show;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
    }
}