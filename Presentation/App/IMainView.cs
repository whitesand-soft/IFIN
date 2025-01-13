using System;
using static Presentation.Common.UICommon;

namespace Presentation.App
{
    public interface IMainView
    {
        MainPresenter Presenter { set; }

        event EventHandler<MENU> OpenMenuEvent;

        void OpenMenu(MENU menu);
    }
}
