namespace Presentation.Views.Ticket
{
    public partial class TicketView : DevExpress.XtraEditors.XtraUserControl, ITicketView
    {
        #region ITicketView
        public TicketPresenter Presenter { get; set; }
        #endregion

        public TicketView()
        {
            InitializeComponent();
        }
    }
}
