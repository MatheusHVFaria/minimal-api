using MinimalAPI.Dominio.Entidades;
using MinimalAPI.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTest.Mocks
{
    public class VeiculoServicoMock : IVeiculoServico
    {
        private static List<Veiculo> veiculos = new List<Veiculo>
        {
            new Veiculo
            {
                Id = 1,
                Nome = "Ford Ka",
                Marca = "Ford",
                Ano = 2020,
            },
            new Veiculo
            {
                Id = 2,
                Nome = "Nissan GT",
                Marca = "Nissan",
                Ano = 2015,
            }
        };

        public void Apagar(Veiculo veiculo)
        {
            if (veiculos.Contains(veiculo))
            {
                veiculos.Remove(veiculo);
            }
        }

        public void Atualizar(Veiculo veiculo)
        {
            if (veiculos.Contains(veiculo))
            {
                for (int i = 0; i < veiculos.Count; i++)
                {
                    Veiculo vei = veiculos[i];
                    if (vei.Id == veiculo.Id && vei.Nome == veiculo.Nome)
                    {
                        vei = veiculo;
                    }
                }
            }
        }

        public Veiculo? BuscaPorID(int id)
        {
            return veiculos.Find(v => v.Id == id);
        }

        public void Incluir(Veiculo veiculo)
        {
            veiculo.Id = veiculos.Count() + 1;
            veiculos.Add(veiculo);
        }

        public List<Veiculo> Todos(int? pagina = 1, string? nome = null, string? marca = null)
        {
            return veiculos;
        }
    }
}
