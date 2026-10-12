# ListaTarefaz API

API Minimal em .NET 10 com Entity Framework Core e PostgreSQL para gerenciamento de tarefas.

---

## 🛠️ 1. Comandos de Banco de Dados e Migrations

### Configurar Senha com Segurança (User Secrets)
Para configurar a Connection String local sem expor a senha no repositório Git:

```bash
dotnet user-secrets init
dotnet user-secrets set "ConnectionStrings:TarefazConnection" "Host=localhost;Port=5432;Database=ListaTarefazDb;Username=postgres;Password=AMX@54321"
```

### Criar uma Nova Migration
```bash
dotnet ef migrations add CriarTabelaTarefaz
```

### Aplicar as Migrations ao Banco de Dados
```bash
dotnet ef database update
```

### Reverter / Remover a Última Migration (se necessário)
```bash
dotnet ef migrations remove
```

---

## 🚀 2. Como Levantar a API

### Rodar a aplicação:
```bash
dotnet run
```

### Ou rodar em modo watch (recarrega automático com hot reload):
```bash
dotnet watch
```

A API estará disponível em:
- **Swagger UI (Visual):** `http://localhost:5093/swagger`
- **Scalar UI (Visual Moderno):** `http://localhost:5093/scalar/v1`
- **OpenAPI Schema (JSON puro):** `http://localhost:5093/openapi/v1.json`
- **Base HTTP:** `http://localhost:5093`
- **Base HTTPS:** `https://localhost:7001`

---

## 🧪 3. URLs e Exemplos de Teste (Endpoints)

Base URL: `http://localhost:5093`

### 1. Listar todas as tarefas (`GET /tarefaz`)
```bash
curl -X GET http://localhost:5093/tarefaz
```

### 2. Buscar tarefa por ID (`GET /tarefaz/{id}`)
```bash
curl -X GET http://localhost:5093/tarefaz/1
```

### 3. Criar uma nova tarefa (`POST /tarefaz`)
Não precisa enviar `id`, `concluida` (inicia `false`) nem `dataCriacao` (automática):
```bash
curl -X POST http://localhost:5093/tarefaz \
  -H "Content-Type: application/json" \
  -d '{
    "titulo": "Aprender Minimal APIs",
    "descricao": "Estudar rotas, EF Core e migrations no .NET 10"
  }'
```

### 4. Atualizar uma tarefa existente (`PUT /tarefaz/{id}`)
O ID já vai na rota (`/tarefaz/1`):
```bash
curl -X PUT http://localhost:5093/tarefaz/1 \
  -H "Content-Type: application/json" \
  -d '{
    "titulo": "Aprender Minimal APIs com EF Core",
    "descricao": "Estudo finalizado com sucesso!",
    "concluida": true,
    "dataConclusao": "2026-10-12"
  }'
```

### 5. Excluir uma tarefa (`DELETE /tarefaz/{id}`)
```bash
curl -X DELETE http://localhost:5093/tarefaz/1
```
