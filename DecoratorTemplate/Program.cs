// See https://aka.ms/new-console-template for more information
using DecoratorTemplate;
using Microsoft.Extensions.DependencyInjection;
using System;
//setup our DI

var serviceProvider = new ServiceCollection()
    .AddScoped<ITerminalRestrictionRepository, TerminalRestrictionRepository>()
    .RegisterTerminalRestrictionUpdateRepositoryDecorator()
    .BuildServiceProvider();

var _terminalRestrictionUpdateRepository = serviceProvider.GetService<ITerminalRestrictionUpdateRepository>();

//do the actual work here
var updateResult = await _terminalRestrictionUpdateRepository.UpdateAsync(parentId: 23);

Console.WriteLine(updateResult.Item2.FirstOrDefault());
