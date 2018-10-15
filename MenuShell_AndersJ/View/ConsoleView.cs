using System;

namespace MenuShell_AndersJ.View
{
    class ConsoleView
    {
        public virtual string Display()
        {
            Console.Clear();
            return "";
        }
    }
}