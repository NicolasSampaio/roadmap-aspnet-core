https://roadmap.sh/aspnet-core

# Plano de Estudos ASP.NET Core Developer com Desafios Práticos

## 🎯 **FASE 1: FUNDAMENTOS (Beginner Level)**

### **Módulo 1: C# e .NET Basics**
**Conceitos do Roadmap:**
- Learn the Basics of C#
- .NET CLI
- General Development Skills
- Data Structures and Algorithms

**Desafios Práticos:**
1. **Hello World API** - Criar primeira API básica
   - *Requisitos: Endpoint GET que retorna "Hello, World!"*
   - *Aprende: Sintaxe C#, estrutura projeto ASP.NET Core*

2. **Calculator API** - API de calculadora básica  
   - *Requisitos: Endpoints para +, -, *, / com validação de entrada*
   - *Aprende: Manipulação de dados, validação, múltiplos endpoints*

**Meta:** Dominar sintaxe C#, conceitos OOP e criar primeiras APIs simples.

---

### **Módulo 2: ASP.NET Core Fundamentals**
**Conceitos do Roadmap:**
- ASP.NET Core
- Web API
- Minimal APIs
- Routing
- Middlewares
- Filters & Attributes
- Configurations
- Options Pattern

**Desafios Práticos:**
1. **Echo API** - API que espelha dados recebidos
   - *Requisitos: Endpoint POST que retorna exatamente o que recebe no body*
   - *Aprende: Routing, middleware pipeline, deserialização JSON*

2. **Password Checker Service** - Validador de força de senhas
   - *Requisitos: Validar comprimento, caracteres especiais, maiúsculas/minúsculas*
   - *Aprende: Lógica de validação complexa, regex, responses customizados*

**Meta:** Entender arquitetura ASP.NET Core, roteamento e middleware.

---

### **Módulo 3: HTTP & Web APIs**
**Conceitos do Roadmap:**
- REST
- JSON APIs
- gRPC
- GraphQL

**Desafios Práticos:**
1. **Temperature Converter API** - Conversor de temperatura
   - *Requisitos: Converter Celsius/Fahrenheit/Kelvin, diferentes endpoints para cada conversão*
   - *Aprende: REST design, status codes HTTP, documentação Swagger*

2. **Weather API** - API do clima integrada
   - *Requisitos: Integração com API externa de clima, cache de 30min*
   - *Aprende: HttpClient, integração externa, tratamento de erros, cache básico*

**Meta:** Dominar REST, HTTP status codes e documentação de APIs.

---

## 🚀 **FASE 2: DESENVOLVIMENTO INTERMEDIÁRIO (Junior Level)**

### **Módulo 4: Banco de Dados & Entity Framework**
**Conceitos do Roadmap:**
- Entity Framework Core
- Relational Databases
- Search Engines
- NoSQL Databases
- Cloud Databases

**Desafios Práticos:**
1. **Todo List API** - Lista de tarefas com persistência
   - *Requisitos: CRUD completo, Entity Framework, SQL Server, migrations*
   - *Aprende: EF Core, Code First, LINQ, relacionamentos 1:N*

2. **User Profile API** - Perfis de usuário
   - *Requisitos: Usuários com perfis, relacionamento 1:1, soft delete*
   - *Aprende: Relacionamentos complexos, soft delete, data annotations*

**Meta:** Integrar banco de dados, usar EF Core e entender mapeamento objeto-relacional.

---

### **Módulo 5: Autenticação & Segurança**
**Conceitos do Roadmap:**
- Authentication
- Authorization
- Identity
- IdentityServer
- Auth0
- SAML
- OAuth
- JWT
- Basic Authentication

**Desafios Práticos:**
1. **Authentication Service** - Serviço de autenticação JWT
   - *Requisitos: Login/registro, JWT tokens, refresh tokens, hash de senhas*
   - *Aprende: ASP.NET Core Identity, JWT, bcrypt, authorization headers*

2. **Password Generator Service** - Gerador de senhas seguras
   - *Requisitos: Gerar senhas com critérios customizáveis, endpoint protegido*
   - *Aprende: Autorização por roles, geração criptográfica segura*

**Meta:** Implementar autenticação JWT, autorização e conceitos de segurança.

---

### **Módulo 6: Comunicação & Background Services**
**Conceitos do Roadmap:**
- Real-Time Communication
- SignalR
- Background Tasks
- HangFire
- Native BackgroundService
- Hosted Services

**Desafios Práticos:**
1. **Email Service** - Serviço de envio de emails
   - *Requisitos: Envio via SMTP, templates HTML, fila de emails*
   - *Aprende: SMTP, templates Razor, background services, filas*

2. **Real-time Chat API** - Chat em tempo real
   - *Requisitos: SignalR, salas de chat, histórico de mensagens*
   - *Aprende: SignalR, WebSockets, real-time communication*

**Meta:** Implementar comunicação externa e serviços em background.

---

### **Módulo 7: APIs Complexas & Dependency Injection**
**Conceitos do Roadmap:**
- Dependency Injection
- Service Locator
- Scrutor
- Autofac
- Ninject

**Desafios Práticos:**
1. **E-commerce API** - API de e-commerce completa
   - *Requisitos: Produtos, categorias, carrinho, pedidos, usuários autenticados*
   - *Aprende: Dependency Injection, Service Pattern, relacionamentos N:N*

2. **Blog API** - API de blog com comentários
   - *Requisitos: Posts, comentários aninhados, tags, paginação*
   - *Aprende: Relacionamentos complexos, paginação, queries otimizadas*

**Meta:** Desenvolver APIs complexas com múltiplas entidades e relacionamentos.

---

## 🏗️ **FASE 3: DEVOPS & CONTAINERIZAÇÃO (Junior Level)**

### **Módulo 8: Testing**
**Conceitos do Roadmap:**
- Unit Testing
- Integration Testing
- Behavior Testing
- E2E Testing
- Performance Testing
- xUnit
- NUnit
- MSTest
- FluentAssertions
- Bogus
- Respawn
- WebApplicationFactory
- SpecFlow
- LightBDD
- NBomber

**Desafios Práticos:**
1. **Unit Testing** - Implementar testes unitários nos projetos anteriores
2. **Integration Testing** - Testes de integração com banco de dados
3. **E2E Testing** - Testes end-to-end das APIs

**Meta:** Implementar testes em todos os níveis da aplicação.

---

### **Módulo 9: Logging & Monitoring**
**Conceitos do Roadmap:**
- Logging
- Serilog
- NLog
- Log4Net
- Monitoring
- Health Checks
- Watchdog

**Desafios Práticos:**
1. **Logging Service** - Sistema de logs estruturados
2. **Health Checks** - Implementar health checks nas APIs
3. **Monitoring** - Monitoramento de aplicações

**Meta:** Implementar observabilidade básica nas aplicações.

---

## 🔧 **FASE 4: ARQUITETURA AVANÇADA (Middle Level)**

### **Módulo 10: Caching**
**Conceitos do Roadmap:**
- Memory Caching
- Distributed Caching
- Redis
- MemCached

**Desafios Práticos:**
1. **Distributed Caching API** - Cache distribuído com Redis
2. **Caching** - Implementação de diferentes tipos de cache

**Meta:** Otimizar performance com diferentes estratégias de caching.

---

### **Módulo 11: Message Brokers & Containerização**
**Conceitos do Roadmap:**
- Message Brokers
- RabbitMQ
- Apache Kafka
- ActiveMQ
- Azure Service Bus
- NetMQ
- Containerization
- Docker
- Docker Compose

**Desafios Práticos:**
1. **Message Queues** - Implementação de filas de mensagem
2. **Container Dockerfile** - Containerizar aplicação
3. **Container Docker Compose** - Orquestração de containers
4. **Real-time Chat API** - Chat em tempo real com message brokers

**Meta:** Implementar comunicação assíncrona e containerização.

---

### **Módulo 12: Object Mapping & API Documentation**
**Conceitos do Roadmap:**
- Object Mapping
- AutoMapper
- Mapster
- ExpressMapper
- API Documentation
- Swagger
- NSwag
- API Versioning

**Desafios Práticos:**
1. **Advanced E-commerce API** - E-commerce com mapeamento de objetos
2. **Analytics API** - API de analytics com documentação Swagger
3. **Payment Gateway Integration** - Integração com gateway de pagamento
4. **API Versioning** - Versionamento de APIs

**Meta:** Implementar mapeamento de objetos e documentação profissional de APIs.

---

## 🎯 **FASE 5: ARQUITETURA SÊNIOR (Senior Level)**

### **Módulo 13: Task Scheduling & Serialization**
**Conceitos do Roadmap:**
- Task Scheduling
- BackgroundService
- Hosted Services
- Serialization
- Newtonsoft.Json
- System.Text.Json
- Protobuf-net

**Desafios Práticos:**
1. **Task Scheduling API** - Agendamento de tarefas
2. **Notification Service API** - Serviço de notificações com diferentes formatos
3. **CMS API** - Sistema de gerenciamento de conteúdo

**Meta:** Implementar agendamento de tarefas e diferentes formatos de serialização.

---

### **Módulo 14: Microservices Architecture**
**Conceitos do Roadmap:**
- Microservices
- Building Message Bus
- MassTransit
- NServiceBus
- EasyNetQ

**Desafios Práticos:**
1. **Microservices Architecture** - Construir aplicação com microserviços
2. **Microservices E-commerce API** - E-commerce em microserviços
3. **Event-Driven API** - Arquitetura orientada a eventos

**Meta:** Implementar arquitetura de microserviços com message bus.

---

### **Módulo 15: CQRS & Templating**
**Conceitos do Roadmap:**
- CQRS
- MediatR
- FluentValidation
- Scrutor
- Templating Engines
- Razor
- DotLiquid
- Scriban
- Fluid

**Desafios Práticos:**
1. **CQRS Event Sourcing API** - Implementação CQRS com Event Sourcing
2. **Multi-tenant API** - API multi-inquilino
3. **Serverless API** - API serverless

**Meta:** Implementar padrão CQRS e sistemas de templates.

---

### **Módulo 16: Client-Side Technologies & Advanced APIs**
**Conceitos do Roadmap:**
- Client-Side .NET
- Blazor Server
- Blazor WebAssembly  
- .NET MAUI
- GraphQL
- API Gateway & Service Mesh
- Distributed Tracing

**Desafios Práticos:**
1. **GraphQL API** - Implementação GraphQL
2. **API Gateway & Service Mesh** - Gateway e malha de serviços  
3. **Distributed Tracing API** - Rastreamento distribuído
4. **Data Processing API** - Processamento de dados
5. **ML Pipeline API** - Pipeline de Machine Learning

**Meta:** Implementar tecnologias client-side e APIs avançadas com observabilidade.

---

## 📋 **CRONOGRAMA SUGERIDO**

|
