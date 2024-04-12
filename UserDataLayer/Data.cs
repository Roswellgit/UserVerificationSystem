using UserModel;

namespace UserDataLayer
{
    public class Data
    {
        List<Model> dummyUser = new List<Model>();

        public Data()
        {
            CreateDummyData();
        }
        private void CreateDummyData()
        {
            Model user1 = new Model { userID = "DNTE-1337", pass = "Durante" };
            Model user2 = new Model { userID = "DNQX-SUEN", pass = "SuenoImposible" };
            Model user3 = new Model { userID = "OTIS-4532", pass = "Odyssey" };

            dummyUser.Add(user1);
            dummyUser.Add(user2);   
            dummyUser.Add(user3);


        }
        public Model GetDummyData(string userID, string pass)
        {
            Model foundUser = new Model();

            foreach(var dummy in dummyUser)
            {
                if(userID == dummy.userID && pass == dummy.pass)
                {
                    foundUser = dummy;
                }
                
            }
            return foundUser;
        }

        
    }
}
