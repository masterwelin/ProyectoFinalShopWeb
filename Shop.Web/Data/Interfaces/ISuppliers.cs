using Shop.Web.Data.Dtos;

namespace Shop.Web.Data.Interfaces
{
    public interface ISuppliers
    {
        void SaveSuppliers(SuppliersAddDto addDto);
        void RemoveSuppliers(SuppliersRemoveDto removeDto);
        void UpdateSuppliers(SuppliersUpdateDto updateDto);
        List<SuppliersAddDto> GetSuppliers();

        SuppliersAddDto GetSuppliersById(int SuppliersId);
    }
}
