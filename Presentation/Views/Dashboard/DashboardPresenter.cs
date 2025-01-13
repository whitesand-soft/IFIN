using Business.Dashboard;
using CoreLib;

namespace Presentation.Views.Dashboard
{
    public class DashboardPresenter : BasePresenter<IDashboardView>
    {
        #region BasePresenter<IDashboardView>
        protected override void OnInitializePresenter() { }
        #endregion

        private IDashboardBLL bll;

        public DashboardPresenter(IDashboardView v, IDashboardBLL bll) : base(v)
        {
            this.bll = bll;
        }
    }
}
