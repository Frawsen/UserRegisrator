using System.Runtime.Intrinsics.X86;
using UserRegisClass;

namespace UserRegisrator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIfUserNameistaken()
        {

            //test som testar att anv�ndarnamnet redan e tagen 
            //arrange 



            var user1 = new User("Fredrik", "fredrik@hotmail.com", "Fredrik123@");
            var user2 = new User("Fredrik", "fredrik@hotmail.com", "Fredrik123@");
            var UserCollections = new UserCollections();


            //act 

            UserCollections.UserAdding(user1);


            // assert

            Assert.ThrowsException<ArgumentException>(() => UserCollections.UserAdding(user2));


        }


        [TestMethod]
        public void testifNameisunder5andover20Character()
        {

            // test som testar att anv�ndarnamnet inneh�ller mellan 5 och 20 tecken 
            //arrange 


            //act  // assert  

            Assert.ThrowsException<ArgumentException>(() => new User("Fre", "fredrik@hotmail.com", "Fredrik123@"));
            Assert.ThrowsException<ArgumentException>(() => new User("Fredrikkkfkfkfkfkfkfkfkfkfkfkfkfkfkfkfkkfkffkfkfkfk", "fredrik@hotmail.com", "Fredrik123@"));

        }

        [TestMethod]
        public void TestifuserhaverightEmailForm()
        {

            // test som testar att det m�ste inneh�lla @hotmail eller gmail
            // det �r ifr�n if satsen d�r jag har gjort att email ska sluta antingen med hotmail.com  eller med gmail.com
            // arrenge //act 

            var user1 = new User("fredrik" , "fredrik@hotmail.com", "12345678@a");
            var exception = Assert.ThrowsException<ArgumentException>(() => new User("fredrik", "fredrtmail.com", "12345678@a"));

            //assert 

            Assert.AreEqual("fredrik@hotmail.com", user1.Email);
            Assert.AreEqual("your Email has to end with  @Hotmail or @Gmail ", exception.Message);
        }

        [TestMethod]
        public void testifMessageWhenSuccessfullWorking()
        {
            // testar och kollar om username added kommer fram och kollar om meddelandet som kommer motsvarar det som ska komma.
            var userCollections = new UserCollections();
            var user = new User("Fredrikooo", "fredrikoo@hotmail.com", "1222.5@@@67a");

            string success = userCollections.UserAdding(user);

            Assert.AreEqual($"userName added", success);

        }

        [TestMethod]
        public void TestIFPasswordHaveRightFormatting()
        {
            // test som testar att l�senordet inneh�ller minst 8 tecken och ett special tecken s� om det g�r det s� blir det r�tt annars gr�nt
            // d� testets� testet �r f�r visa l�senord som inte �r godk�nda och hitta dom det vill s�ga att du vill testa om den f�ngar upp ett felmeddelande om ditt l�senord inte �r inom kriterierna
            // arrenge

            var userCollections = new UserCollections();

            //act arrenge 

            var exception = Assert.ThrowsException<ArgumentException>(() => new User("fredrik ","fredrikoo@gmail.com", "aaaaaaaa."));

            Assert.AreEqual("password must be over 8 Characters and need to have special Character", exception.Message);


        }




    }
}