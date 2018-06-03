using Common.Dtoes;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client.ViewModel
{
    public class LineViewModel : ViewModelBase
    {
        //models properties
        public LineDto Line { get; set; }
        public LineDto SelectedLine { get; set; }
        public PackageIncludeDto PackageIncludes { get; set; }
        public SelectedNumberDto SelectedNumbers { get; set; }
        //boolean properties
        public bool PriceMinutesEnabled { get; set; }
        public bool FriendsEnabled { get; set; }
        public bool FavoriteNumberEnabled { get; set; }
        //observable collections
        public CustomObservableCollection<LineDto> Lines { get; set; }
        public ObservableCollection<CustomerDto> Customers { get; set; }
        public ObservableCollection<PackageDto> Packages { get; set; }
        //commands
        public ICommand SaveCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand ClearCommand { get; set; }
        public ICommand GoBackCommand { get; set; }
        //private fields
        private CustomerDto _customer;
        private bool _xMinYpriceIsChecked;
        private bool _friendsIsChecked;
        private bool _favoriteNumberIsChecked;
        //full properties
        public CustomerDto Customer
        {
            get { return _customer; }
            set
            {
                try
                {
                    _customer = value;
                    Task.Factory.StartNew(() =>
                    {
                        var list = ServicesInit.CRMService.GetLineForCustomerAsync(Customer.CustomerId).Result;
                        if (list != null)
                            this.Lines.Repopulate(list);
                        else Lines = null;
                    });
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }

        public bool FavoriteNumberIsChecked
        {
            get { return _favoriteNumberIsChecked; }
            set
            {
                if (_favoriteNumberIsChecked == value) return;
                _favoriteNumberIsChecked = value;
                FavoriteNumberEnabled = _favoriteNumberIsChecked ? true : false;
                RaisePropertyChanged(nameof(FavoriteNumberEnabled));
                RaisePropertyChanged(nameof(FavoriteNumberIsChecked));
            }
        }

        public bool FriendsIsChecked
        {
            get { return _friendsIsChecked; }
            set
            {
                if (_friendsIsChecked == value) return;
                _friendsIsChecked = value;
                FriendsEnabled = _friendsIsChecked ? true : false;
                RaisePropertyChanged(nameof(FriendsEnabled));
                RaisePropertyChanged(nameof(FriendsIsChecked));
            }
        }

        public bool XMinYpriceIsChecked
        {
            get { return _xMinYpriceIsChecked; }
            set
            {
                if (_xMinYpriceIsChecked == value) return;
                _xMinYpriceIsChecked = value;
                PriceMinutesEnabled = _xMinYpriceIsChecked ? true : false;
                RaisePropertyChanged(nameof(XMinYpriceIsChecked));
                RaisePropertyChanged(nameof(PriceMinutesEnabled));
            }
        }
        //members
        private readonly INavigationService _navigationService;
        //ctor
        public LineViewModel(INavigationService navigationService)
        {
            try
            {
                _navigationService = navigationService;
                SelectedLine = new LineDto();
                Line = new LineDto();
                PackageIncludes = new PackageIncludeDto();
                SelectedNumbers = new SelectedNumberDto();
                Lines = new CustomObservableCollection<LineDto>();
                InitializeObservableCollections();
                InitializeCommands();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        //methods
        private void InitializeObservableCollections()
        {

            var packagesTask = Task.Factory.StartNew(() => ServicesInit.CRMService.GetPackagesAsync());
            var p = packagesTask.Result;
            Packages = new ObservableCollection<PackageDto>(p.Result);
            RaisePropertyChanged(nameof(Lines));

            var clientsTask = Task.Factory.StartNew(() => ServicesInit.CRMService.GetAllCustomersAsync());
            Customers = new ObservableCollection<CustomerDto>(clientsTask.Result.Result);
            RaisePropertyChanged(nameof(Customers));
        }

        private void InitializeCommands()
        {
            SaveCommand = new RelayCommand(() =>
            {
                Line.Customer = Customer;
                Line.CustomerId = Customer.CustomerId;
                Line.Status = Status.Available;
                if (SelectedLine.LineId == 0)
                    ServicesInit.CRMService.AddFullLineAsync(Line, PackageIncludes, SelectedNumbers, Customer);
                else
                    ServicesInit.CRMService.UpdateLineAsync(SelectedLine.LineId, Line);
            });
            ClearCommand = new RelayCommand(() =>
            {
                Line = null;
                PackageIncludes = null;
                SelectedNumbers = null;
                SelectedLine = null;
                RaisePropertyChanged(nameof(Line));
                RaisePropertyChanged(nameof(PackageIncludes));
                RaisePropertyChanged(nameof(SelectedNumbers));
                RaisePropertyChanged(nameof(SelectedLine));
                FavoriteNumberIsChecked = false;
                FriendsIsChecked = false;
                XMinYpriceIsChecked = false;
            });
            DeleteCommand = new RelayCommand(() =>
            {
                ServicesInit.CRMService.RemoveLineAsync(SelectedLine.LineId);
            });
            GoBackCommand = new RelayCommand(() =>
            {
                _navigationService.GoBack();
            });
        }
    }
}
