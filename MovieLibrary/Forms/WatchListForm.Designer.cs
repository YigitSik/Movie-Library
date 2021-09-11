namespace MovieLibrary
{
    partial class WatchListForm
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
            this.watchListControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Title = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Year = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Genre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WatchListElementId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imdbRating = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Notes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pictureBox = new DevExpress.XtraEditors.PictureEdit();
            this.dateLabel = new DevExpress.XtraEditors.LabelControl();
            this.detailsBtn = new DevExpress.XtraEditors.SimpleButton();
            this.wachListNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.watchListNameText = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit = new DevExpress.XtraEditors.DateEdit();
            this.notesText = new System.Windows.Forms.RichTextBox();
            this.deleteBtn = new DevExpress.XtraEditors.SimpleButton();
            this.updateBtn = new DevExpress.XtraEditors.SimpleButton();
            this.imdbId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.excelBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.watchListControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchListNameText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // watchListControl
            // 
            this.watchListControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.watchListControl.Location = new System.Drawing.Point(11, 12);
            this.watchListControl.MainView = this.gridView1;
            this.watchListControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.watchListControl.Name = "watchListControl";
            this.watchListControl.Size = new System.Drawing.Size(879, 670);
            this.watchListControl.TabIndex = 0;
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
            this.WatchListElementId,
            this.imdbRating,
            this.Notes,
            this.imdbId});
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
            // WatchListElementId
            // 
            this.WatchListElementId.FieldName = "WatchListElementId";
            this.WatchListElementId.Name = "WatchListElementId";
            // 
            // imdbRating
            // 
            this.imdbRating.FieldName = "imdbRating";
            this.imdbRating.Name = "imdbRating";
            this.imdbRating.Visible = true;
            this.imdbRating.VisibleIndex = 4;
            // 
            // Notes
            // 
            this.Notes.FieldName = "Notes";
            this.Notes.Name = "Notes";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.excelBtn);
            this.groupControl1.Controls.Add(this.pictureBox);
            this.groupControl1.Controls.Add(this.dateLabel);
            this.groupControl1.Controls.Add(this.detailsBtn);
            this.groupControl1.Controls.Add(this.wachListNameLabel);
            this.groupControl1.Controls.Add(this.watchListNameText);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.dateEdit);
            this.groupControl1.Controls.Add(this.notesText);
            this.groupControl1.Controls.Add(this.deleteBtn);
            this.groupControl1.Controls.Add(this.updateBtn);
            this.groupControl1.Location = new System.Drawing.Point(898, 12);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(271, 670);
            this.groupControl1.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.EditValue = global::MovieLibrary.Properties.Resources.empty;
            this.pictureBox.Location = new System.Drawing.Point(15, 51);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureBox.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureBox.Size = new System.Drawing.Size(242, 275);
            this.pictureBox.TabIndex = 27;
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(16, 385);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(29, 17);
            this.dateLabel.TabIndex = 26;
            this.dateLabel.Text = "Date";
            // 
            // detailsBtn
            // 
            this.detailsBtn.Location = new System.Drawing.Point(155, 14);
            this.detailsBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.detailsBtn.Name = "detailsBtn";
            this.detailsBtn.Size = new System.Drawing.Size(93, 31);
            this.detailsBtn.TabIndex = 25;
            this.detailsBtn.Text = "Details";
            this.detailsBtn.Click += new System.EventHandler(this.detailsBtn_Click);
            // 
            // wachListNameLabel
            // 
            this.wachListNameLabel.Location = new System.Drawing.Point(15, 332);
            this.wachListNameLabel.Name = "wachListNameLabel";
            this.wachListNameLabel.Size = new System.Drawing.Size(105, 17);
            this.wachListNameLabel.TabIndex = 24;
            this.wachListNameLabel.Text = "Watch List Name";
            // 
            // watchListNameText
            // 
            this.watchListNameText.Location = new System.Drawing.Point(15, 355);
            this.watchListNameText.Name = "watchListNameText";
            this.watchListNameText.Size = new System.Drawing.Size(125, 24);
            this.watchListNameText.TabIndex = 23;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 362);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 17);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "Date";
            // 
            // dateEdit
            // 
            this.dateEdit.EditValue = null;
            this.dateEdit.Location = new System.Drawing.Point(15, 411);
            this.dateEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateEdit.Name = "dateEdit";
            this.dateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Size = new System.Drawing.Size(124, 24);
            this.dateEdit.TabIndex = 20;
            // 
            // notesText
            // 
            this.notesText.Location = new System.Drawing.Point(16, 446);
            this.notesText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.notesText.Name = "notesText";
            this.notesText.Size = new System.Drawing.Size(232, 171);
            this.notesText.TabIndex = 19;
            this.notesText.Text = "";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(15, 623);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(93, 31);
            this.deleteBtn.TabIndex = 18;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(153, 623);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(93, 31);
            this.updateBtn.TabIndex = 17;
            this.updateBtn.Text = "Update";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // imdbId
            // 
            this.imdbId.FieldName = "imdbId";
            this.imdbId.Name = "imdbId";
            // 
            // excelBtn
            // 
            this.excelBtn.Location = new System.Drawing.Point(26, 16);
            this.excelBtn.Name = "excelBtn";
            this.excelBtn.Size = new System.Drawing.Size(94, 29);
            this.excelBtn.TabIndex = 28;
            this.excelBtn.Text = "Export Excel";
            this.excelBtn.Click += new System.EventHandler(this.excelBtn_Click);
            // 
            // WatchListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 693);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.watchListControl);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "WatchListForm";
            this.Text = "WatchListForm";
            this.Activated += new System.EventHandler(this.WatchListForm_Activated);
            this.Load += new System.EventHandler(this.WatchListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.watchListControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchListNameText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl watchListControl;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn Date;
        private DevExpress.XtraGrid.Columns.GridColumn Title;
        private DevExpress.XtraGrid.Columns.GridColumn Year;
        private DevExpress.XtraGrid.Columns.GridColumn Genre;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateEdit;
        private System.Windows.Forms.RichTextBox notesText;
        private DevExpress.XtraEditors.SimpleButton deleteBtn;
        private DevExpress.XtraEditors.SimpleButton updateBtn;
        private DevExpress.XtraEditors.LabelControl wachListNameLabel;
        private DevExpress.XtraEditors.TextEdit watchListNameText;
        private DevExpress.XtraEditors.LabelControl dateLabel;
        private DevExpress.XtraEditors.SimpleButton detailsBtn;
        private DevExpress.XtraEditors.PictureEdit pictureBox;
        private DevExpress.XtraGrid.Columns.GridColumn WatchListElementId;
        private DevExpress.XtraGrid.Columns.GridColumn imdbRating;
        private DevExpress.XtraGrid.Columns.GridColumn Notes;
        private DevExpress.XtraGrid.Columns.GridColumn imdbId;
        private DevExpress.XtraEditors.SimpleButton excelBtn;
    }
}