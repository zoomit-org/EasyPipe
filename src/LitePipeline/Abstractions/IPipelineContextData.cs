namespace LitePipeline
{
    public interface IPipelineContextData
    {
        T Get<T>();

        void Set<T>(T instance);
    }
}