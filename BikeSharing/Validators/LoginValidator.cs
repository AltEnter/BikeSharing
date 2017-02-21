using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeSharing.InputModels;
using FluentValidation;

namespace BikeSharing.Validators
{
    public class LoginValidator:AbstractValidator<LoginInputModel>
    {
        public LoginValidator()
        {
           
        }
    }
}
