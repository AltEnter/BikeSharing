using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeSharing.Models;
using FluentValidation;

namespace BikeSharing.Validators
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("用户名不能为空");
            RuleFor(x => x.Password).NotEmpty().WithMessage("密码不能为空");
        }
    }
}
