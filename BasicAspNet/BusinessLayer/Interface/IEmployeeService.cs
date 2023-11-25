using BasicAspNet.Infrastructure.Interface;
using BasicAspNet.Models;

namespace BasicAspNet.BusinessLayer.Interface
{
    public interface IEmployeeService: IAsyncRepository<Employee>
    {
        public Task<string> GetEmployeeName(int id);

    }
}
