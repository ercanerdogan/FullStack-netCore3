using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string productAdded = "Product was successfully added";
        public static string productUpdated = "Product info was successfully updated";
        public static string productDeleted = "Product was successfully deleted";

        public static string categoryAdded = "Category was successfully added";
        public static string categoryUpdated = "Category info was successfully updated";
        public static string categoryDeleted = "Category was successfully deleted";

        public static string UserNotFound = "User not found";

        public static string PasswordError = "User password is not valid";

        public static string SuccesfulLogin = "Login succesfull";

        public static string UserAlreadyExists = "User name is already exists";

        public static string UserRegisteredSuccessful = "User has been registered successfully ";

        public static string AccessTokenCreated = "Access token has been created successfully";
    }
}
