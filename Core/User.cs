using System;
using System.ComponentModel.DataAnnotations;

namespace Core
{
    public class User
    {
        private int _id;
        private string _firstName;
        private string _lastName; 
        private DateTime _birthDate; 
        [Key]
        public int Id
        {
            get { return _id ; }
            set {_id = value ; }
        }  
        public string FirstName
        {
            get { return _firstName ; }
            set {_firstName = value ; }
        }  

        public string LastName
        {
            get { return _lastName ; }
        }  

        public DateTime BirthDate
        {
            get { return _birthDate ; }
        }

        public User()
        {
        }
        public User(string firstName, string lastName, DateTime birthDate)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._birthDate = birthDate;
        }
    }
}
