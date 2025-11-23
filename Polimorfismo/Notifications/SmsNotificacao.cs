namespace Notifications
{
    class SmsNotificacao : INotificacao
    {
        public void EnviarMensagem(string mensagem)
        {
            Console.WriteLine($"Enviando SMS com a mensagem: {mensagem}.....");
        }
    }
}