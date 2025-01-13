using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Business.Dashboard;
using Business.Setting;
using Business.Ticket;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
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

        #region Close & Move Tabs
        private void screens_XtraTabControl_CloseButtonClick(object sender, EventArgs e)
        {
            var page = (e as ClosePageButtonEventArgs).Page as XtraTabPage;
            screens_XtraTabControl.TabPages.Remove(page);

            var menu = tabs.Where(kvp => kvp.Value == page)
                           .Select(kvp => kvp.Key)
                           .Single();

            tabs.Remove(menu);
        }

        private Point point = Point.Empty;

        private XtraTabPage page = null;    

        private void screens_XtraTabControl_MouseDown(object sender, MouseEventArgs e)
        {
            XtraTabControl t = sender as XtraTabControl;
            point = new Point(e.X, e.Y);
            XtraTabHitInfo hi = t?.CalcHitInfo(point);
            if (hi == null) return;
            page = hi.Page;
            if (hi.Page == null)
                point = Point.Empty;
        }

        private void screens_XtraTabControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                if ((point != Point.Empty) && (Math.Abs(e.X - point.X) > SystemInformation.DragSize.Width) || (Math.Abs(e.Y - point.Y) > SystemInformation.DragSize.Height))
                    screens_XtraTabControl.DoDragDrop(sender, DragDropEffects.Move);
        }

        private void screens_XtraTabControl_DragOver(object sender, DragEventArgs e)
        {
            XtraTabControl t = sender as XtraTabControl;
            if (t == null) return;
            XtraTabHitInfo hi = t.CalcHitInfo(t.PointToClient(new Point(e.X, e.Y)));
            if (hi.Page != null)
            {
                if (hi.Page != page)
                {
                    if (t.TabPages.IndexOf(hi.Page) < t.TabPages.IndexOf(page))
                        t.TabPages.Move(t.TabPages.IndexOf(hi.Page), page);
                    else
                        t.TabPages.Move(t.TabPages.IndexOf(hi.Page) + 1, page);
                }
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        #endregion
    }
}
