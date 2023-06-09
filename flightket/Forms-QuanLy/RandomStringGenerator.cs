using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flightket.Forms_QuanLy
{
    public class RandomStringGenerator
    {
        private static Random random = new Random();

        public static string GenerateRandomString()
        {
            const string letters = @"abcdefghijklmnopqrstuvwxyz1234657890ABCDEFGHIJKLMOPQRSTUVWXYZ";
            string randomString = new string(Enumerable.Repeat(letters, 5)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            return randomString;
        }
    }
}
