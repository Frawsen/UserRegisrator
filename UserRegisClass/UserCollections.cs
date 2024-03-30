

namespace UserRegisClass;
public class UserCollections
{

    List<User> users = new List<User>();

    public string UserAdding(User user)
    {
        if (users.Exists(f => f.UserName == user.UserName))
        {
           
            throw  new ArgumentException("Username already exsist");

        }
        else  users.Add(user);
        return "userName added";
            
        

    }
   

}
