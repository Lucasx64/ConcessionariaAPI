using ConcessionariaAPI.Models;
namespace ConcessionariaAPI.Interfaces
{
    public interface IVeiculoRepository
    {
        List<Veiculo> ListarTodos();

        Veiculo? BuscarPorId(int id);

        void Cadastrar(Veiculo veiculo);
    }
}
