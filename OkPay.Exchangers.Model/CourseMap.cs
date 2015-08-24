using System;

namespace OkPay.Exchangers.Model
{
    public class CourseMap
    {
        public Guid Id { get; set; }

        public virtual Exchanger Exchanger { get; set; }

        public virtual Currency FirstCurrency { get; set; }

        public virtual Currency SecondCurrency { get; set; }

        public decimal Course { get; set; }
    }
}