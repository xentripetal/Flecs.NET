using Flecs.NET.Codegen.Helpers;
using Flecs.NET.Codegen.Generators;

Generate<AlertBuilder>();
Generate<BindingContext>();
Generate<Ecs>();
Generate<Entity>();
Generate<IIterable>();
Generate<Invoker>();
Generate<IterIterable>();
Generate<Observer>();
Generate<ObserverBuilder>();
Generate<PageIterable>();
Generate<Pipeline>();
Generate<PipelineBuilder>();
Generate<Query>();
Generate<QueryBuilder>();
Generate<System_>();
Generate<SystemBuilder>();
Generate<TypeHelper>();
Generate<WorkerIterable>();
Generate<World>();

return;

static void Generate<T>() where T : GeneratorBase, new()
{
    new T().Generate();
}
