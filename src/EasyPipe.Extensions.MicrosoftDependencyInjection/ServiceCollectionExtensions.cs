using System;
using EasyPipe.Internal;
using Microsoft.Extensions.DependencyInjection;

namespace EasyPipe.Extensions.MicrosoftDependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static PipelineBuilder<TRequest, TResponse> AddPipeline<TRequest, TResponse>(this IServiceCollection services)
        {
            var builder = new PipelineBuilder<TRequest, TResponse>(services);

            services.AddTransient<IPipeline<TRequest, TResponse>>(sp =>
            {
                return new LazyPipeline<TRequest, TResponse>(sp, builder.Middlewares);
            });
            
            return builder;
        } 
    }
}