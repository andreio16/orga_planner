using BusinessCore;
using BusinessCore.Interfaces;

using DevExpress.Xpf.Accordion;

using Prism.Regions;

using System.Windows;

namespace ORGA_PLANNER.Application.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IApplicationCommands _applicationCommands;
        private readonly IRegionManager _regionManager;

        public MainWindow(IApplicationCommands applicationCommands, IRegionManager regionManager)
        {
            InitializeComponent();
            this.Title = "Orga-Planner";
            this._applicationCommands = applicationCommands;
            this._regionManager = regionManager;
        }

        private void AccordionControl_SelectedItemChanged(object sender, AccordionSelectedItemChangedEventArgs e)
        {
            var selection = ((AccordionControl)sender).SelectedItem as IAccordionControlBar;
            if(selection != null) 
            {
                //TODO: navigate to selection.DefaultNavigationPath 
                _applicationCommands.NavigateCommand.Execute(selection.DefaultNavigationPath);
            }
        }
    }
}
