Imports DevExpress.Spreadsheet
Imports DevExpress.Xpf.Core
Imports DevExpress.XtraSpreadsheet.Localization
Imports System.Windows
Imports System.Windows.Forms

Namespace WpfSpreadsheet_MessageBoxService
    Public Class MyMessageBoxService
        Implements DevExpress.XtraSpreadsheet.Services.IMessageBoxService

        Private Const myMessage As String = "This is a custom message box." & vbLf & vbLf
        ' To test: enter incorrect data into cells with a data validation rule applied. 
        Public Function ShowDataValidationDialog(ByVal message As String, ByVal title As String, ByVal errorStyle As DataValidationErrorStyle) As DialogResult
            Dim customMessage As String = myMessage & message
            If errorStyle Is DataValidationErrorStyle.Stop Then
                Dim result As MessageBoxResult = DXMessageBox.Show(customMessage, title, MessageBoxButton.OKCancel, MessageBoxImage.Stop)
                Return If(result = MessageBoxResult.OK, DialogResult.No, CType(result, DialogResult))
            End If
            If errorStyle Is DataValidationErrorStyle.Warning Then
                Return CType(DXMessageBox.Show(customMessage, title, MessageBoxButton.YesNoCancel, MessageBoxImage.Warning), DialogResult)
            End If
            Return CType(DXMessageBox.Show(customMessage, title, MessageBoxButton.OKCancel, MessageBoxImage.Information), DialogResult)
        End Function

        ' To test: set the row height to an invalid value.
        Public Function ShowMessage(ByVal message As String, ByVal title As String, ByVal icon As MessageBoxIcon) As DialogResult
            Dim customMessage As String = myMessage & message
            DXMessageBox.Show(customMessage, title, MessageBoxButton.OK, CType(icon, MessageBoxImage))
            Return DialogResult.OK
        End Function

        ' To test: select cells with different data validation rules applied and click Data Validation to invoke the Data Validation dialog.
        Public Function ShowOkCancelMessage(ByVal message As String) As Boolean
            Dim customMessage As String = myMessage & message
            ' Hide the 'Do you want to replace the contents of the destination cells?' message.
            ' This message appears when you overwrite the existing cell content (e.g., when you drag and drop cells to another location).
            If message = XtraSpreadsheetLocalizer.GetString(XtraSpreadsheetStringId.Msg_CanReplaceTheContentsOfTheDestinationCells) Then
                Return True
            End If
            Return DXMessageBox.Show(customMessage, System.Windows.Forms.Application.ProductName, MessageBoxButton.OKCancel, MessageBoxImage.Warning) = MessageBoxResult.OK
        End Function

        ' To test: select a cell range with and without data validation settings and click Data Validation to invoke the Data Validation dialog.
        Public Function ShowYesNoCancelMessage(ByVal message As String) As DialogResult
            Dim customMessage As String = myMessage & message
            Return CType(DXMessageBox.Show(customMessage, System.Windows.Forms.Application.ProductName, MessageBoxButton.YesNoCancel, MessageBoxImage.Information), DialogResult)
        End Function

        ' To test: delete a defined name in the Name Manager dialog.
        Public Function ShowYesNoMessage(ByVal message As String) As Boolean
            Dim customMessage As String = myMessage & message
            Return DXMessageBox.Show(customMessage, System.Windows.Forms.Application.ProductName, MessageBoxButton.YesNo, MessageBoxImage.Warning) = MessageBoxResult.Yes
        End Function
    End Class
End Namespace
