namespace BasicMeetingApp.Models
{
    public static class Repository
    {
        private static List<Userinfo> _users = new();

        static Repository()
        {
            _users.Add(new Userinfo() { Id = 1, Name = "emre", Email = "emre@info.com", Phone = "232334234", WillAttend = true });
            _users.Add(new Userinfo() { Id = 2, Name = "ahmet", Email = "ahmet@info.com", Phone = "1232315", WillAttend = false });
        }

        public static List<Userinfo> Users { get {  return _users; } }

        public static void CreateUser(Userinfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }

        public static Userinfo? GetById(int id)
        {
            return _users.FirstOrDefault(user  => user.Id == id);
        }
    }
}
