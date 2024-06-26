﻿
namespace UserRegisClass;

public class User
{
    public string Password { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }



    public User(string userN, string email, string password)
    {
        //if satser som kollar och går igenom alla klar som exempel att hotmail och gmail måste finnas samt att lösenordet får inte vara null och måste innehålla metoden passwordneedchar
        // på else så kommer det meddelandet om if satsen inte innehåller det som den behöver som exempel att  användar namnet måste vara mellan 5 och 20 tecken 
        if (email != null && email.EndsWith("@hotmail.com") || email != null && email.EndsWith("@gmail.com"))
        {
            if ( userN != null && userN.Length >= 5 && userN.Length <= 20)
            {
                if (password != null && password.Length >= 8 && passwordNeedChar(password))
                {
                    this.Password = password;
                    this.UserName = userN;
                    this.Email = email;
                }
                else 
                {
                    throw new ArgumentException("password must be over 8 Characters and need to have special Character");
                }
                
               
            }
            else
            {
                throw new ArgumentException("UserName need to be between 5 and 20 Characters");
            }
            
            
        } else throw new ArgumentException("your Email has to end with  @Hotmail or @Gmail ");
       
    
    
    }

    public bool passwordNeedChar(string password)
    { // metod för att få med specialtecken till lösenordet den gör att den retunerar true om den innehåller annars false 
        foreach (char c in password)
        {

            if (!char.IsLetterOrDigit(c)) return true;

        }
        return false;

    }
}
