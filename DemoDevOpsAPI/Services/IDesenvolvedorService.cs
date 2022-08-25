using DemoDevOpsAPI.Models;

namespace DemoDevOpsAPI.Services
{
    public interface IDesenvolvedorService
    {
        IEnumerable<Desenvolvedor> GetAllItems();
        Desenvolvedor Add(Desenvolvedor novoItem);
        Desenvolvedor GetById(int id);
        void Remove(int id);
    }
}
