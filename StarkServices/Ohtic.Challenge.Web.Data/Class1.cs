using Microsoft.EntityFrameworkCore;
using Ohtic.Challenge.Web.Data.Entities;
using System;

namespace Ohtic.Challenge.Web.Data
{
    public class ChallengeContext : DbContext
    {

        public ChallengeContext(DbContextOptions<ChallengeContext> options) : base(options)
        { }

        public DbSet<UserEntity> Property1 { get; set; }
    }
}
