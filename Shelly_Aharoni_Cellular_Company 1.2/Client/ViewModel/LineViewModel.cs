using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client.ViewModel
{
    public class LineViewModel:ViewModelBase
    {
        private readonly INavigationService _navigationService;
        public LineViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
