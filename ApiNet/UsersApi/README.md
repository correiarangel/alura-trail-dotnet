# Users API

API de usuários desenvolvida com ASP.NET Core, Entity Framework Core, Identity e JWT para cadastro e autenticação.

## Tecnologias

- .NET 10
- ASP.NET Core Web API
- Entity Framework Core
- PostgreSQL
- Identity
- Scalar UI para documentação da API

## Como executar

1. Acesse a pasta do projeto:

   ```bash
   cd /home/rangel/git-dev/alura-trail-dotnet/ApiNet/UsersApi
   ```
2. Execute a aplicação:

   ```bash
   dotnet run
   ```

## URLs de acesso

Após iniciar a aplicação, você pode acessar:

- API base: http://localhost:5109
- Swagger/Scalar UI: http://localhost:5109/scalar
- OpenAPI JSON: http://localhost:5109/openapi/v1.json

## Endpoints principais

- POST /User/create
- POST /User/login

## Observação

A raiz da aplicação não retorna uma página HTML, pois se trata de uma API REST. Para explorar os endpoints, utilize a interface do Scalar ou o arquivo OpenAPI.


# **Criar  Secret**

Inicialmente, acesse o diretório do projeto UsuariosApi através do seu terminal e execute o comando **dotnet user-secrets init** Seu arquivo .csproj deverá adicionar um trecho parecido com:

Deve ser possivel ver esse novo PropertyGroup, UserSecretsId

```C#
dotnet user-secrets init
```

```C#
<PropertyGroup>
    <TargetFramework>net10.0</TargetFramework>
    <UserSecretsId>4374b8ab-3c14-4292-93e3-a000e4a4749</UserSecretsId>
</PropertyGroup>
```

Agora, iremos popular o secret com as informações que estão atualmente presentes em nosso arquivo appsettings.json. Execute:

```C#
dotnet user-secrets set "SymmetricSecurityKey" "MinhaChaveSecretaSuperSecreta"
dotnet user-secrets set "ConnectionStrings:UserConnection" "Host=localhost;Port=5432;Database=usersdb;Username=postgres;Password=minhaSenha"
```

Por fim, não esqueça de utilizar os secrets através da classe Configuration:

```C#
var connString = builder.Configuration["ConnectionStrings:UsuarioConnection"];

builder.Services.AddDbContext<UsuarioDbContext>(opts =>
    {
        opts.UseMySql(connString, ServerVersion.AutoDetect(connString));
    });
```
