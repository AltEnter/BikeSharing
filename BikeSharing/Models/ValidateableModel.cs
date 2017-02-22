using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using ReactiveUI;
using Splat;

namespace BikeSharing.Models
{
    public abstract class ValidateableModel:ReactiveObject
    {
        private readonly AbstractValidator<ValidateableModel> _validator;

        public bool IsValid => _validator.Validate(this).IsValid;

        public IDictionary<string, string> Errors => 
            _validator.Validate(this).Errors.ToDictionary(x => x.PropertyName, x => x.ErrorMessage);

        public ValidateableModel()
        {
            _validator = Locator.Current.GetService(GetType()) as AbstractValidator<ValidateableModel>;
        }
    }
}
