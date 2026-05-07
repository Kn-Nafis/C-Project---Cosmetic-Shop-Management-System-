namespace Cosmatic_Shop_Management.Helpers
{
    public static class SessionManager
    {
        public static int UserId { get; set; }
        public static string FullName { get; set; }
        public static string Email { get; set; }
        public static string RoleName { get; set; }

        public static void Clear()
        {
            UserId = 0;
            FullName = null;
            Email = null;
            RoleName = null;
        }
    }
}