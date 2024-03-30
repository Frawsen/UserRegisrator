using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace UserRegisClass;

public class User
{
    public string Password { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }



    public User(string userN, string email, string password)
    {

        if (email != null && email.EndsWith("@hotmail.com") || email != null && email.EndsWith("@gmail.com"))
        {
            if ( userN != null && userN.Length >= 5 && userN.Length <= 20)
            {
                if (password != null && password.Length >= 8 && passwordNeedChar(password))
                {

                }
                else throw new ArgumentException("password must be over 8 Characters and need to have special Character");
            }
            else
            {
                throw new ArgumentException("UserName need to be between 5 and 20 Characters");
            }
            
        }
         
             


    
    
    }

    public bool passwordNeedChar(string password)
    {
        foreach (char c in password)
        {

            if (!char.IsLetterOrDigit(c)) return true;

        }
        return false;

    }
}
