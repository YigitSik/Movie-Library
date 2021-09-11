namespace MovieLibrary.Forms
{
    partial class AddWatchListForm
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
            this.watchListSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox = new DevExpress.XtraEditors.PictureEdit();
            this.textYear = new DevExpress.XtraEditors.LabelControl();
            this.textTitle = new DevExpress.XtraEditors.LabelControl();
            this.WatchListNameText = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.watchListControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Title = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Year = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Genre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imdbRating = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WatchListNameText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watchListControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // watchListSubmit
            // 
            this.watchListSubmit.Location = new System.Drawing.Point(93, 629);
            this.watchListSubmit.Name = "watchListSubmit";
            this.watchListSubmit.Size = new System.Drawing.Size(82, 31);
            this.watchListSubmit.TabIndex = 10;
            this.watchListSubmit.Text = "Submit";
            this.watchListSubmit.Click += new System.EventHandler(this.watchListSubmit_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(29, 505);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(218, 102);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(29, 443);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(109, 24);
            this.dateEdit1.TabIndex = 14;
            this.dateEdit1.EditValueChanged += new System.EventHandler(this.dateEdit1_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 420);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 17);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Date";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 481);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 17);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Notes";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(29, 367);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(105, 17);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Watch List Name";
            // 
            // pictureBox
            // 
            this.pictureBox.EditValue = global::MovieLibrary.Properties.Resources.blank;
            this.pictureBox.Location = new System.Drawing.Point(29, 22);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureBox.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureBox.Size = new System.Drawing.Size(208, 277);
            this.pictureBox.TabIndex = 22;
            // 
            // textYear
            // 
            this.textYear.Location = new System.Drawing.Point(120, 328);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(27, 17);
            this.textYear.TabIndex = 21;
            this.textYear.Text = "Year";
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(120, 305);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(26, 17);
            this.textTitle.TabIndex = 20;
            this.textTitle.Text = "Title";
            // 
            // WatchListNameText
            // 
            this.WatchListNameText.Location = new System.Drawing.Point(29, 390);
            this.WatchListNameText.Name = "WatchListNameText";
            this.WatchListNameText.Size = new System.Drawing.Size(125, 24);
            this.WatchListNameText.TabIndex = 23;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pictureBox);
            this.panelControl1.Controls.Add(this.WatchListNameText);
            this.panelControl1.Controls.Add(this.watchListSubmit);
            this.panelControl1.Controls.Add(this.richTextBox1);
            this.panelControl1.Controls.Add(this.textYear);
            this.panelControl1.Controls.Add(this.dateEdit1);
            this.panelControl1.Controls.Add(this.textTitle);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(274, 728);
            this.panelControl1.TabIndex = 24;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.watchListControl);
            this.panelControl2.Location = new System.Drawing.Point(292, 12);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(611, 728);
            this.panelControl2.TabIndex = 25;
            // 
            // watchListControl
            // 
            this.watchListControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.watchListControl.Location = new System.Drawing.Point(1, 0);
            this.watchListControl.MainView = this.gridView1;
            this.watchListControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.watchListControl.Name = "watchListControl";
            this.watchListControl.Size = new System.Drawing.Size(609, 728);
            this.watchListControl.TabIndex = 18;
            this.watchListControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.Date,
            this.Title,
            this.Year,
            this.Genre,
            this.imdbRating});
            this.gridView1.DetailHeight = 470;
            this.gridView1.GridControl = this.watchListControl;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsPrint.ExpandAllDetails = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged_1);
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "WatchListName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // Date
            // 
            this.Date.FieldName = "Date";
            this.Date.Name = "Date";
            this.Date.Visible = true;
            this.Date.VisibleIndex = 0;
            // 
            // Title
            // 
            this.Title.FieldName = "Title";
            this.Title.Name = "Title";
            this.Title.Visible = true;
            this.Title.VisibleIndex = 1;
            // 
            // Year
            // 
            this.Year.FieldName = "Year";
            this.Year.Name = "Year";
            this.Year.Visible = true;
            this.Year.VisibleIndex = 2;
            // 
            // Genre
            // 
            this.Genre.FieldName = "Genre";
            this.Genre.Name = "Genre";
            this.Genre.Visible = true;
            this.Genre.VisibleIndex = 3;
            // 
            // imdbRating
            // 
            this.imdbRating.FieldName = "imdbRating";
            this.imdbRating.Name = "imdbRating";
            this.imdbRating.Visible = true;
            this.imdbRating.VisibleIndex = 4;
            // 
            // AddWatchListForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 752);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Futura Std Medium", 7.8F);
            this.Name = "AddWatchListForm";
            this.Text = "AddWatchListForm";
            this.Load += new System.EventHandler(this.AddWatchListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WatchListNameText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.watchListControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton watchListSubmit;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PictureEdit pictureBox;
        private DevExpress.XtraEditors.LabelControl textYear;
        private DevExpress.XtraEditors.LabelControl textTitle;
        private DevExpress.XtraEditors.TextEdit WatchListNameText;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl watchListControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn Date;
        private DevExpress.XtraGrid.Columns.GridColumn Title;
        private DevExpress.XtraGrid.Columns.GridColumn Year;
        private DevExpress.XtraGrid.Columns.GridColumn Genre;
        private DevExpress.XtraGrid.Columns.GridColumn imdbRating;
    }
}