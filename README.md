# SendinBlue's API v3 C# Library

SendinBlue's API exposes the entire SendinBlue features via a standardized programmatic interface. Please refer to the full [documentation](https://developers.sendinblue.com) to learn more.

This is the wrapper for the API. It implements all the features of the API v3.

SendinBlue's API matches the [OpenAPI v2 definition](https://www.openapis.org/). The specification can be downloaded [here](https://api.sendinblue.com/v3/swagger_definition.yml).

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project and is reviewed and maintained by SendinBlue:

- API version: 3.0.0
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://account.sendinblue.com/support](https://account.sendinblue.com/support)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Include the Dependencies (RestSharp, Json.NET and JsonSubTypes as mentioned in Dependencies section) in the C# project, and use the namespaces:
```csharp
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.ApiKey.Add("partner-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("partner-key", "Bearer");

            var apiInstance = new AccountApi();

            try
            {
                // Get your account informations, plans and credits details
                GetAccount result = apiInstance.GetAccount();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.GetAccount: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.sendinblue.com/v3*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccountApi* | [**GetAccount**](docs/AccountApi.md#getaccount) | **GET** /account | Get your account informations, plans and credits details
*AttributesApi* | [**CreateAttribute**](docs/AttributesApi.md#createattribute) | **POST** /contacts/attributes/{attributeCategory}/{attributeName} | Creates contact attribute
*AttributesApi* | [**DeleteAttribute**](docs/AttributesApi.md#deleteattribute) | **DELETE** /contacts/attributes/{attributeCategory}/{attributeName} | Deletes an attribute
*AttributesApi* | [**GetAttributes**](docs/AttributesApi.md#getattributes) | **GET** /contacts/attributes | Lists all attributes
*AttributesApi* | [**UpdateAttribute**](docs/AttributesApi.md#updateattribute) | **PUT** /contacts/attributes/{attributeCategory}/{attributeName} | Updates contact attribute
*ContactsApi* | [**AddContactToList**](docs/ContactsApi.md#addcontacttolist) | **POST** /contacts/lists/{listId}/contacts/add | Add existing contacts to a list
*ContactsApi* | [**CreateAttribute**](docs/ContactsApi.md#createattribute) | **POST** /contacts/attributes/{attributeCategory}/{attributeName} | Creates contact attribute
*ContactsApi* | [**CreateContact**](docs/ContactsApi.md#createcontact) | **POST** /contacts | Create a contact
*ContactsApi* | [**CreateFolder**](docs/ContactsApi.md#createfolder) | **POST** /contacts/folders | Create a folder
*ContactsApi* | [**CreateList**](docs/ContactsApi.md#createlist) | **POST** /contacts/lists | Create a list
*ContactsApi* | [**DeleteAttribute**](docs/ContactsApi.md#deleteattribute) | **DELETE** /contacts/attributes/{attributeCategory}/{attributeName} | Deletes an attribute
*ContactsApi* | [**DeleteContact**](docs/ContactsApi.md#deletecontact) | **DELETE** /contacts/{email} | Deletes a contact
*ContactsApi* | [**DeleteFolder**](docs/ContactsApi.md#deletefolder) | **DELETE** /contacts/folders/{folderId} | Delete a folder (and all its lists)
*ContactsApi* | [**DeleteList**](docs/ContactsApi.md#deletelist) | **DELETE** /contacts/lists/{listId} | Delete a list
*ContactsApi* | [**GetAttributes**](docs/ContactsApi.md#getattributes) | **GET** /contacts/attributes | Lists all attributes
*ContactsApi* | [**GetContactInfo**](docs/ContactsApi.md#getcontactinfo) | **GET** /contacts/{email} | Retrieves contact informations
*ContactsApi* | [**GetContactStats**](docs/ContactsApi.md#getcontactstats) | **GET** /contacts/{email}/campaignStats | Get the campaigns statistics for a contact
*ContactsApi* | [**GetContacts**](docs/ContactsApi.md#getcontacts) | **GET** /contacts | Get all the contacts
*ContactsApi* | [**GetContactsFromList**](docs/ContactsApi.md#getcontactsfromlist) | **GET** /contacts/lists/{listId}/contacts | Get the contacts in a list
*ContactsApi* | [**GetFolder**](docs/ContactsApi.md#getfolder) | **GET** /contacts/folders/{folderId} | Returns folder details
*ContactsApi* | [**GetFolderLists**](docs/ContactsApi.md#getfolderlists) | **GET** /contacts/folders/{folderId}/lists | Get the lists in a folder
*ContactsApi* | [**GetFolders**](docs/ContactsApi.md#getfolders) | **GET** /contacts/folders | Get all the folders
*ContactsApi* | [**GetList**](docs/ContactsApi.md#getlist) | **GET** /contacts/lists/{listId} | Get the details of a list
*ContactsApi* | [**GetLists**](docs/ContactsApi.md#getlists) | **GET** /contacts/lists | Get all the lists
*ContactsApi* | [**ImportContacts**](docs/ContactsApi.md#importcontacts) | **POST** /contacts/import | Import contacts
*ContactsApi* | [**RemoveContactFromList**](docs/ContactsApi.md#removecontactfromlist) | **POST** /contacts/lists/{listId}/contacts/remove | Remove existing contacts from a list
*ContactsApi* | [**RequestContactExport**](docs/ContactsApi.md#requestcontactexport) | **POST** /contacts/export | Export contacts
*ContactsApi* | [**UpdateAttribute**](docs/ContactsApi.md#updateattribute) | **PUT** /contacts/attributes/{attributeCategory}/{attributeName} | Updates contact attribute
*ContactsApi* | [**UpdateContact**](docs/ContactsApi.md#updatecontact) | **PUT** /contacts/{email} | Updates a contact
*ContactsApi* | [**UpdateFolder**](docs/ContactsApi.md#updatefolder) | **PUT** /contacts/folders/{folderId} | Update a contact folder
*ContactsApi* | [**UpdateList**](docs/ContactsApi.md#updatelist) | **PUT** /contacts/lists/{listId} | Update a list
*EmailCampaignsApi* | [**CreateEmailCampaign**](docs/EmailCampaignsApi.md#createemailcampaign) | **POST** /emailCampaigns | Create an email campaign
*EmailCampaignsApi* | [**DeleteEmailCampaign**](docs/EmailCampaignsApi.md#deleteemailcampaign) | **DELETE** /emailCampaigns/{campaignId} | Delete an email campaign
*EmailCampaignsApi* | [**EmailExportRecipients**](docs/EmailCampaignsApi.md#emailexportrecipients) | **POST** /emailCampaigns/{campaignId}/exportRecipients | Export the recipients of a campaign
*EmailCampaignsApi* | [**GetEmailCampaign**](docs/EmailCampaignsApi.md#getemailcampaign) | **GET** /emailCampaigns/{campaignId} | Get campaign informations
*EmailCampaignsApi* | [**GetEmailCampaigns**](docs/EmailCampaignsApi.md#getemailcampaigns) | **GET** /emailCampaigns | Return all your created campaigns
*EmailCampaignsApi* | [**SendEmailCampaignNow**](docs/EmailCampaignsApi.md#sendemailcampaignnow) | **POST** /emailCampaigns/{campaignId}/sendNow | Send an email campaign id of the campaign immediately
*EmailCampaignsApi* | [**SendReport**](docs/EmailCampaignsApi.md#sendreport) | **POST** /emailCampaigns/{campaignId}/sendReport | Send the report of a campaigns
*EmailCampaignsApi* | [**SendTestEmail**](docs/EmailCampaignsApi.md#sendtestemail) | **POST** /emailCampaigns/{campaignId}/sendTest | Send an email campaign to your test list
*EmailCampaignsApi* | [**UpdateCampaignStatus**](docs/EmailCampaignsApi.md#updatecampaignstatus) | **PUT** /emailCampaigns/{campaignId}/status | Update a campaign status
*EmailCampaignsApi* | [**UpdateEmailCampaign**](docs/EmailCampaignsApi.md#updateemailcampaign) | **PUT** /emailCampaigns/{campaignId} | Update a campaign
*FoldersApi* | [**CreateFolder**](docs/FoldersApi.md#createfolder) | **POST** /contacts/folders | Create a folder
*FoldersApi* | [**DeleteFolder**](docs/FoldersApi.md#deletefolder) | **DELETE** /contacts/folders/{folderId} | Delete a folder (and all its lists)
*FoldersApi* | [**GetFolder**](docs/FoldersApi.md#getfolder) | **GET** /contacts/folders/{folderId} | Returns folder details
*FoldersApi* | [**GetFolderLists**](docs/FoldersApi.md#getfolderlists) | **GET** /contacts/folders/{folderId}/lists | Get the lists in a folder
*FoldersApi* | [**GetFolders**](docs/FoldersApi.md#getfolders) | **GET** /contacts/folders | Get all the folders
*FoldersApi* | [**UpdateFolder**](docs/FoldersApi.md#updatefolder) | **PUT** /contacts/folders/{folderId} | Update a contact folder
*ListsApi* | [**AddContactToList**](docs/ListsApi.md#addcontacttolist) | **POST** /contacts/lists/{listId}/contacts/add | Add existing contacts to a list
*ListsApi* | [**CreateList**](docs/ListsApi.md#createlist) | **POST** /contacts/lists | Create a list
*ListsApi* | [**DeleteList**](docs/ListsApi.md#deletelist) | **DELETE** /contacts/lists/{listId} | Delete a list
*ListsApi* | [**GetContactsFromList**](docs/ListsApi.md#getcontactsfromlist) | **GET** /contacts/lists/{listId}/contacts | Get the contacts in a list
*ListsApi* | [**GetFolderLists**](docs/ListsApi.md#getfolderlists) | **GET** /contacts/folders/{folderId}/lists | Get the lists in a folder
*ListsApi* | [**GetList**](docs/ListsApi.md#getlist) | **GET** /contacts/lists/{listId} | Get the details of a list
*ListsApi* | [**GetLists**](docs/ListsApi.md#getlists) | **GET** /contacts/lists | Get all the lists
*ListsApi* | [**RemoveContactFromList**](docs/ListsApi.md#removecontactfromlist) | **POST** /contacts/lists/{listId}/contacts/remove | Remove existing contacts from a list
*ListsApi* | [**UpdateList**](docs/ListsApi.md#updatelist) | **PUT** /contacts/lists/{listId} | Update a list
*ProcessApi* | [**GetProcess**](docs/ProcessApi.md#getprocess) | **GET** /processes/{processId} | Return the informations for a process
*ProcessApi* | [**GetProcesses**](docs/ProcessApi.md#getprocesses) | **GET** /processes | Return all the processes for your account
*ResellerApi* | [**AddCredits**](docs/ResellerApi.md#addcredits) | **POST** /reseller/children/{childAuthKey}/credits/add | Add Email and/or SMS credits to a specific child account
*ResellerApi* | [**AssociateIpToChild**](docs/ResellerApi.md#associateiptochild) | **POST** /reseller/children/{childAuthKey}/ips/associate | Associate a dedicated IP to the child
*ResellerApi* | [**CreateResellerChild**](docs/ResellerApi.md#createresellerchild) | **POST** /reseller/children | Creates a reseller child
*ResellerApi* | [**DeleteResellerChild**](docs/ResellerApi.md#deleteresellerchild) | **DELETE** /reseller/children/{childAuthKey} | Deletes a single reseller child based on the childAuthKey supplied
*ResellerApi* | [**DissociateIpFromChild**](docs/ResellerApi.md#dissociateipfromchild) | **POST** /reseller/children/{childAuthKey}/ips/dissociate | Dissociate a dedicated IP to the child
*ResellerApi* | [**GetChildInfo**](docs/ResellerApi.md#getchildinfo) | **GET** /reseller/children/{childAuthKey} | Gets the info about a specific child account
*ResellerApi* | [**GetResellerChilds**](docs/ResellerApi.md#getresellerchilds) | **GET** /reseller/children | Gets the list of all reseller's children accounts
*ResellerApi* | [**RemoveCredits**](docs/ResellerApi.md#removecredits) | **POST** /reseller/children/{childAuthKey}/credits/remove | Remove Email and/or SMS credits from a specific child account
*ResellerApi* | [**UpdateResellerChild**](docs/ResellerApi.md#updateresellerchild) | **PUT** /reseller/children/{childAuthKey} | Updates infos of reseller's child based on the childAuthKey supplied
*SMSCampaignsApi* | [**CreateSmsCampaign**](docs/SMSCampaignsApi.md#createsmscampaign) | **POST** /smsCampaigns | Creates an SMS campaign
*SMSCampaignsApi* | [**DeleteSmsCampaign**](docs/SMSCampaignsApi.md#deletesmscampaign) | **DELETE** /smsCampaigns/{campaignId} | Delete the SMS campaign
*SMSCampaignsApi* | [**GetSmsCampaign**](docs/SMSCampaignsApi.md#getsmscampaign) | **GET** /smsCampaigns/{campaignId} | Get an SMS campaign
*SMSCampaignsApi* | [**GetSmsCampaigns**](docs/SMSCampaignsApi.md#getsmscampaigns) | **GET** /smsCampaigns | Returns the informations for all your created SMS campaigns
*SMSCampaignsApi* | [**RequestSmsRecipientExport**](docs/SMSCampaignsApi.md#requestsmsrecipientexport) | **POST** /smsCampaigns/{campaignId}/exportRecipients | Exports the recipients of the specified campaign.
*SMSCampaignsApi* | [**SendSmsCampaignNow**](docs/SMSCampaignsApi.md#sendsmscampaignnow) | **POST** /smsCampaigns/{campaignId}/sendNow | Send your SMS campaign immediately
*SMSCampaignsApi* | [**SendSmsReport**](docs/SMSCampaignsApi.md#sendsmsreport) | **POST** /smsCampaigns/{campaignId}/sendReport | Send report of SMS campaigns
*SMSCampaignsApi* | [**SendTestSms**](docs/SMSCampaignsApi.md#sendtestsms) | **POST** /smsCampaigns/{campaignId}/sendTest | Send an SMS
*SMSCampaignsApi* | [**UpdateSmsCampaign**](docs/SMSCampaignsApi.md#updatesmscampaign) | **PUT** /smsCampaigns/{campaignId} | Updates an SMS campaign
*SMSCampaignsApi* | [**UpdateSmsCampaignStatus**](docs/SMSCampaignsApi.md#updatesmscampaignstatus) | **PUT** /smsCampaigns/{campaignId}/status | Update the campaign status
*SMTPApi* | [**CreateSmtpTemplate**](docs/SMTPApi.md#createsmtptemplate) | **POST** /smtp/templates | Create an smtp template
*SMTPApi* | [**DeleteHardbounces**](docs/SMTPApi.md#deletehardbounces) | **POST** /smtp/deleteHardbounces | Delete hardbounces
*SMTPApi* | [**DeleteSmtpTemplate**](docs/SMTPApi.md#deletesmtptemplate) | **DELETE** /smtp/templates/{templateId} | Delete an inactive smtp template
*SMTPApi* | [**GetAggregatedSmtpReport**](docs/SMTPApi.md#getaggregatedsmtpreport) | **GET** /smtp/statistics/aggregatedReport | Get your SMTP activity aggregated over a period of time
*SMTPApi* | [**GetEmailEventReport**](docs/SMTPApi.md#getemaileventreport) | **GET** /smtp/statistics/events | Get all your SMTP activity (unaggregated events)
*SMTPApi* | [**GetSmtpReport**](docs/SMTPApi.md#getsmtpreport) | **GET** /smtp/statistics/reports | Get your SMTP activity aggregated per day
*SMTPApi* | [**GetSmtpTemplate**](docs/SMTPApi.md#getsmtptemplate) | **GET** /smtp/templates/{templateId} | Returns the template informations
*SMTPApi* | [**GetSmtpTemplates**](docs/SMTPApi.md#getsmtptemplates) | **GET** /smtp/templates | Get the list of SMTP templates
*SMTPApi* | [**SendTemplate**](docs/SMTPApi.md#sendtemplate) | **POST** /smtp/templates/{templateId}/send | Send a template
*SMTPApi* | [**SendTestTemplate**](docs/SMTPApi.md#sendtesttemplate) | **POST** /smtp/templates/{templateId}/sendTest | Send a template to your test list
*SMTPApi* | [**SendTransacEmail**](docs/SMTPApi.md#sendtransacemail) | **POST** /smtp/email | Send a transactional email
*SMTPApi* | [**UpdateSmtpTemplate**](docs/SMTPApi.md#updatesmtptemplate) | **PUT** /smtp/templates/{templateId} | Updates an smtp templates
*SendersApi* | [**CreateSender**](docs/SendersApi.md#createsender) | **POST** /senders | Create a new sender
*SendersApi* | [**DeleteSender**](docs/SendersApi.md#deletesender) | **DELETE** /senders/{senderId} | Delete a sender
*SendersApi* | [**GetIps**](docs/SendersApi.md#getips) | **GET** /senders/ips | Return all the dedicated IPs for your account
*SendersApi* | [**GetIpsFromSender**](docs/SendersApi.md#getipsfromsender) | **GET** /senders/{senderId}/ips | Return all the dedicated IPs for a sender
*SendersApi* | [**GetSenders**](docs/SendersApi.md#getsenders) | **GET** /senders | Get the list of all your senders
*SendersApi* | [**UpdateSender**](docs/SendersApi.md#updatesender) | **PUT** /senders/{senderId} | Update a sender
*TransactionalSMSApi* | [**GetSmsEvents**](docs/TransactionalSMSApi.md#getsmsevents) | **GET** /transactionalSMS/statistics/events | Get all the SMS activity (unaggregated events)
*TransactionalSMSApi* | [**GetTransacAggregatedSmsReport**](docs/TransactionalSMSApi.md#gettransacaggregatedsmsreport) | **GET** /transactionalSMS/statistics/aggregatedReport | Get your SMS activity aggregated over a period of time
*TransactionalSMSApi* | [**GetTransacSmsReport**](docs/TransactionalSMSApi.md#gettransacsmsreport) | **GET** /transactionalSMS/statistics/reports | Get your SMS activity aggregated per day
*TransactionalSMSApi* | [**SendTransacSms**](docs/TransactionalSMSApi.md#sendtransacsms) | **POST** /transactionalSMS/sms | Send the SMS campaign to the specified mobile number
*WebhooksApi* | [**CreateWebhook**](docs/WebhooksApi.md#createwebhook) | **POST** /webhooks | Create a webhook
*WebhooksApi* | [**DeleteWebhook**](docs/WebhooksApi.md#deletewebhook) | **DELETE** /webhooks/{webhookId} | Delete a webhook
*WebhooksApi* | [**GetWebhook**](docs/WebhooksApi.md#getwebhook) | **GET** /webhooks/{webhookId} | Get a webhook details
*WebhooksApi* | [**GetWebhooks**](docs/WebhooksApi.md#getwebhooks) | **GET** /webhooks | Get all webhooks
*WebhooksApi* | [**UpdateWebhook**](docs/WebhooksApi.md#updatewebhook) | **PUT** /webhooks/{webhookId} | Update a webhook


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AddContactToList](docs/AddContactToList.md)
 - [Model.AddCredits](docs/AddCredits.md)
 - [Model.CreateAttribute](docs/CreateAttribute.md)
 - [Model.CreateAttributeEnumeration](docs/CreateAttributeEnumeration.md)
 - [Model.CreateChild](docs/CreateChild.md)
 - [Model.CreateContact](docs/CreateContact.md)
 - [Model.CreateEmailCampaign](docs/CreateEmailCampaign.md)
 - [Model.CreateEmailCampaignRecipients](docs/CreateEmailCampaignRecipients.md)
 - [Model.CreateEmailCampaignSender](docs/CreateEmailCampaignSender.md)
 - [Model.CreateList](docs/CreateList.md)
 - [Model.CreateModel](docs/CreateModel.md)
 - [Model.CreateReseller](docs/CreateReseller.md)
 - [Model.CreateSender](docs/CreateSender.md)
 - [Model.CreateSenderIps](docs/CreateSenderIps.md)
 - [Model.CreateSenderModel](docs/CreateSenderModel.md)
 - [Model.CreateSmsCampaign](docs/CreateSmsCampaign.md)
 - [Model.CreateSmsCampaignRecipients](docs/CreateSmsCampaignRecipients.md)
 - [Model.CreateSmtpEmail](docs/CreateSmtpEmail.md)
 - [Model.CreateSmtpTemplate](docs/CreateSmtpTemplate.md)
 - [Model.CreateSmtpTemplateSender](docs/CreateSmtpTemplateSender.md)
 - [Model.CreateUpdateContactModel](docs/CreateUpdateContactModel.md)
 - [Model.CreateUpdateFolder](docs/CreateUpdateFolder.md)
 - [Model.CreateWebhook](docs/CreateWebhook.md)
 - [Model.CreatedProcessId](docs/CreatedProcessId.md)
 - [Model.DeleteHardbounces](docs/DeleteHardbounces.md)
 - [Model.EmailExportRecipients](docs/EmailExportRecipients.md)
 - [Model.ErrorModel](docs/ErrorModel.md)
 - [Model.GetAccountMarketingAutomation](docs/GetAccountMarketingAutomation.md)
 - [Model.GetAccountPlan](docs/GetAccountPlan.md)
 - [Model.GetAccountRelay](docs/GetAccountRelay.md)
 - [Model.GetAccountRelayData](docs/GetAccountRelayData.md)
 - [Model.GetAggregatedReport](docs/GetAggregatedReport.md)
 - [Model.GetAttributes](docs/GetAttributes.md)
 - [Model.GetAttributesAttributes](docs/GetAttributesAttributes.md)
 - [Model.GetAttributesEnumeration](docs/GetAttributesEnumeration.md)
 - [Model.GetCampaignOverview](docs/GetCampaignOverview.md)
 - [Model.GetCampaignRecipients](docs/GetCampaignRecipients.md)
 - [Model.GetCampaignStats](docs/GetCampaignStats.md)
 - [Model.GetChildInfoApiKeys](docs/GetChildInfoApiKeys.md)
 - [Model.GetChildInfoApiKeysV2](docs/GetChildInfoApiKeysV2.md)
 - [Model.GetChildInfoApiKeysV3](docs/GetChildInfoApiKeysV3.md)
 - [Model.GetChildInfoCredits](docs/GetChildInfoCredits.md)
 - [Model.GetChildInfoStatistics](docs/GetChildInfoStatistics.md)
 - [Model.GetChildrenList](docs/GetChildrenList.md)
 - [Model.GetClient](docs/GetClient.md)
 - [Model.GetContactCampaignStats](docs/GetContactCampaignStats.md)
 - [Model.GetContactCampaignStatsClicked](docs/GetContactCampaignStatsClicked.md)
 - [Model.GetContactCampaignStatsOpened](docs/GetContactCampaignStatsOpened.md)
 - [Model.GetContactCampaignStatsTransacAttributes](docs/GetContactCampaignStatsTransacAttributes.md)
 - [Model.GetContactCampaignStatsUnsubscriptions](docs/GetContactCampaignStatsUnsubscriptions.md)
 - [Model.GetContactDetails](docs/GetContactDetails.md)
 - [Model.GetContacts](docs/GetContacts.md)
 - [Model.GetEmailCampaigns](docs/GetEmailCampaigns.md)
 - [Model.GetEmailEventReport](docs/GetEmailEventReport.md)
 - [Model.GetEmailEventReportEvents](docs/GetEmailEventReportEvents.md)
 - [Model.GetExtendedCampaignOverviewSender](docs/GetExtendedCampaignOverviewSender.md)
 - [Model.GetExtendedCampaignStats](docs/GetExtendedCampaignStats.md)
 - [Model.GetExtendedClientAddress](docs/GetExtendedClientAddress.md)
 - [Model.GetExtendedContactDetailsStatistics](docs/GetExtendedContactDetailsStatistics.md)
 - [Model.GetExtendedContactDetailsStatisticsClicked](docs/GetExtendedContactDetailsStatisticsClicked.md)
 - [Model.GetExtendedContactDetailsStatisticsLinks](docs/GetExtendedContactDetailsStatisticsLinks.md)
 - [Model.GetExtendedContactDetailsStatisticsMessagesSent](docs/GetExtendedContactDetailsStatisticsMessagesSent.md)
 - [Model.GetExtendedContactDetailsStatisticsOpened](docs/GetExtendedContactDetailsStatisticsOpened.md)
 - [Model.GetExtendedContactDetailsStatisticsUnsubscriptions](docs/GetExtendedContactDetailsStatisticsUnsubscriptions.md)
 - [Model.GetExtendedContactDetailsStatisticsUnsubscriptionsAdminUnsubscription](docs/GetExtendedContactDetailsStatisticsUnsubscriptionsAdminUnsubscription.md)
 - [Model.GetExtendedContactDetailsStatisticsUnsubscriptionsUserUnsubscription](docs/GetExtendedContactDetailsStatisticsUnsubscriptionsUserUnsubscription.md)
 - [Model.GetExtendedListCampaignStats](docs/GetExtendedListCampaignStats.md)
 - [Model.GetFolder](docs/GetFolder.md)
 - [Model.GetFolderLists](docs/GetFolderLists.md)
 - [Model.GetFolders](docs/GetFolders.md)
 - [Model.GetIp](docs/GetIp.md)
 - [Model.GetIpFromSender](docs/GetIpFromSender.md)
 - [Model.GetIps](docs/GetIps.md)
 - [Model.GetIpsFromSender](docs/GetIpsFromSender.md)
 - [Model.GetList](docs/GetList.md)
 - [Model.GetLists](docs/GetLists.md)
 - [Model.GetProcess](docs/GetProcess.md)
 - [Model.GetProcesses](docs/GetProcesses.md)
 - [Model.GetReports](docs/GetReports.md)
 - [Model.GetReportsReports](docs/GetReportsReports.md)
 - [Model.GetSendersList](docs/GetSendersList.md)
 - [Model.GetSendersListIps](docs/GetSendersListIps.md)
 - [Model.GetSendersListSenders](docs/GetSendersListSenders.md)
 - [Model.GetSmsCampaignOverview](docs/GetSmsCampaignOverview.md)
 - [Model.GetSmsCampaignStats](docs/GetSmsCampaignStats.md)
 - [Model.GetSmsCampaigns](docs/GetSmsCampaigns.md)
 - [Model.GetSmsEventReport](docs/GetSmsEventReport.md)
 - [Model.GetSmsEventReportEvents](docs/GetSmsEventReportEvents.md)
 - [Model.GetSmtpTemplateOverview](docs/GetSmtpTemplateOverview.md)
 - [Model.GetSmtpTemplateOverviewSender](docs/GetSmtpTemplateOverviewSender.md)
 - [Model.GetSmtpTemplates](docs/GetSmtpTemplates.md)
 - [Model.GetStatsByDomain](docs/GetStatsByDomain.md)
 - [Model.GetTransacAggregatedSmsReport](docs/GetTransacAggregatedSmsReport.md)
 - [Model.GetTransacSmsReport](docs/GetTransacSmsReport.md)
 - [Model.GetTransacSmsReportReports](docs/GetTransacSmsReportReports.md)
 - [Model.GetWebhook](docs/GetWebhook.md)
 - [Model.GetWebhooks](docs/GetWebhooks.md)
 - [Model.ManageIp](docs/ManageIp.md)
 - [Model.PostContactInfo](docs/PostContactInfo.md)
 - [Model.PostContactInfoContacts](docs/PostContactInfoContacts.md)
 - [Model.PostSendFailed](docs/PostSendFailed.md)
 - [Model.PostSendSmsTestFailed](docs/PostSendSmsTestFailed.md)
 - [Model.RemainingCreditModel](docs/RemainingCreditModel.md)
 - [Model.RemainingCreditModelChild](docs/RemainingCreditModelChild.md)
 - [Model.RemainingCreditModelReseller](docs/RemainingCreditModelReseller.md)
 - [Model.RemoveContactFromList](docs/RemoveContactFromList.md)
 - [Model.RemoveCredits](docs/RemoveCredits.md)
 - [Model.RequestContactExport](docs/RequestContactExport.md)
 - [Model.RequestContactImport](docs/RequestContactImport.md)
 - [Model.RequestContactImportNewList](docs/RequestContactImportNewList.md)
 - [Model.RequestSmsRecipientExport](docs/RequestSmsRecipientExport.md)
 - [Model.SendEmail](docs/SendEmail.md)
 - [Model.SendEmailAttachment](docs/SendEmailAttachment.md)
 - [Model.SendReport](docs/SendReport.md)
 - [Model.SendReportEmail](docs/SendReportEmail.md)
 - [Model.SendSms](docs/SendSms.md)
 - [Model.SendSmtpEmail](docs/SendSmtpEmail.md)
 - [Model.SendSmtpEmailAttachment](docs/SendSmtpEmailAttachment.md)
 - [Model.SendSmtpEmailBcc](docs/SendSmtpEmailBcc.md)
 - [Model.SendSmtpEmailCc](docs/SendSmtpEmailCc.md)
 - [Model.SendSmtpEmailReplyTo](docs/SendSmtpEmailReplyTo.md)
 - [Model.SendSmtpEmailSender](docs/SendSmtpEmailSender.md)
 - [Model.SendSmtpEmailTo](docs/SendSmtpEmailTo.md)
 - [Model.SendTemplateEmail](docs/SendTemplateEmail.md)
 - [Model.SendTestEmail](docs/SendTestEmail.md)
 - [Model.SendTestSms](docs/SendTestSms.md)
 - [Model.SendTransacSms](docs/SendTransacSms.md)
 - [Model.UpdateAttribute](docs/UpdateAttribute.md)
 - [Model.UpdateAttributeEnumeration](docs/UpdateAttributeEnumeration.md)
 - [Model.UpdateCampaignStatus](docs/UpdateCampaignStatus.md)
 - [Model.UpdateChild](docs/UpdateChild.md)
 - [Model.UpdateContact](docs/UpdateContact.md)
 - [Model.UpdateEmailCampaign](docs/UpdateEmailCampaign.md)
 - [Model.UpdateEmailCampaignRecipients](docs/UpdateEmailCampaignRecipients.md)
 - [Model.UpdateEmailCampaignSender](docs/UpdateEmailCampaignSender.md)
 - [Model.UpdateList](docs/UpdateList.md)
 - [Model.UpdateSender](docs/UpdateSender.md)
 - [Model.UpdateSmsCampaign](docs/UpdateSmsCampaign.md)
 - [Model.UpdateSmtpTemplate](docs/UpdateSmtpTemplate.md)
 - [Model.UpdateSmtpTemplateSender](docs/UpdateSmtpTemplateSender.md)
 - [Model.UpdateWebhook](docs/UpdateWebhook.md)
 - [Model.GetChildInfo](docs/GetChildInfo.md)
 - [Model.GetExtendedCampaignOverview](docs/GetExtendedCampaignOverview.md)
 - [Model.GetExtendedClient](docs/GetExtendedClient.md)
 - [Model.GetExtendedContactDetails](docs/GetExtendedContactDetails.md)
 - [Model.GetExtendedList](docs/GetExtendedList.md)
 - [Model.GetSmsCampaign](docs/GetSmsCampaign.md)
 - [Model.GetAccount](docs/GetAccount.md)
 - [Model.GetEmailCampaign](docs/GetEmailCampaign.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="api-key"></a>
### api-key

- **Type**: API key
- **API key parameter name**: api-key
- **Location**: HTTP header

<a name="partner-key"></a>
### partner-key

The partner key should be passed in the request headers as `partner-key` along with `api-key` pair for successful authentication of partner (Optional).

- **Type**: API key
- **API key parameter name**: partner-key
- **Location**: HTTP header

## Support and Feedback

Be sure to visit the SendinBlue official [documentation website](https://sendinblue.readme.io/docs ) for additional information about our API.

If you find a bug, please post the issue on [Github](https://github.com/sendinblue/APIv3-csharp-library/issues).

As always, if you need additional assistance, drop us a note [here](https://account.sendinblue.com/support).
