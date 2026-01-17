# FileManage - Resumo do Projeto

## Visão Geral

Aplicação **Blazor WebAssembly (PWA)** para gerar e ler arquivos JSON no
navegador, sem backend, utilizando boas práticas de C# e separação de
responsabilidades.

O projeto demonstra serialização, desserialização e manipulação de
arquivos JSON respeitando as limitações do ambiente WebAssembly.

------------------------------------------------------------------------

## Funcionalidades

-   Gerar arquivo JSON de uma pessoa
-   Gerar arquivo JSON de uma lista de pessoas
-   Ler arquivo JSON (pessoa ou lista)
-   Navegação SPA por rotas
-   Download e upload de arquivos no navegador

------------------------------------------------------------------------

## Tecnologias Utilizadas

-   **.NET / Blazor WebAssembly**
-   **PWA (Progressive Web App)**
-   **System.Text.Json**
-   **JavaScript Interop (IJSRuntime)**
-   **Bootstrap** (layout e estilos)
-   **C# moderno (.NET 8/9)**

------------------------------------------------------------------------

## Arquitetura do Projeto

Arquitetura simples, inspirada em **Clean Architecture**, adaptada ao
Blazor WASM.

    FileManage
    │
    ├── Domain
    │   └── Pessoa.cs
    │
    ├── Application
    │   └── (Factories / Services futuros)
    │
    ├── Pages
    │   ├── GerarPessoaJson.razor
    │   ├── GerarListaJson.razor
    │   ├── LerJson.razor
    │   └── Home.razor
    │
    ├── Shared
    │   └── NavMenu.razor
    │
    ├── wwwroot
    │   ├── file.js
    │   └── manifest.json
    │
    └── Program.cs

### Responsabilidades

-   **Domain**: regras e modelos de negócio (POCOs)
-   **Application**: camada para serviços, factories e lógica de
    aplicação
-   **Pages**: componentes Razor (UI)
-   **Shared**: componentes reutilizáveis
-   **wwwroot**: recursos estáticos e JavaScript

------------------------------------------------------------------------

## Patterns Utilizados

### ✔ Separation of Concerns

Cada camada possui responsabilidade clara: - UI não conhece
serialização - Domínio não conhece UI ou JS

### ✔ POCO (Plain Old CLR Object)

Classe `Pessoa` simples, sem dependências externas.

### ✔ Factory (conceitual)

Geração de JSON centralizada (ou preparada para isso).

### ✔ SPA Routing

Uso de `@page` e `NavLink` para navegação client-side.

### ✔ JS Interop Pattern

JavaScript utilizado apenas quando necessário: - Download de arquivos -
Leitura de arquivos

------------------------------------------------------------------------

## Telas do Sistema

### `/gerar-pessoa-json`

-   Entrada de dados de uma pessoa
-   Serialização em JSON
-   Download automático do arquivo

### `/gerar-lista-json`

-   Cadastro em memória de múltiplas pessoas
-   Geração de JSON em lote

### `/ler-json`

-   Upload de arquivo `.json`
-   Desserialização automática:
    -   Tenta lista
    -   Se falhar, tenta objeto único

------------------------------------------------------------------------

## Funcionamento Técnico

-   Serialização:

``` csharp
JsonSerializer.Serialize(obj)
```

-   Desserialização:

``` csharp
JsonSerializer.Deserialize<T>(json)
```

-   Upload:

``` razor
<InputFile OnChange="Handler" />
```

-   Download:

``` csharp
IJSRuntime.InvokeVoidAsync(...)
```

------------------------------------------------------------------------

## Observações Importantes

-   Blazor WASM **não acessa o sistema de arquivos**
-   Download é a forma correta de gerar arquivos
-   Upload depende do usuário
-   Rotas devem ser únicas
-   Não há persistência automática sem LocalStorage ou backend

------------------------------------------------------------------------

## Resultado

Projeto organizado, didático e tecnicamente correto, ideal para: -
Estudo de Blazor WASM - Demonstração de serialização JSON - Base para
filtros, LINQ, LocalStorage ou API REST
