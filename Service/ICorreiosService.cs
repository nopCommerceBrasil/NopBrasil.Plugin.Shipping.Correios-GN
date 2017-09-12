using Grand.Core.Domain.Directory;
using Grand.Services.Directory;
using Grand.Services.Shipping;

namespace NopBrasil.Plugin.Shipping.Correios.Service
{
    public interface ICorreiosService
    {
        WSCorreiosCalcPrecoPrazo.cResultado RequestCorreios(GetShippingOptionRequest getShippingOptionRequest);

        decimal GetConvertedRateToPrimaryCurrency(decimal rate);
    }
}
