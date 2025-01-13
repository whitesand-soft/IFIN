namespace CoreLib
{
    public abstract class BasePresenter<TView>
    {
        public TView View { get; private set; }

        protected BasePresenter(TView view)
        {
            View = view;
            OnInitializePresenter();
        }

        protected abstract void OnInitializePresenter();
    }
}
