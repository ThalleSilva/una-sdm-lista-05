using ConsumerGitHubUser.Models;
using static System.Console;

Console.WriteLine("Digite o id do usuario que deseja pesquisar:");

var id = ReadLine();
var usuarioUrl = $"https://api.github.com/user/{id}";

Console.WriteLine($"Carregando usuario {id}...");
var httpClient = new HttpClient();

try
{
    HttpResponseMessage? response = await httpClient.GetAsync(usuarioUrl);
    response.EnsureSuccessStatusCode();

    string responseBody = await response.Content.ReadAsStringAsync();
    var usuario = System.Text.Json.JsonSerializer.Deserialize<ConsumerGitHubUser.Models.User>(responseBody);
    WriteLine($"Usuario encontrado: {usuario.Name}, {usuario.Empresa}, {usuario.Localizacao}, {usuario.Login}");
}
catch (System.Exception ex)
{
    WriteLine("Erro ao consutar usuario. Verifique tente utilizar outro id: " + ex.Message);
}