// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
namespace Fievus.Windows.Samples.SimpleLoginDemo.Presentation.Login
{
    public interface IUserAuthentication
    {
        UserAuthenticationResult Authenticate(LoginContent loginContent);
    }
}
