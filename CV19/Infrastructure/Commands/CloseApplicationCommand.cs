using CV19.Infrastructure.Commands.Base;

using System.Windows;

namespace CV19.Infrastructure.Commands
{
    /// <summary>
    /// Команда закрытия приложения.
    /// </summary>
    internal class CloseApplicationCommand : Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter) => Application.Current.Shutdown();
    }
}