using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommanderConsole.Commander
{
    class User
    {
        private List<ICommandGame> commands = new List<ICommandGame>();
        private int current = 0;

        public void Redo(int levels)
        {
            if (levels-1 < commands.Count)
            {
                Console.WriteLine("\n---- Redo {0} levels ", levels);

                // Делаем возврат операций
                for (int i = 0; i < levels; i++)
                    if (current < commands.Count )
                        commands[current++].Execute();
            }
        }

        public void Undo(int levels)
        {
            if (levels-1 < commands.Count)
            {
                Console.WriteLine("\n---- Undo {0} levels ", levels);

                // Делаем отмену операций
                for (int i = 0; i < levels; i++)
                    if (current > 0)
                        commands[--current].UnExecute();
            }
        }

        public void Compute(ICommandGame command)
        {
            // Выполняем команду
            command.Execute();
            // Добавляем операцию к списку отмены
            commands.Add(command);
            current++;
        }
    }
}
