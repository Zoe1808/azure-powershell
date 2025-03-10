// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// Xero Service linked service properties.
    /// </summary>
    public partial class XeroLinkedServiceTypeProperties
    {
        /// <summary>
        /// Initializes a new instance of the XeroLinkedServiceTypeProperties class.
        /// </summary>
        public XeroLinkedServiceTypeProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the XeroLinkedServiceTypeProperties class.
        /// </summary>

        /// <param name="connectionProperties">Properties used to connect to Xero. It is mutually exclusive with any other
        /// properties in the linked service. Type: object.
        /// </param>

        /// <param name="host">The endpoint of the Xero server. (i.e. api.xero.com)
        /// </param>

        /// <param name="consumerKey">The consumer key associated with the Xero application.
        /// </param>

        /// <param name="privateKey">The private key from the .pem file that was generated for your Xero private
        /// application. You must include all the text from the .pem file, including
        /// the Unix line endings(
        /// ).
        /// </param>

        /// <param name="useEncryptedEndpoints">Specifies whether the data source endpoints are encrypted using HTTPS. The
        /// default value is true.
        /// </param>

        /// <param name="useHostVerification">Specifies whether to require the host name in the server&#39;s certificate to
        /// match the host name of the server when connecting over SSL. The default
        /// value is true.
        /// </param>

        /// <param name="usePeerVerification">Specifies whether to verify the identity of the server when connecting over
        /// SSL. The default value is true.
        /// </param>

        /// <param name="encryptedCredential">The encrypted credential used for authentication. Credentials are encrypted
        /// using the integration runtime credential manager. Type: string.
        /// </param>
        public XeroLinkedServiceTypeProperties(object connectionProperties = default(object), object host = default(object), SecretBase consumerKey = default(SecretBase), SecretBase privateKey = default(SecretBase), object useEncryptedEndpoints = default(object), object useHostVerification = default(object), object usePeerVerification = default(object), string encryptedCredential = default(string))

        {
            this.ConnectionProperties = connectionProperties;
            this.Host = host;
            this.ConsumerKey = consumerKey;
            this.PrivateKey = privateKey;
            this.UseEncryptedEndpoints = useEncryptedEndpoints;
            this.UseHostVerification = useHostVerification;
            this.UsePeerVerification = usePeerVerification;
            this.EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets properties used to connect to Xero. It is mutually exclusive
        /// with any other properties in the linked service. Type: object.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "connectionProperties")]
        public object ConnectionProperties {get; set; }

        /// <summary>
        /// Gets or sets the endpoint of the Xero server. (i.e. api.xero.com)
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "host")]
        public object Host {get; set; }

        /// <summary>
        /// Gets or sets the consumer key associated with the Xero application.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "consumerKey")]
        public SecretBase ConsumerKey {get; set; }

        /// <summary>
        /// Gets or sets the private key from the .pem file that was generated for your
        /// Xero private application. You must include all the text from the .pem file,
        /// including the Unix line endings(
        /// ).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "privateKey")]
        public SecretBase PrivateKey {get; set; }

        /// <summary>
        /// Gets or sets specifies whether the data source endpoints are encrypted
        /// using HTTPS. The default value is true.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "useEncryptedEndpoints")]
        public object UseEncryptedEndpoints {get; set; }

        /// <summary>
        /// Gets or sets specifies whether to require the host name in the server&#39;s
        /// certificate to match the host name of the server when connecting over SSL.
        /// The default value is true.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "useHostVerification")]
        public object UseHostVerification {get; set; }

        /// <summary>
        /// Gets or sets specifies whether to verify the identity of the server when
        /// connecting over SSL. The default value is true.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "usePeerVerification")]
        public object UsePeerVerification {get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication. Credentials
        /// are encrypted using the integration runtime credential manager. Type:
        /// string.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "encryptedCredential")]
        public string EncryptedCredential {get; set; }
    }
}