using BasicAspNet.BusinessLayer.Interface;
using BasicAspNet.Infrastructure.Reporitory;
using BasicAspNet.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicAspNet.BusinessLayer.Service
{
    public class EmployeeService: AsyncRepository<Employee>,IEmployeeService
    {
        public EmployeeService(EmployeeDbContext dbContext) : base(dbContext)
        {
        }


        public async Task<string> GetEmployeeName(int id)
        {
            var employee = await Get(id);

            return employee.Name;
        }
    }
}
