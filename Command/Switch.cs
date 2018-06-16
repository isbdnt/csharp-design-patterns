using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Switch
    {
        ICommand openCommand;
        ICommand closeCommand;

        public Switch(ICommand openCommand, ICommand closeCommand)
        {
            this.openCommand = openCommand;
            this.closeCommand = closeCommand;
        }

        public void Close()
        {
            closeCommand.Execute();
        }

        public void Open()
        {
            openCommand.Execute();
        }
    }
}
