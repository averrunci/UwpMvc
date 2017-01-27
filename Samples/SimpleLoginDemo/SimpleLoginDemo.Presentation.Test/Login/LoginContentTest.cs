// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Xunit;

namespace Fievus.Windows.Samples.SimpleLoginDemo.Presentation.Login
{
    public class LoginContentTest
    {
        [Fact]
        public void ShoudNotBeValidWhenUserIdAndPasswordAreNull()
        {
            var loginContent = new LoginContent();

            loginContent.UserId.Value = null;
            loginContent.Password.Value = null;

            Assert.False(loginContent.IsValid.Value);
        }

        [Fact]
        public void ShouldNotBeValidWhenUserIdAndPasswordAreEmpty()
        {
            var loginContent = new LoginContent();

            loginContent.UserId.Value = string.Empty;
            loginContent.Password.Value = string.Empty;

            Assert.False(loginContent.IsValid.Value);
        }

        [Fact]
        public void ShouldNotBeValidWhenUserIdIsNullAndPasswordIsNotNullOrEmpty()
        {
            var loginContent = new LoginContent();

            loginContent.UserId.Value = null;
            loginContent.Password.Value = "password";

            Assert.False(loginContent.IsValid.Value);
        }

        [Fact]
        public void ShouldNotBeValidWhenUserIdIsEmptyAndPasswordIsNotNullOrEmpty()
        {
            var loginContent = new LoginContent();

            loginContent.UserId.Value = string.Empty;
            loginContent.Password.Value = "password";

            Assert.False(loginContent.IsValid.Value);
        }

        [Fact]
        public void ShouldNotBeValidWhenUserIdIsNotNullOrEmptyAndPasswordIsNull()
        {
            var loginContent = new LoginContent();

            loginContent.UserId.Value = "user";
            loginContent.Password.Value = null;

            Assert.False(loginContent.IsValid.Value);
        }

        [Fact]
        public void ShouldNotBeValidWhenUserIdIsNotNullOrEmptyAndPasswordIsEmpty()
        {
            var loginContent = new LoginContent();

            loginContent.UserId.Value = "user";
            loginContent.Password.Value = string.Empty;

            Assert.False(loginContent.IsValid.Value);
        }

        [Fact]
        public void ShouldBeValidWhenUserIdIsNotNullOrEmptyAndPasswordIsNotNullOrEmpty()
        {
            var loginContent = new LoginContent();

            loginContent.UserId.Value = "user";
            loginContent.Password.Value = "password";

            Assert.True(loginContent.IsValid.Value);
        }

        [Fact]
        public void ShouldRaiseLoginRequestedEventWhenLoginIsCalled()
        {
            var loginContent = new LoginContent();
            loginContent.UserId.Value = "user";
            loginContent.Password.Value = "password";

            var loginRequested = false;
            loginContent.LoginRequested += (s, e) => loginRequested = true;

            loginContent.Login();

            Assert.True(loginRequested);
        }

        [Fact]
        public void ShouldNotRaiseLoginRequestedEventWhenContentIsNotValid()
        {
            var loginContent = new LoginContent();

            var loginRequested = false;
            loginContent.LoginRequested += (s, e) => loginRequested = false;

            loginContent.Login();

            Assert.False(loginRequested);
        }
    }
}
