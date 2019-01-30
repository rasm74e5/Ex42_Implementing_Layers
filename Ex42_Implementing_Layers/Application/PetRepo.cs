using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex42_Implementing_Layers.Application
{
    public class PetRepo : IObserver, IObservable
    {
        private IObservable Pet;
        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public void Update(string message, IObservable observable)
        {
            Message = message;
            Pet = observable;
        }

        public PetRepo(IObservable observable, string Message)
        {
            Pet = observable;
        }
        //subject
        private List<IObserver> observers = new List<IObserver>();
        public void Attach(IObserver subscriber)
        {
            observers.Add(subscriber);
        }

        public void Detach(IObserver subscriber)
        {
            observers.Remove(subscriber);
        }

        public void Notify(string message)
        {
            foreach (IObserver subscriber in observers)
            {
                subscriber.Update(message, this);
            }
        }
    }
}
