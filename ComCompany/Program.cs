using System;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver manoliiDriver = new Driver("Манолiй", 6);
            Driver janineDriver = new Driver("Яна", 1);
            Engine tigershark_2_4 = new Engine
            {
                Power = 186,
                Manufacturer = "Chrysler"
            };
            Engine mzr_2_0 = new Engine
            {
                Power = 147,
                Manufacturer = "Mazda"
            };
            Engine diesel_2_0 = new Engine
            {
                Power = 140,
                Manufacturer = "MAN"
            };
            Engine gasoline_1_5 = new Engine
            {
                Power = 150,
                Manufacturer = "JAC"
            };
            Car jeepRenegade = new Car
            {
                Model = "Джип",
                Class = "4х4",
                Weight = 1400,
                Driver = manoliiDriver,
                Engine = tigershark_2_4
            };
            Car mazda6 = new Car
            {
                Model = "Мазда 6",
                Class = "Клас D",
                Weight = 1600,
                Driver = janineDriver,
                Engine = mzr_2_0
            };
            Lorry man_tge_3_140 = new Lorry
            {
                Model = "MAN TGE 3.140",
                Class = "Фургон",
                Weight = 3500,
                Driver = manoliiDriver,
                Engine = diesel_2_0,
                CarryingCapacity = 1411
            };
            SportCar jac_j7 = new SportCar
            {
                Model = "JAC J7",
                Class = "Лiфтбек D-класу",
                Weight = 1500,
                Driver = janineDriver,
                Engine = gasoline_1_5,
                MaxSpeed = 170
            };

            Console.WriteLine(jeepRenegade.Start());
            Console.WriteLine(jeepRenegade.TurnRight());
            Console.WriteLine(jeepRenegade.Stop());
            Console.WriteLine(jeepRenegade.TurnLeft());
            Console.WriteLine(jeepRenegade.CarInformationToString());
            Console.WriteLine(mazda6.Start());
            Console.WriteLine(mazda6.TurnLeft());
            Console.WriteLine(mazda6.TurnRight());
            Console.WriteLine(mazda6.Stop());
            Console.WriteLine(mazda6.CarInformationToString());
            Console.WriteLine(man_tge_3_140.Start());
            Console.WriteLine(man_tge_3_140.TurnRight());
            Console.WriteLine(man_tge_3_140.Stop());
            Console.WriteLine(man_tge_3_140.Start());
            Console.WriteLine(man_tge_3_140.TurnLeft());
            Console.WriteLine(man_tge_3_140.Stop());
            Console.WriteLine(man_tge_3_140.CarInformationToString());
            Console.WriteLine(jac_j7.Start());
            Console.WriteLine(jac_j7.TurnLeft());
            Console.WriteLine(jac_j7.TurnRight());
            Console.WriteLine(jac_j7.Stop());
            Console.WriteLine(jac_j7.CarInformationToString());

        }
    }
}
