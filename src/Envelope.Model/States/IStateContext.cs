namespace Envelope.Model.States;

public interface IStateContext
{
}

public interface IStateContext<TEntity, TState> : IStateContext
	where TState : IState<TEntity>
{
	TEntity Entity { get; }
	TState CurrentState { get; }
}
