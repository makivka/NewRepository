using System.Text;

namespace Company
{
    class Lorry : Car
    {
        public double CarryingCapacity { get; set; }
        public override StringBuilder CarInformationToString()
        {
            StringBuilder carInformation = new StringBuilder();
            carInformation.Append("Модель " + CarModel + ",");
            carInformation.Append("\nКлас " + CarClass + ",");
            carInformation.Append("\nВага " + Weight.ToString() + " кг,");
            carInformation.Append("\nВодiй " + Driver.Name + ", ");
            carInformation.Append("\nСтаж водiя " + Driver.DrivingExperience + " рокiв,");
            carInformation.Append("\nПотужнiсть двигуна " + Engine.Power.ToString() + " к.с.,");
            carInformation.Append("\nВиробник двигуна " + Engine.Manufacturer + ", ");
            carInformation.Append("\nВантажопiдйомнiсть " + CarryingCapacity + " кг.");
            return carInformation;
        }
    }
}
