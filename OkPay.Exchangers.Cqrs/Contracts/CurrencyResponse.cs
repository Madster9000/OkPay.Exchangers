using System;

namespace OkPay.Exchangers.Cqrs.Contracts
{
    public class CurrencyResponse
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
    }
}