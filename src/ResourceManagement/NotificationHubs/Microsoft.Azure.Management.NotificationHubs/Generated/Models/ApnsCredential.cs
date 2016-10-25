// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.NotificationHubs.Models
{
    using System.Linq;

    /// <summary>
    /// Description of a NotificationHub ApnsCredential.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ApnsCredential
    {
        /// <summary>
        /// Initializes a new instance of the ApnsCredential class.
        /// </summary>
        public ApnsCredential() { }

        /// <summary>
        /// Initializes a new instance of the ApnsCredential class.
        /// </summary>
        /// <param name="apnsCertificate">The APNS certificate.</param>
        /// <param name="certificateKey">The certificate key.</param>
        /// <param name="endpoint">The endpoint of this credential.</param>
        /// <param name="thumbprint">The Apns certificate Thumbprint</param>
        public ApnsCredential(string apnsCertificate = default(string), string certificateKey = default(string), string endpoint = default(string), string thumbprint = default(string))
        {
            ApnsCertificate = apnsCertificate;
            CertificateKey = certificateKey;
            Endpoint = endpoint;
            Thumbprint = thumbprint;
        }

        /// <summary>
        /// Gets or sets the APNS certificate.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.apnsCertificate")]
        public string ApnsCertificate { get; set; }

        /// <summary>
        /// Gets or sets the certificate key.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.certificateKey")]
        public string CertificateKey { get; set; }

        /// <summary>
        /// Gets or sets the endpoint of this credential.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.endpoint")]
        public string Endpoint { get; set; }

        /// <summary>
        /// Gets or sets the Apns certificate Thumbprint
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.thumbprint")]
        public string Thumbprint { get; set; }

    }
}