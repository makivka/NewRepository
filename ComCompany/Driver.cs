namespace Company
{
    class Driver : Person
    {
        //public string Name { get; set; }
        public int DrivingExperience { get; set; }
        public Driver(string name, int expirience) : base(name)
        {
            DrivingExperience = expirience;
        }
    }
}
