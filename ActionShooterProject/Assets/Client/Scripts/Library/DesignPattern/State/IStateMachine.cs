public interface IStateMachine<T>
{
    // in using this interface, the class needs declaration their variables
    //private IState<T> _state;
    //private bool isInitialized = false;

    public void InitState(IState<T> state, T obj);
    public void UpdateState(T obj);
}
