
using RealEstate_Dapper_Api.Dtos.EmployeeDtos;

namespace RealEstate_Dapper_Api.Repositories.EmployeeRepository
{
    public interface IEmployeeRepository
    {
        public Task<List<ResultEmployeDto>> GetAllEmployeeAsync();
        void CreateEmployee(CreateEmployeDto employeDto);
        void DeleteEmployee(int id);
        void UpdateEmployee(UpdateEmployeDto updateEmployeDto);
        Task<GetByIdEmployeeDto> GetEmployee(int id);
    }
}
