#region Using

using app_tramites.Controllers;
using Microsoft.AspNetCore.Mvc;


#endregion

namespace app_tramites.Extensions
{
    public static class UrlHelperExtensions
    {
        public static string EmailConfirmationLink(this IUrlHelper urlHelper, string userId, string code, string scheme)
        {
            return urlHelper.Action(action: nameof(AccountController.ConfirmEmail), controller: "Account", values: new
            {
                userId,
                code
            }, protocol: scheme);
        }

        public static string ResetPasswordCallbackLink(this IUrlHelper urlHelper, string userId, string code, string scheme)
        {
            return urlHelper.Action(action: nameof(AccountController.ResetPassword), controller: "Account", values: new
            {
                userId,
                code
            }, protocol: scheme);
        }
    }
}
