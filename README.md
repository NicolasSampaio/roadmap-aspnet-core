https://roadmap.sh/aspnet-core

# Roadmap de Projetos em ASP.NET Core

Este roadmap está dividido em **checkpoints**.  
Cada checkpoint contém:
- O que você **precisa saber** antes.
- Os **requisitos práticos** a serem entregues.
- Um **projeto sugerido** para aplicar.

---

## ✅ Checkpoint 1 — Fundamentos prontos
### Precisa saber
- Sintaxe básica do C# (variáveis, condicionais, loops).
- OOP: classes, herança, interfaces, polimorfismo.
- Exceptions: `try/catch/finally`.
- Como criar e rodar um projeto console com `dotnet new console`.
- Estrutura de um projeto Web API (`Program.cs`, `Startup.cs` ou `builder.Services`).
- Conceitos de HTTP (GET, POST, PUT, DELETE, status codes).

### Requisitos práticos
- Subir um servidor ASP.NET Core que responde `"Hello World"`.
- Expor rota `/notes` que devolve lista em memória.

### Projeto sugerido
- API de **notas simples** (sem banco, apenas em memória).

---

## ✅ Checkpoint 2 — CRUD completo
### Precisa saber
- Estrutura de controllers e rotas no ASP.NET Core.
- O que é um `DbContext` e como configurar com Entity Framework Core.
- Como usar migrations (`dotnet ef migrations add Init`).
- Conceito de CRUD (Create, Read, Update, Delete).
- Diferença entre DTOs e Models.

### Requisitos práticos
- CRUD completo em uma entidade (tarefas).
- Dados persistidos em SQLite/SQL Server local.
- Rotas para listar todos, criar, editar e excluir.

### Projeto sugerido
- **To-do list** com banco de dados.

---

## ✅ Checkpoint 3 — Usuários e segurança
### Precisa saber
- Conceito de autenticação x autorização.
- Como funciona JWT (tokens com claims).
- Como configurar `Identity` ou autenticação JWT em ASP.NET Core.
- Data Annotations para validação (`[Required]`, `[EmailAddress]`, `[MinLength]`).
- Middleware no ASP.NET Core.

### Requisitos práticos
- Cadastro/login com hashing de senha.
- Tokens JWT para autenticação.
- Rotas protegidas que exigem usuário logado.
- Validação de entrada nos DTOs.

### Projeto sugerido
- **Blog multiusuário** com posts públicos e privados.

---

## ✅ Checkpoint 4 — Aplicação realista
### Precisa saber
- Como fazer requisições HTTP externas em C# (`HttpClient`).
- O que é e como rodar testes unitários (xUnit ou NUnit).
- Como escrever testes de integração para controllers.
- Conceitos básicos de deploy (Docker, Azure, AWS ou Render).
- Git/GitHub: versionar, usar branches e README.

### Requisitos práticos
- Consumir dados de uma API pública externa.
- Armazenar favoritos no banco por usuário.
- Criar pipeline de build simples (deploy manual ou Docker).
- Criar documentação mínima (README, collection no Postman).

### Projeto sugerido
- **Dashboard de filmes** (favoritar filmes consumidos via API externa).

---

## ✅ Checkpoint 5 — Extras e refinamentos
### Precisa saber
- O que é caching (in-memory, Redis).
- Boas práticas de arquitetura (camadas: Application, Domain, Infrastructure).
- CQRS/DDD (conceitos iniciais, se quiser avançar).
- Logs estruturados (Serilog, ILogger).
- Health checks (`app.MapHealthChecks("/health")`).
- CI/CD (GitHub Actions ou Azure DevOps).

### Requisitos práticos
- Melhorar performance com cache.
- Logging e métricas básicos.
- Pipeline de build e deploy automatizado.
- Estrutura de projeto em camadas.

### Projeto sugerido
- Versão “profissional” do **Dashboard de filmes**  
  (com cache, logs, CI/CD e boas práticas de arquitetura).
