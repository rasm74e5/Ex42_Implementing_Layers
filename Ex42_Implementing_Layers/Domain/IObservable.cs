using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex42_Implementing_Layers.Application
{
    public interface IObservable
    {
        void Attach(IObserver subscriber);
        void Detach(IObserver subscriber);
        void Notify(string message);
    }
}
