namespace Services;
using System.ServiceProcess;

public static class Run {
    public static void Default() {
        // ServiceController[] services = ServiceController.GetServices(Environment.MachineName.ToString());
        ServiceController[] services = ServiceController.GetServices();

        foreach (ServiceController service in services)
        {
            Console.WriteLine($"Serviço: {service.DisplayName}");
        }
        System.Console.WriteLine($"Total de Serviços: {services.Count()}");
    }
}