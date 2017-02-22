using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using ReactiveUI;
using Splat;

namespace BikeSharing.InputModels
{
    public abstract class InputModel
    {
        private readonly AbstractValidator<InputModel> _validator;

        public bool IsValid => _validator.Validate(this).IsValid;

        public IDictionary<string, string> Errors => 
            _validator.Validate(this).Errors.ToDictionary(x => x.PropertyName, x => x.ErrorMessage);

        public InputModel()
        {
            _validator = Locator.Current.GetService(GetType()) as AbstractValidator<InputModel>;
        }
    }
}
