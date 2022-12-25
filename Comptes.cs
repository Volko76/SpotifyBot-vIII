using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyBot_vIII
{
    internal class Comptes
    {
        public Comptes(string comptesUser, string comptesPassword)
        {
            ComptesUser = comptesUser;
            ComptesPassword = comptesPassword;
        }

        public int ComptesId { get; set; }
        public string ComptesUser { get; set; }
        public string ComptesPassword { get; set; }
        public override string ToString()
        {
            return ComptesUser.ToString();
        }
    }
}
