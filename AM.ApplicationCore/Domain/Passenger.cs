using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        private string passeportnumber;
        private string firstname;
        private string lastname;
        private DateTime birthdate;
        private int telnumber;
        private string emailaddress;
        private int id;


        public string PasseportNumber { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public int TelNumber { get; set; }
        public string EmailAddress { get; set; }

        public int Id { get; set; }


        public bool CheckProfile(string FirstName, string LastName)

        {
            return FirstName.Equals(FirstName) && LastName.Equals(LastName);


        }
        public bool CheckProfile(string FirstName, string LastName,string EmailAddress)

        {
            return FirstName.Equals(FirstName) && LastName.Equals(LastName) && EmailAddress.Equals(EmailAddress);


        }

        // méthode qui remplace les 2 deux méthodes
        public bool Login(string FirstName, string LastName, string EmailAddress = null)
        {
            //if( EmailAddress != null)
            //     return CheckProfile(FirstName, LastName, EmailAddress);
            //return FirstName.Equals(FirstName) && LastName.Equals(LastName); //Teb3a el else 
            //;

            return (EmailAddress != null) ? CheckProfile(FirstName, LastName, EmailAddress) : CheckProfile(FirstName, LastName);
        }
        //générer opérator if else , if ? 
                                                                                                                                 // : else => traitement
        

            // Implémenter méthode dans classe mére et faire l'héritage dans les deux classes filles
            // attribut oui méthode non dans classes filles
         
        public virtual void PassengerType() // on doit ajouter virtual 
        {
            Console.WriteLine("Im aycha , the passenger ");


        }



        }

    

}

