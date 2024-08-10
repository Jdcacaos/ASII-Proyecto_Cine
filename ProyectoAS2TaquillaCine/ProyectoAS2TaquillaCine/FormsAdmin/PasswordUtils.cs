using System;
using Konscious.Security.Cryptography;
using System.Text;

public class PasswordUtils
{
    public static string HashPassword(string password)
    {
        using (var hasher = new Argon2id(Encoding.UTF8.GetBytes(password)))
        {
            hasher.Salt = GenerateRandomSalt();
            hasher.DegreeOfParallelism = 8;
            hasher.MemorySize = 65536;
            hasher.Iterations = 4;

            byte[] hash = hasher.GetBytes(32);
            return Convert.ToBase64String(hash);
        }
    }

    public static bool VerifyPassword(string password, string hashedPassword)
    {
        byte[] salt = GetStoredSalt(); // Implementa la lógica para obtener el salt

        using (var hasher = new Argon2id(Encoding.UTF8.GetBytes(password)))
        {
            hasher.Salt = salt;
            hasher.DegreeOfParallelism = 8;
            hasher.MemorySize = 65536;
            hasher.Iterations = 4;

            byte[] hash = hasher.GetBytes(32);
            string hashString = Convert.ToBase64String(hash);
            return hashString == hashedPassword;
        }
    }

    private static byte[] GenerateRandomSalt()
    {
        using (var rng = new System.Security.Cryptography.RNGCryptoServiceProvider())
        {
            byte[] salt = new byte[16];
            rng.GetBytes(salt);
            return salt;
        }
    }

    private static byte[] GetStoredSalt()
    {
        // Implementa la lógica para obtener el salt almacenado
        throw new NotImplementedException();
    }
}
