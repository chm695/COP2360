using System;

namespace MyDreamCar
{
    class Car
    {
        //Classification of data types
        string color;
        string make;
        int year;
        string model;

        //Creation of objects pertaining to different car classes
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.model = "XSE";
            car1.color = "Red";
            car1.year = 2020;
            car1.make = "Camry";

            Car car2 = new Car();
            car2.model = "Chevy";
            car2.color = "Black";
            car2.year = 1995;
            car2.make = "Impala";

            Console.WriteLine(car1.model);
            Console.WriteLine(car2.make);


        }
    }

}
