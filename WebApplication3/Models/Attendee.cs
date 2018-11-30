using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Attendee
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public bool Attending;
        public string DateChosen;
        public bool BringGuest;
        public string GuestFirstName;
        public string GuestLastName;
        public bool BringDish;
        public string DishName;
        public string DishDescription;

        public Attendee(string firstName, string lastName, string email,
            bool attending, string dateChosen, bool bringGuest, string guestFirstName, string guestLastName,
            bool bringDish, string dishName, string dishDescription)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Attending = attending;
            DateChosen = dateChosen;
            BringGuest = bringGuest;
            GuestFirstName = guestFirstName;
            GuestLastName = guestLastName;
            BringDish = bringDish;
            DishName = dishName;
            DishDescription = dishDescription;
        }

        public Attendee()
        {}


    }
}