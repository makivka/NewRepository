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
            return Move("поїхали!");
        }
        public StringBuilder Stop()
        {
            return Move("зупиняємось.");
        }
        public StringBuilder TurnRight()
        {
            return Move("поворот направо.");
        }
        public StringBuilder TurnLeft()
        {
            return Move("поворот налiво.");
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
