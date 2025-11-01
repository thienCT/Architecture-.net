
namespace ShowroomManagermentSystem.Application.Common.Behaviors
{
    internal interface IValidator<TRequest> where TRequest : notnull
    {
        Task ValidateAsync<TRequest>(ValidationContext<TRequest> context, CancellationToken ct) where TRequest : notnull;
    }
}