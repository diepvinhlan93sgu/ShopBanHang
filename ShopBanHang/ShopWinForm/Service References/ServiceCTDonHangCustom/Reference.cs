﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopWinForm.ServiceCTDonHangCustom {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CTDonHangCustom", Namespace="http://schemas.datacontract.org/2004/07/ShopBanHang")]
    [System.SerializableAttribute()]
    public partial class CTDonHangCustom : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> GiaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> MaDonHangField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> MaSPField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> SoLuongField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenSPField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> ThanhTienField;
        
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
        public System.Nullable<decimal> Gia {
            get {
                return this.GiaField;
            }
            set {
                if ((this.GiaField.Equals(value) != true)) {
                    this.GiaField = value;
                    this.RaisePropertyChanged("Gia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> MaDonHang {
            get {
                return this.MaDonHangField;
            }
            set {
                if ((this.MaDonHangField.Equals(value) != true)) {
                    this.MaDonHangField = value;
                    this.RaisePropertyChanged("MaDonHang");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> MaSP {
            get {
                return this.MaSPField;
            }
            set {
                if ((this.MaSPField.Equals(value) != true)) {
                    this.MaSPField = value;
                    this.RaisePropertyChanged("MaSP");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> SoLuong {
            get {
                return this.SoLuongField;
            }
            set {
                if ((this.SoLuongField.Equals(value) != true)) {
                    this.SoLuongField = value;
                    this.RaisePropertyChanged("SoLuong");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TenSP {
            get {
                return this.TenSPField;
            }
            set {
                if ((object.ReferenceEquals(this.TenSPField, value) != true)) {
                    this.TenSPField = value;
                    this.RaisePropertyChanged("TenSP");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> ThanhTien {
            get {
                return this.ThanhTienField;
            }
            set {
                if ((this.ThanhTienField.Equals(value) != true)) {
                    this.ThanhTienField = value;
                    this.RaisePropertyChanged("ThanhTien");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceCTDonHangCustom.IServiceCTDonHangCustom")]
    public interface IServiceCTDonHangCustom {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCTDonHangCustom/ChiTietDonHang", ReplyAction="http://tempuri.org/IServiceCTDonHangCustom/ChiTietDonHangResponse")]
        ShopWinForm.ServiceCTDonHangCustom.CTDonHangCustom[] ChiTietDonHang(int madonhang);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCTDonHangCustom/ChiTietDonHang", ReplyAction="http://tempuri.org/IServiceCTDonHangCustom/ChiTietDonHangResponse")]
        System.Threading.Tasks.Task<ShopWinForm.ServiceCTDonHangCustom.CTDonHangCustom[]> ChiTietDonHangAsync(int madonhang);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceCTDonHangCustomChannel : ShopWinForm.ServiceCTDonHangCustom.IServiceCTDonHangCustom, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceCTDonHangCustomClient : System.ServiceModel.ClientBase<ShopWinForm.ServiceCTDonHangCustom.IServiceCTDonHangCustom>, ShopWinForm.ServiceCTDonHangCustom.IServiceCTDonHangCustom {
        
        public ServiceCTDonHangCustomClient() {
        }
        
        public ServiceCTDonHangCustomClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceCTDonHangCustomClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceCTDonHangCustomClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceCTDonHangCustomClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ShopWinForm.ServiceCTDonHangCustom.CTDonHangCustom[] ChiTietDonHang(int madonhang) {
            return base.Channel.ChiTietDonHang(madonhang);
        }
        
        public System.Threading.Tasks.Task<ShopWinForm.ServiceCTDonHangCustom.CTDonHangCustom[]> ChiTietDonHangAsync(int madonhang) {
            return base.Channel.ChiTietDonHangAsync(madonhang);
        }
    }
}
