namespace ShowroomManagermentSystem.Application.Common.Behaviors
{
    internal class ValidationContext<TRequest> where TRequest : notnull
    {
        private TRequest request;

        public ValidationContext(TRequest request)
        {
            this.request = request;
        }
    }
}