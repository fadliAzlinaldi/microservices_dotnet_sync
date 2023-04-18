using ProductServices.Dtos;

namespace ProductServices.SyncDataServices.Http
{
    public interface IOrderDataClient
    {
        Task SendProductToOrder(ReadProductDto readProductDto);
    }
}
