namespace Notifications
{
    class EmailNotificacao : INotificacao
    {
        public void EnviarMensagem(string mensagem)
        {
            Console.WriteLine($"Enviando e-mail com a mensagem: {mensagem}.....");
        }
    }
}