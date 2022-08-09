using System.Text;

namespace Company
{
    class Lorry : Car
    {
        public double CarryingCapacity { get; set; }
        public override string ToString()
        {
            return "Модель " + Model + "," +
                "\nКлас " + Class + "," +
                "\nВага " + Weight.ToString() + "," +
                "\nВодiй " + Driver.Name + ", " +
                "\nСтаж водiя " + Driver.DrivingExperience + " рокiв," +
                "\nПотужнiсть двигуна " + Engine.Power.ToString() + " к.с.," +
                "\nВиробник двигуна " + Engine.Manufacturer + ","+
                "\nВантажопiдйомнiсть " + CarryingCapacity + " кг.";

        }
    }
}
