namespace Bibliothéque.Views
{
    partial class Form_MAin_Stagiaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MAin_Stagiaire));
            this.lblnomstagiaire = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.mini1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.mini2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.close = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlmove = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pcbximgadmin = new System.Windows.Forms.PictureBox();
            this.max = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuFlatButton8 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlleft = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pnldate = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbldate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlmain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mini1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mini2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.pnlmove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbximgadmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.pnlleft.SuspendLayout();
            this.pnldate.SuspendLayout();
            this.pnlmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnomstagiaire
            // 
            this.lblnomstagiaire.AutoSize = true;
            this.lblnomstagiaire.BackColor = System.Drawing.Color.Transparent;
            this.lblnomstagiaire.Font = new System.Drawing.Font("Engravers MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomstagiaire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.lblnomstagiaire.Location = new System.Drawing.Point(71, 10);
            this.lblnomstagiaire.Name = "lblnomstagiaire";
            this.lblnomstagiaire.Size = new System.Drawing.Size(247, 25);
            this.lblnomstagiaire.TabIndex = 16;
            this.lblnomstagiaire.Text = "Nom Stagiaire";
            // 
            // mini1
            // 
            this.mini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mini1.BackColor = System.Drawing.Color.Transparent;
            this.mini1.Image = global::Bibliothéque.Properties.Resources.minimize;
            this.mini1.ImageActive = null;
            this.mini1.Location = new System.Drawing.Point(1056, 6);
            this.mini1.Name = "mini1";
            this.mini1.Size = new System.Drawing.Size(25, 25);
            this.mini1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mini1.TabIndex = 0;
            this.mini1.TabStop = false;
            this.mini1.Zoom = 10;
            this.mini1.Click += new System.EventHandler(this.mini1_Click);
            // 
            // mini2
            // 
            this.mini2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mini2.BackColor = System.Drawing.Color.Transparent;
            this.mini2.Image = global::Bibliothéque.Properties.Resources.minimize__1_;
            this.mini2.ImageActive = null;
            this.mini2.Location = new System.Drawing.Point(1087, 6);
            this.mini2.Name = "mini2";
            this.mini2.Size = new System.Drawing.Size(25, 25);
            this.mini2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mini2.TabIndex = 0;
            this.mini2.TabStop = false;
            this.mini2.Visible = false;
            this.mini2.Zoom = 10;
            this.mini2.Click += new System.EventHandler(this.mini2_Click);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Image = global::Bibliothéque.Properties.Resources.close__1_;
            this.close.ImageActive = null;
            this.close.Location = new System.Drawing.Point(1118, 6);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(25, 25);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 0;
            this.close.TabStop = false;
            this.close.Zoom = 10;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // pnlmove
            // 
            this.pnlmove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.pnlmove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlmove.BackgroundImage")));
            this.pnlmove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlmove.Controls.Add(this.lblnomstagiaire);
            this.pnlmove.Controls.Add(this.pcbximgadmin);
            this.pnlmove.Controls.Add(this.mini1);
            this.pnlmove.Controls.Add(this.mini2);
            this.pnlmove.Controls.Add(this.max);
            this.pnlmove.Controls.Add(this.close);
            this.pnlmove.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlmove.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.pnlmove.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.pnlmove.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.pnlmove.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.pnlmove.Location = new System.Drawing.Point(56, 0);
            this.pnlmove.Name = "pnlmove";
            this.pnlmove.Quality = 10;
            this.pnlmove.Size = new System.Drawing.Size(1152, 44);
            this.pnlmove.TabIndex = 6;
            this.pnlmove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlmove_MouseDown);
            this.pnlmove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlmove_MouseMove);
            this.pnlmove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlmove_MouseUp);
            // 
            // pcbximgadmin
            // 
            this.pcbximgadmin.BackColor = System.Drawing.Color.Transparent;
            this.pcbximgadmin.Image = global::Bibliothéque.Properties.Resources.user__1_;
            this.pcbximgadmin.Location = new System.Drawing.Point(3, 1);
            this.pcbximgadmin.Name = "pcbximgadmin";
            this.pcbximgadmin.Size = new System.Drawing.Size(62, 45);
            this.pcbximgadmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbximgadmin.TabIndex = 1;
            this.pcbximgadmin.TabStop = false;
            this.pcbximgadmin.Click += new System.EventHandler(this.pcbximgadmin_Click);
            // 
            // max
            // 
            this.max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.max.BackColor = System.Drawing.Color.Transparent;
            this.max.Image = global::Bibliothéque.Properties.Resources.resize;
            this.max.ImageActive = null;
            this.max.Location = new System.Drawing.Point(1087, 6);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(25, 25);
            this.max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.max.TabIndex = 0;
            this.max.TabStop = false;
            this.max.Zoom = 10;
            this.max.Click += new System.EventHandler(this.max_Click);
            // 
            // bunifuFlatButton8
            // 
            this.bunifuFlatButton8.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton8.BorderRadius = 0;
            this.bunifuFlatButton8.ButtonText = "Change Password";
            this.bunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.bunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.Iconimage = global::Bibliothéque.Properties.Resources.padlock__3_;
            this.bunifuFlatButton8.Iconimage_right = null;
            this.bunifuFlatButton8.Iconimage_right_Selected = null;
            this.bunifuFlatButton8.Iconimage_Selected = null;
            this.bunifuFlatButton8.IconMarginLeft = 0;
            this.bunifuFlatButton8.IconMarginRight = 0;
            this.bunifuFlatButton8.IconRightVisible = true;
            this.bunifuFlatButton8.IconRightZoom = 0D;
            this.bunifuFlatButton8.IconVisible = true;
            this.bunifuFlatButton8.IconZoom = 90D;
            this.bunifuFlatButton8.IsTab = false;
            this.bunifuFlatButton8.Location = new System.Drawing.Point(0, 301);
            this.bunifuFlatButton8.Name = "bunifuFlatButton8";
            this.bunifuFlatButton8.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.OnHovercolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.bunifuFlatButton8.selected = false;
            this.bunifuFlatButton8.Size = new System.Drawing.Size(53, 48);
            this.bunifuFlatButton8.TabIndex = 5;
            this.bunifuFlatButton8.Text = "Change Password";
            this.bunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton8.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.bunifuFlatButton8.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton8.Click += new System.EventHandler(this.bunifuFlatButton8_Click);
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "Reservation Books";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = global::Bibliothéque.Properties.Resources.library;
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 90D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(3, 247);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(53, 48);
            this.bunifuFlatButton6.TabIndex = 5;
            this.bunifuFlatButton6.Text = "Reservation Books";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton6.Click += new System.EventHandler(this.bunifuFlatButton6_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::Bibliothéque.Properties.Resources.home__1_;
            this.bunifuImageButton1.ImageActive = global::Bibliothéque.Properties.Resources.home__2_;
            this.bunifuImageButton1.Location = new System.Drawing.Point(12, 564);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = global::Bibliothéque.Properties.Resources.list;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(4, 4);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(47, 36);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 0;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            this.bunifuImageButton2.MouseHover += new System.EventHandler(this.bunifuImageButton2_MouseHover);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 90;
            this.bunifuElipse2.TargetControl = this.pcbximgadmin;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlleft
            // 
            this.pnlleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.pnlleft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlleft.BackgroundImage")));
            this.pnlleft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlleft.Controls.Add(this.bunifuFlatButton8);
            this.pnlleft.Controls.Add(this.bunifuFlatButton6);
            this.pnlleft.Controls.Add(this.bunifuImageButton1);
            this.pnlleft.Controls.Add(this.bunifuImageButton2);
            this.pnlleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlleft.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.pnlleft.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.pnlleft.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.pnlleft.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.pnlleft.Location = new System.Drawing.Point(0, 0);
            this.pnlleft.Name = "pnlleft";
            this.pnlleft.Quality = 10;
            this.pnlleft.Size = new System.Drawing.Size(56, 597);
            this.pnlleft.TabIndex = 7;
            // 
            // pnldate
            // 
            this.pnldate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.pnldate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnldate.BackgroundImage")));
            this.pnldate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnldate.Controls.Add(this.lbldate);
            this.pnldate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnldate.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.pnldate.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.pnldate.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.pnldate.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.pnldate.Location = new System.Drawing.Point(56, 553);
            this.pnldate.Name = "pnldate";
            this.pnldate.Quality = 10;
            this.pnldate.Size = new System.Drawing.Size(1152, 44);
            this.pnldate.TabIndex = 20;
            // 
            // lbldate
            // 
            this.lbldate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.Transparent;
            this.lbldate.Font = new System.Drawing.Font("Engravers MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(47)))), ((int)(((byte)(2)))));
            this.lbldate.Location = new System.Drawing.Point(792, 11);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(136, 17);
            this.lbldate.TabIndex = 16;
            this.lbldate.Text = "Nom Admin";
            // 
            // pnlmain
            // 
            this.pnlmain.BackColor = System.Drawing.Color.White;
            this.pnlmain.Controls.Add(this.pictureBox1);
            this.pnlmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlmain.Location = new System.Drawing.Point(56, 44);
            this.pnlmain.Name = "pnlmain";
            this.pnlmain.Size = new System.Drawing.Size(1152, 509);
            this.pnlmain.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Bibliothéque.Properties.Resources.book__1_;
            this.pictureBox1.Location = new System.Drawing.Point(356, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form_MAin_Stagiaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 597);
            this.Controls.Add(this.pnlmain);
            this.Controls.Add(this.pnldate);
            this.Controls.Add(this.pnlmove);
            this.Controls.Add(this.pnlleft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form_MAin_Stagiaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_MAin_Stagiaire";
            this.Load += new System.EventHandler(this.Form_MAin_Stagiaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mini1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mini2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.pnlmove.ResumeLayout(false);
            this.pnlmove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbximgadmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.pnlleft.ResumeLayout(false);
            this.pnldate.ResumeLayout(false);
            this.pnldate.PerformLayout();
            this.pnlmain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblnomstagiaire;
        private Bunifu.Framework.UI.BunifuImageButton mini1;
        private Bunifu.Framework.UI.BunifuImageButton mini2;
        private Bunifu.Framework.UI.BunifuImageButton close;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlmove;
        private System.Windows.Forms.PictureBox pcbximgadmin;
        private Bunifu.Framework.UI.BunifuImageButton max;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton8;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlleft;
        private Bunifu.Framework.UI.BunifuGradientPanel pnldate;
        private Bunifu.Framework.UI.BunifuCustomLabel lbldate;
        private System.Windows.Forms.Panel pnlmain;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}