using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagementSystem.Entity.UserDb {

    /// <summary>
    /// Other User Data like Name, Address etc. that are not related to
    /// User Authentication and Authorizaiton.
    /// </summary>
    public class UserProfile {

        /// <summary>
        /// Unique Identifier
        /// </summary>
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// First name of user
        /// </summary>
        [Required]
        [StringLength(30, ErrorMessage = "First name should not exceed 30 characters.")]
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Middle name of user (optional)
        /// </summary>
        [StringLength(30, ErrorMessage = "Middle name should not exceed 30 characters")]
        public string MiddleName { get; set; } = string.Empty;

        /// <summary>
        /// Last name of user
        /// </summary>
        [Required]
        [StringLength(30, ErrorMessage = "Last name should not exceed 30 characters")]
        public string LastName {  get; set; } = string.Empty;

        /// <summary>
        /// Gender of user, this is true if male.
        /// </summary>
        [Required]
        public bool IsMale { get; set; } = true;

        /// <summary>
        /// Address Line 1
        /// </summary>
        [Required]
        [StringLength(100, ErrorMessage = "Address Line 1 should not exceed 100 characters")]
        public string AddressLine1 {  get; set; } = string.Empty;

        /// <summary>
        /// Address Line 2
        /// </summary>
        [StringLength(100, ErrorMessage = "Address Line 2 should not exceed 100 characters")]
        public string AddressLine2 {  get; set; } = string.Empty;

        /// <summary>
        /// Address Line 3
        /// </summary>
        [StringLength(100, ErrorMessage = "Address Line 3 should not exceed 100 characters")]
        public string AddressLine3 { get; set; } = string.Empty;

        // ====================================================
        // FOREIGN REFERENCES

        /// <summary>
        /// See <see cref="UserDb.UserCredential"/>
        /// </summary>
        [ForeignKey("IdUserCredential")]
        [Required]
        public UserCredential UserCredential { get; set; } = null!;
    }
}
