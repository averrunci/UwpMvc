// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Charites.Windows.Samples.SimpleLoginDemo.Presentation.Login;

namespace Charites.Windows.SamplesSimpleLoginDemo.Adapter.User
{
    public class UserAuthentication : IUserAuthentication
    {
        protected virtual UserAuthenticationResult Authenticate(LoginContent loginContent)
            => loginContent.UserId.Value == loginContent.Password.Value ? UserAuthenticationResult.Success : UserAuthenticationResult.Failure;

        UserAuthenticationResult IUserAuthentication.Authenticate(LoginContent loginContent)
            => Authenticate(loginContent);
    }
}
