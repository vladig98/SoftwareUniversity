using Pizzeria.App.Core.Dtos;

namespace Pizzeria.App.Core.Contracts
{
    public interface IManagerController
    {
        void SetManager(int employeeId, int managerId);
        ManagerDto GetManagerInfo(int employeeId);
    }
}
