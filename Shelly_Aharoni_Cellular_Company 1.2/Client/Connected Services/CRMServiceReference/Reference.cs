﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 15.0.27428.2043
// 
namespace Client.CRMServiceReference {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LineDto", Namespace="http://schemas.datacontract.org/2004/07/Common.Dtoes")]
    public partial class LineDto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private Client.CRMServiceReference.CustomerDto CustomerField;
        
        private int CustomerIdField;
        
        private int LineIdField;
        
        private string NumberField;
        
        private Client.CRMServiceReference.PackageDto PackageField;
        
        private int PackageIdField;
        
        private Client.CRMServiceReference.PackageIncludeDto PackageIncludeField;
        
        private int PackageIncludeIdField;
        
        private Client.CRMServiceReference.Status StatusField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.CRMServiceReference.CustomerDto Customer {
            get {
                return this.CustomerField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerField, value) != true)) {
                    this.CustomerField = value;
                    this.RaisePropertyChanged("Customer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((this.CustomerIdField.Equals(value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LineId {
            get {
                return this.LineIdField;
            }
            set {
                if ((this.LineIdField.Equals(value) != true)) {
                    this.LineIdField = value;
                    this.RaisePropertyChanged("LineId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Number {
            get {
                return this.NumberField;
            }
            set {
                if ((object.ReferenceEquals(this.NumberField, value) != true)) {
                    this.NumberField = value;
                    this.RaisePropertyChanged("Number");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.CRMServiceReference.PackageDto Package {
            get {
                return this.PackageField;
            }
            set {
                if ((object.ReferenceEquals(this.PackageField, value) != true)) {
                    this.PackageField = value;
                    this.RaisePropertyChanged("Package");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PackageId {
            get {
                return this.PackageIdField;
            }
            set {
                if ((this.PackageIdField.Equals(value) != true)) {
                    this.PackageIdField = value;
                    this.RaisePropertyChanged("PackageId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.CRMServiceReference.PackageIncludeDto PackageInclude {
            get {
                return this.PackageIncludeField;
            }
            set {
                if ((object.ReferenceEquals(this.PackageIncludeField, value) != true)) {
                    this.PackageIncludeField = value;
                    this.RaisePropertyChanged("PackageInclude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PackageIncludeId {
            get {
                return this.PackageIncludeIdField;
            }
            set {
                if ((this.PackageIncludeIdField.Equals(value) != true)) {
                    this.PackageIncludeIdField = value;
                    this.RaisePropertyChanged("PackageIncludeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.CRMServiceReference.Status Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomerDto", Namespace="http://schemas.datacontract.org/2004/07/Common.Dtoes")]
    public partial class CustomerDto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string AddressField;
        
        private System.Nullable<int> CallsToCenterField;
        
        private string ContactNumberField;
        
        private int CustomerIdField;
        
        private Client.CRMServiceReference.CustomerTypeDto CustomerTypeField;
        
        private int CustomerTypeIdField;
        
        private string FirstNameField;
        
        private string LastNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> CallsToCenter {
            get {
                return this.CallsToCenterField;
            }
            set {
                if ((this.CallsToCenterField.Equals(value) != true)) {
                    this.CallsToCenterField = value;
                    this.RaisePropertyChanged("CallsToCenter");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContactNumber {
            get {
                return this.ContactNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactNumberField, value) != true)) {
                    this.ContactNumberField = value;
                    this.RaisePropertyChanged("ContactNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((this.CustomerIdField.Equals(value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.CRMServiceReference.CustomerTypeDto CustomerType {
            get {
                return this.CustomerTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerTypeField, value) != true)) {
                    this.CustomerTypeField = value;
                    this.RaisePropertyChanged("CustomerType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CustomerTypeId {
            get {
                return this.CustomerTypeIdField;
            }
            set {
                if ((this.CustomerTypeIdField.Equals(value) != true)) {
                    this.CustomerTypeIdField = value;
                    this.RaisePropertyChanged("CustomerTypeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PackageDto", Namespace="http://schemas.datacontract.org/2004/07/Common.Dtoes")]
    public partial class PackageDto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int PackageIdField;
        
        private string PackageNameField;
        
        private double PackageTotalPriceField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PackageId {
            get {
                return this.PackageIdField;
            }
            set {
                if ((this.PackageIdField.Equals(value) != true)) {
                    this.PackageIdField = value;
                    this.RaisePropertyChanged("PackageId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PackageName {
            get {
                return this.PackageNameField;
            }
            set {
                if ((object.ReferenceEquals(this.PackageNameField, value) != true)) {
                    this.PackageNameField = value;
                    this.RaisePropertyChanged("PackageName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double PackageTotalPrice {
            get {
                return this.PackageTotalPriceField;
            }
            set {
                if ((this.PackageTotalPriceField.Equals(value) != true)) {
                    this.PackageTotalPriceField = value;
                    this.RaisePropertyChanged("PackageTotalPrice");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PackageIncludeDto", Namespace="http://schemas.datacontract.org/2004/07/Common.Dtoes")]
    public partial class PackageIncludeDto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private double DiscountPrecentageField;
        
        private System.Nullable<int> FavoriteNumbersIdField;
        
        private double FixedPriceField;
        
        private string IncludeNameField;
        
        private bool InsideFamilyCallsField;
        
        private int MaxMinuteField;
        
        private string MostCalledNumberField;
        
        private int PackageIncludeIdField;
        
        private Client.CRMServiceReference.SelectedNumberDto SelectedNumberField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double DiscountPrecentage {
            get {
                return this.DiscountPrecentageField;
            }
            set {
                if ((this.DiscountPrecentageField.Equals(value) != true)) {
                    this.DiscountPrecentageField = value;
                    this.RaisePropertyChanged("DiscountPrecentage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> FavoriteNumbersId {
            get {
                return this.FavoriteNumbersIdField;
            }
            set {
                if ((this.FavoriteNumbersIdField.Equals(value) != true)) {
                    this.FavoriteNumbersIdField = value;
                    this.RaisePropertyChanged("FavoriteNumbersId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double FixedPrice {
            get {
                return this.FixedPriceField;
            }
            set {
                if ((this.FixedPriceField.Equals(value) != true)) {
                    this.FixedPriceField = value;
                    this.RaisePropertyChanged("FixedPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IncludeName {
            get {
                return this.IncludeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.IncludeNameField, value) != true)) {
                    this.IncludeNameField = value;
                    this.RaisePropertyChanged("IncludeName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool InsideFamilyCalls {
            get {
                return this.InsideFamilyCallsField;
            }
            set {
                if ((this.InsideFamilyCallsField.Equals(value) != true)) {
                    this.InsideFamilyCallsField = value;
                    this.RaisePropertyChanged("InsideFamilyCalls");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MaxMinute {
            get {
                return this.MaxMinuteField;
            }
            set {
                if ((this.MaxMinuteField.Equals(value) != true)) {
                    this.MaxMinuteField = value;
                    this.RaisePropertyChanged("MaxMinute");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MostCalledNumber {
            get {
                return this.MostCalledNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.MostCalledNumberField, value) != true)) {
                    this.MostCalledNumberField = value;
                    this.RaisePropertyChanged("MostCalledNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PackageIncludeId {
            get {
                return this.PackageIncludeIdField;
            }
            set {
                if ((this.PackageIncludeIdField.Equals(value) != true)) {
                    this.PackageIncludeIdField = value;
                    this.RaisePropertyChanged("PackageIncludeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.CRMServiceReference.SelectedNumberDto SelectedNumber {
            get {
                return this.SelectedNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.SelectedNumberField, value) != true)) {
                    this.SelectedNumberField = value;
                    this.RaisePropertyChanged("SelectedNumber");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Status", Namespace="http://schemas.datacontract.org/2004/07/")]
    public enum Status : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Available = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Used = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Stolen = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Blocked = 3,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomerTypeDto", Namespace="http://schemas.datacontract.org/2004/07/Common.Dtoes")]
    public partial class CustomerTypeDto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int CustomerTypeIdField;
        
        private double MinutePriceField;
        
        private double SMSPriceField;
        
        private string TypeNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CustomerTypeId {
            get {
                return this.CustomerTypeIdField;
            }
            set {
                if ((this.CustomerTypeIdField.Equals(value) != true)) {
                    this.CustomerTypeIdField = value;
                    this.RaisePropertyChanged("CustomerTypeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double MinutePrice {
            get {
                return this.MinutePriceField;
            }
            set {
                if ((this.MinutePriceField.Equals(value) != true)) {
                    this.MinutePriceField = value;
                    this.RaisePropertyChanged("MinutePrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double SMSPrice {
            get {
                return this.SMSPriceField;
            }
            set {
                if ((this.SMSPriceField.Equals(value) != true)) {
                    this.SMSPriceField = value;
                    this.RaisePropertyChanged("SMSPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TypeName {
            get {
                return this.TypeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeNameField, value) != true)) {
                    this.TypeNameField = value;
                    this.RaisePropertyChanged("TypeName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SelectedNumberDto", Namespace="http://schemas.datacontract.org/2004/07/Common.Dtoes")]
    public partial class SelectedNumberDto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string FirstNumberField;
        
        private string SecondNumberField;
        
        private int SelectedNumberIdField;
        
        private string ThirdNumberField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstNumber {
            get {
                return this.FirstNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNumberField, value) != true)) {
                    this.FirstNumberField = value;
                    this.RaisePropertyChanged("FirstNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SecondNumber {
            get {
                return this.SecondNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.SecondNumberField, value) != true)) {
                    this.SecondNumberField = value;
                    this.RaisePropertyChanged("SecondNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SelectedNumberId {
            get {
                return this.SelectedNumberIdField;
            }
            set {
                if ((this.SelectedNumberIdField.Equals(value) != true)) {
                    this.SelectedNumberIdField = value;
                    this.RaisePropertyChanged("SelectedNumberId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ThirdNumber {
            get {
                return this.ThirdNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.ThirdNumberField, value) != true)) {
                    this.ThirdNumberField = value;
                    this.RaisePropertyChanged("ThirdNumber");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CRMServiceReference.ICRMService")]
    public interface ICRMService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/AddFullLine", ReplyAction="http://tempuri.org/ICRMService/AddFullLineResponse")]
        System.Threading.Tasks.Task<bool> AddFullLineAsync(Client.CRMServiceReference.LineDto line, Client.CRMServiceReference.PackageIncludeDto packageInclude, Client.CRMServiceReference.SelectedNumberDto selectedNumber, Client.CRMServiceReference.CustomerDto customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/AddCustomer", ReplyAction="http://tempuri.org/ICRMService/AddCustomerResponse")]
        System.Threading.Tasks.Task<Client.CRMServiceReference.CustomerDto> AddCustomerAsync(Client.CRMServiceReference.CustomerDto customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/RemoveCustomer", ReplyAction="http://tempuri.org/ICRMService/RemoveCustomerResponse")]
        System.Threading.Tasks.Task<Client.CRMServiceReference.CustomerDto> RemoveCustomerAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/RemoveLine", ReplyAction="http://tempuri.org/ICRMService/RemoveLineResponse")]
        System.Threading.Tasks.Task<Client.CRMServiceReference.LineDto> RemoveLineAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/UpdateCustomer", ReplyAction="http://tempuri.org/ICRMService/UpdateCustomerResponse")]
        System.Threading.Tasks.Task<Client.CRMServiceReference.CustomerDto> UpdateCustomerAsync(Client.CRMServiceReference.CustomerDto customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/UpdateLine", ReplyAction="http://tempuri.org/ICRMService/UpdateLineResponse")]
        System.Threading.Tasks.Task<Client.CRMServiceReference.LineDto> UpdateLineAsync(int lineId, Client.CRMServiceReference.LineDto line);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/GetSelectedNumbers", ReplyAction="http://tempuri.org/ICRMService/GetSelectedNumbersResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<string>> GetSelectedNumbersAsync(int lineId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/GetAllCustomers", ReplyAction="http://tempuri.org/ICRMService/GetAllCustomersResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<Client.CRMServiceReference.CustomerDto>> GetAllCustomersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/GetCustomersIds", ReplyAction="http://tempuri.org/ICRMService/GetCustomersIdsResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<int>> GetCustomersIdsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/GetCustomerTypes", ReplyAction="http://tempuri.org/ICRMService/GetCustomerTypesResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<Client.CRMServiceReference.CustomerTypeDto>> GetCustomerTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/GetPackages", ReplyAction="http://tempuri.org/ICRMService/GetPackagesResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<Client.CRMServiceReference.PackageDto>> GetPackagesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRMService/GetLineForCustomer", ReplyAction="http://tempuri.org/ICRMService/GetLineForCustomerResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<Client.CRMServiceReference.LineDto>> GetLineForCustomerAsync(int customerId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICRMServiceChannel : Client.CRMServiceReference.ICRMService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CRMServiceClient : System.ServiceModel.ClientBase<Client.CRMServiceReference.ICRMService>, Client.CRMServiceReference.ICRMService {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public CRMServiceClient() : 
                base(CRMServiceClient.GetDefaultBinding(), CRMServiceClient.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ICRMService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CRMServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(CRMServiceClient.GetBindingForEndpoint(endpointConfiguration), CRMServiceClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CRMServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(CRMServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CRMServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(CRMServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CRMServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task<bool> AddFullLineAsync(Client.CRMServiceReference.LineDto line, Client.CRMServiceReference.PackageIncludeDto packageInclude, Client.CRMServiceReference.SelectedNumberDto selectedNumber, Client.CRMServiceReference.CustomerDto customer) {
            return base.Channel.AddFullLineAsync(line, packageInclude, selectedNumber, customer);
        }
        
        public System.Threading.Tasks.Task<Client.CRMServiceReference.CustomerDto> AddCustomerAsync(Client.CRMServiceReference.CustomerDto customer) {
            return base.Channel.AddCustomerAsync(customer);
        }
        
        public System.Threading.Tasks.Task<Client.CRMServiceReference.CustomerDto> RemoveCustomerAsync(int id) {
            return base.Channel.RemoveCustomerAsync(id);
        }
        
        public System.Threading.Tasks.Task<Client.CRMServiceReference.LineDto> RemoveLineAsync(int id) {
            return base.Channel.RemoveLineAsync(id);
        }
        
        public System.Threading.Tasks.Task<Client.CRMServiceReference.CustomerDto> UpdateCustomerAsync(Client.CRMServiceReference.CustomerDto customer) {
            return base.Channel.UpdateCustomerAsync(customer);
        }
        
        public System.Threading.Tasks.Task<Client.CRMServiceReference.LineDto> UpdateLineAsync(int lineId, Client.CRMServiceReference.LineDto line) {
            return base.Channel.UpdateLineAsync(lineId, line);
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<string>> GetSelectedNumbersAsync(int lineId) {
            return base.Channel.GetSelectedNumbersAsync(lineId);
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<Client.CRMServiceReference.CustomerDto>> GetAllCustomersAsync() {
            return base.Channel.GetAllCustomersAsync();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<int>> GetCustomersIdsAsync() {
            return base.Channel.GetCustomersIdsAsync();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<Client.CRMServiceReference.CustomerTypeDto>> GetCustomerTypesAsync() {
            return base.Channel.GetCustomerTypesAsync();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<Client.CRMServiceReference.PackageDto>> GetPackagesAsync() {
            return base.Channel.GetPackagesAsync();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<Client.CRMServiceReference.LineDto>> GetLineForCustomerAsync(int customerId) {
            return base.Channel.GetLineForCustomerAsync(customerId);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ICRMService)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ICRMService)) {
                return new System.ServiceModel.EndpointAddress("http://localhost:57594/Services/CRMService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return CRMServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ICRMService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return CRMServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ICRMService);
        }
        
        public enum EndpointConfiguration {
            
            BasicHttpBinding_ICRMService,
        }
    }
}
