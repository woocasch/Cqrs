namespace Lnow.Libraries.Cqrs
{
    public interface IQueryHandler<TQuery, TResult>
        where TResult : IResult
        where TQuery : IQuery<TResult>
    {
        TResult Fetch(TQuery query);
    }
}