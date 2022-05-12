using System.Collections.Concurrent;

namespace Sim.Core;

public interface ICanvasSerializaton<TModel>
    : ICanvasShape<TModel>
{
    void Load();

    void Render(BlockingCollection<TModel> shapes);

    void Render(List<TModel> shapes);

    void Save();

    void RunDispatcher(Action action);
}