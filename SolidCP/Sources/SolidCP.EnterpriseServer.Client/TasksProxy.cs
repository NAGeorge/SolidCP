// Copyright (c) 2016, SolidCP
// SolidCP is distributed under the Creative Commons Share-alike license
// 
// SolidCP is a fork of WebsitePanel:
// Copyright (c) 2015, Outercurve Foundation.
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
//
// - Redistributions of source code must  retain  the  above copyright notice, this
//   list of conditions and the following disclaimer.
//
// - Redistributions in binary form  must  reproduce the  above  copyright  notice,
//   this list of conditions  and  the  following  disclaimer in  the documentation
//   and/or other materials provided with the distribution.
//
// - Neither  the  name  of  the  Outercurve Foundation  nor   the   names  of  its
//   contributors may be used to endorse or  promote  products  derived  from  this
//   software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING,  BUT  NOT  LIMITED TO, THE IMPLIED
// WARRANTIES  OF  MERCHANTABILITY   AND  FITNESS  FOR  A  PARTICULAR  PURPOSE  ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR
// ANY DIRECT, INDIRECT, INCIDENTAL,  SPECIAL,  EXEMPLARY, OR CONSEQUENTIAL DAMAGES
// (INCLUDING, BUT NOT LIMITED TO,  PROCUREMENT  OF  SUBSTITUTE  GOODS OR SERVICES;
// LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)  HOWEVER  CAUSED AND ON
// ANY  THEORY  OF  LIABILITY,  WHETHER  IN  CONTRACT,  STRICT  LIABILITY,  OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE)  ARISING  IN  ANY WAY OUT OF THE USE OF THIS
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by wsdl, Version=2.0.50727.42.
// 
namespace SolidCP.EnterpriseServer
{
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "esTasksSoap", Namespace = "http://smbsaas/solidcp/enterpriseserver")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BackgroundTaskLogRecord[]))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(object[]))]
    public partial class esTasks : Microsoft.Web.Services3.WebServicesClientProtocol
    {

        private System.Threading.SendOrPostCallback GetTaskOperationCompleted;

        private System.Threading.SendOrPostCallback GetTaskWithLogRecordsOperationCompleted;

        private System.Threading.SendOrPostCallback GetTasksNumberOperationCompleted;

        private System.Threading.SendOrPostCallback GetUserTasksOperationCompleted;

        private System.Threading.SendOrPostCallback GetUserCompletedTasksOperationCompleted;

        private System.Threading.SendOrPostCallback SetTaskNotifyOnCompleteOperationCompleted;

        private System.Threading.SendOrPostCallback StopTaskOperationCompleted;

        /// <remarks/>
        public esTasks()
        {
            this.Url = "http://localhost/EnterpriseServer/esTasks.asmx";
        }

        /// <remarks/>
        public event GetTaskCompletedEventHandler GetTaskCompleted;

        /// <remarks/>
        public event GetTaskWithLogRecordsCompletedEventHandler GetTaskWithLogRecordsCompleted;

        /// <remarks/>
        public event GetTasksNumberCompletedEventHandler GetTasksNumberCompleted;

        /// <remarks/>
        public event GetUserTasksCompletedEventHandler GetUserTasksCompleted;

        /// <remarks/>
        public event GetUserCompletedTasksCompletedEventHandler GetUserCompletedTasksCompleted;

        /// <remarks/>
        public event SetTaskNotifyOnCompleteCompletedEventHandler SetTaskNotifyOnCompleteCompleted;

        /// <remarks/>
        public event StopTaskCompletedEventHandler StopTaskCompleted;

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/solidcp/enterpriseserver/GetTask", RequestNamespace = "http://smbsaas/solidcp/enterpriseserver", ResponseNamespace = "http://smbsaas/solidcp/enterpriseserver", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public BackgroundTask GetTask(string taskId)
        {
            object[] results = this.Invoke("GetTask", new object[] {
                        taskId});
            return ((BackgroundTask)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetTask(string taskId, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetTask", new object[] {
                        taskId}, callback, asyncState);
        }

        /// <remarks/>
        public BackgroundTask EndGetTask(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((BackgroundTask)(results[0]));
        }

        /// <remarks/>
        public void GetTaskAsync(string taskId)
        {
            this.GetTaskAsync(taskId, null);
        }

        /// <remarks/>
        public void GetTaskAsync(string taskId, object userState)
        {
            if ((this.GetTaskOperationCompleted == null))
            {
                this.GetTaskOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTaskOperationCompleted);
            }
            this.InvokeAsync("GetTask", new object[] {
                        taskId}, this.GetTaskOperationCompleted, userState);
        }

        private void OnGetTaskOperationCompleted(object arg)
        {
            if ((this.GetTaskCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTaskCompleted(this, new GetTaskCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/solidcp/enterpriseserver/GetTaskWithLogRecords", RequestNamespace = "http://smbsaas/solidcp/enterpriseserver", ResponseNamespace = "http://smbsaas/solidcp/enterpriseserver", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public BackgroundTask GetTaskWithLogRecords(string taskId, System.DateTime startLogTime)
        {
            object[] results = this.Invoke("GetTaskWithLogRecords", new object[] {
                        taskId,
                        startLogTime});
            return ((BackgroundTask)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetTaskWithLogRecords(string taskId, System.DateTime startLogTime, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetTaskWithLogRecords", new object[] {
                        taskId,
                        startLogTime}, callback, asyncState);
        }

        /// <remarks/>
        public BackgroundTask EndGetTaskWithLogRecords(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((BackgroundTask)(results[0]));
        }

        /// <remarks/>
        public void GetTaskWithLogRecordsAsync(string taskId, System.DateTime startLogTime)
        {
            this.GetTaskWithLogRecordsAsync(taskId, startLogTime, null);
        }

        /// <remarks/>
        public void GetTaskWithLogRecordsAsync(string taskId, System.DateTime startLogTime, object userState)
        {
            if ((this.GetTaskWithLogRecordsOperationCompleted == null))
            {
                this.GetTaskWithLogRecordsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTaskWithLogRecordsOperationCompleted);
            }
            this.InvokeAsync("GetTaskWithLogRecords", new object[] {
                        taskId,
                        startLogTime}, this.GetTaskWithLogRecordsOperationCompleted, userState);
        }

        private void OnGetTaskWithLogRecordsOperationCompleted(object arg)
        {
            if ((this.GetTaskWithLogRecordsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTaskWithLogRecordsCompleted(this, new GetTaskWithLogRecordsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/solidcp/enterpriseserver/GetTasksNumber", RequestNamespace = "http://smbsaas/solidcp/enterpriseserver", ResponseNamespace = "http://smbsaas/solidcp/enterpriseserver", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int GetTasksNumber()
        {
            object[] results = this.Invoke("GetTasksNumber", new object[0]);
            return ((int)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetTasksNumber(System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetTasksNumber", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public int EndGetTasksNumber(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }

        /// <remarks/>
        public void GetTasksNumberAsync()
        {
            this.GetTasksNumberAsync(null);
        }

        /// <remarks/>
        public void GetTasksNumberAsync(object userState)
        {
            if ((this.GetTasksNumberOperationCompleted == null))
            {
                this.GetTasksNumberOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTasksNumberOperationCompleted);
            }
            this.InvokeAsync("GetTasksNumber", new object[0], this.GetTasksNumberOperationCompleted, userState);
        }

        private void OnGetTasksNumberOperationCompleted(object arg)
        {
            if ((this.GetTasksNumberCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTasksNumberCompleted(this, new GetTasksNumberCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/solidcp/enterpriseserver/GetUserTasks", RequestNamespace = "http://smbsaas/solidcp/enterpriseserver", ResponseNamespace = "http://smbsaas/solidcp/enterpriseserver", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public BackgroundTask[] GetUserTasks(int userId)
        {
            object[] results = this.Invoke("GetUserTasks", new object[] {
                        userId});
            return ((BackgroundTask[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetUserTasks(int userId, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetUserTasks", new object[] {
                        userId}, callback, asyncState);
        }

        /// <remarks/>
        public BackgroundTask[] EndGetUserTasks(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((BackgroundTask[])(results[0]));
        }

        /// <remarks/>
        public void GetUserTasksAsync(int userId)
        {
            this.GetUserTasksAsync(userId, null);
        }

        /// <remarks/>
        public void GetUserTasksAsync(int userId, object userState)
        {
            if ((this.GetUserTasksOperationCompleted == null))
            {
                this.GetUserTasksOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetUserTasksOperationCompleted);
            }
            this.InvokeAsync("GetUserTasks", new object[] {
                        userId}, this.GetUserTasksOperationCompleted, userState);
        }

        private void OnGetUserTasksOperationCompleted(object arg)
        {
            if ((this.GetUserTasksCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetUserTasksCompleted(this, new GetUserTasksCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/solidcp/enterpriseserver/GetUserCompletedTasks", RequestNamespace = "http://smbsaas/solidcp/enterpriseserver", ResponseNamespace = "http://smbsaas/solidcp/enterpriseserver", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public BackgroundTask[] GetUserCompletedTasks(int userId)
        {
            object[] results = this.Invoke("GetUserCompletedTasks", new object[] {
                        userId});
            return ((BackgroundTask[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetUserCompletedTasks(int userId, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetUserCompletedTasks", new object[] {
                        userId}, callback, asyncState);
        }

        /// <remarks/>
        public BackgroundTask[] EndGetUserCompletedTasks(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((BackgroundTask[])(results[0]));
        }

        /// <remarks/>
        public void GetUserCompletedTasksAsync(int userId)
        {
            this.GetUserCompletedTasksAsync(userId, null);
        }

        /// <remarks/>
        public void GetUserCompletedTasksAsync(int userId, object userState)
        {
            if ((this.GetUserCompletedTasksOperationCompleted == null))
            {
                this.GetUserCompletedTasksOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetUserCompletedTasksOperationCompleted);
            }
            this.InvokeAsync("GetUserCompletedTasks", new object[] {
                        userId}, this.GetUserCompletedTasksOperationCompleted, userState);
        }

        private void OnGetUserCompletedTasksOperationCompleted(object arg)
        {
            if ((this.GetUserCompletedTasksCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetUserCompletedTasksCompleted(this, new GetUserCompletedTasksCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/solidcp/enterpriseserver/SetTaskNotifyOnComplete", RequestNamespace = "http://smbsaas/solidcp/enterpriseserver", ResponseNamespace = "http://smbsaas/solidcp/enterpriseserver", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SetTaskNotifyOnComplete(string taskId)
        {
            this.Invoke("SetTaskNotifyOnComplete", new object[] {
                        taskId});
        }

        /// <remarks/>
        public System.IAsyncResult BeginSetTaskNotifyOnComplete(string taskId, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("SetTaskNotifyOnComplete", new object[] {
                        taskId}, callback, asyncState);
        }

        /// <remarks/>
        public void EndSetTaskNotifyOnComplete(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void SetTaskNotifyOnCompleteAsync(string taskId)
        {
            this.SetTaskNotifyOnCompleteAsync(taskId, null);
        }

        /// <remarks/>
        public void SetTaskNotifyOnCompleteAsync(string taskId, object userState)
        {
            if ((this.SetTaskNotifyOnCompleteOperationCompleted == null))
            {
                this.SetTaskNotifyOnCompleteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetTaskNotifyOnCompleteOperationCompleted);
            }
            this.InvokeAsync("SetTaskNotifyOnComplete", new object[] {
                        taskId}, this.SetTaskNotifyOnCompleteOperationCompleted, userState);
        }

        private void OnSetTaskNotifyOnCompleteOperationCompleted(object arg)
        {
            if ((this.SetTaskNotifyOnCompleteCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetTaskNotifyOnCompleteCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/solidcp/enterpriseserver/StopTask", RequestNamespace = "http://smbsaas/solidcp/enterpriseserver", ResponseNamespace = "http://smbsaas/solidcp/enterpriseserver", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void StopTask(string taskId)
        {
            this.Invoke("StopTask", new object[] {
                        taskId});
        }

        /// <remarks/>
        public System.IAsyncResult BeginStopTask(string taskId, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("StopTask", new object[] {
                        taskId}, callback, asyncState);
        }

        /// <remarks/>
        public void EndStopTask(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void StopTaskAsync(string taskId)
        {
            this.StopTaskAsync(taskId, null);
        }

        /// <remarks/>
        public void StopTaskAsync(string taskId, object userState)
        {
            if ((this.StopTaskOperationCompleted == null))
            {
                this.StopTaskOperationCompleted = new System.Threading.SendOrPostCallback(this.OnStopTaskOperationCompleted);
            }
            this.InvokeAsync("StopTask", new object[] {
                        taskId}, this.StopTaskOperationCompleted, userState);
        }

        private void OnStopTaskOperationCompleted(object arg)
        {
            if ((this.StopTaskCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.StopTaskCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        public new void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void GetTaskCompletedEventHandler(object sender, GetTaskCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTaskCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetTaskCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState)
            :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public BackgroundTask Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((BackgroundTask)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void GetTaskWithLogRecordsCompletedEventHandler(object sender, GetTaskWithLogRecordsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTaskWithLogRecordsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetTaskWithLogRecordsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState)
            :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public BackgroundTask Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((BackgroundTask)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void GetTasksNumberCompletedEventHandler(object sender, GetTasksNumberCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTasksNumberCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetTasksNumberCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState)
            :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public int Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void GetUserTasksCompletedEventHandler(object sender, GetUserTasksCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetUserTasksCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetUserTasksCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState)
            :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public BackgroundTask[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((BackgroundTask[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void GetUserCompletedTasksCompletedEventHandler(object sender, GetUserCompletedTasksCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetUserCompletedTasksCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetUserCompletedTasksCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState)
            :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public BackgroundTask[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((BackgroundTask[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void SetTaskNotifyOnCompleteCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void StopTaskCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}