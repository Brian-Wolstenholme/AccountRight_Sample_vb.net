AccountRight_Sample_vb.net

Demonstrates Oauth connecting to Web API
==========================
=======
VB.Net Sample App
==========================
Desktop sample app demonstrating accessing the AccountRight Live API using the SDK in vb.net

AccountRight API - VB.NET desktop app
----------------------------------------
•	Uses the new .Net SDK released with version 2 of the API
•	Navigates available files on local and cloud server
•	Manages OAuth login (note: SDK manages refreshing of tokens!)
•	Demonstrates use of paging through listing of invoices
•	Shows how to create new service invoices 

Requirements
---------------
•	Visual Studio 2010 with Visual Basic
•	To access local server: AccountRight 2013.3 and API 
•	To access cloud server: MYOBApi developer key and secret

Getting up and running
-------------------------
Unzip source code to a local folder and open the solution file. Install the MYOB.AccountRight.API.SDK NuGet package (i.e. type “Install-Package MYOB.AccountRight.API.SDK” in the package manager console), then compile and run. To use the cloud service with the sample change the placeholder Key and Secret in the code with your own.  

The following blog post provides more details about getting started with the sample: VB.Net sample using the new AccountRight API SDK (http://myobapi.tumblr.com/post/58280200848/vb-net-sample-using-the-new-accountright-api-sdk)

