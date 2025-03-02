﻿namespace AdminPanel;

public static partial class ESM
{
    public const string CartPage = "~/esm/Modules/Conne/Cart/CartPage.js";
    public const string CategoryPage = "~/esm/Modules/Conne/Category/CategoryPage.js";
    public const string LanguagePage = "~/esm/Modules/Administration/Language/LanguagePage.js";
    public const string LoginPage = "~/esm/Modules/Membership/Account/Login/LoginPage.js";
    public const string ProductPage = "~/esm/Modules/Conne/Product/ProductPage.js";
    public const string ReviewPage = "~/esm/Modules/Conne/Review/ReviewPage.js";
    public const string RolePage = "~/esm/Modules/Administration/Role/RolePage.js";
    public const string ScriptInit = "~/esm/Modules/Common/ScriptInit.js";
    public const string SignUpPage = "~/esm/Modules/Membership/Account/SignUp/SignUpPage.js";
    public const string TranslationPage = "~/esm/Modules/Administration/Translation/TranslationPage.js";
    public const string UserPage = "~/esm/Modules/Administration/User/UserPage.js";

    public static partial class Modules
    {
        public static partial class Administration
        {
            public static partial class Language
            {
                public const string LanguagePage = "~/esm/Modules/Administration/Language/LanguagePage.js";
            }

            public static partial class Role
            {
                public const string RolePage = "~/esm/Modules/Administration/Role/RolePage.js";
            }

            public static partial class Translation
            {
                public const string TranslationPage = "~/esm/Modules/Administration/Translation/TranslationPage.js";
            }

            public static partial class User
            {
                public const string UserPage = "~/esm/Modules/Administration/User/UserPage.js";
            }
        }

        public static partial class Common
        {
            public const string ScriptInit = "~/esm/Modules/Common/ScriptInit.js";
        }

        public static partial class Conne
        {
            public static partial class Cart
            {
                public const string CartPage = "~/esm/Modules/Conne/Cart/CartPage.js";
            }

            public static partial class Category
            {
                public const string CategoryPage = "~/esm/Modules/Conne/Category/CategoryPage.js";
            }

            public static partial class Product
            {
                public const string ProductPage = "~/esm/Modules/Conne/Product/ProductPage.js";
            }

            public static partial class Review
            {
                public const string ReviewPage = "~/esm/Modules/Conne/Review/ReviewPage.js";
            }
        }

        public static partial class Membership
        {
            public static partial class Account
            {
                public static partial class Login
                {
                    public const string LoginPage = "~/esm/Modules/Membership/Account/Login/LoginPage.js";
                }

                public static partial class SignUp
                {
                    public const string SignUpPage = "~/esm/Modules/Membership/Account/SignUp/SignUpPage.js";
                }
            }
        }
    }
}