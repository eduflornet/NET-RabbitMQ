
using MediatR;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Domain.CommandHandlers;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Events;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace MicroRabbit.Infra.IoC
{
    public static class DependencyContainer
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            // Domain bus.
            services.AddTransient<IEventBus, RabbitMQBus>(serviceProvider => {
                var mediator = serviceProvider.GetService<IMediator>();
                var serviceScopeFactory = serviceProvider.GetService<IServiceScopeFactory>();
                return new RabbitMQBus(mediator, serviceScopeFactory);
            });

            // Domain Banking Commands
            services.AddTransient<IRequestHandler<AccountTransferCommand, bool>, AccountTransferCommandHandler>();
            
            // Domain Banking Events
            //services.AddTransient<IEventHandler<AccountTransferCreatedEvent>>();
            
            // Application Services.
            services.AddTransient<IAccountService, AccountService>();

            // Data services.
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDbContext>();

        }
    }
}
