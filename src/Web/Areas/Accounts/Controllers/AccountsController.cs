using Spokeoft.Clobberfest.Web.Controllers;

namespace Spokesoft.Clobberfest.Web.Areas.Accounts.Controllers
{
    /// <summary>
    /// Base controller for the accounts area.
    /// </summary>
    public class AccountsController : AppController
    {
        public const string AreaName = "Accounts";

        /// <summary>
        /// Accounts area routes
        /// </summary>
        public const string AccessDeniedRoute = "/access-denied";
        public const string ConfirmEmailChangeRoute = "/confirm-email-change";
        public const string ConfirmEmailRoute = "/confirm-email";
        public const string ExternalLoginRoute = "/external-login";
        public const string ForgotPasswordConfirmationRoute = "/forgot-password-confirmation";
        public const string ForgotPasswordRoute = "/forgot-password";
        public const string LockoutRoute = "/lockout";
        public const string LoginRoute = "/login";
        public const string LoginWith2faRoute = "/login-with-2fa";
        public const string LoginWithRecoveryCodeRoute = "/login-with-recovery-code";
        public const string LogoutRoute = "/logout";
        public const string RegisterConfirmationRoute = "/register-confirmation";
        public const string RegisterRoute = "/register";
        public const string ResendEmailConfirmationRoute = "/resend-email-confirmation";
        public const string ResetPasswordConfirmationRoute = "/reset-password-confirmation";
        public const string ResetPasswordRoute = "/reset-password";

        protected string DefaultLayout => "Accounts/_Layout.cshtml";

        protected string ViewPath(string path)
        {
            return $"~/Areas/{AreaName}/Views/{path}";
        }
    }
}