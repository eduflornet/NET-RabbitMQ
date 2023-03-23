## [Build .NET6 Microservices using RabbitMQ Messaging](https://github.com/eduflornet/NET-RabbitMQ/tree/main/src/MicroRabbit)

### Implementation Details
    Libraries
        - MicroRabbit.Domain.Core (Domain library)
        - MicroRabbit.Infra.Bus (EventBus library)
    Microservice Banking 
        - MicroRabbit.Banking.Api (ASP.NET Web API)
          - Controllers
            - BankingController
          - Program
        - MicroRabbit.Banking.Application (Application library)
          - Interfaces
          - Models
          - Services
        - MicroRabbit.Banking.Data (Data library)
          - Context
          - Migration
          - Repository
        - MicroRabbit.Banking.Domain (Domain library)
          - CommandHandlers
          - Commands
          - EventHandlers
          - Events
          - Interfaces
          - Models

<img src="https://images2.imgbox.com/e4/7d/hj2VuELR_o.jpg?download=true" width="70%" height="70%">

### Tools
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)
- [NET6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- [MediatR version 12 by Jimmy Bogard](https://github.com/jbogard/MediatR)
- [RabbitMQ Client version 6.4.0](https://www.rabbitmq.com/)
- [Newtonsoft.JSON version 13.0.3](https://www.newtonsoft.com/json)
- [Microsoft.Extensions.DependencyInjection version 6.0.1](https://www.nuget.org/packages/Microsoft.Extensions.DependencyInjection/)
- [Microsoft.EntityFrameworkCore version 6.0.15](https://learn.microsoft.com/en-us/ef/core/)
- [Microsoft.EntityFrameworkCore.Design version 6.0.15](https://learn.microsoft.com/en-us/ef/core/cli/services)
- [Microsoft.EntityFrameworkCore.SqlServer version 6.0.15](https://learn.microsoft.com/en-us/ef/core/providers/sql-server/?tabs=dotnet-core-cli)
- [Microsoft.EntityFrameworkCore.Tools version 6.0.15](https://learn.microsoft.com/en-us/ef/core/cli/)
- [MediatR.Extensions.Microsoft.DependencyInjectionFixed version 5.1.2](https://www.nuget.org/packages/MediatR.Extensions.Microsoft.DependencyInjectionFixed/5.1.2?_src=template)
- [Swashbuckle.AspNetCore version 6.2.3](https://www.nuget.org/packages/Swashbuckle.AspNetCore)
- [Docker](https://www.docker.com/)

  
## [NET6 Sample Console producer and receiver with RabbitMQ Client](https://github.com/eduflornet/NET-RabbitMQ/tree/main/samples/ProducerConsumerRabbitMQ)

### References
- [rabbitmqctl](https://www.rabbitmq.com/rabbitmqctl.8.html)
- [Tutorial: Uso de la inserción de dependencias en .NET](https://learn.microsoft.com/es-mx/dotnet/core/extensions/dependency-injection-usage)
- [stackoverflow-How to add mediatr in .NET 6?](https://stackoverflow.com/questions/72261822/how-to-add-mediatr-in-net-6)
- [stackoverflow-Could not load type 'MediatR.ServiceFactory'](https://stackoverflow.com/questions/75527541/could-not-load-type-mediatr-servicefactory)
- [MediaTypeNames.Application.Json](https://docs.microsoft.com/en-us/dotnet/api/system.net.mime.mediatypenames.application.json?view=net-7.0)
- [stackoverflow-Rabbitmq connection refused from Docker container to local host](https://stackoverflow.com/questions/41089268/rabbitmq-connection-refused-from-docker-container-to-local-host)
- 

