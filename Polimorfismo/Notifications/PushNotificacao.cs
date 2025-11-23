namespace Notifications
{
    class PushNotificacao : INotificacao
    {
        public void EnviarMensagem(string mensagem)
        {
            Console.WriteLine($"Enviando notificação push com a mensagem: {mensagem}.....");
        }
    }
}