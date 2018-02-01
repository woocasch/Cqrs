namespace Lnow.Libraries.Cqrs
{
    public interface IQuery<TResult> : ILoad
        where TResult : IResult
    {

    }
}