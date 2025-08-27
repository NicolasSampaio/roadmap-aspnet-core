https://roadmap.sh/aspnet-core

https://github.com/libre-university/backend-challenges?tab=readme-ov-file

# Plano de Estudos ASP.NET Core Developer com Desafios Práticos

## 🎯 **FASE 1: FUNDAMENTOS (Beginner Level)**

### **Módulo 1: C# e .NET Basics**
**Conceitos do Roadmap:**
- Learn the Basics of C#
- C#
- .NET
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

**Meta:** Dominar sintaxe C#, conceitos .NET e criar primeiras APIs simples.

---

### **Módulo 2: Version Control & HTTP**
**Conceitos do Roadmap:**
- Git - Version Control
- GitHub, GitLab, BitBucket
- HTTP / HTTPs Protocol

**Desafios Práticos:**
1. **Echo API** - API que espelha dados recebidos
   - *Requisitos: Endpoint POST que retorna exatamente o que recebe no body*
   - *Aprende: HTTP methods, request/response, versionamento Git*

2. **Password Checker Service** - Validador de força de senhas
   - *Requisitos: Validar comprimento, caracteres especiais, maiúsculas/minúsculas*
   - *Aprende: HTTP status codes, validation, Git workflow*

**Meta:** Entender HTTP protocol e controle de versão.

---

### **Módulo 3: ASP.NET Core Fundamentals**
**Conceitos do Roadmap:**
- ASP.NET Core Basics
- MVC
- REST
- Razor Pages
- Razor Components
- Middlewares
- Filters and Attributes
- App Settings and Configs
- Minimal APIs

**Desafios Práticos:**
1. **Temperature Converter API** - Conversor de temperatura
   - *Requisitos: Converter Celsius/Fahrenheit/Kelvin, diferentes endpoints para cada conversão*
   - *Aprende: REST design, middlewares, app settings*

2. **Weather API** - API do clima integrada
   - *Requisitos: Integração com API externa de clima, configurações via appsettings*
   - *Aprende: Filters, attributes, external API integration*

**Meta:** Dominar fundamentos ASP.NET Core e arquitetura REST.

---

## 🚀 **FASE 2: DADOS E PERSISTÊNCIA (Junior Level)**

### **Módulo 4: Database Fundamentals**
**Conceitos do Roadmap:**
- Database Fundamentals
- SQL Basics
- Database Design Basics
- Stored Procedures
- Constraints
- Triggers

**Desafios Práticos:**
1. **Todo List API** - Lista de tarefas com SQL raw
   - *Requisitos: CRUD com SQL raw, stored procedures, constraints*
   - *Aprende: SQL fundamentals, database design, triggers*

**Meta:** Dominar SQL e design de banco de dados.

---

### **Módulo 5: Object Relational Mapping**
**Conceitos do Roadmap:**
- Object Relational Mapping
- Entity Framework Core
- Code First + Migrations
- Lazy, Eager, Explicit Loading
- Change Tracker API
- Dapper
- NHibernate

**Desafios Práticos:**
1. **User Profile API** - Perfis de usuário com EF Core
   - *Requisitos: Code First, migrations, relacionamento 1:1, lazy/eager loading*
   - *Aprende: EF Core, migrations, loading strategies*

2. **Blog API** - API de blog com Dapper
   - *Requisitos: Posts, comentários, implementação com Dapper para performance*
   - *Aprende: Micro ORM, performance tuning, Change Tracker*

**Meta:** Dominar ORMs e estratégias de carregamento de dados.

---

### **Módulo 6: Dependency Injection**
**Conceitos do Roadmap:**
- Dependency Injection
- Life Cycles
- DI Containers
- Microsoft.Extensions
- Scrutor
- AutoFac
- Scoped
- Transient
- Singleton

**Desafios Práticos:**
1. **E-commerce API** - API com DI completa
   - *Requisitos: Services com diferentes lifetimes, AutoFac container*
   - *Aprende: DI patterns, service lifetimes, container configuration*

**Meta:** Implementar injeção de dependência profissional.

---

## 🔧 **FASE 3: PERFORMANCE E COMUNICAÇÃO (Middle Level)**

### **Módulo 7: Caching**
**Conceitos do Roadmap:**
- Caching
- Memory Cache
- Entity Framework 2nd Level Cache
- Distributed Cache
- Redis
- Memcached

**Desafios Práticos:**
1. **Distributed Caching API** - Cache distribuído com Redis
   - *Requisitos: Memory cache local, Redis distribuído, EF 2nd level cache*
   - *Aprende: Cache strategies, Redis, performance optimization*

**Meta:** Implementar diferentes níveis de caching.

---

### **Módulo 8: Databases Advanced**
**Conceitos do Roadmap:**
- Databases
- Relational (SQL Server, PostgreSQL, MariaDB, MySQL)
- NoSQL (MongoDB, Cassandra, LiteDB, CouchDB)
- Cloud (Cosmos DB, Dynamo DB)
- Search Engines (Elastic Search, Solr, Sphinx)

**Desafios Práticos:**
1. **Multi-Database API** - API com SQL Server + MongoDB
   - *Requisitos: Dados relacionais no SQL Server, logs no MongoDB*
   - *Aprende: Multi-database architecture, NoSQL patterns*

2. **Search API** - API de busca com Elasticsearch
   - *Requisitos: Indexação automática, busca full-text, agregações*
   - *Aprende: Search engines, indexing, query optimization*

**Meta:** Trabalhar com diferentes tipos de banco de dados.

---

### **Módulo 9: Logging**
**Conceitos do Roadmap:**
- Log Frameworks
- Serilog
- NLog

**Desafios Práticos:**
1. **Logging Service** - Sistema de logs estruturados
   - *Requisitos: Serilog, logs em arquivo/console/database, diferentes sinks*
   - *Aprende: Structured logging, log levels, sinks configuration*

**Meta:** Implementar logging profissional.

---

### **Módulo 10: API Communication**
**Conceitos do Roadmap:**
- API Clients and Communication
- REST
- GraphQL
- GraphQL .NET
- HotChocolate
- gRPC

**Desafios Práticos:**
1. **GraphQL API** - Implementação GraphQL com HotChocolate
   - *Requisitos: Queries, mutations, subscriptions, schema stitching*
   - *Aprende: GraphQL schema design, resolvers, subscriptions*

2. **gRPC Service** - Serviço gRPC
   - *Requisitos: Proto definitions, streaming, interceptors*
   - *Aprende: gRPC protocols, performance, binary communication*

**Meta:** Implementar diferentes protocolos de comunicação.

---

## 🌐 **FASE 4: REAL-TIME E INTEGRAÇÃO (Middle-Senior Level)**

### **Módulo 11: Real-Time Communication**
**Conceitos do Roadmap:**
- Real-Time Communication
- Web Sockets
- SignalR Core

**Desafios Práticos:**
1. **Real-time Chat API** - Chat em tempo real
   - *Requisitos: SignalR Core, salas de chat, histórico de mensagens*
   - *Aprende: SignalR hubs, groups, real-time broadcasting*

**Meta:** Implementar comunicação em tempo real.

---

### **Módulo 12: Object Mapping**
**Conceitos do Roadmap:**
- Object Mapping
- AutoMapper
- Mapperly
- Manual Mapping

**Desafios Práticos:**
1. **Advanced E-commerce API** - E-commerce com AutoMapper
   - *Requisitos: DTOs complexos, perfis de mapeamento, validação*
   - *Aprende: AutoMapper profiles, custom resolvers, performance*

**Meta:** Implementar mapeamento de objetos eficiente.

---

### **Módulo 13: Task Scheduling**
**Conceitos do Roadmap:**
- Task Scheduling
- Native Background Service
- Hangfire
- Quartz
- Coravel

**Desafios Práticos:**
1. **Task Scheduling API** - Agendamento com Hangfire
   - *Requisitos: Jobs recorrentes, fire-and-forget, delayed jobs, dashboard*
   - *Aprende: Background services, job scheduling, monitoring*

**Meta:** Implementar processamento em background.

---

## 🧪 **FASE 5: TESTING E QUALIDADE (Senior Level)**

### **Módulo 14: Testing**
**Conceitos do Roadmap:**
- Testing
- XUnit
- NUnit
- MSTest
- Shouldly
- NSubstitute
- Moq
- FakeItEasy
- AutoFixture
- Bogus
- WebApplicationFactory
- Test Containers
- Respawn
- Specflow
- Light BDD
- Playwright
- Puppeteer
- Cypress

**Desafios Práticos:**
1. **Comprehensive Testing** - Suite de testes completa
   - *Requisitos: Unit tests (XUnit), Integration tests (WebApplicationFactory), E2E (Playwright)*
   - *Aprende: Test pyramids, mocking strategies, test containers*

2. **BDD Testing** - Behavior Driven Development
   - *Requisitos: SpecFlow scenarios, living documentation*
   - *Aprende: BDD patterns, executable specifications*

**Meta:** Implementar testing em todos os níveis.

---

## 🏗️ **FASE 6: MICROSERVICES E ARQUITETURA (Senior Level)**

### **Módulo 15: Microservices**
**Conceitos do Roadmap:**
- Microservices
- ActiveMQ
- Kafka
- RabbitMQ
- Azure Service Bus
- Mass Transit
- NServiceBus
- EasyNetQ
- Ocelot
- YARP

**Desafios Práticos:**
1. **Microservices E-commerce** - E-commerce em microserviços
   - *Requisitos: User Service, Product Service, Order Service, API Gateway (YARP)*
   - *Aprende: Service decomposition, API Gateway patterns*

2. **Event-Driven Architecture** - Arquitetura orientada a eventos
   - *Requisitos: RabbitMQ + MassTransit, event sourcing, saga patterns*
   - *Aprende: Message brokers, event-driven patterns, distributed transactions*

**Meta:** Implementar arquitetura de microserviços completa.

---

### **Módulo 16: Cloud & CI/CD**
**Conceitos do Roadmap:**
- Cloud
- Docker
- Kubernetes
- Orleans
- Dapr
- CI / CD
- GitHub Actions
- Azure Pipelines
- GitLab CI/CD
- Circle CI

**Desafios Práticos:**
1. **Containerization & Orchestration** - Deploy com K8s
   - *Requisitos: Docker containers, Kubernetes deployment, health checks*
   - *Aprende: Container orchestration, scaling, monitoring*

2. **CI/CD Pipeline** - Pipeline completo
   - *Requisitos: GitHub Actions, automated testing, deployment*
   - *Aprende: DevOps practices, automation, deployment strategies*

**Meta:** Implementar deployment e orquestração cloud-native.

---

## 🎨 **FASE 7: FRAMEWORKS AVANÇADOS (Expert Level)**

### **Módulo 17: Template Engines & Frameworks**
**Conceitos do Roadmap:**
- Template Engines (Razor, Scriban, Fluid)
- Frameworks (Blazor, .NET MAUI)

**Desafios Práticos:**
1. **CMS API** - Sistema de gerenciamento de conteúdo
   - *Requisitos: Templates dinâmicos com Scriban, admin panel com Blazor*
   - *Aprende: Template engines, hybrid applications*

**Meta:** Integrar template engines e frameworks modernos.

---

### **Módulo 18: Software Architecture**
**Conceitos do Roadmap:**
- Software Design and Architecture
- MediatR
- FluentValidation
- Polly
- Marten
- Scalar

**Desafios Práticos:**
1. **CQRS Event Sourcing API** - Arquitetura CQRS completa
   - *Requisitos: MediatR, FluentValidation, Marten event store, Polly resilience*
   - *Aprende: CQRS, Event Sourcing, resilience patterns*

2. **Multi-tenant SaaS API** - SaaS multi-inquilino
   - *Requisitos: Tenant isolation, feature flags, billing integration*
   - *Aprende: Multi-tenancy, SaaS patterns, distributed systems*

**Meta:** Implementar padrões arquiteturais avançados.

---

## 📋 **CRONOGRAMA SUGERIDO**

| **Fase** | **Duração** | **Foco Principal** |
|----------|-------------|-------------------|
| **Fase 1** (Módulos 1-3) | 4 semanas | Fundamentos C# e ASP.NET Core |
| **Fase 2** (Módulos 4-6) | 6 semanas | Dados e Persistência |
| **Fase 3** (Módulos 7-10) | 8 semanas | Performance e Comunicação |
| **Fase 4** (Módulos 11-13) | 6 semanas | Real-time e Integração |
| **Fase 5** (Módulo 14) | 3 semanas | Testing e Qualidade |
| **Fase 6** (Módulos 15-16) | 8 semanas | Microservices e Cloud |
| **Fase 7** (Módulos 17-18) | 6 semanas | Arquitetura Avançada |

**Total:** 41 semanas (~10 meses)

## 🎯 **DICAS DE EXECUÇÃO**

- **Complete todos os requisitos** de cada desafio antes de prosseguir
- **Documente seu aprendizado** - crie um portfólio no GitHub
- **Use os tópicos do roadmap** como checklist - marque cada conceito dominado
- **Implemente testes** a partir do Módulo 5
- **Revise periodicamente** - refatore projetos anteriores com novos conhecimentos

## 📚 **RECURSOS COMPLEMENTARES**

- **Microsoft Learn** - Documentação oficial .NET
- **Pluralsight/Udemy** - Cursos específicos por tecnologia
- **GitHub** - Estudar projetos open source
- **Stack Overflow** - Comunidade para dúvidas
- **Discord/Reddit** - Comunidades .NET para networking
