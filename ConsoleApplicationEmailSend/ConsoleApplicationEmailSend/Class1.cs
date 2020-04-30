using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationEmailSend
{
    public class Class1
    {

        public void SendMailLocalhost()
        {
           
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.To.Add("scheng.wang@flowportal.com");
            //msg.To.Add("b@b.com");
            /* msg.To.Add("b@b.com");  
            * msg.To.Add("b@b.com");  
            * msg.To.Add("b@b.com");可以发送给多人  
            */
            //msg.CC.Add(c@c.com);
            /*  
            * msg.CC.Add("c@c.com");  
            * msg.CC.Add("c@c.com");可以抄送给多人  
            */
            msg.From = new MailAddress("2569059551@qq.com", "wangshicheng", System.Text.Encoding.UTF8);
            /* 上面3个参数分别是发件人地址（可以随便写），发件人姓名，编码*/
            msg.Subject = "这是测试邮件";//邮件标题  
            msg.SubjectEncoding = System.Text.Encoding.UTF8;//邮件标题编码  
            msg.Body = "邮件内容";//邮件内容  
            msg.BodyEncoding = System.Text.Encoding.UTF8;//邮件内容编码  
            msg.IsBodyHtml = false;//是否是HTML邮件  
            msg.Priority = MailPriority.High;//邮件优先级 

            SmtpClient client = new SmtpClient();
            client.Host = "58.251.149.147";
            object userState = msg;
            try
            {
                client.SendAsync(msg, userState);
                //简单一点儿可以client.Send(msg);  
                ///MessageBox.Show("发送成功");
                Console.WriteLine("发送成功");
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                //MessageBox.Show(ex.Message, "发送邮件出错");
                Console.WriteLine("发送邮件出错");
            }
        }

        public void test()
        {
            var emailAcount = "2569059551@qq.com";
                        var emailPassword = "wang19981002";
                        var reciver = "scheng.wang@flowportal.com";
                        var content = "测试";
                        MailMessage message = new MailMessage();
                        //设置发件人,发件人需要与设置的邮件发送服务器的邮箱一致
            MailAddress fromAddr = new MailAddress("2569059551@qq.com");
                     message.From = fromAddr;
                     //设置收件人,可添加多个,添加方法与下面的一样
         message.To.Add(reciver);
                     //设置抄送人
        // message.CC.Add("qwe123@163.com");
                     //设置邮件标题
         message.Subject = "Test";
                     //设置邮件内容
         message.Body = content;
                     //设置邮件发送服务器,服务器根据你使用的邮箱而不同,可以到相应的 邮箱管理后台查看,下面是QQ的
         SmtpClient client = new SmtpClient("smtp.qq.com", 25);
                     //设置发送人的邮箱账号和密码
         client.Credentials = new NetworkCredential(emailAcount, emailPassword);
                     //启用ssl,也就是安全发送
         client.EnableSsl = true;
                     //发送邮件
         client.Send(message);
     }

        public void SendMailUseZj()
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.To.Add("scheng.wang@flowportal.com");
            //msg.To.Add(b@b.com);
            /*   
            * msg.To.Add("b@b.com");   
            * msg.To.Add("b@b.com");   
            * msg.To.Add("b@b.com");可以发送给多人   
            */
            //msg.CC.Add("c@c.com");
            /*   
            * msg.CC.Add("c@c.com");   
            * msg.CC.Add("c@c.com");可以抄送给多人   
            */
            msg.From = new MailAddress("2569059551@qq.com", "老王", System.Text.Encoding.UTF8);
            /* 上面3个参数分别是发件人地址（可以随便写），发件人姓名，编码*/
            msg.Subject = "这是测试邮件";//邮件标题    
            msg.SubjectEncoding = System.Text.Encoding.UTF8;//邮件标题编码    
            msg.Body = "邮件内容";//邮件内容    
            msg.BodyEncoding = System.Text.Encoding.UTF8;//邮件内容编码    
            msg.IsBodyHtml = false;//是否是HTML邮件    
            msg.Priority = MailPriority.High;//邮件优先级    

            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("dulei@71info.com", "userpass");
            //在71info.com注册的邮箱和密码    
            //client.Host = "smtp.71info.com";
            object userState = msg;
            try
            {
                client.SendAsync(msg, userState);
                //简单一点儿可以client.Send(msg);    
               // MessageBox.Show("发送成功");
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                //MessageBox.Show(ex.Message, "发送邮件出错");
            }
        }
    }
}
