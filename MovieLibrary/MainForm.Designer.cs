namespace MovieLibrary
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.homeScreenBtn = new DevExpress.XtraBars.BarButtonItem();
            this.favouritesBtn = new DevExpress.XtraBars.BarButtonItem();
            this.watchListBtn = new DevExpress.XtraBars.BarButtonItem();
            this.statisticsBtn = new DevExpress.XtraBars.BarButtonItem();
            this.profileBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AllowHtmlText = true;
            this.ribbonControl1.AllowMinimizeRibbon = false;
            this.ribbonControl1.ExpandCollapseItem.AllowDrawArrowInMenu = false;
            this.ribbonControl1.ExpandCollapseItem.AllowRightClickInMenu = false;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.homeScreenBtn,
            this.favouritesBtn,
            this.watchListBtn,
            this.statisticsBtn,
            this.profileBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsCustomizationForm.FormIcon = ((System.Drawing.Icon)(resources.GetObject("resource.FormIcon")));
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1200, 73);
            // 
            // homeScreenBtn
            // 
            this.homeScreenBtn.Caption = "Movies";
            this.homeScreenBtn.Id = 1;
            this.homeScreenBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("homeScreenBtn.ImageOptions.Image")));
            this.homeScreenBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("homeScreenBtn.ImageOptions.LargeImage")));
            this.homeScreenBtn.Name = "homeScreenBtn";
            this.homeScreenBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.homeScreenBtn_ItemClick);
            // 
            // favouritesBtn
            // 
            this.favouritesBtn.Caption = "Favourites";
            this.favouritesBtn.Id = 2;
            this.favouritesBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("favouritesBtn.ImageOptions.Image")));
            this.favouritesBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("favouritesBtn.ImageOptions.LargeImage")));
            this.favouritesBtn.Name = "favouritesBtn";
            this.favouritesBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.favouritesBtn_ItemClick);
            // 
            // watchListBtn
            // 
            this.watchListBtn.Caption = "Watch List";
            this.watchListBtn.Id = 3;
            this.watchListBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("watchListBtn.ImageOptions.Image")));
            this.watchListBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("watchListBtn.ImageOptions.LargeImage")));
            this.watchListBtn.Name = "watchListBtn";
            this.watchListBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.watchListBtn_ItemClick);
            // 
            // statisticsBtn
            // 
            this.statisticsBtn.Caption = "Statistics";
            this.statisticsBtn.Id = 4;
            this.statisticsBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("statisticsBtn.ImageOptions.Image")));
            this.statisticsBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("statisticsBtn.ImageOptions.LargeImage")));
            this.statisticsBtn.Name = "statisticsBtn";
            this.statisticsBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.statisticsBtn_ItemClick);
            // 
            // profileBtn
            // 
            this.profileBtn.Id = 6;
            this.profileBtn.Name = "profileBtn";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Movies";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.homeScreenBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.watchListBtn, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.favouritesBtn, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.statisticsBtn, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.profileBtn, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(0, 0);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = null;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(0, 0);
            this.fluentDesignFormControl1.TabIndex = 0;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 866);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem homeScreenBtn;
        private DevExpress.XtraBars.BarButtonItem favouritesBtn;
        private DevExpress.XtraBars.BarButtonItem watchListBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem statisticsBtn;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraBars.BarButtonItem profileBtn;
    }
}