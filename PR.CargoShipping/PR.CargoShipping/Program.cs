using Microsoft.Extensions.DependencyInjection;
using PR.CargoShipping.Repository;
using PR.CargoShipping.Service;
using System.ServiceProcess;

namespace PR.CargoShipping
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var frmTrips = serviceProvider.GetRequiredService<frmTrips>();
                Application.Run(frmTrips);
            }
        }

        static void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<frmTrips>();
            services.AddTransient<ITripSegmentService, TripSegmentService>();
            services.AddTransient<ITripSegmentRepository, TripSegmentRepository>();
        }
    }
}