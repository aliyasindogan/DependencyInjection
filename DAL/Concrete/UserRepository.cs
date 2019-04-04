using DAL.Abstract;
using ENTITIES;

namespace DAL.Concrete
{
    public class UserRepository : Repository<User, DatabaseContext>, IUserRepository
    {

    }
}
