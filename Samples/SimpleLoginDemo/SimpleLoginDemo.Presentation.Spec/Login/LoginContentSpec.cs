﻿// Copyright (C) 2018-2021 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Carna;

namespace Charites.Windows.Samples.SimpleLoginDemo.Presentation.Login
{
    [Specification("LoginContent Spec")]
    class LoginContentSpec : FixtureSteppable
    {
        LoginContent LoginContent { get; } = new LoginContent();

        [Example("Validates the user id and the password")]
        [Sample(null, null, false, Description = "When the user id is null and the password is null")]
        [Sample("", "", false, Description = "When the user id is empty and the password is empty")]
        [Sample(null, "password", false, Description = "When the user id is null and the password is not null or empty")]
        [Sample("", "password", false, Description = "When the user id is empty and the password is not null or empty")]
        [Sample("user", null, false, Description = "When the user id is not null or empty and the password is null")]
        [Sample("user", "", false, Description = "When the user id is not null or empty and the password is empty")]
        [Sample("user", "password", true, Description = "When the user id is not null or empty and the password is not null or empty")]
        void Ex01(string userId, string password, bool expected)
        {
            When("the user id is set", () => LoginContent.UserId.Value = userId);
            When("the password is set", () => LoginContent.Password.Value = password);
            Then($"the result should be {expected}", () => LoginContent.IsValid.Value == expected);
        }
    }
}
