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
        private StringBuilder Move(string direction)
        {
            StringBuilder move = new StringBuilder();
            move.Append(Model + ", ");
            move.Append(direction);
            return move;
        }
        public StringBuilder Start()
        {
            StringBuilder start = new StringBuilder();
            return start=Move("поїхали!");
        }
        public StringBuilder Stop()
        {
            StringBuilder stop = new StringBuilder();
            return stop=Move("зупиняємось.");
        }
        public StringBuilder TurnRight()
        {
            StringBuilder turnRight = new StringBuilder();
            return turnRight=Move("поворот направо.");
        }
        public StringBuilder TurnLeft()
        {
            StringBuilder turnLeft = new StringBuilder();
            return turnLeft=Move("поворот налiво.");
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
        public override string ToString()
        {
            return "Модель " + Model + "," +
                "\nКлас " + Class + "," +
                "\nВага " + Weight.ToString() + "," +
                "\nВодiй " + Driver.Name + ", " +
                "\nСтаж водiя " + Driver.DrivingExperience + " рокiв," +
                "\nПотужнiсть двигуна " + Engine.Power.ToString() + " к.с.," +
                "\nВиробник двигуна " + Engine.Manufacturer + ".";

        }
    }
}
