namespace Game4u.Services
{
    public interface IGamesService
    {
        IEnumerable<Game> GetAll();
        Game? GetById(int id);
        Task Create(CreateGameFromViewModel model);
        Task<Game?> Update(EditGameFormViewModel model);
        bool Delete(int id);
    }
}
