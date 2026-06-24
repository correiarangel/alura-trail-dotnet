# 🎬 MuvieApi

Web API desenvolvida durante o curso **".NET: Criando uma Web API"** da [Alura](https://www.alura.com.br), parte da trilha de programação .NET.

## 📚 Sobre o Curso

> **Curso:** .NET: Criando uma Web API
> **Plataforma:** Alura
> **Progresso atual:** 12%

### O que está sendo aprendido:

- ✅ Receber requisições em uma API REST
- ✅ Principais verbos HTTP (`GET`, `POST`, `PUT`, `DELETE`)
- ✅ Retornar informações de forma padronizada ao cliente
- ✅ Utilizar **DTOs** (Data Transfer Objects) para lidar com requisições e respostas
- ✅ Trabalhar com **DbContext** para leitura e escrita no banco de dados

---

## 🛠️ Stack e Tecnologias

| Tecnologia                                                                               | Versão |
| ---------------------------------------------------------------------------------------- | ------- |
| [.NET](https://dotnet.microsoft.com/)                                                       | 10.0    |
| ASP.NET Core Web API                                                                     | 10.0    |
| [Microsoft.AspNetCore.OpenApi](https://www.nuget.org/packages/Microsoft.AspNetCore.OpenApi) | 10.0.8  |
| [Scalar.AspNetCore](https://scalar.com/)                                                    | 2.16.3  |

---

## 📁 Estrutura do Projeto

```
MuvieApi/
├── Controllers/
│   └── WeatherForecastController.cs   # Controller de exemplo (padrão .NET)
├── Properties/
│   └── launchSettings.json            # Configurações de execução e portas
├── appsettings.json                   # Configurações da aplicação
├── appsettings.Development.json       # Configurações do ambiente de desenvolvimento
├── Program.cs                         # Ponto de entrada e configuração da aplicação
├── WeatherForecast.cs                 # Model de exemplo (padrão .NET)
└── MuvieApi.csproj                    # Arquivo de projeto e dependências
```

---

## ▶️ Como Rodar o Projeto

### Pré-requisitos

- [.NET 10 SDK](https://dotnet.microsoft.com/download) instalado
- Certificado HTTPS de desenvolvimento confiável

### 1. Configurar o certificado HTTPS (apenas na primeira vez)

```bash
dotnet dev-certs https --trust
```

### 2. Restaurar as dependências

```bash
dotnet restore
```

### 3. Executar a aplicação

**Perfil HTTPS (recomendado):**

```bash
dotnet run --launch-profile https
```

**Perfil HTTP:**

```bash
dotnet run --launch-profile http
```

#### 4. **Executar Migration:**

**Intall tools:**

Se o comando não existir, instale a ferramenta primeiro:

`dotnet tool install --global dotnet-ef`

**Paea criar rode na pasta do projeto, ou especifique o projeto explicitamente:**

`dotnet ef migrations add CreatTableMovie --project MuvieApi.csproj`

Ou

```
dotnet ef migrations add CreatTableMovie
```

**Para atualizar o banco com as migrations, use:**

`dotnet ef database update`

**Se quiser aplicar até uma migration específica:**

dotnet ef database update CreatTableMovie

**E, se o projeto precisar do DbContext explícito, pode usar:**

dotnet ef database update --project MuvieApi.csproj

**Remova uma Migrations com:**

`dotnet ef migrations remove --project MuvieApi.csproj dotnet ef migrations add CreatTableMovie --project MuvieApi.csproj`


---

## 🌐 URLs Disponíveis

| Recurso                                             | URL                                    |
| --------------------------------------------------- | -------------------------------------- |
| 🎨**Scalar UI** (testar a API)                | https://localhost:7263/scalar/v1       |
| 📄**OpenAPI JSON Spec**                       | https://localhost:7263/openapi/v1.json |
| 🌡️**WeatherForecast** (endpoint de exemplo) | https://localhost:7263/WeatherForecast |
| 🔓**HTTP** (sem SSL)                          | http://localhost:5103                  |

> **Nota:** A documentação interativa (Scalar) e o JSON da spec só ficam disponíveis no ambiente `Development`.

---

## 🧪 Testando a API

### Via Scalar UI (recomendado)

Acesse `https://localhost:7263/scalar/v1` no browser e use a interface interativa para explorar e testar os endpoints.

### Via linha de comando (curl)

```bash
# Listar previsões do tempo (endpoint de exemplo)
curl -k https://localhost:7263/WeatherForecast
```

### Via arquivo .http

O projeto inclui o arquivo `MuvieApi.http` que pode ser usado diretamente no **Visual Studio**, **VS Code** (com extensão REST Client) ou **JetBrains Rider**.

---

## 📖 Referências

- [Documentação oficial ASP.NET Core](https://docs.microsoft.com/aspnet/core)
- [Scalar para ASP.NET Core](https://github.com/scalar/scalar)
- [Curso na Alura](https://www.alura.com.br)
