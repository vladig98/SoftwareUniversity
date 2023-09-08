using Pizzeria.App.Core.Contracts;
using System;
using System.Globalization;

namespace Pizzeria.App.Core.Commands
{
    public class SetBirthdayCommand : ICommand
    {
        private readonly IEmployeeController controller;

        public SetBirthdayCommand(IEmployeeController controller)
        {
            this.controller = controller;
        }

        public string Execute(string[] args)
        {
            int id = int.Parse(args[0]);
            DateTime date = DateTime.ParseExact(args[1], "dd-MM-yyyy", CultureInfo.InvariantCulture);

            controller.SetBirthday(id, date);

            return "Command accomplished successfully";
        }
    }
}
