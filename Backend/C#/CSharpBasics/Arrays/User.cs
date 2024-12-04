namespace Arrays
{
    internal class User
    {
        #region Properties
        public string Username { get; set; }
        public string Password { get; set; }

        public string[,] usersCredentials = new string[3, 2]
        {
            { "admin", "admin"},
            {"admin1", "pass1" },
            {"a", "p" }
        };
        #endregion

        #region Methods
        public string CheckLogin(User user)
        {

            string username = user.Username;
            string password = user.Password;
            string result = string.Empty;

            Console.Write("Username: ");
            user.Username = Console.ReadLine();
            Console.Write("Password: ");
            user.Password = Console.ReadLine();

            int height = user.usersCredentials.GetLength(0);
            int width = user.usersCredentials.GetLength(1);

            for (int i = 0; i < height; i++)
            {

                for (int j = 0; j < width; j++)
                {
                    //  Console.WriteLine($":{i},{j} {usersCredentials[i, j]}");
                    if (usersCredentials[i, j].Contains(user.Username) && usersCredentials[j + 1, i].Contains(user.Password))
                    {
                        return result = $"Welcome {user.Username}!";
                    }
                    else
                    {
                        result = "Invalid username or password!";
                    }
                }
                // }
            }
            return result;
        }
        #endregion
    }
}
