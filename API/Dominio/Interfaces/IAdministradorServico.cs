using minimal_api.Dominio.DTOs;
using MinimalAPI.Dominio.Entidades;
using MinimalAPI.DTOS;

namespace MinimalAPI.Dominio.Interfaces
{
    public interface IAdministradorServico
    {
        Administrador Login(LoginDTO loginDTO);
        Administrador Incluir(Administrador administrador);
        List<Administrador> Todos(int? pagina);
        Administrador? BuscaPorID(int id);
    }
}