using Business.Ticket;
using CoreLib;

namespace Presentation.Views.Ticket
{
    public class TicketPresenter : BasePresenter<ITicketView>
    {
        #region BasePresenter<ITicketView>
        protected override void OnInitializePresenter() { }
        #endregion

        private ITicketBLL bll;

        public TicketPresenter(ITicketView v, ITicketBLL bll) : base(v)
        {
            this.bll = bll;
        }
    }
}
