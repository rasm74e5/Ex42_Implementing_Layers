using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex42_Implementing_Layers.Domain;

namespace Ex42_Implementing_Layers.Application
{
    public interface IObserver
    {
        void Update(string message, IObservable observable);
    }
}
