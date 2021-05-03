using Commander.Models;
using System.Collections.Generic;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "test", Line = "test", Platform = "test" },
                new Command { Id = 0, HowTo = "test2", Line = "test2", Platform = "test2" },
                new Command { Id = 0, HowTo = "test3", Line = "test3", Platform = "test3" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "test", Line = "test", Platform = "test" };
        }
    }
}
