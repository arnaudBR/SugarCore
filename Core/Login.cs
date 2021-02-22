using System;

namespace Core
{
    public class Login
    {
         private string _identifiant;
         private string _EncryptedPassword; 


        public string Identifiant
        {
            get { return _identifiant ; }
        }  


        public Login(string identifiant)
        {
            this._identifiant = identifiant;
        }
    }
}
