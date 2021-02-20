using System;

namespace Core
{
    public class User
    {
        private int _id;
        private string _firstName;
        private string _lastName; 
        private DateTime _birthDate; 


        public string FirstName
        {
            get { return _firstName ; }
        }  

        public string LastName
        {
            get { return _lastName ; }
        }  

        public DateTime BirthDate
        {
            get { return _birthDate ; }
        }


        public User(string firstName, string lastName, DateTime birthDate)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._birthDate = birthDate;
        }
    }
}
