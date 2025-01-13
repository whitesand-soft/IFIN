namespace Presentation.Views.Dashboard
{
    public partial class DashboardView : DevExpress.XtraEditors.XtraUserControl, IDashboardView
    {
        #region IDashboardView
        public DashboardPresenter Presenter { get; set; }
        #endregion

        public DashboardView()
        {
            InitializeComponent();
        }
    }
}
