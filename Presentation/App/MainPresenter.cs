using CoreLib;

namespace Presentation.App
{
    public class MainPresenter : BasePresenter<IMainView>
    {
        public MainPresenter(IMainView view) : base(view) { }

        protected override void OnInitializePresenter()
        {
            View.OpenMenuEvent += (s, e) => View.OpenMenu(e);
        }
    }
}
