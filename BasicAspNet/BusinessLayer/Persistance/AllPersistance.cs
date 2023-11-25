using BasicAspNet.BusinessLayer.Interface;
using BasicAspNet.BusinessLayer.Service;
using BasicAspNet.Infrastructure.Interface;
using BasicAspNet.Infrastructure.Reporitory;
using BasicAspNet.Models;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace BasicAspNet.BusinessLayer.Persistance
{
    public static class AllPersistance
    {
        public static IServiceCollection InjectEmployeePersistance(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeService, EmployeeService>();
            return services;
        }
    }
}
