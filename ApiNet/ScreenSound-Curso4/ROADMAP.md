# ROADMAP - ScreenSound (.NET 10 Migration & Study)

Status Geral do Projeto e Marcos de Evolução.

---

## 🎯 Marco Atual: Modernização de Versão e Banco (.NET 10 & PostgreSQL)

- [x] Atualização de todos os projetos para `TargetFramework net10.0`
- [x] Atualização dos pacotes EF Core para `10.0.0`
- [x] Atualização do tool local `dotnet-ef` para `10.0.9`
- [x] Atualização do Swashbuckle para `7.3.1` (compatível com .NET 10)
- [x] Atualização do MudBlazor para `8.3.0` e correção de componentes na UI
- [x] Desacoplamento do banco de dados legado `TheBook` e apontamento para `ScreenSound` (PostgreSQL)
- [x] Resolução de conflito de snapshots (antigas migrações SQL Server excluídas de compilação)
- [x] Remoção da referência ativa a `Microsoft.EntityFrameworkCore.SqlServer`
- [x] Criação do `ScreenSoundContextFactory` para suporte a design-time migrations
- [x] Criação e aplicação da migration inicial PostgreSQL com 11 tabelas (Domínio + Identity)
- [x] Criação de `README.md` detalhado com mapa de comandos e guia de execução

---

## 🚀 Próximos Passos (Melhorias e Evolução)

- [ ] Implementar autenticação e autorização ponta a ponta na API e WebAssembly
- [ ] Aplicar Result Pattern e ProblemDetails padronizado (RFC 9457) nos endpoints
- [ ] Implementar suíte de testes unitários e de integração com xUnit
- [ ] Adicionar suporte a containerização com Docker Compose (PostgreSQL + API + Web)
