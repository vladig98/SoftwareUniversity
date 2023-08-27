using BashSoft.Exceptions;
using System;

namespace BashSoft.IO.Commands
{
    public abstract class Command
    {
        private string input;
        private string[] data;
        private Tester judge;
        private StudentsRepository repository;
        private IOManager inputOutputManager;

        public string Input
        {
            get
            {
                return input;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidStringException();
                }

                input = value;
            }
        }

        public string[] Data
        {
            get { return data; }

            private set 
            {
                if (value == null || value.Length == 0)
                {
                    throw new NullReferenceException();
                }

                data = value; 
            }
        }

        protected Tester Judge
        {
            get { return judge; }
        }

        protected StudentsRepository Repository
        {
            get { return repository; }
        }

        protected IOManager InputOutputManager
        {
            get { return inputOutputManager; }
        }

        public Command(string input, string[] data, Tester judge, StudentsRepository repository, IOManager inputOutputManager)
        {
            Input = input;
            Data = data;
            this.judge = judge;
            this.repository = repository;
            this.inputOutputManager = inputOutputManager;
        }

        public abstract void Execute();
    }
}
