using Module19.DAL.Entities;


namespace Module19.DAL.Repositories
{
    public interface IUserRepository
    {
        int Create(UserEntity userEntity);
        UserEntity FindByEmail(string email);
        IEnumerable<UserEntity> FindAll();
        UserEntity FindById(int id);
        int Update(UserEntity userEntity);
        int DeleteById(int id);
    }
}
