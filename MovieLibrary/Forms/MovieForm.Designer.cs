namespace MovieLibrary
{
    partial class MovieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieForm));
            this.searchBox = new DevExpress.XtraEditors.SearchControl();
            this.searchBtn = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MovieGrid = new DevExpress.XtraGrid.GridControl();
            this.dataGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimdbID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPoster = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.watchListBtn = new DevExpress.XtraEditors.SimpleButton();
            this.favouritesBtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.detailsBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.searchBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(31, 63);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchBox.Name = "searchBox";
            this.searchBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton()});
            this.searchBox.Properties.ShowSearchButton = false;
            this.searchBox.Size = new System.Drawing.Size(635, 24);
            this.searchBox.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(720, 58);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(93, 31);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Search";
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MovieGrid
            // 
            this.MovieGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MovieGrid.Location = new System.Drawing.Point(12, 126);
            this.MovieGrid.MainView = this.dataGrid;
            this.MovieGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MovieGrid.Name = "MovieGrid";
            this.MovieGrid.Size = new System.Drawing.Size(813, 555);
            this.MovieGrid.TabIndex = 4;
            this.MovieGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dataGrid});
            // 
            // dataGrid
            // 
            this.dataGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTitle,
            this.colYear,
            this.colType,
            this.colimdbID,
            this.colPoster});
            this.dataGrid.DetailHeight = 372;
            this.dataGrid.GridControl = this.MovieGrid;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.OptionsBehavior.Editable = false;
            this.dataGrid.OptionsBehavior.FocusLeaveOnTab = true;
            this.dataGrid.OptionsView.ShowGroupPanel = false;
            this.dataGrid.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dataGrid_FocusedRowChanged);
            // 
            // colTitle
            // 
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 0;
            // 
            // colYear
            // 
            this.colYear.FieldName = "Year";
            this.colYear.Name = "colYear";
            this.colYear.Visible = true;
            this.colYear.VisibleIndex = 1;
            // 
            // colType
            // 
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 2;
            // 
            // colimdbID
            // 
            this.colimdbID.FieldName = "imdbID";
            this.colimdbID.Name = "colimdbID";
            // 
            // colPoster
            // 
            this.colPoster.FieldName = "Poster";
            this.colPoster.Name = "colPoster";
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::MovieLibrary.Properties.Resources.search;
            this.pictureEdit1.Location = new System.Drawing.Point(9, 50);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ErrorImageOptions.Image = global::MovieLibrary.Properties.Resources.blank;
            this.pictureEdit1.Properties.InitialImageOptions.Image = global::MovieLibrary.Properties.Resources.blank;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(317, 423);
            this.pictureEdit1.TabIndex = 6;
            // 
            // watchListBtn
            // 
            this.watchListBtn.Location = new System.Drawing.Point(27, 491);
            this.watchListBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.watchListBtn.Name = "watchListBtn";
            this.watchListBtn.Size = new System.Drawing.Size(128, 46);
            this.watchListBtn.TabIndex = 7;
            this.watchListBtn.Text = "Add To Watchlist";
            this.watchListBtn.Click += new System.EventHandler(this.watchListBtn_Click);
            // 
            // favouritesBtn
            // 
            this.favouritesBtn.Location = new System.Drawing.Point(180, 491);
            this.favouritesBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.favouritesBtn.Name = "favouritesBtn";
            this.favouritesBtn.Size = new System.Drawing.Size(128, 46);
            this.favouritesBtn.TabIndex = 8;
            this.favouritesBtn.Text = "Add To Favourites";
            this.favouritesBtn.Click += new System.EventHandler(this.favouritesBtn_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(31, 40);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(116, 17);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Search For a Movie";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.detailsBtn);
            this.groupControl1.Controls.Add(this.favouritesBtn);
            this.groupControl1.Controls.Add(this.pictureEdit1);
            this.groupControl1.Controls.Add(this.watchListBtn);
            this.groupControl1.Location = new System.Drawing.Point(833, 126);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(336, 555);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "groupControl1";
            // 
            // detailsBtn
            // 
            this.detailsBtn.Location = new System.Drawing.Point(121, 5);
            this.detailsBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.detailsBtn.Name = "detailsBtn";
            this.detailsBtn.Size = new System.Drawing.Size(93, 31);
            this.detailsBtn.TabIndex = 9;
            this.detailsBtn.Text = "Details";
            this.detailsBtn.Click += new System.EventHandler(this.detailsBtn_Click);
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 693);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.MovieGrid);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.groupControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MovieForm";
            this.Text = "Movies";
            ((System.ComponentModel.ISupportInitialize)(this.searchBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SearchControl searchBox;
        private DevExpress.XtraEditors.SimpleButton searchBtn;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraGrid.GridControl MovieGrid;
        private System.Windows.Forms.ImageList imageList2;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView dataGrid;
        private DevExpress.XtraEditors.SimpleButton watchListBtn;
        private DevExpress.XtraEditors.SimpleButton favouritesBtn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton detailsBtn;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colYear;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colimdbID;
        private DevExpress.XtraGrid.Columns.GridColumn colPoster;
    }
}

