using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationEmailSend
{
    public class SendEmail163
    {

        public void SendEmail()
        {
            // 设置发送方的邮件信息,例如使用网易的smtp
            string smtpServer = "smtp.163.com"; //SMTP服务器
            //string smtpServer = "smtp.aliyun.com"; //SMTP服务器
            string mailFrom = "laowangwsc@163.com"; //登陆用户名
            //string mailFrom = "zhanbozhiye@aliyun.com"; //登陆用户名
            //string userPassword = "zbzy1111";//登陆密码
            //string mailFrom = "scheng.wang@flowportal.com"; //登陆用户名
            string userPassword = "Wsc123456";// 授权码

            // 邮件服务设置
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;//指定电子邮件发送方式
            smtpClient.Host = smtpServer; //指定SMTP服务器
            smtpClient.UseDefaultCredentials = true;
            smtpClient.Credentials = new System.Net.NetworkCredential(mailFrom, userPassword);//用户名和密码
            smtpClient.Port = 25;
            //string mailTo = "scheng.wang@flowportal.com";//收件人
            string mailTo = "2569059551@qq.com";//收件人

            // 发送邮件设置       
            MailMessage mailMessage = new MailMessage(mailFrom, mailTo); // 发送人和收件人

            mailMessage.Subject = "测试";//主题
            mailMessage.Body = "测试展博邮件";//内容
            mailMessage.BodyEncoding = Encoding.UTF8;//正文编码
            mailMessage.IsBodyHtml = false;//设置为HTML格式
            mailMessage.Priority = MailPriority.Low;//优先级

            try
            {
                smtpClient.Send(mailMessage); // 发送邮件
                Console.WriteLine("成功");
            }
            catch (SmtpException ex)
            {
                Console.WriteLine("失败：" + ex.Message);
            }
        }
    }
}
