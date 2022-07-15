namespace Bibliothéque.Views.Views_Manages
{
    partial class FormSecteurs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSecteurs));
            this.dtgvSecteurs = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.cntmsecteurs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtnomsecteur = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bindingNVGSecteurs = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnadd = new System.Windows.Forms.ToolStripButton();
            this.btnupdate = new System.Windows.Forms.ToolStripButton();
            this.btndelete = new System.Windows.Forms.ToolStripButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSecteurs)).BeginInit();
            this.cntmsecteurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNVGSecteurs)).BeginInit();
            this.bindingNVGSecteurs.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvSecteurs
            // 
            this.dtgvSecteurs.AllowUserToAddRows = false;
            this.dtgvSecteurs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            this.dtgvSecteurs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvSecteurs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtgvSecteurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSecteurs.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgvSecteurs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvSecteurs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvSecteurs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvSecteurs.ColumnHeadersHeight = 40;
            this.dtgvSecteurs.ContextMenuStrip = this.cntmsecteurs;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(47)))), ((int)(((byte)(2)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvSecteurs.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvSecteurs.DoubleBuffered = true;
            this.dtgvSecteurs.EnableHeadersVisualStyles = false;
            this.dtgvSecteurs.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.dtgvSecteurs.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtgvSecteurs.Location = new System.Drawing.Point(0, 53);
            this.dtgvSecteurs.MultiSelect = false;
            this.dtgvSecteurs.Name = "dtgvSecteurs";
            this.dtgvSecteurs.ReadOnly = true;
            this.dtgvSecteurs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvSecteurs.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.dtgvSecteurs.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvSecteurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvSecteurs.Size = new System.Drawing.Size(942, 491);
            this.dtgvSecteurs.TabIndex = 0;
            this.dtgvSecteurs.SelectionChanged += new System.EventHandler(this.dtgvSecteurs_SelectionChanged);
            // 
            // cntmsecteurs
            // 
            this.cntmsecteurs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
            this.cntmsecteurs.Name = "cntmsecteurs";
            this.cntmsecteurs.Size = new System.Drawing.Size(113, 26);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.updateToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(47)))), ((int)(((byte)(2)))));
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtnomsecteur
            // 
            this.txtnomsecteur.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtnomsecteur.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.txtnomsecteur.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            this.txtnomsecteur.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.txtnomsecteur.BorderThickness = 3;
            this.txtnomsecteur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnomsecteur.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtnomsecteur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtnomsecteur.isPassword = false;
            this.txtnomsecteur.Location = new System.Drawing.Point(605, 12);
            this.txtnomsecteur.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtnomsecteur.Name = "txtnomsecteur";
            this.txtnomsecteur.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.txtnomsecteur.Size = new System.Drawing.Size(325, 32);
            this.txtnomsecteur.TabIndex = 1;
            this.txtnomsecteur.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bindingNVGSecteurs
            // 
            this.bindingNVGSecteurs.AddNewItem = null;
            this.bindingNVGSecteurs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bindingNVGSecteurs.BackColor = System.Drawing.Color.Transparent;
            this.bindingNVGSecteurs.CountItem = this.bindingNavigatorCountItem;
            this.bindingNVGSecteurs.DeleteItem = null;
            this.bindingNVGSecteurs.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNVGSecteurs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnadd,
            this.btnupdate,
            this.btndelete});
            this.bindingNVGSecteurs.Location = new System.Drawing.Point(9, 12);
            this.bindingNVGSecteurs.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNVGSecteurs.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNVGSecteurs.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNVGSecteurs.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNVGSecteurs.Name = "bindingNVGSecteurs";
            this.bindingNVGSecteurs.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNVGSecteurs.Size = new System.Drawing.Size(278, 25);
            this.bindingNVGSecteurs.TabIndex = 21;
            this.bindingNVGSecteurs.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnadd
            // 
            this.btnadd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnadd.Image = global::Bibliothéque.Properties.Resources.add__2_;
            this.btnadd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(23, 22);
            this.btnadd.Text = "Add Secteur";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnupdate.Enabled = false;
            this.btnupdate.Image = global::Bibliothéque.Properties.Resources.refresh;
            this.btnupdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(23, 22);
            this.btnupdate.Text = "Update Secteur";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btndelete.Image = global::Bibliothéque.Properties.Resources.trash;
            this.btndelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(23, 22);
            this.btndelete.Text = "Delete Secteur";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(407, 18);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(199, 19);
            this.bunifuCustomLabel1.TabIndex = 32;
            this.bunifuCustomLabel1.Text = "Nom Secteure :";
            // 
            // FormSecteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(942, 544);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bindingNVGSecteurs);
            this.Controls.Add(this.txtnomsecteur);
            this.Controls.Add(this.dtgvSecteurs);
            this.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(47)))), ((int)(((byte)(2)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FormSecteurs";
            this.Text = "FormSecteurs";
            this.Load += new System.EventHandler(this.FormSecteurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSecteurs)).EndInit();
            this.cntmsecteurs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNVGSecteurs)).EndInit();
            this.bindingNVGSecteurs.ResumeLayout(false);
            this.bindingNVGSecteurs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgvSecteurs;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtnomsecteur;
        private System.Windows.Forms.BindingNavigator bindingNVGSecteurs;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnadd;
        private System.Windows.Forms.ToolStripButton btnupdate;
        private System.Windows.Forms.ToolStripButton btndelete;
        private System.Windows.Forms.ContextMenuStrip cntmsecteurs;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}