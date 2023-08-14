using BusinessCore.Interfaces;

using Prism.Commands;

namespace BusinessCore.Commands
{
    public class ApplicationCommands : IApplicationCommands
    {
        public CompositeCommand NavigateCommand { get; } = new CompositeCommand();
    }
}
