using Ex42_Implementing_Layers.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex42_Implementing_Layers.Domain
{
    public class Pet : IObservable
    {
        IObservable observer;
        private string _petname;
        public string PetName
        {
            get { return _petname; }
            set
            {
                if (value != _petname)
                {
                    _petname = value;
                    //Notify("PetName");
                    observer.Notify("PetName");
                }
            }
        }
        private string _petbreed;
        public string PetBreed
        {
            get { return _petbreed; }
            set
            {
                if (value != _petbreed)
                {
                    _petbreed = value;
                    //Notify("PetBreed");
                    observer.Notify("PetBreed");
                }

            }
        }
        public string PetType
        {
            get;
            set;
        }
        public string PetDOB
        {
            get;
            set;
        }
        public string PetWeight
        {
            get;
            set;
        }
        public string OwnerID
        {
            get;
            set;
        }
        public Pet(string petname, string petbreed, string pettype, string petdob, string petweight, string ownerid)
        {
            PetName = petname;
            PetBreed = petbreed;
            PetType = pettype;
            PetDOB = petdob;
            PetWeight = petweight;
            OwnerID = ownerid;

        }
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
