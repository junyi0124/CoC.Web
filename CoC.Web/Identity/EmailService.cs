using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace CoC.Web.Identity
{
    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            // �ڴ˴���������ʼ�����ɷ��͵����ʼ���
            return Task.FromResult(0);
        }
    }
}