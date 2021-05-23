using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Interfaces
{
    interface IManager
    {
        List<IWorker> Workers { get; set; }
        void Manage();
        void Organize();
        void Control();

    }
}
