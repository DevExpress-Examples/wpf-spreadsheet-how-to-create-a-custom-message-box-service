using DevExpress.Portable;
using DevExpress.Spreadsheet;
using DevExpress.Xpf.Core;
using DevExpress.XtraSpreadsheet.Localization;
using System.Windows;
using System.Windows.Forms;

namespace WpfSpreadsheet_MessageBoxService
{
    public class MyMessageBoxService : DevExpress.XtraSpreadsheet.Services.IMessageBoxService
    {
        const string myMessage = "This is a custom message box.\n\n";
        // To test: enter incorrect data into cells with a data validation rule applied. 
        public PortableDialogResult ShowDataValidationDialog(string message, string title, DataValidationErrorStyle errorStyle)
        {
            string customMessage = myMessage + message;
            if (errorStyle == DataValidationErrorStyle.Stop)
            {
                MessageBoxResult result = DXMessageBox.Show(customMessage, title, MessageBoxButton.OKCancel, MessageBoxImage.Stop);
                return result == MessageBoxResult.OK ? PortableDialogResult.No : (PortableDialogResult)result;
            }
            if (errorStyle == DataValidationErrorStyle.Warning)
                return (PortableDialogResult)DXMessageBox.Show(customMessage, title, MessageBoxButton.YesNoCancel, MessageBoxImage.Warning);
            return (PortableDialogResult)DXMessageBox.Show(customMessage, title, MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }

        // To test: set the row height to an invalid value.
        public PortableDialogResult ShowMessage(string message, string title, PortableMessageBoxIcon icon)
        {
            string customMessage = myMessage + message;
            DXMessageBox.Show(customMessage, title, MessageBoxButton.OK, (MessageBoxImage)icon);
            return PortableDialogResult.OK;
        }

        // To test: select cells with different data validation rules applied and click Data Validation to invoke the Data Validation dialog.
        public bool ShowOkCancelMessage(string message)
        {
            string customMessage = myMessage + message;
            // Hide the 'Do you want to replace the contents of the destination cells?' message.
            // This message appears when you overwrite the existing cell content (e.g., when you drag and drop cells to another location).
            if (message == XtraSpreadsheetLocalizer.GetString(XtraSpreadsheetStringId.Msg_CanReplaceTheContentsOfTheDestinationCells))
                return true;
            return DXMessageBox.Show(customMessage, System.Windows.Forms.Application.ProductName, MessageBoxButton.OKCancel, MessageBoxImage.Warning) == MessageBoxResult.OK;
        }

        // To test: select a cell range with and without data validation settings and click Data Validation to invoke the Data Validation dialog.
        public PortableDialogResult ShowYesNoCancelMessage(string message)
        {
            string customMessage = myMessage + message;
            return (PortableDialogResult)DXMessageBox.Show(customMessage, System.Windows.Forms.Application.ProductName, MessageBoxButton.YesNoCancel, MessageBoxImage.Information);
        }

        // To test: delete a defined name in the Name Manager dialog.
        public bool ShowYesNoMessage(string message)
        {
            string customMessage = myMessage + message;
            return DXMessageBox.Show(customMessage, System.Windows.Forms.Application.ProductName, MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes;
        }
    }
}
