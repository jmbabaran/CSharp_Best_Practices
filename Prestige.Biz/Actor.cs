using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestige.Biz
{
    public class Actor
    {
        public Actor()
        {
            Console.WriteLine("An actor is born.");
            //this.CurrentAgency = new Agency(); object needed always
        }

        public Actor( string actorName) : this() //defult constructor will be called.
        {
            ActorName = actorName;
        }

        private string actorName;

        public string ActorName
        {
            get { return actorName; }
            set {
                var formattedValue = value?.Trim();
                actorName = formattedValue;
            }
        }

        private string jobTitle;

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        private Agency currentAgency;

        public Agency CurrentAgency
        {
            get {
                //object needed sometime
                if (currentAgency==null)
                {
                    currentAgency = new Agency();
                }
                return currentAgency;
            }   
            set { currentAgency = value; }
        }



        /// <summary>
        /// Will return Title
        /// </summary>
        /// <returns></returns>
        public string GetOccupation()
        {
            jobTitle = "Actor";
            return jobTitle;
        }

        public int ActorAge { get; set; }

        public string ActorDescription { get; set; } = "Regular Actor.";

        /// <summary>
        /// Books actor and not date specified
        /// </summary>
        public string BookActor()
        {
            //Method Chaining
            return BookActor(string.Empty);

            //var details = "Book can change if " +
            //    "actor starts trouble.";
            //return "Actor " + ActorName + " is booked. " + details; 
        }

        /// <summary>
        /// Books actor on specific date
        /// </summary>
        /// <param name="theDate"></param>
        public string BookActor( string theDate)
        {
            var details = "Book can change if " +
                "actor starts trouble.";
            
            if(theDate != string.Empty)
            {
                return "Actor " + ActorName + " is booked on " + theDate + ". " + details;
            }
            else
            {
                return "Actor " + ActorName + " is booked. " + details;
            }
        }

        public string GetAgency()
        {
            //var currentAgency = new Agency();
            return CurrentAgency.Name;
        }
    }
}
