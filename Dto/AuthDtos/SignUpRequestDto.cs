using System.ComponentModel.DataAnnotations;

namespace UserManagementSystem.Dto.AuthDtos {

    /// <summary>
    /// DTO for <see cref="Controllers.AuthController.SignUp"/>
    /// </summary>
    public class SignUpRequestDto {

        /// <summary>
        /// Username of the user.<br></br>
        /// Must be unique
        /// </summary>
        [Key]
        [Required]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Username should be between 4 and 20 characters")]
        public string Username { get; set; } = null!;

        /// <summary>
        /// Password of the user, must be hashed
        /// </summary>
        [Required]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Length of Password must be between 6 and 100 characters")]
        public string Password { get; set; } = null!;

        /// <summary>
        /// E mail of the user
        /// </summary>
        [Required]
        [EmailAddress(ErrorMessage = "The Email is not a valid email")]
        public string Email {  get; set; } = null!;

        /// <summary>
        /// First name of user
        /// </summary>
        [Required]
        [StringLength(30, ErrorMessage = "First name should not exceed 30 characters.")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Middle name of user (optional)
        /// </summary>
        [StringLength(30, ErrorMessage = "Middle name should not exceed 30 characters")]
        public string? MiddleName {  get; set; }

        /// <summary>
        /// Last name of user
        /// </summary>
        [Required]
        [StringLength(30, ErrorMessage = "Last name should not exceed 30 characters")]
        public string? LastName {  get; set; }

        /// <summary>
        /// Gender of user, this is true if male.
        /// </summary>
        [Required]
        public bool IsMale { get; set; }

        /// <summary>
        /// Address Line 1
        /// </summary>
        [StringLength(100, ErrorMessage = "Address Line 1 should not exceed 100 characters")]
        public string? AddressLine1 {  get; set; }
        /// <summary>
        /// Address Line 2
        /// </summary>
        [StringLength(100, ErrorMessage = "Address Line 2 should not exceed 100 characters")]
        public string? AddressLine2 {  get; set; }

        /// <summary>
        /// Address Line 3
        /// </summary>
        [StringLength(100, ErrorMessage = "Address Line 3 should not exceed 100 characters")]
        public string? AddressLine3 {  get; set; }
    }
}
