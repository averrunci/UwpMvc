// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Fievus.Windows.Samples.SimpleLoginDemo.Presentation.Login;

namespace Fievus.Windows.Samples.SimpleLoginDemo.Adapter.User
{
    public class UserAuthentication : IUserAuthentication
    {
        protected virtual UserAuthenticationResult Authenticate(LoginContent loginContent) =>
            loginContent.UserId.Value == loginContent.Password.Value ? UserAuthenticationResult.Success : UserAuthenticationResult.Failure;

        UserAuthenticationResult IUserAuthentication.Authenticate(LoginContent loginContent) =>
            Authenticate(loginContent);
    }
}
