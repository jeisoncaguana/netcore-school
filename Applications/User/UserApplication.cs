namespace netcore_school.Applications.User
{
    public class UserApplication
    {
         

        public async Task<(bool exito, object data)> FindUsersAsync()
        {
            try
            {
                var data = new List<object>
                {
                    new { Id = 1, Name = "Jieson", lastName = "Caguana" },
                    new { Id = 2, Name = "John", lastName = "Doe" },
                    new { Id = 3, Name = "Jane", lastName = "Smith" },
                    new { Id = 4, Name = "Alice", lastName = "Johnson" }
                };

                return  (true, data);
            }
            catch
            {
                return (false, null);
            }
        }
    }
}
