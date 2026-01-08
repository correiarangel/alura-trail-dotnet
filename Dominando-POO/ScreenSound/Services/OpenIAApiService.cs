using OpenAI;
using OpenAI.Chat;

public interface IOpenAIClientService
{
    Task<string> ObterResumoAsync(string prompt);
}

public sealed class OpenAIClientService : IOpenAIClientService
{
    private const string keyOpenIAI = "aqui sua key";
    
    private const string gptModel = "gpt-4o-mini";
    public static string KeyOpenIAI => keyOpenIAI;
    private readonly ChatClient _chatClient;

    public OpenAIClientService(string apiKey)
    {
        _chatClient = new ChatClient(
            model: gptModel,
            apiKey: apiKey
        );
    }

    public async Task<string> ObterResumoAsync(string nomeBanda)
    {
        ChatCompletion completion = await _chatClient.CompleteChatAsync($"resuma o nome da banda {nomeBanda}");

        return completion.Content.Count > 0
            ? completion.Content[0].Text
            : string.Empty;
    }
}
