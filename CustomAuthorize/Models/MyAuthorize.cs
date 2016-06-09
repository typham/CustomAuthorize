using System.Linq;
using System.Web.Mvc;

namespace CustomAuthorize.Models
{
    public class MyAuthorize:AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            AuthorizeDbContext _db = new AuthorizeDbContext();
            var userlogged = Exts.UserLogged();
            //List<string> permission = new List<string> { "Product-Index"};
            var permission = _db.Permission.Single(i => i.RoleId == userlogged.RoleId).ListPermission.Split(';');
            string currentControllerAction = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName + "-" + filterContext.ActionDescriptor.ActionName;
            if (!permission.Contains(currentControllerAction))
            {
                filterContext.Result = new RedirectResult("~/Account/AccessDenied");
            }
        }
    }
}