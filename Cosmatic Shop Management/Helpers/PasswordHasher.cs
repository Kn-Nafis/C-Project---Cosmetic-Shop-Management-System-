using System;
using System.Security.Cryptography;

namespace Cosmatic_Shop_Management.Helpers
{
    public static class PasswordHasher
    {
        private const int Iterations = 100000;
        private const int SaltSize = 32;
        private const int HashSize = 32;

        public static void CreatePasswordHash(string password, out string passwordHash, out string passwordSalt)
        {
            byte[] saltBytes = new byte[SaltSize];

            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, Iterations, HashAlgorithmName.SHA256))
            {
                byte[] hashBytes = pbkdf2.GetBytes(HashSize);

                passwordHash = Convert.ToBase64String(hashBytes);
                passwordSalt = Convert.ToBase64String(saltBytes);
            }
        }

        public static bool VerifyPassword(string enteredPassword, string storedHash, string storedSalt)
        {
            byte[] saltBytes = Convert.FromBase64String(storedSalt);

            using (var pbkdf2 = new Rfc2898DeriveBytes(enteredPassword, saltBytes, Iterations, HashAlgorithmName.SHA256))
            {
                byte[] enteredHashBytes = pbkdf2.GetBytes(HashSize);
                string enteredHash = Convert.ToBase64String(enteredHashBytes);

                return enteredHash == storedHash;
            }
        }
    }
}