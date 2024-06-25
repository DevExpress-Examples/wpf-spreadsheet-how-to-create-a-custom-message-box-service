<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/143886538/17.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830548)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# WPF Spreadsheet - How to customize a message dialog displayed when a runtime error occurs


This example demonstrates how to display a custom message in place of the default user warning dialog box.

Create a class that implements the [IMessageBox](https://documentation.devexpress.com/CoreLibraries/DevExpress.XtraSpreadsheet.Services.IMessageBoxService.class) service and use the [SpreadsheetControl.ReplaceService](https://documentation.devexpress.com/WPF/DevExpress.Xpf.Spreadsheet.SpreadsheetControl.ReplaceService~T~.method) method to register this class in place of the default service. Note that due to WPF Spreadsheet implementation specifics, it is necessary to replace the built-in service **after the control is completely loaded**.

The [IMessageBox](https://documentation.devexpress.com/CoreLibraries/DevExpress.XtraSpreadsheet.Services.IMessageBoxService.class) service provides the [ShowMessage](https://documentation.devexpress.com/CoreLibraries/DevExpress.XtraSpreadsheet.Services.IMessageBoxService.ShowMessage.method), [ShowOkCancelMessage](https://documentation.devexpress.com/CoreLibraries/DevExpress.XtraSpreadsheet.Services.IMessageBoxService.ShowOkCancelMessage.method), [ShowYesNoCancelMessage](https://documentation.devexpress.com/CoreLibraries/DevExpress.XtraSpreadsheet.Services.IMessageBoxService.ShowYesNoCancelMessage.method), [ShowYesNoMessage](https://documentation.devexpress.com/CoreLibraries/DevExpress.XtraSpreadsheet.Services.IMessageBoxService.ShowYesNoMessage.method), and [ShowDataValidationDialog](https://documentation.devexpress.com/CoreLibraries/DevExpress.XtraSpreadsheet.Services.IMessageBoxService.ShowDataValidationDialog.method) methods that are called when the SpreadsheetControl needs user attention.

See the following files for implementation details:

CS | VB
------------ | -------------
[MainWindow.xaml](./CS/WpfSpreadsheet_MessageBoxService/MainWindow.xaml) | [MainWindow.xaml](./VB/WpfSpreadsheet_MessageBoxService/MainWindow.xaml)
[MainWindow.xaml.cs](./CS/WpfSpreadsheet_MessageBoxService/MainWindow.xaml.cs) | [MainWindow.xaml.vb](./VB/WpfSpreadsheet_MessageBoxService/MainWindow.xaml.vb)
[**MyMessageBoxService.cs**](./CS/WpfSpreadsheet_MessageBoxService/MyMessageBoxService.cs) | [**MyMessageBoxService.vb**](./VB/WpfSpreadsheet_MessageBoxService/MyMessageBoxService.vb)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-spreadsheet-how-to-create-a-custom-message-box-service&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-spreadsheet-how-to-create-a-custom-message-box-service&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
