using Business.Setting;
using CoreLib;

namespace Presentation.Views.Setting
{
    public class SettingPresenter : BasePresenter<ISettingView>
    {
        #region BasePresenter<ISettingView>
        protected override void OnInitializePresenter() { }
        #endregion

        private ISettingBLL bll;

        public SettingPresenter(ISettingView v, ISettingBLL bll) : base(v)
        {
            this.bll = bll;
        }
    }
}
