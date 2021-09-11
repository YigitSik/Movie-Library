namespace MovieLibrary.Forms
{
    partial class StatisticsForm
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
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView2 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesView pointSeriesView1 = new DevExpress.XtraCharts.PointSeriesView();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView3 = new DevExpress.XtraCharts.PieSeriesView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.countryChart = new DevExpress.XtraCharts.ChartControl();
            this.languageChart = new DevExpress.XtraCharts.ChartControl();
            this.ratingsChart = new DevExpress.XtraCharts.ChartControl();
            this.genreChart = new DevExpress.XtraCharts.ChartControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.countryChart);
            this.panelControl1.Controls.Add(this.languageChart);
            this.panelControl1.Controls.Add(this.ratingsChart);
            this.panelControl1.Controls.Add(this.genreChart);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1182, 765);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(627, 20);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(199, 17);
            this.labelControl4.TabIndex = 27;
            this.labelControl4.Text = "Genres Of Your Favourite Movies";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(627, 385);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(215, 17);
            this.labelControl3.TabIndex = 26;
            this.labelControl3.Text = "Countries Of Your Favourite Movies";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(57, 385);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(222, 17);
            this.labelControl2.TabIndex = 25;
            this.labelControl2.Text = "Languages Of Your Favourite Movies";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(56, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(237, 17);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Imdb Ratings Of Your Favourite Movies";
            // 
            // countryChart
            // 
            this.countryChart.Legend.Name = "Default Legend";
            this.countryChart.Location = new System.Drawing.Point(627, 409);
            this.countryChart.Name = "countryChart";
            series1.LegendTextPattern = "{A}";
            series1.Name = "Series 1";
            series1.View = pieSeriesView1;
            this.countryChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.countryChart.Size = new System.Drawing.Size(500, 319);
            this.countryChart.TabIndex = 23;
            // 
            // languageChart
            // 
            this.languageChart.Legend.Name = "Default Legend";
            this.languageChart.Location = new System.Drawing.Point(57, 409);
            this.languageChart.Name = "languageChart";
            series2.LegendTextPattern = "{A}";
            series2.Name = "Series 1";
            series2.View = pieSeriesView2;
            this.languageChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.languageChart.Size = new System.Drawing.Size(500, 319);
            this.languageChart.TabIndex = 22;
            // 
            // ratingsChart
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.ratingsChart.Diagram = xyDiagram1;
            this.ratingsChart.Legend.Name = "Default Legend";
            this.ratingsChart.Location = new System.Drawing.Point(56, 45);
            this.ratingsChart.Name = "ratingsChart";
            series3.Name = "Imdb Ratings";
            series3.View = pointSeriesView1;
            series4.Name = "Avearage Rating";
            series4.View = lineSeriesView1;
            this.ratingsChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3,
        series4};
            this.ratingsChart.Size = new System.Drawing.Size(500, 319);
            this.ratingsChart.TabIndex = 21;
            // 
            // genreChart
            // 
            this.genreChart.Legend.Name = "Default Legend";
            this.genreChart.Location = new System.Drawing.Point(627, 45);
            this.genreChart.Name = "genreChart";
            series5.LegendTextPattern = "{A}";
            series5.Name = "Series 1";
            series5.View = pieSeriesView3;
            this.genreChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series5};
            this.genreChart.Size = new System.Drawing.Size(500, 319);
            this.genreChart.TabIndex = 20;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 765);
            this.Controls.Add(this.panelControl1);
            this.Name = "StatisticsForm";
            this.Text = "Statistics";
            this.Activated += new System.EventHandler(this.StatisticsForm_Activated);
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraCharts.ChartControl countryChart;
        private DevExpress.XtraCharts.ChartControl languageChart;
        private DevExpress.XtraCharts.ChartControl ratingsChart;
        private DevExpress.XtraCharts.ChartControl genreChart;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}