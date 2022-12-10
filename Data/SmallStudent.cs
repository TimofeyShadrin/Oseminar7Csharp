namespace OSeminar7
{
    class SmallStudent : Student, ILearn
    {
        public SmallStudent()
        {
        }

        public override void getAllMethods()
        {
            learn();
            cry();
        }

        public void learn() => Console.WriteLine("Я люблю учиться");

        private void cry() => Console.WriteLine("Я хочу к маме");
    }
}