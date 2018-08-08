Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Controls

Namespace WpfSpreadsheet_MessageBoxService
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits DevExpress.Xpf.Core.ThemedWindow

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub spreadsheet_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dispatcher.BeginInvoke(New Action(Sub()
                ReplaceMessageBoxService()
            End Sub), System.Windows.Threading.DispatcherPriority.Render)
        End Sub

        Private Sub ReplaceMessageBoxService()
            ' Replace the default MessageBoxService service with a custom one.
            Dim service As New MyMessageBoxService()
            spreadsheet.ReplaceService(Of DevExpress.XtraSpreadsheet.Services.IMessageBoxService)(service)
        End Sub
    End Class
End Namespace
