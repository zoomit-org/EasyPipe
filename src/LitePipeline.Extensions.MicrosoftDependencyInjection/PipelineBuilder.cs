using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace LitePipeline.Extensions.MicrosoftDependencyInjection
{
    public class PipelineBuilder<TRequest, TResponse>
    {
        private readonly IServiceCollection _services;

        internal List<Type> Middlewares { get; }

        public PipelineBuilder(IServiceCollection services)
        {
            _services = services;
            Middlewares = new();
        }

        public PipelineBuilder<TRequest, TResponse> WithMiddleware<TMiddleware>()
            where TMiddleware : class, IMiddleware<TRequest, TResponse>
        {
            _services.AddTransient<TMiddleware>();
            Middlewares.Add(typeof(TMiddleware));

            return this;
        }
    }
}