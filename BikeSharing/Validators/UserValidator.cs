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
            RuleFor(x => x.UserName)
                .NotEmpty().WithMessage("用户名不能为空")
                .NotNull().WithMessage("用户名不能为空")
                .Length(3, 10).WithMessage("用户名必须大于3个字符");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("密码不能为空")
                .NotNull().WithMessage("密码不能为空")
                .Length(6, 250).WithMessage("密码长度不能小于6个字符");
        }
    }
}
