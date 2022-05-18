namespace HouseRentalManagement
{
    public class UserDatabase
    {
        public static List<Users> GetUsers()
        {
        List<Users> userList = new List<Users>()
            {
                new Users(){UserID=1, UserName="John Doe", UserEmail="John123@gmail.com",Password="12345",City="Kolkata"},
                new Users(){UserID=2, UserName="Atif Hussain", UserEmail="Atif123@gmail.com",Password="54321",City="Patna"},
                new Users(){UserID=3, UserName="Nawaz", UserEmail="Nawaz123@gmail.com",Password="1234",City="Mumbai"},
                new Users(){UserID=4, UserName="Aryan", UserEmail="Aryan123@gmail.com",Password="123",City="Hyderabad"},
                new Users(){UserID=5, UserName="Anshuman", UserEmail="Anshuman123@gmail.com",Password="qwert",City="Chennai"},
                new Users(){UserID=6, UserName="Kartik", UserEmail="Kartik123@gmail.com",Password="abcde",City="Jaipur"}
            };
            return userList;
        }
    }
}
