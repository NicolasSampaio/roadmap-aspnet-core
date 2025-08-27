https://roadmap.sh/aspnet-core

https://github.com/libre-university/backend-challenges?tab=readme-ov-file

# Plano de Estudos ASP.NET Core Developer com Desafios Práticos

## 🎯 **FASE 1: PREPARAÇÃO PARA BEGINNER CHALLENGES**

### **Módulo 1: C# e .NET Fundamentals**
**Conceitos do Roadmap:**
- Learn the Basics of C#
- C#
- .NET
- .NET CLI
- General Development Skills
- Data Structures and Algorithms

**Objetivos:**
- Dominar sintaxe C# básica
- Entender tipos de dados, classes, métodos
- Configurar ambiente .NET
- Conceitos de programação orientada a objetos

**Meta:** Preparar base sólida em C# antes de criar APIs.

---

### **Módulo 2: HTTP e REST Fundamentals**
**Conceitos do Roadmap:**
- HTTP / HTTPs Protocol
- REST
- Git - Version Control
- GitHub, GitLab, BitBucket

**Objetivos:**
- Entender HTTP methods (GET, POST, PUT, DELETE)
- Compreender status codes HTTP
- Conceitos REST (endpoints, resources, stateless)
- Configurar controle de versão

**Meta:** Dominar conceitos HTTP e REST antes do primeiro desafio.

---

### **Módulo 3: ASP.NET Core para APIs**
**Conceitos do Roadmap:**
- ASP.NET Core Basics
- MVC
- REST
- Minimal APIs
- Middlewares
- Filters and Attributes
- App Settings and Configs

**Objetivos:**
- Criar projetos ASP.NET Core
- Entender controllers e actions
- Configurar routing
- Middleware pipeline básico

**Meta:** Preparar para criar APIs REST funcionais.

---

## 🚀 **FASE 2: BEGINNER CHALLENGES**

### **Módulo 4: APIs Básicas**

**Desafios Práticos:**
1. **Hello World API** - Develop a basic REST API that returns "Hello, World!"
   - *Aplicar: ASP.NET Core, REST endpoints, HTTP GET*
   - *Aprende na prática: Criação de controllers, routing básico*

2. **Echo API** - Build an API that echoes back data sent via POST requests
   - *Aplicar: HTTP POST, request/response handling*
   - *Aprende na prática: Model binding, serialização JSON*

3. **Number Generator Service** - Develop an API that returns a random number
   - *Aplicar: Business logic em APIs*
   - *Aprende na prática: Services, dependency injection básico*

### **Módulo 5: APIs com Validação e Lógica**

**Desafios Práticos:**
4. **Palindrome Checker Service** - Build an API to check if a string is a palindrome
   - *Aplicar: String manipulation, business logic*
   - *Aprende na prática: Input validation, algoritmos*

5. **Password Checker Service** - Build an API to check the strength and security of passwords
   - *Aplicar: Complex validation, security concepts*
   - *Aprende na prática: Regex, security practices, response formatting*

6. **Password Generator Service** - Develop a service to generate secure passwords
   - *Aplicar: Random generation, configuration*
   - *Aprende na prática: Cryptographic security, configurable services*

**Meta:** Implementar APIs com lógica de negócio e validações.

---

### **Módulo 6: APIs com Integração Externa**

**Desafios Práticos:**
7. **Time Zone Service** - Create a Service to retrieve time zone information
   - *Aplicar: DateTime handling, external data*
   - *Aprende na prática: Time zones, date formatting, external APIs*

8. **IP Address Tracker** - Track and analyze IP addresses
   - *Aplicar: Network concepts, geolocation*
   - *Aprende na prática: HttpClient, third-party API integration*

9. **ZipCode Lookup** - Lookup service for postal codes
   - *Aplicar: Data lookup, external services*
   - *Aprende na prática: Error handling, caching básico*

**Meta:** Integrar com APIs externas e lidar com dados externos.

---

## 🔧 **FASE 3: PREPARAÇÃO PARA JUNIOR CHALLENGES**

### **Módulo 7: Database Fundamentals**
**Conceitos do Roadmap:**
- Database Fundamentals
- SQL Basics
- Database Design Basics
- Stored Procedures
- Constraints
- Triggers

**Objetivos:**
- Entender conceitos de banco de dados
- Dominar SQL básico
- Projetar schemas simples
- Compreender relacionamentos

**Meta:** Preparar para desafios que requerem persistência de dados.

---

### **Módulo 8: Entity Framework Core**
**Conceitos do Roadmap:**
- Object Relational Mapping
- Entity Framework Core
- Code First + Migrations
- Lazy, Eager, Explicit Loading
- Change Tracker API

**Objetivos:**
- Configurar EF Core
- Criar modelos e DbContext
- Executar migrations
- Entender loading strategies

**Meta:** Dominar ORM antes dos desafios Junior.

---

## 🚀 **FASE 4: JUNIOR CHALLENGES**

### **Módulo 9: APIs com Persistência Básica**

**Desafios Práticos:**
10. **Calculator API** - Calculator with operation history
    - *Aplicar: EF Core, data persistence*
    - *Aprende na prática: CRUD operations, data modeling*

11. **Temperature Converter API** - Converter with conversion history  
    - *Aplicar: Database relationships*
    - *Aprende na prática: One-to-many relationships, querying*

12. **Currency Converter API** - Currency converter with rates storage
    - *Aplicar: External API + database*
    - *Aprende na prática: Data synchronization, caching*

**Meta:** Combinar APIs com persistência de dados.

---

### **Módulo 10: APIs CRUD Completas**

**Desafios Práticos:**
13. **Todo List API** - Full CRUD todo list
    - *Aplicar: Complete CRUD operations*
    - *Aprende na prática: RESTful design patterns*

14. **Contact Form API** - Contact management system
    - *Aplicar: Form processing, data validation*
    - *Aprende na prática: Input sanitization, business rules*

15. **Weather API** - Weather service with location storage
    - *Aplicar: Complex data relationships*
    - *Aprende na prática: Geolocation data, API composition*

**Meta:** Dominar operações CRUD completas.

---

## 🔧 **FASE 5: PREPARAÇÃO PARA MIDDLE CHALLENGES**

### **Módulo 11: Dependency Injection**
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

**Objetivos:**
- Configurar DI containers
- Entender service lifetimes
- Implementar service patterns
- Configurar AutoFac

**Meta:** Dominar injeção de dependência para arquiteturas complexas.

---

### **Módulo 12: Authentication & Authorization**
**Conceitos do Roadmap:**
- Authentication
- Authorization
- JWT
- Identity
- OAuth
- SAML

**Objetivos:**
- Implementar autenticação JWT
- Configurar autorização por roles
- Integrar Identity
- Entender OAuth flows

**Meta:** Preparar para APIs que requerem segurança.

---

## 🚀 **FASE 6: MIDDLE CHALLENGES** 

### **Módulo 13: APIs com Arquitetura Avançada**

**Desafios Práticos:**
16. **URL Shortener Service** - Create an API for shortening and managing URLs
    - *Aplicar: DI, caching, unique generation*
    - *Aprende na prática: Service architecture, URL generation algorithms*

17. **Authentication Service** - User authentication and authorization system
    - *Aplicar: JWT, Identity, security*
    - *Aprende na prática: Token management, password hashing*

18. **Email Service** - Email sending and templating service
    - *Aplicar: SMTP, background services*
    - *Aprende na prática: Email templates, queue processing*

**Meta:** Implementar serviços com arquitetura robusta.

---

### **Módulo 14: APIs Complexas com Múltiplas Responsabilidades**

**Desafios Práticos:**
19. **User Profile API** - Complete user management system
    - *Aplicar: Complex relationships, file handling*
    - *Aprende na prática: Profile management, image upload*

20. **Task Management API** - Project and task management
    - *Aplicar: Complex business logic, notifications*
    - *Aprende na prática: Project hierarchies, task dependencies*

21. **Event Scheduling API** - Event and calendar management
    - *Aplicar: DateTime complexity, recurring events*
    - *Aprende na prática: Calendar algorithms, timezone handling*

**Meta:** Desenvolver APIs com lógica de negócio complexa.

---

### **Módulo 15: E-commerce & Payment Integration**

**Desafios Práticos:**
22. **Inventory Management API** - Stock and inventory tracking
    - *Aplicar: Transaction management, concurrency*
    - *Aprende na prática: Stock control, transaction isolation*

23. **E-commerce API** - Full e-commerce platform
    - *Aplicar: Complex relationships, business rules*
    - *Aprende na prática: Cart management, order processing*

24. **Payment Processing Service** - Payment gateway integration
    - *Aplicar: External integrations, security*
    - *Aprende na prática: Payment flows, webhook handling*

**Meta:** Integrar pagamentos e processos de negócio complexos.

---

## 🔧 **FASE 7: PREPARAÇÃO PARA SENIOR CHALLENGES**

### **Módulo 16: Caching & Performance**
**Conceitos do Roadmap:**
- Caching
- Memory Cache
- Distributed Cache
- Redis
- Entity Framework 2nd Level Cache

**Objetivos:**
- Implementar diferentes tipos de cache
- Configurar Redis
- Otimizar performance de queries
- Estratégias de invalidação

**Meta:** Preparar para sistemas de alta performance.

---

### **Módulo 17: Message Brokers & Microservices**
**Conceitos do Roadmap:**
- Microservices
- RabbitMQ
- Kafka
- Mass Transit
- NServiceBus

**Objetivos:**
- Configurar message brokers
- Implementar event-driven architecture  
- Entender microservices patterns
- Service communication

**Meta:** Preparar para arquitetura distribuída.

---

## 🚀 **FASE 8: SENIOR CHALLENGES**

### **Módulo 18: High Performance & Distributed Systems**

**Desafios Práticos:**
25. **Advanced E-commerce API** - E-commerce with caching and queuing
    - *Aplicar: Redis, RabbitMQ, advanced caching*
    - *Aprende na prática: Performance optimization, async processing*

26. **Microservices E-commerce API** - E-commerce using microservices architecture  
    - *Aplicar: Service decomposition, API Gateway*
    - *Aprende na prática: Distributed systems, service mesh*

27. **Real-time Chat API** - Scalable real-time messaging
    - *Aplicar: SignalR, scaling, message persistence*
    - *Aprende na prática: Real-time scaling, connection management*

**Meta:** Implementar sistemas distribuídos de alta performance.

---

### **Módulo 19: Advanced Architecture Patterns**

**Desafios Práticos:**
28. **CQRS Event Sourcing API** - Full CQRS with event sourcing
    - *Aplicar: MediatR, event sourcing, separate read/write models*
    - *Aprende na prática: CQRS patterns, event store design*

29. **Multi-tenant API** - Multi-tenant SaaS application
    - *Aplicar: Tenant isolation, data separation*
    - *Aprende na prática: Multi-tenancy patterns, tenant resolution*

30. **API Gateway & Service Mesh** - Service mesh implementation
    - *Aplicar: YARP, service discovery, circuit breakers*
    - *Aprende na prática: Gateway patterns, resilience*

**Meta:** Implementar padrões arquiteturais enterprise.

---

## 📋 **CRONOGRAMA SUGERIDO CORRIGIDO**

| **Fase** | **Duração** | **Foco Principal** |
|----------|-------------|-------------------|
| **Fases 1-2** (Módulos 1-6) | 6 semanas | Preparação + Beginner Challenges |
| **Fases 3-4** (Módulos 7-10) | 6 semanas | Preparação + Junior Challenges |
| **Fases 5-6** (Módulos 11-15) | 8 semanas | Preparação + Middle Challenges |
| **Fases 7-8** (Módulos 16-19) | 8 semanas | Preparação + Senior Challenges |

**Total:** 28 semanas (~7 meses)

## 🎯 **METODOLOGIA CORRIGIDA**

**✅ PREPARAÇÃO ANTES DOS DESAFIOS:** Cada fase tem módulos de preparação teórica antes dos desafios práticos  
**✅ REQUISITOS REAIS:** Desafios baseados nas descrições reais do repositório  
**✅ PROGRESSÃO LÓGICA:** Conceitos são ensinados na ordem necessária para os desafios  
**✅ APLICAÇÃO PRÁTICA:** Cada desafio aplica conceitos específicos aprendidos na preparação

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
