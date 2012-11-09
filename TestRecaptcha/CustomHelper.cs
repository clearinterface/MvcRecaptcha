using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Recaptcha;

namespace MvcHelper
{
    public static class CustomHelper
    {


        //
        public static MvcHtmlString GenerateCaptchaHere(this HtmlHelper htmlHelper)
        {
            RecaptchaControlMvc.PrivateKey = "Your Private Key here";
            RecaptchaControlMvc.PublicKey = "Your Public Key";

            var html = Recaptcha.RecaptchaControlMvc.GenerateCaptcha(htmlHelper);
            return MvcHtmlString.Create(html);
        }


    }
}