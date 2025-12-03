using MyScale.Domain.Base;
using MyScale.Domain.Responses;

namespace MyScale.Domain.Interfaces.Gateways;

public interface IViaCepGateway
{
    Task<Result<AddressLookupResult>> GetAddressByCepAsync(string zipCode);
}