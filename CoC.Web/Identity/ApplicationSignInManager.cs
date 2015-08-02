using System.Security.Claims;
using System.Threading.Tasks;
using CoC.Web.Models;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;

namespace CoC.Web.Identity
{
    // ���ô�Ӧ�ó�����ʹ�õ�Ӧ�ó����û���������UserManager �� ASP.NET Identity �ж��壬���ɴ�Ӧ�ó���ʹ�á�

    // ����Ҫ�ڴ�Ӧ�ó�����ʹ�õ�Ӧ�ó����¼��������
    public class ApplicationSignInManager : SignInManager<ApplicationUser, string>
    {
        public ApplicationSignInManager(ApplicationUserManager userManager, IAuthenticationManager authenticationManager)
            : base(userManager, authenticationManager)
        {
        }

        public override Task<ClaimsIdentity> CreateUserIdentityAsync(ApplicationUser user)
        {
            return user.GenerateUserIdentityAsync((ApplicationUserManager)UserManager);
        }

        public static ApplicationSignInManager Create(IdentityFactoryOptions<ApplicationSignInManager> options, IOwinContext context)
        {
            return new ApplicationSignInManager(context.GetUserManager<ApplicationUserManager>(), context.Authentication);
        }
    }
}
