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
            Model user1 = new Model { userID = "DNTE-DRNT", pass = "Durante" };
            Model user2 = new Model { userID = "VRGL-CHRN", pass = "RedGaze" };
            Model user3 = new Model { userID = "OTIS-ODYS", pass = "Odyssey" };

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
