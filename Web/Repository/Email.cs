using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Mail;

namespace Web.Repository
{
    public class Email
    {
        [Required(ErrorMessage = "Обязательное поле")]
        [DataType(DataType.EmailAddress)]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        public string Body { get; set; }

        public Email(string subject, string body)
        {
            Subject = subject;
            Body = body;
        }
        
        public void Send()
        {
            // Отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("relfina@shop.ru");
            // Кому отправляем
            MailAddress to = new MailAddress("prosto.ovne@mail.ru");
            // Создаем объект сообщения
            MailMessage message = new MailMessage(from, to);
            // Тема письма
            message.Subject = $"Письмо с приложения 'Библиотека': {Subject}";
            // Текст письма
            message.Body = Body;
            // Адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("mail.fckrasnodar.ru", 25);
            // Логин и пароль
            smtp.Credentials = new NetworkCredential("hostmaster@fckrasnodar.ru", "M212f3FAfib6j");
            smtp.Send(message);
        }
    }
}