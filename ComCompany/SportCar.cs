using System.Text;

namespace Company
{
    class SportCar : Car
    {
        public double MaxSpeed { get; set; }
        public override StringBuilder CarInformationToString()
        {
            StringBuilder carInformation = new StringBuilder();
            carInformation.Append("Модель " + Model + ",");
            carInformation.Append("\nКлас " + Class + ",");
            carInformation.Append("\nВага " + Weight.ToString() + " кг,");
            carInformation.Append("\nВодiй " + Driver.Name + ", ");
            carInformation.Append("\nСтаж водiя " + Driver.DrivingExperience + " рокiв,");
            carInformation.Append("\nПотужнiсть двигуна " + Engine.Power.ToString() + " к.с.,");
            carInformation.Append("\nВиробник двигуна " + Engine.Manufacturer + ", ");
            carInformation.Append("\nМаксимальна швидкiсть " + MaxSpeed + " км/год.");
            return carInformation;
        }
    }
}
