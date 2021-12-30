using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtic.Challenge.Web.Data.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string HashedPassword { get; set; }

        public string LastIssuedToken { get; set; }

        public string Email { get; set; }

        public DateTime LastIssuedTokenAt { get; set; }


    }
}
