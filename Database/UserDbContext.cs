using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using UserManagementSystem.Entity.UserDb;

namespace UserManagementSystem.Database {

    /// <summary>
    /// Primary Database to store all user data
    /// </summary>
    public class UserDbContext(DbContextOptions<UserDbContext> options) : DbContext(options) {

        /// <summary>
        /// See <see cref="UserCredential"/>
        /// </summary>
        public virtual DbSet<UserCredential> UserCredentials {  get; set; }

        /// <summary>
        /// See <see cref="UserProfile"/>
        /// </summary>
        public virtual DbSet<UserProfile> UserProfiles { get; set; }
    }
}
