using System;
using static Presentation.Common.UICommon;

namespace Presentation.App
{
    public interface IMainView
    {
        MainPresenter Presenter { get; }

        event EventHandler<MENU> OpenMenuEvent;

        void OpenMenu(MENU menu);
    }
}
