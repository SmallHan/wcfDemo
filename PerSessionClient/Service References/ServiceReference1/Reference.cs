﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PerSessionClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ISocketService")]
    public interface ISocketService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocketService/GetPrice", ReplyAction="http://tempuri.org/ISocketService/GetPriceResponse")]
        double GetPrice(string ticket);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/ISocketService/GetPrice", ReplyAction="http://tempuri.org/ISocketService/GetPriceResponse")]
        System.IAsyncResult BeginGetPrice(string ticket, System.AsyncCallback callback, object asyncState);
        
        double EndGetPrice(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISocketServiceChannel : PerSessionClient.ServiceReference1.ISocketService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetPriceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetPriceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public double Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SocketServiceClient : System.ServiceModel.ClientBase<PerSessionClient.ServiceReference1.ISocketService>, PerSessionClient.ServiceReference1.ISocketService {
        
        private BeginOperationDelegate onBeginGetPriceDelegate;
        
        private EndOperationDelegate onEndGetPriceDelegate;
        
        private System.Threading.SendOrPostCallback onGetPriceCompletedDelegate;
        
        public SocketServiceClient() {
        }
        
        public SocketServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SocketServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SocketServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SocketServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<GetPriceCompletedEventArgs> GetPriceCompleted;
        
        public double GetPrice(string ticket) {
            return base.Channel.GetPrice(ticket);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetPrice(string ticket, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetPrice(ticket, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public double EndGetPrice(System.IAsyncResult result) {
            return base.Channel.EndGetPrice(result);
        }
        
        private System.IAsyncResult OnBeginGetPrice(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string ticket = ((string)(inValues[0]));
            return this.BeginGetPrice(ticket, callback, asyncState);
        }
        
        private object[] OnEndGetPrice(System.IAsyncResult result) {
            double retVal = this.EndGetPrice(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetPriceCompleted(object state) {
            if ((this.GetPriceCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetPriceCompleted(this, new GetPriceCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetPriceAsync(string ticket) {
            this.GetPriceAsync(ticket, null);
        }
        
        public void GetPriceAsync(string ticket, object userState) {
            if ((this.onBeginGetPriceDelegate == null)) {
                this.onBeginGetPriceDelegate = new BeginOperationDelegate(this.OnBeginGetPrice);
            }
            if ((this.onEndGetPriceDelegate == null)) {
                this.onEndGetPriceDelegate = new EndOperationDelegate(this.OnEndGetPrice);
            }
            if ((this.onGetPriceCompletedDelegate == null)) {
                this.onGetPriceCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetPriceCompleted);
            }
            base.InvokeAsync(this.onBeginGetPriceDelegate, new object[] {
                        ticket}, this.onEndGetPriceDelegate, this.onGetPriceCompletedDelegate, userState);
        }
    }
}
