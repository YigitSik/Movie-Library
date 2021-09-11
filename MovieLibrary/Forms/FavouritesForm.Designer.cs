namespace MovieLibrary
{
    partial class FavouritesForm
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Title = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Year = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Genre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imdbId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imdbRating = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Notes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PersonalRating = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBoxFav = new DevExpress.XtraEditors.PictureEdit();
            this.ratingControl1 = new DevExpress.XtraEditors.RatingControl();
            this.notesText = new System.Windows.Forms.RichTextBox();
            this.deleteBtn = new DevExpress.XtraEditors.SimpleButton();
            this.updateBtn = new DevExpress.XtraEditors.SimpleButton();
            this.detailsButton = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.excelBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFav.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Location = new System.Drawing.Point(904, 12);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(0, 0);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Title,
            this.Year,
            this.Genre,
            this.imdbId,
            this.imdbRating,
            this.Notes,
            this.PersonalRating});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // Title
            // 
            this.Title.FieldName = "Title";
            this.Title.Name = "Title";
            this.Title.Visible = true;
            this.Title.VisibleIndex = 0;
            // 
            // Year
            // 
            this.Year.FieldName = "Year";
            this.Year.Name = "Year";
            this.Year.Visible = true;
            this.Year.VisibleIndex = 1;
            // 
            // Genre
            // 
            this.Genre.FieldName = "Genre";
            this.Genre.Name = "Genre";
            this.Genre.Visible = true;
            this.Genre.VisibleIndex = 2;
            // 
            // imdbId
            // 
            this.imdbId.FieldName = "imdbId";
            this.imdbId.Name = "imdbId";
            // 
            // imdbRating
            // 
            this.imdbRating.FieldName = "imdbRating";
            this.imdbRating.Name = "imdbRating";
            this.imdbRating.Visible = true;
            this.imdbRating.VisibleIndex = 3;
            // 
            // Notes
            // 
            this.Notes.FieldName = "Notes";
            this.Notes.Name = "Notes";
            // 
            // PersonalRating
            // 
            this.PersonalRating.FieldName = "PersonalRating";
            this.PersonalRating.Name = "PersonalRating";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(869, 670);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.excelBtn);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.notesText);
            this.panelControl1.Controls.Add(this.deleteBtn);
            this.panelControl1.Controls.Add(this.updateBtn);
            this.panelControl1.Controls.Add(this.detailsButton);
            this.panelControl1.Location = new System.Drawing.Point(887, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(283, 669);
            this.panelControl1.TabIndex = 4;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.pictureBoxFav);
            this.panelControl2.Controls.Add(this.ratingControl1);
            this.panelControl2.Location = new System.Drawing.Point(26, 51);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(231, 359);
            this.panelControl2.TabIndex = 29;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(75, 291);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 17);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "Your Rating";
            // 
            // pictureBoxFav
            // 
            this.pictureBoxFav.EditValue = global::MovieLibrary.Properties.Resources.empty;
            this.pictureBoxFav.Location = new System.Drawing.Point(5, 12);
            this.pictureBoxFav.Name = "pictureBoxFav";
            this.pictureBoxFav.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureBoxFav.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureBoxFav.Size = new System.Drawing.Size(220, 273);
            this.pictureBoxFav.TabIndex = 27;
            // 
            // ratingControl1
            // 
            this.ratingControl1.Location = new System.Drawing.Point(64, 323);
            this.ratingControl1.Name = "ratingControl1";
            this.ratingControl1.Rating = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ratingControl1.Size = new System.Drawing.Size(92, 16);
            this.ratingControl1.TabIndex = 26;
            this.ratingControl1.Text = "ratingControl1";
            // 
            // notesText
            // 
            this.notesText.Location = new System.Drawing.Point(25, 433);
            this.notesText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.notesText.Name = "notesText";
            this.notesText.Size = new System.Drawing.Size(232, 171);
            this.notesText.TabIndex = 28;
            this.notesText.Text = "";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(24, 610);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(93, 31);
            this.deleteBtn.TabIndex = 27;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click_1);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(162, 610);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(93, 31);
            this.updateBtn.TabIndex = 26;
            this.updateBtn.Text = "Update";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click_1);
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(157, 16);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(94, 29);
            this.detailsButton.TabIndex = 24;
            this.detailsButton.Text = "Details";
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click_1);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            // 
            // excelBtn
            // 
            this.excelBtn.Location = new System.Drawing.Point(31, 16);
            this.excelBtn.Name = "excelBtn";
            this.excelBtn.Size = new System.Drawing.Size(94, 29);
            this.excelBtn.TabIndex = 30;
            this.excelBtn.Text = "Export Excel";
            this.excelBtn.Click += new System.EventHandler(this.excelBtn_Click);
            // 
            // FavouritesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 693);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FavouritesForm";
            this.Text = "Favourites";
            this.Activated += new System.EventHandler(this.FavouritesForm_Activated);
            this.Load += new System.EventHandler(this.FavouritesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFav.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingControl1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Title;
        private DevExpress.XtraGrid.Columns.GridColumn Year;
        private DevExpress.XtraGrid.Columns.GridColumn Genre;
        private DevExpress.XtraGrid.Columns.GridColumn imdbId;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Columns.GridColumn imdbRating;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton detailsButton;
        private System.Windows.Forms.RichTextBox notesText;
        private DevExpress.XtraEditors.SimpleButton deleteBtn;
        private DevExpress.XtraEditors.SimpleButton updateBtn;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureBoxFav;
        private DevExpress.XtraEditors.RatingControl ratingControl1;
        private DevExpress.XtraGrid.Columns.GridColumn Notes;
        private DevExpress.XtraGrid.Columns.GridColumn PersonalRating;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.SimpleButton excelBtn;
    }
}