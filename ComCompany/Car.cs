using System.Text;

namespace Company
{
    class Car
    {
        public string Model { get; set; }
        public string Class { get; set; }
        public double Weight { get; set; }
        public Driver Driver { get; set; }
        public Engine Engine { get; set; }
        public StringBuilder Start()
        {
            StringBuilder start = new StringBuilder();
            start.Append(Model + ", ");
            start.Append("поїхали!");
            return start;
        }
        public StringBuilder Stop()
        {
            StringBuilder stop = new StringBuilder();
            stop.Append(Model + ", ");
            stop.Append("зупиняємось.");
            return stop;
        }
        public StringBuilder TurnRight()
        {
            StringBuilder turnRight = new StringBuilder();
            turnRight.Append(Model + ", ");
            turnRight.Append("поворот направо.");
            return turnRight;
        }
        public StringBuilder TurnLeft()
        {
            StringBuilder turnLeft = new StringBuilder();
            turnLeft.Append(Model + ", ");
            turnLeft.Append("поворот налiво.");
            return turnLeft;
        }
        public virtual StringBuilder CarInformationToString()
        {
            StringBuilder carInformation = new StringBuilder();
            carInformation.Append("Модель " + Model + ",");
            carInformation.Append("\nКлас " + Class + ",");
            carInformation.Append("\nВага " + Weight.ToString() + ",");
            carInformation.Append("\nВодiй " + Driver.Name + ", ");
            carInformation.Append("\nСтаж водiя " + Driver.DrivingExperience + " рокiв,");
            carInformation.Append("\nПотужнiсть двигуна " + Engine.Power.ToString() + " к.с.,");
            carInformation.Append("\nВиробник двигуна " + Engine.Manufacturer + ".");
            return carInformation;
        }
    }
}
