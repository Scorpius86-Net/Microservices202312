using Microservices.SOA.Client.Models;

namespace Microservices.SOA.Client.Helper
{
    public static class PriceCalculator
    {
        public static int GetPrice(Order order)
        {
            return order.Weight < 10 ? 6 : 10;
        }
    }
}
