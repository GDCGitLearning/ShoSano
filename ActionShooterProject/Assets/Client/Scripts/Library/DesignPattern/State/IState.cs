public interface IState<T>
{
    public abstract void Enter(T obj);
    public abstract IState<T> Update(T obj);
    public abstract void Exit(T obj);
}
