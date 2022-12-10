namespace OSeminar7
{
    class HighStudent : Student, ILearn, ISmoke
    {
        public override void getAllMethods()
        {
            learn();
            prepare();
            smoke();
            meeting();
        }

        public void learn() => Console.WriteLine("Я должен учиться");

        public void smoke() => Console.WriteLine("Я бросаю курить");

        private void meeting() => Console.WriteLine("У меня есть друг (подруга)");

        private void prepare() => Console.WriteLine("Я готовлюсь к экзаменам");
    }
}