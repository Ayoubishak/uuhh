namespace Bibliothéque.Views.Views_Manages
{
    partial class Form_Groupe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Groupe));
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
            this.cmbsecteurs = new System.Windows.Forms.ComboBox();
            this.cntmsecteurs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnupdate = new System.Windows.Forms.ToolStripButton();
            this.bindingNVGGroups = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtnomGroupe = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dtgvgroupes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.cmbfilieres = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblfilieres = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cntmsecteurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNVGGroups)).BeginInit();
            this.bindingNVGGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvgroupes)).BeginInit();
            this.SuspendLayout();
            // 
            // btndelete
            // 
            this.btndelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btndelete.Image = global::Bibliothéque.Properties.Resources.trash;
            this.btndelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(23, 22);
            this.btndelete.Text = "Delete Groupe";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnadd.Image = global::Bibliothéque.Properties.Resources.add__2_;
            this.btnadd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(23, 22);
            this.btnadd.Text = "Add Groupe";
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
            this.cmbsecteurs.Location = new System.Drawing.Point(313, 22);
            this.cmbsecteurs.Name = "cmbsecteurs";
            this.cmbsecteurs.Size = new System.Drawing.Size(293, 28);
            this.cmbsecteurs.TabIndex = 29;
            this.cmbsecteurs.SelectedIndexChanged += new System.EventHandler(this.cmbsecteurs_SelectedIndexChanged);
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
            // btnupdate
            // 
            this.btnupdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnupdate.Enabled = false;
            this.btnupdate.Image = global::Bibliothéque.Properties.Resources.refresh;
            this.btnupdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(23, 22);
            this.btnupdate.Text = "Update Groupe";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // bindingNVGGroups
            // 
            this.bindingNVGGroups.AddNewItem = null;
            this.bindingNVGGroups.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bindingNVGGroups.BackColor = System.Drawing.Color.Transparent;
            this.bindingNVGGroups.CountItem = this.bindingNavigatorCountItem;
            this.bindingNVGGroups.DeleteItem = null;
            this.bindingNVGGroups.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNVGGroups.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNVGGroups.Location = new System.Drawing.Point(23, 22);
            this.bindingNVGGroups.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNVGGroups.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNVGGroups.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNVGGroups.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNVGGroups.Name = "bindingNVGGroups";
            this.bindingNVGGroups.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNVGGroups.Size = new System.Drawing.Size(278, 25);
            this.bindingNVGGroups.TabIndex = 28;
            this.bindingNVGGroups.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // txtnomGroupe
            // 
            this.txtnomGroupe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtnomGroupe.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.txtnomGroupe.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            this.txtnomGroupe.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.txtnomGroupe.BorderThickness = 3;
            this.txtnomGroupe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnomGroupe.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtnomGroupe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtnomGroupe.isPassword = false;
            this.txtnomGroupe.Location = new System.Drawing.Point(857, 21);
            this.txtnomGroupe.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtnomGroupe.Name = "txtnomGroupe";
            this.txtnomGroupe.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.txtnomGroupe.Size = new System.Drawing.Size(203, 32);
            this.txtnomGroupe.TabIndex = 27;
            this.txtnomGroupe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dtgvgroupes
            // 
            this.dtgvgroupes.AllowUserToAddRows = false;
            this.dtgvgroupes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            this.dtgvgroupes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvgroupes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtgvgroupes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvgroupes.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgvgroupes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvgroupes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvgroupes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvgroupes.ColumnHeadersHeight = 40;
            this.dtgvgroupes.ContextMenuStrip = this.cntmsecteurs;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(47)))), ((int)(((byte)(2)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvgroupes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvgroupes.DoubleBuffered = true;
            this.dtgvgroupes.EnableHeadersVisualStyles = false;
            this.dtgvgroupes.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.dtgvgroupes.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtgvgroupes.Location = new System.Drawing.Point(23, 61);
            this.dtgvgroupes.MultiSelect = false;
            this.dtgvgroupes.Name = "dtgvgroupes";
            this.dtgvgroupes.ReadOnly = true;
            this.dtgvgroupes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvgroupes.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.dtgvgroupes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvgroupes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvgroupes.Size = new System.Drawing.Size(1037, 480);
            this.dtgvgroupes.TabIndex = 26;
            this.dtgvgroupes.SelectionChanged += new System.EventHandler(this.dtgvgroupes_SelectionChanged);
            // 
            // cmbfilieres
            // 
            this.cmbfilieres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbfilieres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.cmbfilieres.DropDownHeight = 120;
            this.cmbfilieres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfilieres.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbfilieres.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbfilieres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmbfilieres.FormattingEnabled = true;
            this.cmbfilieres.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.cmbfilieres.IntegralHeight = false;
            this.cmbfilieres.ItemHeight = 20;
            this.cmbfilieres.Location = new System.Drawing.Point(629, 22);
            this.cmbfilieres.Name = "cmbfilieres";
            this.cmbfilieres.Size = new System.Drawing.Size(209, 28);
            this.cmbfilieres.TabIndex = 29;
            this.cmbfilieres.Visible = false;
            this.cmbfilieres.SelectedIndexChanged += new System.EventHandler(this.cmbfilieres_SelectedIndexChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Engravers MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(376, 4);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(143, 14);
            this.bunifuCustomLabel2.TabIndex = 30;
            this.bunifuCustomLabel2.Text = "List Secteurs";
            // 
            // lblfilieres
            // 
            this.lblfilieres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblfilieres.AutoSize = true;
            this.lblfilieres.Font = new System.Drawing.Font("Engravers MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfilieres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.lblfilieres.Location = new System.Drawing.Point(663, 5);
            this.lblfilieres.Name = "lblfilieres";
            this.lblfilieres.Size = new System.Drawing.Size(133, 14);
            this.lblfilieres.TabIndex = 30;
            this.lblfilieres.Text = "List Filières";
            this.lblfilieres.Visible = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Engravers MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(887, 5);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(124, 14);
            this.bunifuCustomLabel1.TabIndex = 30;
            this.bunifuCustomLabel1.Text = "Nom Groupe";
            // 
            // Form_Groupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 544);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.lblfilieres);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.cmbfilieres);
            this.Controls.Add(this.cmbsecteurs);
            this.Controls.Add(this.bindingNVGGroups);
            this.Controls.Add(this.txtnomGroupe);
            this.Controls.Add(this.dtgvgroupes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Groupe";
            this.Text = "Form_Groupe";
            this.Load += new System.EventHandler(this.Form_Groupe_Load);
            this.cntmsecteurs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNVGGroups)).EndInit();
            this.bindingNVGGroups.ResumeLayout(false);
            this.bindingNVGGroups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvgroupes)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbsecteurs;
        private System.Windows.Forms.ContextMenuStrip cntmsecteurs;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnupdate;
        private System.Windows.Forms.BindingNavigator bindingNVGGroups;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtnomGroupe;
        private System.Windows.Forms.ComboBox cmbfilieres;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgvgroupes;
        private Bunifu.Framework.UI.BunifuCustomLabel lblfilieres;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}