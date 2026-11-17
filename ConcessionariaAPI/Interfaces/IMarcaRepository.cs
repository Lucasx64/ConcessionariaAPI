using ConcessionariaAPI.Models;

namespace ConcessionariaAPI.Interfaces
{
    public interface IMarcaRepository
    {
        List<Marca> ListarTodos();

        // R - Read: busca um curso pelo Id (ou null se não achar).
        Marca? BuscarPorId(int id);

        // C - Create: cadastra um curso novo.
        void Cadastrar(Marca marca);

    }
}
