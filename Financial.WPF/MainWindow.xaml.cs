using Financial.ApplicationApp.Interfaces;
using System.Windows;

namespace Financial.WPF
{
    public partial class MainWindow : Window
    {
        private readonly InterfaceFinancialMovementApp _InterfaceFinancialMovementApp;
        public MainWindow(InterfaceFinancialMovementApp _InterfaceFinancialMovementApp)
        {            
            InitializeComponent();
            this._InterfaceFinancialMovementApp = _InterfaceFinancialMovementApp;

            teste();
        }

        private async void teste()
        {
            await _InterfaceFinancialMovementApp.List();
        }
    }
}
