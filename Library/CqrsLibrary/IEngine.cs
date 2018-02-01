namespace Lnow.Libraries.Cqrs
{
    public interface IEngine
    {
        void Handle<TCommand>(TCommand command)
            where TCommand : ICommand;

        TResult Fetch<TQuery, TResult>(TQuery query)
            where TResult : IResult
            where TQuery  : IQuery<TResult>;
    }
}