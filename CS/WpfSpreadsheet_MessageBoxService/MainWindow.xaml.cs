using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WpfSpreadsheet_MessageBoxService
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DevExpress.Xpf.Core.ThemedWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void spreadsheet_Loaded(object sender, RoutedEventArgs e)
        {
            Dispatcher.BeginInvoke(new Action(() =>
            {
                ReplaceMessageBoxService();
            }), System.Windows.Threading.DispatcherPriority.Render);
        }

        private void ReplaceMessageBoxService()
        {
            // Replace the default MessageBoxService service with a custom one.
            MyMessageBoxService service = new MyMessageBoxService();
            spreadsheet.ReplaceService<DevExpress.XtraSpreadsheet.Services.IMessageBoxService>(service);
        }
    }
}
