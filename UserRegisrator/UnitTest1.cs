using UserRegisClass;

namespace UserRegisrator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIfUserNameistaken()
        {
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
            //arrange 

       




            //act  // assert  

            Assert.ThrowsException<ArgumentException>(() => new User("Fre", "fredrik@hotmail.com", "Fredrik123@"));
            Assert.ThrowsException<ArgumentException>(() => new User("Fredrikkkfkfkfkfkfkfkfkfkfkfkfkfkfkfkfkkfkffkfkfkfk", "fredrik@hotmail.com", "Fredrik123@"));

        }
    }
}