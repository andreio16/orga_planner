using BusinessCore.Interfaces;

using DevExpress.Xpf.Accordion;

using System.Windows;

namespace ORGA_PLANNER.Application.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Orga-Planner";
        }

        private void AccordionControl_SelectedItemChanged(object sender, AccordionSelectedItemChangedEventArgs e)
        {
            var selection = ((AccordionControl)sender).SelectedItem as IAccordionControlBar;
            if(selection != null) 
            {
                //TODO: navigate to selection.DefaultNavigationPath 

            }
        }
    }
}
