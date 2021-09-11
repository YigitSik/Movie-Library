namespace MovieLibrary.Forms
{
    partial class AddFavouriteForm
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pictureBoxFav = new DevExpress.XtraEditors.PictureEdit();
            this.textYear = new DevExpress.XtraEditors.LabelControl();
            this.textTitle = new DevExpress.XtraEditors.LabelControl();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ratingControlFav = new DevExpress.XtraEditors.RatingControl();
            this.richTextNotes = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFav.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingControlFav.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 54;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(496, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 627);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(496, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 627);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(496, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 627);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.saveBtn);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.ratingControlFav);
            this.panelControl1.Controls.Add(this.richTextNotes);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(496, 627);
            this.panelControl1.TabIndex = 18;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.pictureBoxFav);
            this.panelControl2.Controls.Add(this.textYear);
            this.panelControl2.Controls.Add(this.textTitle);
            this.panelControl2.Location = new System.Drawing.Point(144, 12);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(200, 283);
            this.panelControl2.TabIndex = 22;
            // 
            // pictureBoxFav
            // 
            this.pictureBoxFav.EditValue = global::MovieLibrary.Properties.Resources.blank;
            this.pictureBoxFav.Location = new System.Drawing.Point(5, 5);
            this.pictureBoxFav.MenuManager = this.barManager1;
            this.pictureBoxFav.Name = "pictureBoxFav";
            this.pictureBoxFav.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureBoxFav.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureBoxFav.Size = new System.Drawing.Size(190, 222);
            this.pictureBoxFav.TabIndex = 25;
            // 
            // textYear
            // 
            this.textYear.Location = new System.Drawing.Point(83, 256);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(27, 17);
            this.textYear.TabIndex = 24;
            this.textYear.Text = "Year";
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(84, 233);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(26, 17);
            this.textTitle.TabIndex = 23;
            this.textTitle.Text = "Title";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(366, 328);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(82, 31);
            this.saveBtn.TabIndex = 19;
            this.saveBtn.Text = "Submit";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click_1);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(48, 387);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 17);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Notes";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(48, 305);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 17);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Your Score";
            // 
            // ratingControlFav
            // 
            this.ratingControlFav.Location = new System.Drawing.Point(48, 328);
            this.ratingControlFav.Name = "ratingControlFav";
            this.ratingControlFav.Rating = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ratingControlFav.Size = new System.Drawing.Size(92, 16);
            this.ratingControlFav.TabIndex = 16;
            this.ratingControlFav.Text = "ratingControl1";
            this.ratingControlFav.EditValueChanged += new System.EventHandler(this.ratingControlFav_EditValueChanged);
            // 
            // richTextNotes
            // 
            this.richTextNotes.Location = new System.Drawing.Point(48, 410);
            this.richTextNotes.Name = "richTextNotes";
            this.richTextNotes.Size = new System.Drawing.Size(375, 192);
            this.richTextNotes.TabIndex = 14;
            this.richTextNotes.Text = "";
            this.richTextNotes.TextChanged += new System.EventHandler(this.richTextNotes_TextChanged);
            // 
            // AddFavouriteForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 627);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Futura Std Medium", 7.8F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddFavouriteForm";
            this.Text = "AddFavouriteForm";
            this.Load += new System.EventHandler(this.AddFavouriteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFav.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingControlFav.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.RatingControl ratingControlFav;
        private System.Windows.Forms.RichTextBox richTextNotes;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PictureEdit pictureBoxFav;
        private DevExpress.XtraEditors.LabelControl textYear;
        private DevExpress.XtraEditors.LabelControl textTitle;
    }
}