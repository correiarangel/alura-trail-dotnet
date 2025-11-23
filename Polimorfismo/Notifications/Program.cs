using Notifications;

Console.WriteLine("\n*** Notificações de sistema ***\n");


List<INotificacao> notificacoes = new List<INotificacao>
{
    new EmailNotificacao(),
    new SmsNotificacao(),
    new PushNotificacao()
};

foreach (var notificacao in notificacoes)
{
    notificacao.EnviarMensagem("Sistema fora do ar!");
}