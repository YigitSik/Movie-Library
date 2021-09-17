using MovieLibrary.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLibrary
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        FavouritesForm favouritesForm;
        MovieForm movieForm;
        WatchListForm watchListForm;
        StatisticsForm statisticsForm;

        private void favouritesBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (favouritesForm == null || favouritesForm.IsDisposed)
            {
                favouritesForm = new FavouritesForm();
                favouritesForm.MdiParent = this;
                favouritesForm.Show();
            }
            else
            {
                favouritesForm.Select();

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (movieForm == null || movieForm.IsDisposed)
            {
                movieForm = new MovieForm();
                movieForm.MdiParent = this;
                movieForm.Show();
            }
            else
            {
                movieForm.Select();
            }

        }

        private void watchListBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (watchListForm == null || watchListForm.IsDisposed)
            {
                watchListForm = new WatchListForm();
                watchListForm.MdiParent = this;
                watchListForm.Show();
            }
            else
            {
                watchListForm.Select();
            }
            

        }

        private void homeScreenBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (movieForm == null || movieForm.IsDisposed)
            {
                movieForm = new MovieForm();
                movieForm.MdiParent = this;
                movieForm.Show();
            }
            else
            {
                movieForm.Select();
            }
         
        }

        private void statisticsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (statisticsForm == null || statisticsForm.IsDisposed)
            {
                statisticsForm = new StatisticsForm();
                statisticsForm.MdiParent = this;
                statisticsForm.Show();
            }
            else
            {
                statisticsForm.Select();
            }
        }

    }
}
