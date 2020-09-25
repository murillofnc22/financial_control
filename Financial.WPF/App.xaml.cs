using Financial.ApplicationApp.Interfaces;
using Financial.ApplicationApp.OpenApp;
using Financial.Domain.Interfaces.Generics;
using Financial.Domain.Interfaces.InterfaceFinancialMovement;
using Financial.Domain.Interfaces.InterfaceServices;
using Financial.Domain.Services;
using Financial.Infra.Repository.Generic;
using Financial.Infra.Repository.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace Financial.WPF
{
    public partial class App : Application
    {
        ServiceProvider serviceProvider;
        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton(typeof(IGeneric<>), typeof(RespositoryGeneric<>));
            
            services.AddSingleton<IFinancialMovement, RepositoryFinancialMovement>();
            services.AddSingleton<InterfaceFinancialMovementApp, AppFinancialMovement>();
            services.AddSingleton<IServiceFinancialMovement, ServiceFinancialMovement>();

            services.AddSingleton<MainWindow>();
        }
        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }
}
