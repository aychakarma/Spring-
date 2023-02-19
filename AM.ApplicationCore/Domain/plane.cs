using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{   
    // cas 1 enum
    //public enum PlaneType
    //{
    //    Boing,
    //    Airbus 
        
    //}
   public class Plane //on doit changer internel en public : 1 ére étape 
    {
        #region exemple;
        //private string name;

        ////public String Getname()
        ////{
        ////  return name;
        ////}

        ////public void Setname (String name)
        ////{
        ////  this.name = name;
        ////}
        //// light version
        //public string Name { get; set; } //par défaut int MyProperty en majuscule , la propriété encapsule l'attribut get et set 
        //                                 // + public
        //                                 // privé mais get et set public 

        //// another version
        ////Version full, séparer l'attribut des accesseurs 
        //// quand on a besoin de la version full ?? on peut modifier ou ajouter comportement, on a une condition , format bien déterminé
        //// ou password respecté format bien déterminé 
        //private int number;

        //public int Number 
        //{
        //    get { return number; }
        //    set { number = value; }
        //}

        //// ecriture 3 secure version 
        ////private set on peut pas modifier le set 
        //public int MyProperty { get; private set; }

        //// on travaille avec la version light !!!
        #endregion

       private int capacity;
       private  DateTime manufacturedate;
       private int planeid;
       private int PlaneType;

        public Plane()
        {
        }

        public Plane(int capacity, int planeId, DateTime manufactureDate)
        {
            Capacity = capacity;
            planeid = planeId;
            manufactureDate = manufacturedate;
        }
        public int Capacity { get; set; }

        public int Planeid { get; set; }

        public DateTime Manufacture { get; set; }
        public PlaneType PlaneTypes { get; set; }
        public IList<Flights> Flights { get; set; }
    }



}
