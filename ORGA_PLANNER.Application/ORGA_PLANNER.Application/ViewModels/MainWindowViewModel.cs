using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

using System;

namespace ORGA_PLANNER.Application.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        #region Fields
        private string _title = "Prism Application";
        private readonly IRegionManager _regionManager;
        private DelegateCommand<string> _navigateCommand;

        #endregion

        #region Properties
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public DelegateCommand<string> NavigateCommand =>
            _navigateCommand ?? (_navigateCommand = new DelegateCommand<string>(ExecuteNavigateCommandName));



        #endregion
        #region Constructor
        public MainWindowViewModel(IRegionManager regionManager)
        {
            this._regionManager = regionManager;
        }
        void ExecuteNavigateCommandName(string navigatePath)
        {
            if (string.IsNullOrEmpty(navigatePath))
                throw new ArgumentNullException();
        }
        #endregion
    }
}
