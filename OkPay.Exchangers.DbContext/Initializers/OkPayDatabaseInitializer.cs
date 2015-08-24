using System;
using System.Collections.Generic;
using System.Data.Entity;
using OkPay.Exchangers.Model;

namespace OkPay.Exchangers.DbContext.Initializers
{
    public class OkPayDatabaseInitializer : CreateDatabaseIfNotExists<OkPayContext>
    {
        protected override void Seed(OkPayContext context)
        {
            var moscowBank = new Exchanger {Id = Guid.NewGuid(), Name = "Банк Москвы"};
            var binBank = new Exchanger {Id = Guid.NewGuid(), Name = "Бин Банк"};
            var sberBank = new Exchanger {Id = Guid.NewGuid(), Name = "Сбербанк"};
            var alfaBank = new Exchanger {Id = Guid.NewGuid(), Name = "Банк Москвы"};

            var euro = new Currency {Id = Guid.NewGuid(), Name = "EUR"};
            var dollar = new Currency { Id = Guid.NewGuid(), Name = "USD" };
            var rubl = new Currency { Id = Guid.NewGuid(), Name = "RUB" };

            #region заполнение курсов валют
            var moskowRubToRub = new CourseMap
            {
                Id = Guid.NewGuid(),
                Exchanger = moscowBank,
                Course = 1.01m,
                FirstCurrency = rubl,
                SecondCurrency = rubl
            };
            var sberRubToUsd = new CourseMap
            {
                Id = Guid.NewGuid(),
                Exchanger = sberBank,
                Course = 0.2m,
                FirstCurrency = rubl,
                SecondCurrency = dollar
            };
            var alfaUsdToRub = new CourseMap
            {
                Id = Guid.NewGuid(),
                Exchanger = alfaBank,
                Course = 35m,
                FirstCurrency = dollar,
                SecondCurrency = rubl
            };
            var alfaUsdToUsd = new CourseMap
            {
                Id = Guid.NewGuid(),
                Exchanger = alfaBank,
                Course = 0.9m,
                FirstCurrency = dollar,
                SecondCurrency = dollar
            };
            var sberEurToEur = new CourseMap
            {
                Id = Guid.NewGuid(),
                Exchanger = sberBank,
                Course = 1.02m,
                FirstCurrency = euro,
                SecondCurrency = euro
            };
            var moskowDollToEur = new CourseMap
            {
                Id = Guid.NewGuid(),
                Exchanger = moscowBank,
                Course = 0.2m,
                FirstCurrency = dollar,
                SecondCurrency = euro
            };
            var sberDollToEur = new CourseMap
            {
                Id = Guid.NewGuid(),
                Exchanger = sberBank,
                Course = 0.3m,
                FirstCurrency = dollar,
                SecondCurrency = euro
            };
            var binDollToEur = new CourseMap
            {
                Id = Guid.NewGuid(),
                Exchanger = binBank,
                Course = 0.15m,
                FirstCurrency = dollar,
                SecondCurrency = euro
            };
            var alfaDollToEur = new CourseMap
            {
                Id = Guid.NewGuid(),
                Exchanger = alfaBank,
                Course = 0.18m,
                FirstCurrency = dollar,
                SecondCurrency = euro
            };

            var moskowEurToDoll = new CourseMap
            {
                Id = Guid.NewGuid(),
                Exchanger = moscowBank,
                Course = 1.2m,
                FirstCurrency = euro,
                SecondCurrency = dollar
            };
            var sberEurToDoll = new CourseMap
            {
                Id = Guid.NewGuid(),
                Exchanger = sberBank,
                Course = 0.3m,
                FirstCurrency = euro,
                SecondCurrency = dollar
            };
            var binRubToEur = new CourseMap
            {
                Id = Guid.NewGuid(),
                Exchanger = binBank,
                Course = 0.05m,
                FirstCurrency = rubl,
                SecondCurrency = euro
            };
            var alfaEurToRub = new CourseMap
            {
                Id = Guid.NewGuid(),
                Exchanger = alfaBank,
                Course = 50m,
                FirstCurrency = euro,
                SecondCurrency = rubl
            };
            #endregion

            var courseMaps = new List<CourseMap>
            {
                moskowDollToEur,
                moskowEurToDoll,
                sberDollToEur,
                sberEurToDoll,
                binDollToEur,
                binRubToEur,
                alfaDollToEur,
                alfaEurToRub,
                moskowRubToRub,
                sberRubToUsd ,
                alfaUsdToRub,
                alfaUsdToUsd,
                sberEurToEur,
            };

            var exchangers = new List<Exchanger>{moscowBank, binBank, sberBank, alfaBank};
            var currencies = new List<Currency> {euro, dollar, rubl};

            context.Currencies.AddRange(currencies);
            context.Exchangers.AddRange(exchangers);
            context.CourseMaps.AddRange(courseMaps);

            base.Seed(context);
        }

    }
}