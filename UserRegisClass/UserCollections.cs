

namespace UserRegisClass;
public class UserCollections
{
    // user collections som gör en lista av användarna och där ifrån kan se om användaren redan finns
    // annars lägger den till användaren via metoden useradding
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
