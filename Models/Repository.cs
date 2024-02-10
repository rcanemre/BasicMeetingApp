namespace BasicMeetingApp.Models
{
    public static class Repository
    {
        private static List<Userinfo> _users = new();

        static Repository()
        {
            _users.Add(new Userinfo() { Name = "emre", Email = "emre@info.com", Phone = "232334234", WillAttend = true });
        }

        public static List<Userinfo> Users { get {  return _users; } }

        public static void CreateUser(Userinfo user)
        {
            _users.Add(user);
        }
    }
}
