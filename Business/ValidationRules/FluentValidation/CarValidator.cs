using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {

            RuleFor(c => c.BrandID).NotNull();
            RuleFor(c => c.ColorID).NotNull();
            RuleFor(c => c.Descriptions).MinimumLength(3);
            RuleFor(c => c.DailyPrice).GreaterThan(0);
        }
    }
}
