using System.Text;

namespace Company
{
    class SportCar : Car
    {
        public double MaxSpeed { get; set; }
         public override string ToString()
        {
            return "Модель " + Model + "," +
                "\nКлас " + Class + "," +
                "\nВага " + Weight.ToString() + "," +
                "\nВодiй " + Driver.Name + ", " +
                "\nСтаж водiя " + Driver.DrivingExperience + " рокiв," +
                "\nПотужнiсть двигуна " + Engine.Power.ToString() + " к.с.," +
                "\nВиробник двигуна " + Engine.Manufacturer + "," +
                "\nМаксимальна швидкiсть " + MaxSpeed + " км/год.";

        }
    }
}
