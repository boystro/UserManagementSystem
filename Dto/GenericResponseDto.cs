using System.Net;

namespace UserManagementSystem.Dto {

    /// <summary>
    /// Class representing a generic API Response
    /// </summary>
    public class GenericResponseDto<T> {

        /// <summary>
        /// Status code of response
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// Additional Information in text.
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Additional Data
        /// </summary>
        public T? Data { get; set; }

    }
}
