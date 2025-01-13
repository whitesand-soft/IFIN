using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Business.Dashboard;
using Business.Setting;
using Business.Ticket;
using DevExpress.XtraTab;
using Microsoft.Extensions.DependencyInjection;
using Presentation.Properties;
using Presentation.Views.Dashboard;
using Presentation.Views.Setting;
using Presentation.Views.Ticket;
using static Presentation.Common.UICommon;

namespace Presentation.App
{
    public partial class MainView : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm, IMainView
    {
        public MainView()
        {
            InitializeComponent();

            dashboard_AccordionControlElement.Click += (s, e) => OpenMenuEvent?.Invoke(this, MENU.DASHBOARD);
            ticket_AccordionControlElement.Click += (s, e) => OpenMenuEvent?.Invoke(this, MENU.TICKET);
            setting_AccordionControlElement.Click += (s, e) => OpenMenuEvent?.Invoke(this, MENU.SETTING);
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

        #region Private Methods
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
                    control = new DashboardView();
                    ((IDashboardView)control).Presenter = new DashboardPresenter((IDashboardView)control, IFIN.ServiceProvider.GetRequiredService<IDashboardBLL>());
                    break;
                case MENU.TICKET:
                    control = new TicketView();
                    ((ITicketView)control).Presenter = new TicketPresenter((ITicketView)control, IFIN.ServiceProvider.GetRequiredService<ITicketBLL>());
                    break;
                case MENU.SETTING:
                    control = new SettingView();
                    ((ISettingView)control).Presenter = new SettingPresenter((ISettingView)control, IFIN.ServiceProvider.GetRequiredService<ISettingBLL>());
                    break;
                default:
                    break;
            }

            return control;
        }
        #endregion
    }
}
