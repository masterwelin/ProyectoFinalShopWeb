using Shop.Web.Data.Dtos;

namespace Shop.Web.Data.Interfaces
{
    public interface IEmployees
    {
        void SaveEmployees(EmployeesAddDto addDto);
        void RemoveEmployees(EmployeesRemoveDto removeDto);
        void UpdateEmployees(EmployeesUpdateDto updateDto);
        List<EmployeesAddDto> GetEmployees();

        EmployeesAddDto GetEmployeesById(int employeesId);

    }

}
