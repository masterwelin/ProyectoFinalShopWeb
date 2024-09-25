using Shop.Web.Data.Dtos;

namespace Shop.Web.Data.Interfaces
{
    public interface ICustomers
    {
        void SaveCustomers(CustomersAddDto addDto);
        void RemoveCustomers(CustomersRemoveDto removeDto);
        void UpdateCustomers(CustomersUpdateDto updateDto);
        List<CustomersAddDto> GetCustomers();

        CustomersAddDto GetCustomersById(int CustomersId);
    }
}
