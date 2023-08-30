namespace InfernoInfinityBonus.Core.Commands
{
    public abstract class Command
    {
        private string[] data;

        protected string[] Data
        {
            get { return data; }
            private set { data = value; }
        }

        public Command(string[] data)
        {
            Data = data;
        }

        public abstract void Execute();
    }
}
