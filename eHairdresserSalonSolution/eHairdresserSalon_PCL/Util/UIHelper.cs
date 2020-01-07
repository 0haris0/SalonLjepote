using PCLCrypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHairdresserSalon_PCL.Util
{
    public class UIHelper
    {
        #region Klijenti
        public static string GenerateSalt()
        {
            var arr = WinRTCrypto.CryptographicBuffer.GenerateRandom(16);
            return Convert.ToBase64String(arr);
        }
        public static string GenerateHash(string lozinka, string salt)
        {
            byte[] byteLozinka = Encoding.Unicode.GetBytes(lozinka);
            byte[] byteSalt = Convert.FromBase64String(salt);
            byte[] forHashing = new byte[byteLozinka.Length + byteSalt.Length];

            System.Buffer.BlockCopy(byteLozinka, 0, forHashing, 0, byteLozinka.Length);
            System.Buffer.BlockCopy(byteSalt, 0, forHashing, byteLozinka.Length, byteSalt.Length);

            var alg = WinRTCrypto.HashAlgorithmProvider.OpenAlgorithm(HashAlgorithm.Sha1);
            byte[] inArray = alg.HashData(forHashing);
            return Convert.ToBase64String(inArray);
        }
        #endregion
    }
}
