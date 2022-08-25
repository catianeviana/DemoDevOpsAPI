using DemoDevOpsAPI.Models;
using DemoDevOpsAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDevOpsAPI.Tests
{
    internal class DesenvolvedorServiceFake : IDesenvolvedorService
    {
        private readonly List<Desenvolvedor> _desenvolvedor;

        public DesenvolvedorServiceFake()
        {
            _desenvolvedor = new List<Desenvolvedor>()
            {
                new Desenvolvedor() { Id = 1, Nome = "Maria",
                                   Nivel ="Estagiário", Salario = 765.00M },
                new Desenvolvedor() { Id = 2, Nome = "Jose",
                                   Nivel ="Junior", Salario = 644.00M },
                new Desenvolvedor() { Id = 3, Nome = "Pedro",
                                   Nivel ="Pleno", Salario = 987.00M },
                new Desenvolvedor() { Id = 4, Nome = "Marcos",
                                   Nivel ="Senior", Salario = 879.00M },
                new Desenvolvedor() { Id = 5, Nome = "Lucas",
                                   Nivel ="Master", Salario = 612.00M }
            };
        }
        public IEnumerable<Desenvolvedor> GetAllItems()
        {
            return _desenvolvedor;
        }
        public Desenvolvedor Add(Desenvolvedor novoItem)
        {
            novoItem.Id = GeraId();
            _desenvolvedor.Add(novoItem);
            return novoItem;
        }
        public Desenvolvedor GetById(int id)
        {
            return _desenvolvedor.Where(a => a.Id == id)
                .FirstOrDefault();
        }
        public void Remove(int id)
        {
            var item = _desenvolvedor.First(a => a.Id == id);
            _desenvolvedor.Remove(item);
        }
        static int GeraId()
        {
            Random random = new Random();
            return random.Next(1, 100);
        }
    }
}
