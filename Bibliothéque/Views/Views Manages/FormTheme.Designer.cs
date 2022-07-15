namespace Bibliothéque.Views.Views_Manages
{
    partial class FormTheme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTheme));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingNVGTheme = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.txtnomtheme = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dtgvTheme = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.cntmtheme = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNVGTheme)).BeginInit();
            this.bindingNVGTheme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTheme)).BeginInit();
            this.cntmtheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingNVGTheme
            // 
            this.bindingNVGTheme.AddNewItem = null;
            this.bindingNVGTheme.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bindingNVGTheme.BackColor = System.Drawing.Color.Transparent;
            this.bindingNVGTheme.CountItem = this.bindingNavigatorCountItem;
            this.bindingNVGTheme.DeleteItem = null;
            this.bindingNVGTheme.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNVGTheme.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNVGTheme.Location = new System.Drawing.Point(9, 12);
            this.bindingNVGTheme.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNVGTheme.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNVGTheme.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNVGTheme.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNVGTheme.Name = "bindingNVGTheme";
            this.bindingNVGTheme.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNVGTheme.Size = new System.Drawing.Size(278, 25);
            this.bindingNVGTheme.TabIndex = 24;
            this.bindingNVGTheme.Text = "bindingNavigator1";
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
            this.btnadd.Text = "Add Thème";
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
            this.btnupdate.Text = "Update Thème";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btndelete.Image = global::Bibliothéque.Properties.Resources.trash;
            this.btndelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(23, 22);
            this.btndelete.Text = "Delete Thème";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtnomtheme
            // 
            this.txtnomtheme.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtnomtheme.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.txtnomtheme.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            this.txtnomtheme.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.txtnomtheme.BorderThickness = 3;
            this.txtnomtheme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnomtheme.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtnomtheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtnomtheme.isPassword = false;
            this.txtnomtheme.Location = new System.Drawing.Point(605, 12);
            this.txtnomtheme.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtnomtheme.Name = "txtnomtheme";
            this.txtnomtheme.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.txtnomtheme.Size = new System.Drawing.Size(325, 32);
            this.txtnomtheme.TabIndex = 23;
            this.txtnomtheme.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dtgvTheme
            // 
            this.dtgvTheme.AllowUserToAddRows = false;
            this.dtgvTheme.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            this.dtgvTheme.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtgvTheme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTheme.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgvTheme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvTheme.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTheme.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvTheme.ColumnHeadersHeight = 40;
            this.dtgvTheme.ContextMenuStrip = this.cntmtheme;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvTheme.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvTheme.DoubleBuffered = true;
            this.dtgvTheme.EnableHeadersVisualStyles = false;
            this.dtgvTheme.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.dtgvTheme.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtgvTheme.Location = new System.Drawing.Point(0, 53);
            this.dtgvTheme.MultiSelect = false;
            this.dtgvTheme.Name = "dtgvTheme";
            this.dtgvTheme.ReadOnly = true;
            this.dtgvTheme.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTheme.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvTheme.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dtgvTheme.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvTheme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTheme.Size = new System.Drawing.Size(942, 492);
            this.dtgvTheme.TabIndex = 22;
            this.dtgvTheme.SelectionChanged += new System.EventHandler(this.dtgvTheme_SelectionChanged);
            // 
            // cntmtheme
            // 
            this.cntmtheme.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
            this.cntmtheme.Name = "cntmsecteurs";
            this.cntmtheme.Size = new System.Drawing.Size(113, 26);
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
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(445, 18);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(159, 19);
            this.bunifuCustomLabel1.TabIndex = 33;
            this.bunifuCustomLabel1.Text = "Nom Thème :";
            // 
            // FormTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 544);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bindingNVGTheme);
            this.Controls.Add(this.txtnomtheme);
            this.Controls.Add(this.dtgvTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTheme";
            this.Text = "FormTheme";
            this.Load += new System.EventHandler(this.FormTheme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNVGTheme)).EndInit();
            this.bindingNVGTheme.ResumeLayout(false);
            this.bindingNVGTheme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTheme)).EndInit();
            this.cntmtheme.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNVGTheme;
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
        private Bunifu.Framework.UI.BunifuMetroTextbox txtnomtheme;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgvTheme;
        private System.Windows.Forms.ContextMenuStrip cntmtheme;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}