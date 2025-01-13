namespace Presentation.Views.Setting
{
    public partial class SettingView : DevExpress.XtraEditors.XtraUserControl, ISettingView
    {
        #region ISettingView
        public SettingPresenter Presenter { get; set; }
        #endregion

        public SettingView()
        {
            InitializeComponent();
        }
    }
}
