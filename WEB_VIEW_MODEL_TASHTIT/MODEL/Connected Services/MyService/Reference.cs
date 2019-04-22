﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MODEL.MyService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="Cities", Namespace="http://schemas.datacontract.org/2004/07/MODEL", ItemName="City")]
    [System.SerializableAttribute()]
    public class Cities : System.Collections.Generic.List<MODEL.MyService.City> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="City", Namespace="http://schemas.datacontract.org/2004/07/MODEL")]
    [System.SerializableAttribute()]
    public partial class City : MODEL.MyService.BaseEntity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseEntity", Namespace="http://schemas.datacontract.org/2004/07/MODEL")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MODEL.MyService.AreaCode))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MODEL.MyService.Brand))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MODEL.MyService.Category))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MODEL.MyService.Role))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MODEL.MyService.Size))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MODEL.MyService.City))]
    public partial class BaseEntity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MODEL.MyService.EntityStatus EntityStatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool checkValidationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HELPER.ErrorStatus statusField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MODEL.MyService.EntityStatus EntityStatus {
            get {
                return this.EntityStatusField;
            }
            set {
                if ((this.EntityStatusField.Equals(value) != true)) {
                    this.EntityStatusField = value;
                    this.RaisePropertyChanged("EntityStatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Num {
            get {
                return this.NumField;
            }
            set {
                if ((this.NumField.Equals(value) != true)) {
                    this.NumField = value;
                    this.RaisePropertyChanged("Num");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool checkValidation {
            get {
                return this.checkValidationField;
            }
            set {
                if ((this.checkValidationField.Equals(value) != true)) {
                    this.checkValidationField = value;
                    this.RaisePropertyChanged("checkValidation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HELPER.ErrorStatus status {
            get {
                return this.statusField;
            }
            set {
                if ((this.statusField.Equals(value) != true)) {
                    this.statusField = value;
                    this.RaisePropertyChanged("status");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AreaCode", Namespace="http://schemas.datacontract.org/2004/07/MODEL")]
    [System.SerializableAttribute()]
    public partial class AreaCode : MODEL.MyService.BaseEntity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Brand", Namespace="http://schemas.datacontract.org/2004/07/MODEL")]
    [System.SerializableAttribute()]
    public partial class Brand : MODEL.MyService.BaseEntity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Category", Namespace="http://schemas.datacontract.org/2004/07/MODEL")]
    [System.SerializableAttribute()]
    public partial class Category : MODEL.MyService.BaseEntity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Role", Namespace="http://schemas.datacontract.org/2004/07/MODEL")]
    [System.SerializableAttribute()]
    public partial class Role : MODEL.MyService.BaseEntity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Size", Namespace="http://schemas.datacontract.org/2004/07/MODEL")]
    [System.SerializableAttribute()]
    public partial class Size : MODEL.MyService.BaseEntity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.FlagsAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityStatus", Namespace="http://schemas.datacontract.org/2004/07/MODEL")]
    public enum EntityStatus : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Added = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Modified = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Deleted = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unchanged = 3,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="AreaCodes", Namespace="http://schemas.datacontract.org/2004/07/MODEL", ItemName="AreaCode")]
    [System.SerializableAttribute()]
    public class AreaCodes : System.Collections.Generic.List<MODEL.MyService.AreaCode> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="Brands", Namespace="http://schemas.datacontract.org/2004/07/MODEL", ItemName="Brand")]
    [System.SerializableAttribute()]
    public class Brands : System.Collections.Generic.List<MODEL.MyService.Brand> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="Categories", Namespace="http://schemas.datacontract.org/2004/07/MODEL", ItemName="Category")]
    [System.SerializableAttribute()]
    public class Categories : System.Collections.Generic.List<MODEL.MyService.Category> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="Roles", Namespace="http://schemas.datacontract.org/2004/07/MODEL", ItemName="Role")]
    [System.SerializableAttribute()]
    public class Roles : System.Collections.Generic.List<MODEL.MyService.Role> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="Sizes", Namespace="http://schemas.datacontract.org/2004/07/MODEL", ItemName="Size")]
    [System.SerializableAttribute()]
    public class Sizes : System.Collections.Generic.List<MODEL.MyService.Size> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyService.IMyService")]
    public interface IMyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/SelectAllCities", ReplyAction="http://tempuri.org/IMyService/SelectAllCitiesResponse")]
        MODEL.MyService.Cities SelectAllCities();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/SelectAllCities", ReplyAction="http://tempuri.org/IMyService/SelectAllCitiesResponse")]
        System.Threading.Tasks.Task<MODEL.MyService.Cities> SelectAllCitiesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/AddCity", ReplyAction="http://tempuri.org/IMyService/AddCityResponse")]
        bool AddCity(MODEL.MyService.City city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/AddCity", ReplyAction="http://tempuri.org/IMyService/AddCityResponse")]
        System.Threading.Tasks.Task<bool> AddCityAsync(MODEL.MyService.City city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/ModifyCity", ReplyAction="http://tempuri.org/IMyService/ModifyCityResponse")]
        bool ModifyCity(MODEL.MyService.City oldCity, MODEL.MyService.City newCity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/ModifyCity", ReplyAction="http://tempuri.org/IMyService/ModifyCityResponse")]
        System.Threading.Tasks.Task<bool> ModifyCityAsync(MODEL.MyService.City oldCity, MODEL.MyService.City newCity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/DeleteCity", ReplyAction="http://tempuri.org/IMyService/DeleteCityResponse")]
        bool DeleteCity(MODEL.MyService.City city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/DeleteCity", ReplyAction="http://tempuri.org/IMyService/DeleteCityResponse")]
        System.Threading.Tasks.Task<bool> DeleteCityAsync(MODEL.MyService.City city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/SelectAllAreaCodes", ReplyAction="http://tempuri.org/IMyService/SelectAllAreaCodesResponse")]
        MODEL.MyService.AreaCodes SelectAllAreaCodes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/SelectAllAreaCodes", ReplyAction="http://tempuri.org/IMyService/SelectAllAreaCodesResponse")]
        System.Threading.Tasks.Task<MODEL.MyService.AreaCodes> SelectAllAreaCodesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/AddAreaCode", ReplyAction="http://tempuri.org/IMyService/AddAreaCodeResponse")]
        bool AddAreaCode(MODEL.MyService.AreaCode areaCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/AddAreaCode", ReplyAction="http://tempuri.org/IMyService/AddAreaCodeResponse")]
        System.Threading.Tasks.Task<bool> AddAreaCodeAsync(MODEL.MyService.AreaCode areaCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/ModifyAreaCode", ReplyAction="http://tempuri.org/IMyService/ModifyAreaCodeResponse")]
        bool ModifyAreaCode(MODEL.MyService.AreaCode oldAreaCode, MODEL.MyService.AreaCode newAreaCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/ModifyAreaCode", ReplyAction="http://tempuri.org/IMyService/ModifyAreaCodeResponse")]
        System.Threading.Tasks.Task<bool> ModifyAreaCodeAsync(MODEL.MyService.AreaCode oldAreaCode, MODEL.MyService.AreaCode newAreaCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/DeleteAreaCode", ReplyAction="http://tempuri.org/IMyService/DeleteAreaCodeResponse")]
        bool DeleteAreaCode(MODEL.MyService.AreaCode areaCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/DeleteAreaCode", ReplyAction="http://tempuri.org/IMyService/DeleteAreaCodeResponse")]
        System.Threading.Tasks.Task<bool> DeleteAreaCodeAsync(MODEL.MyService.AreaCode areaCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/SelectAllBrands", ReplyAction="http://tempuri.org/IMyService/SelectAllBrandsResponse")]
        MODEL.MyService.Brands SelectAllBrands();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/SelectAllBrands", ReplyAction="http://tempuri.org/IMyService/SelectAllBrandsResponse")]
        System.Threading.Tasks.Task<MODEL.MyService.Brands> SelectAllBrandsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/AddBrand", ReplyAction="http://tempuri.org/IMyService/AddBrandResponse")]
        bool AddBrand(MODEL.MyService.Brand brand);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/AddBrand", ReplyAction="http://tempuri.org/IMyService/AddBrandResponse")]
        System.Threading.Tasks.Task<bool> AddBrandAsync(MODEL.MyService.Brand brand);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/ModifyBrand", ReplyAction="http://tempuri.org/IMyService/ModifyBrandResponse")]
        bool ModifyBrand(MODEL.MyService.Brand oldBrand, MODEL.MyService.Brand newBrand);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/ModifyBrand", ReplyAction="http://tempuri.org/IMyService/ModifyBrandResponse")]
        System.Threading.Tasks.Task<bool> ModifyBrandAsync(MODEL.MyService.Brand oldBrand, MODEL.MyService.Brand newBrand);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/DeleteBrand", ReplyAction="http://tempuri.org/IMyService/DeleteBrandResponse")]
        bool DeleteBrand(MODEL.MyService.Brand brand);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/DeleteBrand", ReplyAction="http://tempuri.org/IMyService/DeleteBrandResponse")]
        System.Threading.Tasks.Task<bool> DeleteBrandAsync(MODEL.MyService.Brand brand);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/SelectAllCategories", ReplyAction="http://tempuri.org/IMyService/SelectAllCategoriesResponse")]
        MODEL.MyService.Categories SelectAllCategories();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/SelectAllCategories", ReplyAction="http://tempuri.org/IMyService/SelectAllCategoriesResponse")]
        System.Threading.Tasks.Task<MODEL.MyService.Categories> SelectAllCategoriesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/AddCategory", ReplyAction="http://tempuri.org/IMyService/AddCategoryResponse")]
        bool AddCategory(MODEL.MyService.Category category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/AddCategory", ReplyAction="http://tempuri.org/IMyService/AddCategoryResponse")]
        System.Threading.Tasks.Task<bool> AddCategoryAsync(MODEL.MyService.Category category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/ModifyCategory", ReplyAction="http://tempuri.org/IMyService/ModifyCategoryResponse")]
        bool ModifyCategory(MODEL.MyService.Category oldCategory, MODEL.MyService.Category newCategory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/ModifyCategory", ReplyAction="http://tempuri.org/IMyService/ModifyCategoryResponse")]
        System.Threading.Tasks.Task<bool> ModifyCategoryAsync(MODEL.MyService.Category oldCategory, MODEL.MyService.Category newCategory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/DeleteCategory", ReplyAction="http://tempuri.org/IMyService/DeleteCategoryResponse")]
        bool DeleteCategory(MODEL.MyService.Category category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/DeleteCategory", ReplyAction="http://tempuri.org/IMyService/DeleteCategoryResponse")]
        System.Threading.Tasks.Task<bool> DeleteCategoryAsync(MODEL.MyService.Category category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/SelectAllRoles", ReplyAction="http://tempuri.org/IMyService/SelectAllRolesResponse")]
        MODEL.MyService.Roles SelectAllRoles();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/SelectAllRoles", ReplyAction="http://tempuri.org/IMyService/SelectAllRolesResponse")]
        System.Threading.Tasks.Task<MODEL.MyService.Roles> SelectAllRolesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/AddRole", ReplyAction="http://tempuri.org/IMyService/AddRoleResponse")]
        bool AddRole(MODEL.MyService.Role role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/AddRole", ReplyAction="http://tempuri.org/IMyService/AddRoleResponse")]
        System.Threading.Tasks.Task<bool> AddRoleAsync(MODEL.MyService.Role role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/ModifyRole", ReplyAction="http://tempuri.org/IMyService/ModifyRoleResponse")]
        bool ModifyRole(MODEL.MyService.Role OldRole, MODEL.MyService.Role newRole);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/ModifyRole", ReplyAction="http://tempuri.org/IMyService/ModifyRoleResponse")]
        System.Threading.Tasks.Task<bool> ModifyRoleAsync(MODEL.MyService.Role OldRole, MODEL.MyService.Role newRole);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/DeleteRole", ReplyAction="http://tempuri.org/IMyService/DeleteRoleResponse")]
        bool DeleteRole(MODEL.MyService.Role role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/DeleteRole", ReplyAction="http://tempuri.org/IMyService/DeleteRoleResponse")]
        System.Threading.Tasks.Task<bool> DeleteRoleAsync(MODEL.MyService.Role role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/SelectAllSizes", ReplyAction="http://tempuri.org/IMyService/SelectAllSizesResponse")]
        MODEL.MyService.Sizes SelectAllSizes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/SelectAllSizes", ReplyAction="http://tempuri.org/IMyService/SelectAllSizesResponse")]
        System.Threading.Tasks.Task<MODEL.MyService.Sizes> SelectAllSizesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/AddSize", ReplyAction="http://tempuri.org/IMyService/AddSizeResponse")]
        bool AddSize(MODEL.MyService.Size size);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/AddSize", ReplyAction="http://tempuri.org/IMyService/AddSizeResponse")]
        System.Threading.Tasks.Task<bool> AddSizeAsync(MODEL.MyService.Size size);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/ModifySize", ReplyAction="http://tempuri.org/IMyService/ModifySizeResponse")]
        bool ModifySize(MODEL.MyService.Size OldSize, MODEL.MyService.Size newSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/ModifySize", ReplyAction="http://tempuri.org/IMyService/ModifySizeResponse")]
        System.Threading.Tasks.Task<bool> ModifySizeAsync(MODEL.MyService.Size OldSize, MODEL.MyService.Size newSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/DeleteSize", ReplyAction="http://tempuri.org/IMyService/DeleteSizeResponse")]
        bool DeleteSize(MODEL.MyService.Size size);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/DeleteSize", ReplyAction="http://tempuri.org/IMyService/DeleteSizeResponse")]
        System.Threading.Tasks.Task<bool> DeleteSizeAsync(MODEL.MyService.Size size);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMyServiceChannel : MODEL.MyService.IMyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyServiceClient : System.ServiceModel.ClientBase<MODEL.MyService.IMyService>, MODEL.MyService.IMyService {
        
        public MyServiceClient() {
        }
        
        public MyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MODEL.MyService.Cities SelectAllCities() {
            return base.Channel.SelectAllCities();
        }
        
        public System.Threading.Tasks.Task<MODEL.MyService.Cities> SelectAllCitiesAsync() {
            return base.Channel.SelectAllCitiesAsync();
        }
        
        public bool AddCity(MODEL.MyService.City city) {
            return base.Channel.AddCity(city);
        }
        
        public System.Threading.Tasks.Task<bool> AddCityAsync(MODEL.MyService.City city) {
            return base.Channel.AddCityAsync(city);
        }
        
        public bool ModifyCity(MODEL.MyService.City oldCity, MODEL.MyService.City newCity) {
            return base.Channel.ModifyCity(oldCity, newCity);
        }
        
        public System.Threading.Tasks.Task<bool> ModifyCityAsync(MODEL.MyService.City oldCity, MODEL.MyService.City newCity) {
            return base.Channel.ModifyCityAsync(oldCity, newCity);
        }
        
        public bool DeleteCity(MODEL.MyService.City city) {
            return base.Channel.DeleteCity(city);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteCityAsync(MODEL.MyService.City city) {
            return base.Channel.DeleteCityAsync(city);
        }
        
        public MODEL.MyService.AreaCodes SelectAllAreaCodes() {
            return base.Channel.SelectAllAreaCodes();
        }
        
        public System.Threading.Tasks.Task<MODEL.MyService.AreaCodes> SelectAllAreaCodesAsync() {
            return base.Channel.SelectAllAreaCodesAsync();
        }
        
        public bool AddAreaCode(MODEL.MyService.AreaCode areaCode) {
            return base.Channel.AddAreaCode(areaCode);
        }
        
        public System.Threading.Tasks.Task<bool> AddAreaCodeAsync(MODEL.MyService.AreaCode areaCode) {
            return base.Channel.AddAreaCodeAsync(areaCode);
        }
        
        public bool ModifyAreaCode(MODEL.MyService.AreaCode oldAreaCode, MODEL.MyService.AreaCode newAreaCode) {
            return base.Channel.ModifyAreaCode(oldAreaCode, newAreaCode);
        }
        
        public System.Threading.Tasks.Task<bool> ModifyAreaCodeAsync(MODEL.MyService.AreaCode oldAreaCode, MODEL.MyService.AreaCode newAreaCode) {
            return base.Channel.ModifyAreaCodeAsync(oldAreaCode, newAreaCode);
        }
        
        public bool DeleteAreaCode(MODEL.MyService.AreaCode areaCode) {
            return base.Channel.DeleteAreaCode(areaCode);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteAreaCodeAsync(MODEL.MyService.AreaCode areaCode) {
            return base.Channel.DeleteAreaCodeAsync(areaCode);
        }
        
        public MODEL.MyService.Brands SelectAllBrands() {
            return base.Channel.SelectAllBrands();
        }
        
        public System.Threading.Tasks.Task<MODEL.MyService.Brands> SelectAllBrandsAsync() {
            return base.Channel.SelectAllBrandsAsync();
        }
        
        public bool AddBrand(MODEL.MyService.Brand brand) {
            return base.Channel.AddBrand(brand);
        }
        
        public System.Threading.Tasks.Task<bool> AddBrandAsync(MODEL.MyService.Brand brand) {
            return base.Channel.AddBrandAsync(brand);
        }
        
        public bool ModifyBrand(MODEL.MyService.Brand oldBrand, MODEL.MyService.Brand newBrand) {
            return base.Channel.ModifyBrand(oldBrand, newBrand);
        }
        
        public System.Threading.Tasks.Task<bool> ModifyBrandAsync(MODEL.MyService.Brand oldBrand, MODEL.MyService.Brand newBrand) {
            return base.Channel.ModifyBrandAsync(oldBrand, newBrand);
        }
        
        public bool DeleteBrand(MODEL.MyService.Brand brand) {
            return base.Channel.DeleteBrand(brand);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteBrandAsync(MODEL.MyService.Brand brand) {
            return base.Channel.DeleteBrandAsync(brand);
        }
        
        public MODEL.MyService.Categories SelectAllCategories() {
            return base.Channel.SelectAllCategories();
        }
        
        public System.Threading.Tasks.Task<MODEL.MyService.Categories> SelectAllCategoriesAsync() {
            return base.Channel.SelectAllCategoriesAsync();
        }
        
        public bool AddCategory(MODEL.MyService.Category category) {
            return base.Channel.AddCategory(category);
        }
        
        public System.Threading.Tasks.Task<bool> AddCategoryAsync(MODEL.MyService.Category category) {
            return base.Channel.AddCategoryAsync(category);
        }
        
        public bool ModifyCategory(MODEL.MyService.Category oldCategory, MODEL.MyService.Category newCategory) {
            return base.Channel.ModifyCategory(oldCategory, newCategory);
        }
        
        public System.Threading.Tasks.Task<bool> ModifyCategoryAsync(MODEL.MyService.Category oldCategory, MODEL.MyService.Category newCategory) {
            return base.Channel.ModifyCategoryAsync(oldCategory, newCategory);
        }
        
        public bool DeleteCategory(MODEL.MyService.Category category) {
            return base.Channel.DeleteCategory(category);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteCategoryAsync(MODEL.MyService.Category category) {
            return base.Channel.DeleteCategoryAsync(category);
        }
        
        public MODEL.MyService.Roles SelectAllRoles() {
            return base.Channel.SelectAllRoles();
        }
        
        public System.Threading.Tasks.Task<MODEL.MyService.Roles> SelectAllRolesAsync() {
            return base.Channel.SelectAllRolesAsync();
        }
        
        public bool AddRole(MODEL.MyService.Role role) {
            return base.Channel.AddRole(role);
        }
        
        public System.Threading.Tasks.Task<bool> AddRoleAsync(MODEL.MyService.Role role) {
            return base.Channel.AddRoleAsync(role);
        }
        
        public bool ModifyRole(MODEL.MyService.Role OldRole, MODEL.MyService.Role newRole) {
            return base.Channel.ModifyRole(OldRole, newRole);
        }
        
        public System.Threading.Tasks.Task<bool> ModifyRoleAsync(MODEL.MyService.Role OldRole, MODEL.MyService.Role newRole) {
            return base.Channel.ModifyRoleAsync(OldRole, newRole);
        }
        
        public bool DeleteRole(MODEL.MyService.Role role) {
            return base.Channel.DeleteRole(role);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteRoleAsync(MODEL.MyService.Role role) {
            return base.Channel.DeleteRoleAsync(role);
        }
        
        public MODEL.MyService.Sizes SelectAllSizes() {
            return base.Channel.SelectAllSizes();
        }
        
        public System.Threading.Tasks.Task<MODEL.MyService.Sizes> SelectAllSizesAsync() {
            return base.Channel.SelectAllSizesAsync();
        }
        
        public bool AddSize(MODEL.MyService.Size size) {
            return base.Channel.AddSize(size);
        }
        
        public System.Threading.Tasks.Task<bool> AddSizeAsync(MODEL.MyService.Size size) {
            return base.Channel.AddSizeAsync(size);
        }
        
        public bool ModifySize(MODEL.MyService.Size OldSize, MODEL.MyService.Size newSize) {
            return base.Channel.ModifySize(OldSize, newSize);
        }
        
        public System.Threading.Tasks.Task<bool> ModifySizeAsync(MODEL.MyService.Size OldSize, MODEL.MyService.Size newSize) {
            return base.Channel.ModifySizeAsync(OldSize, newSize);
        }
        
        public bool DeleteSize(MODEL.MyService.Size size) {
            return base.Channel.DeleteSize(size);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteSizeAsync(MODEL.MyService.Size size) {
            return base.Channel.DeleteSizeAsync(size);
        }
    }
}