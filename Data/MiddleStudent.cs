namespace OSeminar7
{
    class MiddleStudent : Student, ILearn, ISmoke
    {
        public MiddleStudent()
        {
        }

        public override void getAllMethods()
        {
            learn();
            walkLesson();
            smoke();
        }

        public void learn() => Console.WriteLine("Я ненавижу учиться");

        private void walkLesson() => Console.WriteLine("Я прогулял урок");

        public void smoke() => Console.WriteLine("Я начал курить");
    }
}