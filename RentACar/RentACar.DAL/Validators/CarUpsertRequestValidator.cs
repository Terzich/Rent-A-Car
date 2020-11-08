using FluentValidation;
using RentACar.DAL.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.DAL.Validators
{
    public class CarUpsertRequestValidator : AbstractValidator<CarUpsertRequest>
    {
        public CarUpsertRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().Matches("^[A-Za-z0-9 ]*$");
            RuleFor(x => x.NumberOfDoors).NotEmpty().LessThan(6);
            RuleFor(x => x.YearOfProduction).NotEmpty().LessThan(2021).GreaterThan(2000);

        }
    }
}
