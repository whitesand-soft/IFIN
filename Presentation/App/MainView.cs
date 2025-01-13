using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraTab;
using Presentation.Properties;
using static Presentation.Common.UICommon;

namespace Presentation.App
{
    public partial class MainView : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm, IMainView
    {
        public MainView()
        {
            InitializeComponent();
        }

        #region IMainView
        public MainPresenter Presenter { get; set; }

        public event EventHandler<MENU> OpenMenuEvent;

        private Dictionary<MENU, XtraTabPage> tabs = new Dictionary<MENU, XtraTabPage>();

        public void OpenMenu(MENU menu)
        {
            if (!tabs.ContainsKey(menu))
            {
                var page = new XtraTabPage();
                page.Text = _GetTabCaption(menu);

                var uc = _GetUserControl(menu);
                uc.Dock = DockStyle.Fill;
                page.Controls.Add(uc);

                tabs.Add(menu, page);
                screens_XtraTabControl.TabPages.Add(page);
            }

            screens_XtraTabControl.SelectedTabPage = tabs[menu];
        }
        #endregion

        #region private methods
        private string _GetTabCaption(MENU menu)
        {
            switch (menu)
            {
                case MENU.DASHBOARD:
                    return Resources.Dashboard;
                case MENU.TICKET:
                    return Resources.Ticket;
                case MENU.SETTING:
                    return Resources.Setting;
                default:
                    return null;
            }
        }

        private UserControl _GetUserControl(MENU menu)
        {
            UserControl control = null;

            switch (menu)
            {
                case MENU.DASHBOARD:
                    break;
                case MENU.TICKET:
                    break;
                case MENU.SETTING:
                    break;
                default:
                    break;
            }

            return control;
        }
        #endregion
    }
}
