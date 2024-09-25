using Shop.Web.Data.Dtos;

namespace Shop.Web.Data.Interfaces
{
    public interface IShippers
    {
        void SaveShippers(ShippersAddDto addDto);
        void RemoveShippers(ShippersRemoveDto removeDto);
        void UpdateShippers(ShippersUpdateDto updateDto);
        List<ShippersAddDto> GetShippers();

        ShippersAddDto GetShippersById(int ShippersId);
    }
}
