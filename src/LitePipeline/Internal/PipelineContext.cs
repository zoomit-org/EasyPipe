namespace LitePipeline.Internal
{
    internal class PipelineContext : IPipelineContext
    {
        public PipelineContext()
        {
            Data = new PipelineContextData();
        }

        public IPipelineContextData Data { get; }
    }
}