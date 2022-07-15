namespace Bibliothéque.Views.Views_Manages
{
    partial class Form_Filieur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Filieur));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btndelete = new System.Windows.Forms.ToolStripButton();
            this.btnadd = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNVGFiliers = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnupdate = new System.Windows.Forms.ToolStripButton();
            this.txtnomFilière = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cntmsecteurs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dtgvFilieurs = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.cmbsecteurs = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNVGFiliers)).BeginInit();
            this.bindingNVGFiliers.SuspendLayout();
            this.cntmsecteurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFilieurs)).BeginInit();
            this.SuspendLayout();
            // 
            // btndelete
            // 
            this.btndelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btndelete.Image = global::Bibliothéque.Properties.Resources.trash;
            this.btndelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(23, 22);
            this.btndelete.Text = "Delete Filière";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnadd.Image = global::Bibliothéque.Properties.Resources.add__2_;
            this.btnadd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(23, 22);
            this.btnadd.Text = "Add Filière";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
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
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNVGFiliers
            // 
            this.bindingNVGFiliers.AddNewItem = null;
            this.bindingNVGFiliers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bindingNVGFiliers.BackColor = System.Drawing.Color.Transparent;
            this.bindingNVGFiliers.CountItem = this.bindingNavigatorCountItem;
            this.bindingNVGFiliers.DeleteItem = null;
            this.bindingNVGFiliers.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNVGFiliers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNVGFiliers.Location = new System.Drawing.Point(9, 23);
            this.bindingNVGFiliers.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNVGFiliers.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNVGFiliers.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNVGFiliers.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNVGFiliers.Name = "bindingNVGFiliers";
            this.bindingNVGFiliers.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNVGFiliers.Size = new System.Drawing.Size(278, 25);
            this.bindingNVGFiliers.TabIndex = 24;
            this.bindingNVGFiliers.Text = "bindingNavigator1";
            // 
            // btnupdate
            // 
            this.btnupdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnupdate.Enabled = false;
            this.btnupdate.Image = global::Bibliothéque.Properties.Resources.refresh;
            this.btnupdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(23, 22);
            this.btnupdate.Text = "Update Filière";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtnomFilière
            // 
            this.txtnomFilière.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtnomFilière.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.txtnomFilière.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            this.txtnomFilière.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.txtnomFilière.BorderThickness = 3;
            this.txtnomFilière.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnomFilière.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtnomFilière.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtnomFilière.isPassword = false;
            this.txtnomFilière.Location = new System.Drawing.Point(454, 16);
            this.txtnomFilière.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtnomFilière.Name = "txtnomFilière";
            this.txtnomFilière.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.txtnomFilière.Size = new System.Drawing.Size(237, 32);
            this.txtnomFilière.TabIndex = 23;
            this.txtnomFilière.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
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
            // cntmsecteurs
            // 
            this.cntmsecteurs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
            this.cntmsecteurs.Name = "cntmsecteurs";
            this.cntmsecteurs.Size = new System.Drawing.Size(113, 26);
            // 
            // dtgvFilieurs
            // 
            this.dtgvFilieurs.AllowUserToAddRows = false;
            this.dtgvFilieurs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            this.dtgvFilieurs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvFilieurs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtgvFilieurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvFilieurs.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgvFilieurs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvFilieurs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvFilieurs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvFilieurs.ColumnHeadersHeight = 40;
            this.dtgvFilieurs.ContextMenuStrip = this.cntmsecteurs;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(47)))), ((int)(((byte)(2)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvFilieurs.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvFilieurs.DoubleBuffered = true;
            this.dtgvFilieurs.EnableHeadersVisualStyles = false;
            this.dtgvFilieurs.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.dtgvFilieurs.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtgvFilieurs.Location = new System.Drawing.Point(0, 57);
            this.dtgvFilieurs.MultiSelect = false;
            this.dtgvFilieurs.Name = "dtgvFilieurs";
            this.dtgvFilieurs.ReadOnly = true;
            this.dtgvFilieurs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvFilieurs.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.dtgvFilieurs.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvFilieurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvFilieurs.Size = new System.Drawing.Size(942, 487);
            this.dtgvFilieurs.TabIndex = 22;
            this.dtgvFilieurs.SelectionChanged += new System.EventHandler(this.dtgvFilieurs_SelectionChanged);
            // 
            // cmbsecteurs
            // 
            this.cmbsecteurs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbsecteurs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.cmbsecteurs.DropDownHeight = 120;
            this.cmbsecteurs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsecteurs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbsecteurs.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsecteurs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmbsecteurs.FormattingEnabled = true;
            this.cmbsecteurs.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.cmbsecteurs.IntegralHeight = false;
            this.cmbsecteurs.ItemHeight = 20;
            this.cmbsecteurs.Location = new System.Drawing.Point(716, 23);
            this.cmbsecteurs.Name = "cmbsecteurs";
            this.cmbsecteurs.Size = new System.Drawing.Size(214, 28);
            this.cmbsecteurs.TabIndex = 25;
            this.cmbsecteurs.SelectedIndexChanged += new System.EventHandler(this.cmbsecteurs_SelectedIndexChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Engravers MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(311, 24);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(143, 15);
            this.bunifuCustomLabel2.TabIndex = 31;
            this.bunifuCustomLabel2.Text = "Nom Filière :";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Engravers MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(743, 7);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(143, 14);
            this.bunifuCustomLabel1.TabIndex = 32;
            this.bunifuCustomLabel1.Text = "List Secteurs";
            // 
            // Form_Filieur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 544);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.cmbsecteurs);
            this.Controls.Add(this.bindingNVGFiliers);
            this.Controls.Add(this.txtnomFilière);
            this.Controls.Add(this.dtgvFilieurs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Filieur";
            this.Text = "Form_Filieur";
            this.Load += new System.EventHandler(this.Form_Filieur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNVGFiliers)).EndInit();
            this.bindingNVGFiliers.ResumeLayout(false);
            this.bindingNVGFiliers.PerformLayout();
            this.cntmsecteurs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFilieurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btndelete;
        private System.Windows.Forms.ToolStripButton btnadd;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.BindingNavigator bindingNVGFiliers;
        private System.Windows.Forms.ToolStripButton btnupdate;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtnomFilière;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgvFilieurs;
        private System.Windows.Forms.ContextMenuStrip cntmsecteurs;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbsecteurs;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}