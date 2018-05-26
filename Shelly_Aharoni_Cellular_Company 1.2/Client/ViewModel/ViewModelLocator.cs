using Client.Pages;
using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;

namespace Client.ViewModel
{
    public class ViewModelLocator
    {
        private const string CustomerPageKey = "CustomerPage";
        private const string LinePageKey = "LinePage";

        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            var nav = new NavigationService();

            nav.Configure(CustomerPageKey,typeof(CustomerDetailsPage));
            nav.Configure(LinePageKey, typeof(LineDetailsPage));

            SimpleIoc.Default.Register<INavigationService>(() => nav);

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<CustomerViewModel>();
            SimpleIoc.Default.Register<LineViewModel>();

        }

        public MainViewModel MainVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public CustomerViewModel CustomerVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<CustomerViewModel>();
            }
        }

        public LineViewModel LineVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<LineViewModel>();
            }
        }
        
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}