using System.Threading;
using System.Threading.Tasks;

namespace LitePipeline
{
    public interface IPipeline<in TRequest, TResponse>
    {
        Task<TResponse> RunAsync(TRequest request,
                                 CancellationToken cancellationToken = default);
    }
}