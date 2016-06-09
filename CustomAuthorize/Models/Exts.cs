using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace CustomAuthorize.Models
{
    public static class Exts
    {
        public static User UserLogged()
        {
            AuthorizeDbContext _db = new AuthorizeDbContext();
            return _db.User.Single(i => i.Username == HttpContext.Current.User.Identity.Name);
        }
    }
}