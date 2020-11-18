﻿using MBDEVproCOREwebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MBDEVproCOREwebAPI.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command> {
                new Command { Id = 0, HowTo = "Code an API", Line = ".NET CORE", Platform = "WebAPI and JSON" },
                new Command { Id = 1, HowTo = "Angular 10", Line = "Modules", Platform = "Components" },
                new Command { Id = 2, HowTo = "WCF", Line = "C#", Platform = "SOAP Request" }
        };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{ Id = 0, HowTo = "Code an API", Line = ".NET CORE", Platform = "WebAPI and JSON" };
        }
    }
}
