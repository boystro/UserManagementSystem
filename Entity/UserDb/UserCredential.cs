using System.ComponentModel.DataAnnotations;

namespace UserManagementSystem.Entity.UserDb {

    /// <summary>
    /// Stores the credentials of the user
    /// </summary>
    public class UserCredential {

        /// <summary>
        /// Username of the user.<br></br>
        /// Must be unique
        /// </summary>
        [Key]
        [Required]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Username should be between 4 and 20 characters")]
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// E mail of the user
        /// </summary>
        [Required]
        [EmailAddress(ErrorMessage = "The Email is not a valid email")]
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Password of the user, must be hashed
        /// </summary>
        [Required]
        public string Password { get; set; } = string.Empty;
        
        /// <summary>
        /// Keeps record if email is verified
        /// </summary>
        [Required]
        public bool IsEmailVerified { get; set; } = false;

        // ====================================================
        // FOREIGN REFERENCES

        /// <summary>
        /// See <see cref="UserDb.UserProfile"/>
        /// </summary>
        public UserProfile? UserProfile { get; set; } = null;
    }
}
