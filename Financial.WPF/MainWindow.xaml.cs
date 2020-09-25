using Financial.ApplicationApp.Interfaces;
using Financial.Entities.Entities;
using System;
using System.Threading.Tasks;
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

            RefreshGrid();
        }

        private async void RefreshGrid()
        {
            DgvMovimentações.ItemsSource = await _InterfaceFinancialMovementApp.List();
        }

        private async void InsereMovimentacao()
        {
            await _InterfaceFinancialMovementApp.Add(new FinancialMovement() { Tipo_movimentacao = true, Valor = 150, Categoria = "Casa", Forma_pagamento = "Boleto", Data_pagamento = DateTime.Today, Data_recebimento = DateTime.Today, Data_vencimento = DateTime.Today, Taxas = 0 });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InsereMovimentacao();
            RefreshGrid();
        }
    }
}
