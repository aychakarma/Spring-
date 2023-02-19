// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using Microsoft.VisualBasic;

Console.WriteLine("Hello, World!");



//constructeur par defaut 
Console.WriteLine("Hello, World!");
Plane plane1 = new Plane();
plane1.Capacity = 1;
plane1.Planeid = 1;
plane1.PlaneTypes = PlaneType.Boing;
plane1.Manufacture = DateTime.Now;
Plane plane2 = new Plane(1, 2, new DateTime(1999 - 12 - 2));
//initialiseur d'objet 
Plane plane3 = new Plane
{
    Capacity = 2,
    Manufacture = new DateTime(),
    Planeid = 5,
    PlaneTypes = PlaneType.Boing
};

Passenger p = new Passenger
{
    BirthDate = new DateTime(1999-12-3),
    EmailAddress= "karma" ,
    FirstName="chadha", LastName="kanzari"
};
Traveller T = new Traveller
{
    FirstName = "karma"
};
Staff S = new Staff
{
    LastName ="karma"
};
Console.WriteLine(p.CheckProfile("test","testc"));
p.PassengerType();
T.PassengerType();
S.PassengerType();