﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BikeSharing.InputModels;
using ReactiveUI;

namespace BikeSharing.ViewModels
{
    public class LoginViewModel : ViewModel
    {
        private LoginInputModel _loginInputModel;

        public LoginInputModel LoginInputModel
        {
            get => _loginInputModel;
            set => this.RaiseAndSetIfChanged(ref _loginInputModel, value);
        }


        private string _userName;
        public string UserName
        {
            get => _userName;
            set => this.RaiseAndSetIfChanged(ref _userName, value);
        }

        private ObservableAsPropertyHelper<string> _userNameError;

        public string UserNameError => _userNameError?.Value ?? null;

        private string _password;

        public string Password
        {
            get => _password;
            set => this.RaiseAndSetIfChanged(ref _password, value);
        }

        private ObservableAsPropertyHelper<string> _passwordError;

        public string PasswordError => _passwordError?.Value ?? null;

        public ReactiveCommand Login { get; private set; }

        public LoginViewModel(IScreen hostScreen) : base(hostScreen)
        {
            this.WhenAnyValue(x => x.UserName, selector: userName => Validate(userName))
                .ToProperty(this, x => x.UserNameError, out _userNameError);
            this.WhenAnyValue(x => x.Password, selector: password => Validate(password))
                .ToProperty(this, x =>x.PasswordError, out _passwordError);

            
        }

        private string Validate(string userName)
        {
            return userName;
        }
    }
}
