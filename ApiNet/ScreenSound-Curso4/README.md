# ScreenSound - Plataforma de Músicas (.NET 10 & Blazor)

Projeto de estudo desenvolvido durante a formação .NET da Alura, modernizado para **.NET 10**, **Entity Framework Core 10**, **PostgreSQL** e **Blazor WebAssembly** com **MudBlazor**.

---

## 📋 Resumo das Atualizações (.NET 10 & PostgreSQL)

O projeto passou por um processo de atualização de versão, desacoplamento de banco de dados legado (SQL Server) e migração completa para PostgreSQL:

| Item                                          | Antes                                               | Depois                                                    |
| --------------------------------------------- | --------------------------------------------------- | --------------------------------------------------------- |
| **TargetFramework** (todos os projetos) | `net8.0`                                          | `net10.0`                                               |
| **Pacotes EF Core**                     | `7.0.18`                                          | `10.0.0`                                                |
| **dotnet-ef CLI Tool**                  | `8.0.0`                                           | `10.0.9` (manifest local)                               |
| **Swashbuckle / OpenAPI**               | `6.9.0` (incompatível com .NET 10)               | `7.3.1`                                                 |
| **MudBlazor (Web)**                     | `6.11.1`                                          | `8.3.0`                                                 |
| **Banco de Dados**                      | `TheBook` (banco de outro projeto)                | `ScreenSound` (PostgreSQL limpo)                        |
| **Snapshots de Migração**             | Dois`ScreenSoundContextModelSnapshot` em conflito | Antigas migrações SQL Server excluídas da compilação |
| **Driver de Persistência**             | `Microsoft.EntityFrameworkCore.SqlServer`         | `Npgsql.EntityFrameworkCore.PostgreSQL`                 |
| **Design-Time Factory**                 | Ausente                                             | `ScreenSoundContextFactory.cs` criado na API            |

### 🗄️ Estrutura do Banco de Dados (11 Tabelas)

O banco de dados `ScreenSound` é estruturado com tabelas de domínio e controle de autenticação/autorização via ASP.NET Core Identity:

- **Domínio**:
  - `Artistas`: Cadastro de músicos, foto de perfil e biografia.
  - `Generos`: Gêneros musicais.
  - `Musicas`: Músicas com ano de lançamento e vínculo com artistas.
  - `GeneroMusica`: Tabela de junção N:N entre Músicas e Gêneros.
- **Identity**:
  - `AspNetUsers`: Usuários com permissões (`PerssonWithPermission`).
  - `AspNetRoles`: Perfis de acesso (`PermittedProfile`).
  - `AspNetUserRoles`, `AspNetUserClaims`, `AspNetRoleClaims`, `AspNetUserLogins`, `AspNetUserTokens`: Gestão de claims, logins externos e tokens.

---

## 🏗️ Arquitetura da Solução

```text
ScreenSound/
├── ScreenSound.API/            # Web API RESTful com Minimal APIs, Swagger e Migrations PostgreSQL
├── ScreenSound.Web/            # Frontend SPA em Blazor WebAssembly com biblioteca MudBlazor
├── ScreenSound.Shared.Dados/   # Camada de Persistência, DbContext, DAL e Models Identity
├── ScreenSound.Shared.Modelos/ # Entidades puras de Domínio (Artista, Musica, Genero, etc.)
├── ScreenSound/                # Console App interativo para operações no terminal
└── ScreenSound.sln             # Arquivo da Solução .NET
```

---

## ⚙️ Pré-requisitos

Antes de iniciar, certifique-se de ter instalado em sua máquina:

1. **.NET 10 SDK** (ou versão compatível configurada):
   ```bash
   dotnet --version
   ```
2. **PostgreSQL** (versão 14 ou superior) em execução (porta padrão `5432`).
3. Uma base de dados criada no PostgreSQL:
   ```sql
   CREATE DATABASE "ScreenSound";
   ```

---

## 🔐 Configuração de Credenciais e Segurança

Para seguir as boas práticas de desenvolvimento e evitar expor credenciais em arquivos versionados, utilize o **Microsoft User Secrets** ou variáveis de ambiente.

### Opção 1: User Secrets (Recomendado para Desenvolvimento)

No terminal, execute na raiz do projeto:

```bash
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "User ID=postgres;Password=SUA_SENHA;Host=localhost;Port=5432;Database=ScreenSound;Pooling=true;" --project ScreenSound.API
```

### Opção 2: Variável de Ambiente

No Linux / macOS:

```bash
export ConnectionStrings__DefaultConnection="User ID=postgres;Password=SUA_SENHA;Host=localhost;Port=5432;Database=ScreenSound;Pooling=true;"
```

No Windows (PowerShell):

```powershell
$env:ConnectionStrings__DefaultConnection="User ID=postgres;Password=SUA_SENHA;Host=localhost;Port=5432;Database=ScreenSound;Pooling=true;"
```

---

## 🚀 Como Executar o Projeto

### 1. Restaurar Dependências e Ferramentas

Restaure os pacotes NuGet da solução e a ferramenta local `dotnet-ef`:

```bash
# Na raiz da solução:
dotnet restore

# Restaurar ferramentas locais (dotnet-ef):
cd ScreenSound.API
dotnet tool restore
cd ..
```

### 2. Executar a Web API

Em um terminal:

```bash
cd ScreenSound.API
dotnet run
```

> **Nota:** Em modo `Development`, a API aplica automaticamente as migrações pendentes no banco PostgreSQL ao subir (`context.Database.Migrate()`).

- **URL da API**: [https://localhost:7089](https://localhost:7089)
- **Swagger UI**: [https://localhost:7089/swagger](https://localhost:7089/swagger)

### 3. Executar o Frontend Blazor

Em outro terminal:

```bash
cd ScreenSound.Web
dotnet run
```

- **URL da Aplicação Web**: [https://localhost:7015](https://localhost:7015)

### 4. Executar o Console App (Opcional)

Se desejar testar a aplicação de terminal interativa:

```bash
cd ScreenSound
dotnet run
```

---

## 🗺️ Mapa de Comandos EF Core (Migrations)

Todas as operações de migração devem ser executadas a partir do diretório **`ScreenSound.API`**, apontando para o contexto **`ScreenSoundContext`** e a pasta de saída **`Migrations/PostgreSQL`**:

### Adicionar Nova Migration

Sempre que alterar entidades no modelo de dados:

```bash
cd ScreenSound.API
dotnet ef migrations add <NomeDaMigration> --output-dir Migrations/PostgreSQL --context ScreenSoundContext
```

*Exemplo:*

```bash
dotnet ef migrations add AdicionarCampoBiografia --output-dir Migrations/PostgreSQL --context ScreenSoundContext
```

### Aplicar Migrations no Banco

Para aplicar as migrações manualmente no PostgreSQL:

```bash
cd ScreenSound.API
dotnet ef database update --context ScreenSoundContext
```

### Listar Migrations Existentes e Aplicadas

```bash
cd ScreenSound.API
dotnet ef migrations list --context ScreenSoundContext
```

### Remover a Última Migration (Não Aplicada)

```bash
cd ScreenSound.API
dotnet ef migrations remove --context ScreenSoundContext
```

### Gerar Script SQL para Ambientes de Produção

```bash
cd ScreenSound.API
dotnet ef migrations script --output Migrations/PostgreSQL/script_atualizacao.sql --context ScreenSoundContext
```

---

## 🛡️ Notas Técnicas & Boas Práticas

- **Design-Time DbContext Factory**: A classe [ScreenSoundContextFactory.cs](file:///home/rangel/git-dev/alura-trail-dotnet/ApiNet/ScreenSound-Curso4/ScreenSound.API/ScreenSoundContextFactory.cs) permite que a CLI do `dotnet ef` execute comandos de migração sem precisar instanciar todo o pipeline HTTP do ASP.NET.
- **Isolamento de Migrações Legadas**: A pasta `ScreenSound.Shared.Dados/Migrations` contém o histórico antigo de SQL Server, excluído do build via `<Compile Remove="Migrations/**" />` para evitar duplicação do `ModelSnapshot`.
- **CORS Configurado**: A API está pré-configurada par
- a aceitar requisições originadas do Blazor WebAssembly (`https://localhost:7015`).
- **Prevenção de Ciclos de Referência**: Serialização JSON configurada com `ReferenceHandler.IgnoreCycles` para permitir relacionamentos bidirecionais entre entidades (ex: Artista e Música).

# Terminal 1 - API

```Shell
cd ScreenSound.API && dotnet run
```

# Terminal 2 - Web

```Shell
cd ScreenSound.Web && dotnet run
```

**Referencias:**

[learn.microsoft.com/en-us/aspnet/core/security/?view=aspnetcore-8.0](https://learn.microsoft.com/en-us/aspnet/core/security/?view=aspnetcore-8.0)

[learn.microsoft.com/pt-br/aspnet/core/security/?view=aspnetcore-10.0](https://learn.microsoft.com/pt-br/aspnet/core/security/?view=aspnetcore-10.0)

[learn.microsoft.com/pt-br/azure/active-directory/fundamentals/introduction-identity-access-management](https://learn.microsoft.com/pt-br/azure/active-directory/fundamentals/introduction-identity-access-management)

[learn.microsoft.com/pt-br/aspnet/core/security/authentication/identity?view=aspnetcore-10.0&amp;tabs=visual-studio](https://learn.microsoft.com/pt-br/aspnet/core/security/authentication/identity?view=aspnetcore-10.0&tabs=visual-studio)

**Clains:**

[learn.microsoft.com/en-us/dotnet/api/system.security.claims.claimtypes](https://learn.microsoft.com/en-us/dotnet/api/system.security.claims.claimtypes)

###### ClaimsPrincipal: pessoa usuária com sua identificação

Para concluir o modelo, temos o tipo `ClaimsPrincipal`, que representa o “contexto de segurança da pessoa usuária em cujo nome o código está em execução, incluindo sua identidade […]” (tradução obtida na [documentação oficial](https://learn.microsoft.com/pt-br/dotnet/api/system.security.principal.iprincipal) da interface `IPrincipal`, implementada por `ClaimsPrincipal`).

### Aprofunde o tema!

Abaixo, seguem algumas referências para você aprofundar o assunto, com explicações e até mesmo ilustrações do modelo:

* Artigo [Autenticação e autorização em aplicações Blazor](https://learn.microsoft.com/pt-br/aspnet/core/blazor/security/). Enquanto estava preparando esta aula, voltei repetidas vezes a essa referência para organizar o conhecimento e estruturar melhor o conteúdo.
* Artigo [Sharepoint - Definições de termos de identidade baseadas em declarações](https://learn.microsoft.com/pt-br/sharepoint/dev/general-development/claims-based-identity-term-definitions). O mais importante para nosso estudo é a tabela inicial com as definições. Resolvi trazer essa referência para mostrar que o modelo é usado de forma abrangente em outros produtos e situações.
* Artigo [Introduction to Authentication with ASP.NET Core](https://andrewlock.net/introduction-to-authentication-with-asp-net-core/) (em inglês), de Andrew Lock, com introdução sobre o tema usando o ASP.NET Core.

## Para saber mais: AddScoped, AddTransient e AddSingleton

[learn.microsoft.com/pt-br/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-9.0](https://learn.microsoft.com/pt-br/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-9.0)

[learn.microsoft.com/pt-br/dotnet/core/extensions/dependency-injection](https://learn.microsoft.com/pt-br/dotnet/core/extensions/dependency-injection)

* [Classe Math](https://learn.microsoft.com/en-us/dotnet/api/system.math) e seus métodos, incluindo `Min()`, `Max()` e `Clamp()`;
* [Operadores condicionais ternários](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator).


A tabela abaixo, extraída do artigo da Microsoft sobre os estilos [Functional programming vs. imperative programming (LINQ to XML)](https://learn.microsoft.com/en-us/dotnet/standard/linq/functional-vs-imperative-programming), sintetiza a diferença entre os dois estilos.

| Característica                    | Estilo imperativo                                                                      | Estilo declarativo                                                      |
| ---------------------------------- | -------------------------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| Foco da programação              | Como executar tarefas (algoritmos) e como monitorar as mudanças no estado do programa | Que informação é desejável e quais as transformações necessárias |
| Ordem de execução                | Relevante                                                                              | Não interessa                                                          |
| Fluxo de controle                  | Loops, condicionais e chamadas de métodos                                             | Chamadas de funções e recursão                                       |
| Unidade principal de manipulação | Objetos e classes                                                                      | Funções (no C# usamos métodos de extensão) e coleções de dados    |

No blog da Alura temos também o artigo [Programação funcional: O que é?](https://www.alura.com.br/artigos/programacao-funcional-o-que-e) com uma explicação sobre a programação funcional, que é um estilo influenciado pela programação declarativa.
