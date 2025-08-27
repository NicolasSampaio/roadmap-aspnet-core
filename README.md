https://roadmap.sh/aspnet-core

# Roadmap de Projetos em ASP.NET Core

# Plano de Projetos para ASP.NET Core

Com base no roteiro do `roadmap.sh/aspnet-core`, aqui está uma sugestão de projetos para aplicar os conhecimentos de forma prática e progressiva.

---

### Nível Iniciante

O foco aqui é construir a base, entendendo como uma aplicação ASP.NET Core funciona, como ela responde a requisições e como é estruturada.

1.  **Nome do Projeto**
    * API de Gerenciamento de Tarefas (To-Do List)

2.  **Requisitos:**
    * Criar uma nova tarefa com título, descrição e data de vencimento.
    * Listar todas as tarefas cadastradas.
    * Buscar uma tarefa específica pelo seu ID.
    * Atualizar o título, descrição ou status (concluída/pendente) de uma tarefa.
    * Deletar uma tarefa.
    * *Desafio extra:* Adicionar validações para não permitir criar tarefas sem título.

3.  **Tópicos Necessários:**
    * C#
    * ASP.NET Core Basics
    * Kestrel
    * MVC
    * REST
    * Building APIs
    * Dependency Injection
    * Configuration
    * appsettings.json
    * Options Pattern
    * Secret Management
    * Routing
    * Middleware
    * Filters
    * Controllers
    * Action Results
    * Model Binding
    * Validation

---

### Nível Intermediário

Neste nível, o objetivo é construir aplicações mais robustas, introduzindo um banco de dados real, autenticação de usuários e boas práticas de desenvolvimento.

1.  **Nome do Projeto**
    * Plataforma de Blog com Autenticação

2.  **Requisitos:**
    * Qualquer pessoa pode visualizar os posts do blog.
    * Usuários podem se registrar e fazer login na plataforma.
    * Apenas usuários autenticados podem criar novos posts.
    * Um usuário pode editar ou deletar apenas os posts que ele mesmo criou.
    * Implementar um banco de dados para persistir as informações de usuários e posts.
    * Registrar (logar) eventos importantes, como a criação de um novo usuário ou a ocorrência de um erro na aplicação.
    * Utilizar cache para a lista de posts na página inicial para melhorar o desempenho.

3.  **Tópicos Necessários:**
    * *(Todos os tópicos do nível Iniciante)*
    * Authentication
        * Cookie-Based
        * JWT Authentication
    * Authorization
        * Claims-Based Authorization
        * Role-Based Authorization
        * Policies
    * Object-Relational Mapping (ORM)
        * Entity Framework Core
        * Migrations
        * Data Seeding
    * SOLID
        * Single Responsibility
        * Open-Closed Principle
        * Liskov Substitution
        * Interface Segregation
        * Dependency Inversion
    * Logging
        * Serilog
    * Caching
        * In-Memory Caching
        * Distributed Caching
        * Client-side Caching
    * Testing
        * Unit Testing
        * Integration Testing

---

### Nível Avançado

O foco avançado é em escalabilidade, performance e arquiteturas modernas. Vamos quebrar a aplicação monolítica em serviços menores e prepará-la para um ambiente de produção complexo.

1.  **Nome do Projeto**
    * Sistema de E-commerce baseado em Microsserviços

2.  **Requisitos:**
    * Dividir a aplicação em, no mínimo, três serviços independentes:
        * **Serviço de Identidade:** Responsável pelo registro e login de usuários.
        * **Serviço de Catálogo:** Responsável por gerenciar produtos e categorias.
        * **Serviço de Pedidos:** Responsável por processar os pedidos dos clientes.
    * Implementar um API Gateway como ponto de entrada único para todas as requisições dos clientes.
    * Os serviços devem se comunicar de forma assíncrona usando uma fila de mensagens (ex: quando um pedido é criado, o serviço de pedidos publica um evento, e outros serviços podem reagir a ele).
    * Implementar uma notificação em tempo real (real-time) para o cliente quando o status do seu pedido for atualizado.
    * Containerizar cada microsserviço usando Docker para facilitar o deploy.
    * Criar um pipeline básico de CI/CD para automatizar o build e a publicação das imagens Docker.

3.  **Tópicos Necessários:**
    * *(Todos os tópicos dos níveis Iniciante e Intermediário)*
    * Real-time Communication
        * SignalR
    * Background Tasks
        * Hosted Services
        * BackgroundService
    * Message Queues
        * RabbitMQ
    * Microservices
        * API Gateway
        * Ocelot
        * Communication
        * gRPC
    * Containerization
        * Docker
    * CI/CD
    * GraphQL
    * gRPC
