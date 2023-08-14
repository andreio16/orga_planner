using Prism.Commands;

namespace BusinessCore.Interfaces
{
    public interface IApplicationCommands
    {
        CompositeCommand NavigateCommand { get; }
    }
}
