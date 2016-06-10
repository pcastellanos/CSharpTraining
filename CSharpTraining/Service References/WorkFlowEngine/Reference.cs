﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSharpTraining.WorkFlowEngine {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WorkFlowEngine.WorkflowEngineSOASoap")]
    public interface WorkflowEngineSOASoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ping", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string ping(string sMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ping", ReplyAction="*")]
        System.Threading.Tasks.Task<string> pingAsync(string sMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/createCasesAsString", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string createCasesAsString(string casesInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/createCasesAsString", ReplyAction="*")]
        System.Threading.Tasks.Task<string> createCasesAsStringAsync(string casesInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/performActivityAsString", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string performActivityAsString(string activityInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/performActivityAsString", ReplyAction="*")]
        System.Threading.Tasks.Task<string> performActivityAsStringAsync(string activityInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/setEventAsString", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string setEventAsString(string eventInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/setEventAsString", ReplyAction="*")]
        System.Threading.Tasks.Task<string> setEventAsStringAsync(string eventInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCasesAsString", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string getCasesAsString(string caseFilters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCasesAsString", ReplyAction="*")]
        System.Threading.Tasks.Task<string> getCasesAsStringAsync(string caseFilters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/saveActivityAsString", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string saveActivityAsString(string activityInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/saveActivityAsString", ReplyAction="*")]
        System.Threading.Tasks.Task<string> saveActivityAsStringAsync(string activityInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getActivitiesAsString", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string getActivitiesAsString(string activityFilters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getActivitiesAsString", ReplyAction="*")]
        System.Threading.Tasks.Task<string> getActivitiesAsStringAsync(string activityFilters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/suspendCasesAsString", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string suspendCasesAsString(string cases);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/suspendCasesAsString", ReplyAction="*")]
        System.Threading.Tasks.Task<string> suspendCasesAsStringAsync(string cases);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/resumeCasesAsString", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string resumeCasesAsString(string cases);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/resumeCasesAsString", ReplyAction="*")]
        System.Threading.Tasks.Task<string> resumeCasesAsStringAsync(string cases);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getClosedActivitiesAsString", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string getClosedActivitiesAsString(string caseInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getClosedActivitiesAsString", ReplyAction="*")]
        System.Threading.Tasks.Task<string> getClosedActivitiesAsStringAsync(string caseInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getEventsAsString", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string getEventsAsString(string actFilters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getEventsAsString", ReplyAction="*")]
        System.Threading.Tasks.Task<string> getEventsAsStringAsync(string actFilters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getWorkflowClassesAsString", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string getWorkflowClassesAsString(string category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getWorkflowClassesAsString", ReplyAction="*")]
        System.Threading.Tasks.Task<string> getWorkflowClassesAsStringAsync(string category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCategoriesAsString", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string getCategoriesAsString(string appName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCategoriesAsString", ReplyAction="*")]
        System.Threading.Tasks.Task<string> getCategoriesAsStringAsync(string appName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/abortCasesAsString", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string abortCasesAsString(string info);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/abortCasesAsString", ReplyAction="*")]
        System.Threading.Tasks.Task<string> abortCasesAsStringAsync(string info);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getAssignationLogAsString", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string getAssignationLogAsString(string info);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getAssignationLogAsString", ReplyAction="*")]
        System.Threading.Tasks.Task<string> getAssignationLogAsStringAsync(string info);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CheckPassword", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int CheckPassword(string sDomain, string sUserName, string sPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CheckPassword", ReplyAction="*")]
        System.Threading.Tasks.Task<int> CheckPasswordAsync(string sDomain, string sUserName, string sPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/assignActivityAsString", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string assignActivityAsString(string info);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/assignActivityAsString", ReplyAction="*")]
        System.Threading.Tasks.Task<string> assignActivityAsStringAsync(string info);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/grantCaseAccess", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string grantCaseAccess(string caseAccessXML);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/grantCaseAccess", ReplyAction="*")]
        System.Threading.Tasks.Task<string> grantCaseAccessAsync(string caseAccessXML);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/revokeCaseAccess", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string revokeCaseAccess(string caseAccessXML);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/revokeCaseAccess", ReplyAction="*")]
        System.Threading.Tasks.Task<string> revokeCaseAccessAsync(string caseAccessXML);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/cleanTestData", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode cleanTestData(System.Xml.XmlNode caseInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/cleanTestData", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> cleanTestDataAsync(System.Xml.XmlNode caseInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/createCases", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode createCases(System.Xml.XmlNode casesInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/createCases", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> createCasesAsync(System.Xml.XmlNode casesInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/evalRule", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode evalRule(System.Xml.XmlNode assertionInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/evalRule", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> evalRuleAsync(System.Xml.XmlNode assertionInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getActivities", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode getActivities(System.Xml.XmlNode activitiesFilters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getActivities", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getActivitiesAsync(System.Xml.XmlNode activitiesFilters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getAssignationLog", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode getAssignationLog(System.Xml.XmlNode caseInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getAssignationLog", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getAssignationLogAsync(System.Xml.XmlNode caseInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getClosedActivities", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode getClosedActivities(System.Xml.XmlNode caseInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getClosedActivities", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getClosedActivitiesAsync(System.Xml.XmlNode caseInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/performActivity", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode performActivity(System.Xml.XmlNode activityInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/performActivity", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> performActivityAsync(System.Xml.XmlNode activityInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/resumeCases", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode resumeCases(System.Xml.XmlNode cases);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/resumeCases", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> resumeCasesAsync(System.Xml.XmlNode cases);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/rollbackCase", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode rollbackCase(System.Xml.XmlNode caseInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/rollbackCase", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> rollbackCaseAsync(System.Xml.XmlNode caseInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/setEvent", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode setEvent(System.Xml.XmlNode eventInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/setEvent", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> setEventAsync(System.Xml.XmlNode eventInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/suspendCases", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode suspendCases(System.Xml.XmlNode cases);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/suspendCases", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> suspendCasesAsync(System.Xml.XmlNode cases);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/abortCases", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode abortCases(System.Xml.XmlNode casesInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/abortCases", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> abortCasesAsync(System.Xml.XmlNode casesInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getApplications", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode getApplications();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getApplications", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getApplicationsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCategories", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode getCategories(System.Xml.XmlNode application);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCategories", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getCategoriesAsync(System.Xml.XmlNode application);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCategories2", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode getCategories2(string applicationName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCategories2", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getCategories2Async(string applicationName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCategoriesFromApplicationName", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode getCategoriesFromApplicationName(string applicationName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCategoriesFromApplicationName", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getCategoriesFromApplicationNameAsync(string applicationName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getWorkflowClassesFromCategoryName", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode getWorkflowClassesFromCategoryName(string categoryName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getWorkflowClassesFromCategoryName", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getWorkflowClassesFromCategoryNameAsync(string categoryName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCategoriesLocalized", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode getCategoriesLocalized(string applicationName, string cultureName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCategoriesLocalized", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getCategoriesLocalizedAsync(string applicationName, string cultureName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getWorkflowClasses", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode getWorkflowClasses(System.Xml.XmlNode category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getWorkflowClasses", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getWorkflowClassesAsync(System.Xml.XmlNode category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getWorkflowClasses2", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode getWorkflowClasses2(string categoryName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getWorkflowClasses2", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getWorkflowClasses2Async(string categoryName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getEvents", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode getEvents(System.Xml.XmlNode activitiesFilters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getEvents", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getEventsAsync(System.Xml.XmlNode activitiesFilters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCases", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode getCases(System.Xml.XmlNode casesFilters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCases", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> getCasesAsync(System.Xml.XmlNode casesFilters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/saveActivity", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode saveActivity(System.Xml.XmlNode activityInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/saveActivity", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> saveActivityAsync(System.Xml.XmlNode activityInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/assignActivity", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode assignActivity(System.Xml.XmlNode xmlDoc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/assignActivity", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> assignActivityAsync(System.Xml.XmlNode xmlDoc);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WorkflowEngineSOASoapChannel : CSharpTraining.WorkFlowEngine.WorkflowEngineSOASoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WorkflowEngineSOASoapClient : System.ServiceModel.ClientBase<CSharpTraining.WorkFlowEngine.WorkflowEngineSOASoap>, CSharpTraining.WorkFlowEngine.WorkflowEngineSOASoap {
        
        public WorkflowEngineSOASoapClient() {
        }
        
        public WorkflowEngineSOASoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WorkflowEngineSOASoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WorkflowEngineSOASoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WorkflowEngineSOASoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string ping(string sMessage) {
            return base.Channel.ping(sMessage);
        }
        
        public System.Threading.Tasks.Task<string> pingAsync(string sMessage) {
            return base.Channel.pingAsync(sMessage);
        }
        
        public string createCasesAsString(string casesInfo) {
            return base.Channel.createCasesAsString(casesInfo);
        }
        
        public System.Threading.Tasks.Task<string> createCasesAsStringAsync(string casesInfo) {
            return base.Channel.createCasesAsStringAsync(casesInfo);
        }
        
        public string performActivityAsString(string activityInfo) {
            return base.Channel.performActivityAsString(activityInfo);
        }
        
        public System.Threading.Tasks.Task<string> performActivityAsStringAsync(string activityInfo) {
            return base.Channel.performActivityAsStringAsync(activityInfo);
        }
        
        public string setEventAsString(string eventInfo) {
            return base.Channel.setEventAsString(eventInfo);
        }
        
        public System.Threading.Tasks.Task<string> setEventAsStringAsync(string eventInfo) {
            return base.Channel.setEventAsStringAsync(eventInfo);
        }
        
        public string getCasesAsString(string caseFilters) {
            return base.Channel.getCasesAsString(caseFilters);
        }
        
        public System.Threading.Tasks.Task<string> getCasesAsStringAsync(string caseFilters) {
            return base.Channel.getCasesAsStringAsync(caseFilters);
        }
        
        public string saveActivityAsString(string activityInfo) {
            return base.Channel.saveActivityAsString(activityInfo);
        }
        
        public System.Threading.Tasks.Task<string> saveActivityAsStringAsync(string activityInfo) {
            return base.Channel.saveActivityAsStringAsync(activityInfo);
        }
        
        public string getActivitiesAsString(string activityFilters) {
            return base.Channel.getActivitiesAsString(activityFilters);
        }
        
        public System.Threading.Tasks.Task<string> getActivitiesAsStringAsync(string activityFilters) {
            return base.Channel.getActivitiesAsStringAsync(activityFilters);
        }
        
        public string suspendCasesAsString(string cases) {
            return base.Channel.suspendCasesAsString(cases);
        }
        
        public System.Threading.Tasks.Task<string> suspendCasesAsStringAsync(string cases) {
            return base.Channel.suspendCasesAsStringAsync(cases);
        }
        
        public string resumeCasesAsString(string cases) {
            return base.Channel.resumeCasesAsString(cases);
        }
        
        public System.Threading.Tasks.Task<string> resumeCasesAsStringAsync(string cases) {
            return base.Channel.resumeCasesAsStringAsync(cases);
        }
        
        public string getClosedActivitiesAsString(string caseInfo) {
            return base.Channel.getClosedActivitiesAsString(caseInfo);
        }
        
        public System.Threading.Tasks.Task<string> getClosedActivitiesAsStringAsync(string caseInfo) {
            return base.Channel.getClosedActivitiesAsStringAsync(caseInfo);
        }
        
        public string getEventsAsString(string actFilters) {
            return base.Channel.getEventsAsString(actFilters);
        }
        
        public System.Threading.Tasks.Task<string> getEventsAsStringAsync(string actFilters) {
            return base.Channel.getEventsAsStringAsync(actFilters);
        }
        
        public string getWorkflowClassesAsString(string category) {
            return base.Channel.getWorkflowClassesAsString(category);
        }
        
        public System.Threading.Tasks.Task<string> getWorkflowClassesAsStringAsync(string category) {
            return base.Channel.getWorkflowClassesAsStringAsync(category);
        }
        
        public string getCategoriesAsString(string appName) {
            return base.Channel.getCategoriesAsString(appName);
        }
        
        public System.Threading.Tasks.Task<string> getCategoriesAsStringAsync(string appName) {
            return base.Channel.getCategoriesAsStringAsync(appName);
        }
        
        public string abortCasesAsString(string info) {
            return base.Channel.abortCasesAsString(info);
        }
        
        public System.Threading.Tasks.Task<string> abortCasesAsStringAsync(string info) {
            return base.Channel.abortCasesAsStringAsync(info);
        }
        
        public string getAssignationLogAsString(string info) {
            return base.Channel.getAssignationLogAsString(info);
        }
        
        public System.Threading.Tasks.Task<string> getAssignationLogAsStringAsync(string info) {
            return base.Channel.getAssignationLogAsStringAsync(info);
        }
        
        public int CheckPassword(string sDomain, string sUserName, string sPassword) {
            return base.Channel.CheckPassword(sDomain, sUserName, sPassword);
        }
        
        public System.Threading.Tasks.Task<int> CheckPasswordAsync(string sDomain, string sUserName, string sPassword) {
            return base.Channel.CheckPasswordAsync(sDomain, sUserName, sPassword);
        }
        
        public string assignActivityAsString(string info) {
            return base.Channel.assignActivityAsString(info);
        }
        
        public System.Threading.Tasks.Task<string> assignActivityAsStringAsync(string info) {
            return base.Channel.assignActivityAsStringAsync(info);
        }
        
        public string grantCaseAccess(string caseAccessXML) {
            return base.Channel.grantCaseAccess(caseAccessXML);
        }
        
        public System.Threading.Tasks.Task<string> grantCaseAccessAsync(string caseAccessXML) {
            return base.Channel.grantCaseAccessAsync(caseAccessXML);
        }
        
        public string revokeCaseAccess(string caseAccessXML) {
            return base.Channel.revokeCaseAccess(caseAccessXML);
        }
        
        public System.Threading.Tasks.Task<string> revokeCaseAccessAsync(string caseAccessXML) {
            return base.Channel.revokeCaseAccessAsync(caseAccessXML);
        }
        
        public System.Xml.XmlNode cleanTestData(System.Xml.XmlNode caseInfo) {
            return base.Channel.cleanTestData(caseInfo);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> cleanTestDataAsync(System.Xml.XmlNode caseInfo) {
            return base.Channel.cleanTestDataAsync(caseInfo);
        }
        
        public System.Xml.XmlNode createCases(System.Xml.XmlNode casesInfo) {
            return base.Channel.createCases(casesInfo);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> createCasesAsync(System.Xml.XmlNode casesInfo) {
            return base.Channel.createCasesAsync(casesInfo);
        }
        
        public System.Xml.XmlNode evalRule(System.Xml.XmlNode assertionInfo) {
            return base.Channel.evalRule(assertionInfo);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> evalRuleAsync(System.Xml.XmlNode assertionInfo) {
            return base.Channel.evalRuleAsync(assertionInfo);
        }
        
        public System.Xml.XmlNode getActivities(System.Xml.XmlNode activitiesFilters) {
            return base.Channel.getActivities(activitiesFilters);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getActivitiesAsync(System.Xml.XmlNode activitiesFilters) {
            return base.Channel.getActivitiesAsync(activitiesFilters);
        }
        
        public System.Xml.XmlNode getAssignationLog(System.Xml.XmlNode caseInfo) {
            return base.Channel.getAssignationLog(caseInfo);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getAssignationLogAsync(System.Xml.XmlNode caseInfo) {
            return base.Channel.getAssignationLogAsync(caseInfo);
        }
        
        public System.Xml.XmlNode getClosedActivities(System.Xml.XmlNode caseInfo) {
            return base.Channel.getClosedActivities(caseInfo);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getClosedActivitiesAsync(System.Xml.XmlNode caseInfo) {
            return base.Channel.getClosedActivitiesAsync(caseInfo);
        }
        
        public System.Xml.XmlNode performActivity(System.Xml.XmlNode activityInfo) {
            return base.Channel.performActivity(activityInfo);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> performActivityAsync(System.Xml.XmlNode activityInfo) {
            return base.Channel.performActivityAsync(activityInfo);
        }
        
        public System.Xml.XmlNode resumeCases(System.Xml.XmlNode cases) {
            return base.Channel.resumeCases(cases);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> resumeCasesAsync(System.Xml.XmlNode cases) {
            return base.Channel.resumeCasesAsync(cases);
        }
        
        public System.Xml.XmlNode rollbackCase(System.Xml.XmlNode caseInfo) {
            return base.Channel.rollbackCase(caseInfo);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> rollbackCaseAsync(System.Xml.XmlNode caseInfo) {
            return base.Channel.rollbackCaseAsync(caseInfo);
        }
        
        public System.Xml.XmlNode setEvent(System.Xml.XmlNode eventInfo) {
            return base.Channel.setEvent(eventInfo);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> setEventAsync(System.Xml.XmlNode eventInfo) {
            return base.Channel.setEventAsync(eventInfo);
        }
        
        public System.Xml.XmlNode suspendCases(System.Xml.XmlNode cases) {
            return base.Channel.suspendCases(cases);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> suspendCasesAsync(System.Xml.XmlNode cases) {
            return base.Channel.suspendCasesAsync(cases);
        }
        
        public System.Xml.XmlNode abortCases(System.Xml.XmlNode casesInfo) {
            return base.Channel.abortCases(casesInfo);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> abortCasesAsync(System.Xml.XmlNode casesInfo) {
            return base.Channel.abortCasesAsync(casesInfo);
        }
        
        public System.Xml.XmlNode getApplications() {
            return base.Channel.getApplications();
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getApplicationsAsync() {
            return base.Channel.getApplicationsAsync();
        }
        
        public System.Xml.XmlNode getCategories(System.Xml.XmlNode application) {
            return base.Channel.getCategories(application);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getCategoriesAsync(System.Xml.XmlNode application) {
            return base.Channel.getCategoriesAsync(application);
        }
        
        public System.Xml.XmlNode getCategories2(string applicationName) {
            return base.Channel.getCategories2(applicationName);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getCategories2Async(string applicationName) {
            return base.Channel.getCategories2Async(applicationName);
        }
        
        public System.Xml.XmlNode getCategoriesFromApplicationName(string applicationName) {
            return base.Channel.getCategoriesFromApplicationName(applicationName);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getCategoriesFromApplicationNameAsync(string applicationName) {
            return base.Channel.getCategoriesFromApplicationNameAsync(applicationName);
        }
        
        public System.Xml.XmlNode getWorkflowClassesFromCategoryName(string categoryName) {
            return base.Channel.getWorkflowClassesFromCategoryName(categoryName);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getWorkflowClassesFromCategoryNameAsync(string categoryName) {
            return base.Channel.getWorkflowClassesFromCategoryNameAsync(categoryName);
        }
        
        public System.Xml.XmlNode getCategoriesLocalized(string applicationName, string cultureName) {
            return base.Channel.getCategoriesLocalized(applicationName, cultureName);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getCategoriesLocalizedAsync(string applicationName, string cultureName) {
            return base.Channel.getCategoriesLocalizedAsync(applicationName, cultureName);
        }
        
        public System.Xml.XmlNode getWorkflowClasses(System.Xml.XmlNode category) {
            return base.Channel.getWorkflowClasses(category);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getWorkflowClassesAsync(System.Xml.XmlNode category) {
            return base.Channel.getWorkflowClassesAsync(category);
        }
        
        public System.Xml.XmlNode getWorkflowClasses2(string categoryName) {
            return base.Channel.getWorkflowClasses2(categoryName);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getWorkflowClasses2Async(string categoryName) {
            return base.Channel.getWorkflowClasses2Async(categoryName);
        }
        
        public System.Xml.XmlNode getEvents(System.Xml.XmlNode activitiesFilters) {
            return base.Channel.getEvents(activitiesFilters);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getEventsAsync(System.Xml.XmlNode activitiesFilters) {
            return base.Channel.getEventsAsync(activitiesFilters);
        }
        
        public System.Xml.XmlNode getCases(System.Xml.XmlNode casesFilters) {
            return base.Channel.getCases(casesFilters);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> getCasesAsync(System.Xml.XmlNode casesFilters) {
            return base.Channel.getCasesAsync(casesFilters);
        }
        
        public System.Xml.XmlNode saveActivity(System.Xml.XmlNode activityInfo) {
            return base.Channel.saveActivity(activityInfo);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> saveActivityAsync(System.Xml.XmlNode activityInfo) {
            return base.Channel.saveActivityAsync(activityInfo);
        }
        
        public System.Xml.XmlNode assignActivity(System.Xml.XmlNode xmlDoc) {
            return base.Channel.assignActivity(xmlDoc);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> assignActivityAsync(System.Xml.XmlNode xmlDoc) {
            return base.Channel.assignActivityAsync(xmlDoc);
        }
    }
}
