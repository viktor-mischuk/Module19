using Module19.DAL.Entities;


namespace Module19.DAL.Repositories
{
    public interface IFriendRepository
    {
        int Create(FriendEntity friendEntity);
        IEnumerable<FriendEntity> FindAllByUserId(int userId);
        int Delete(int id);
    }
}
