using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace CoC.Web.Identity
{
    public class SmsService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            // �ڴ˴����� SMS ����ɷ��Ͷ��š�
            return Task.FromResult(0);
        }
    }
}