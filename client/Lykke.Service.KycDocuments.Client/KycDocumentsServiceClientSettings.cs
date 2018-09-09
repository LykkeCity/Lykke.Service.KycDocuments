using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.KycDocuments.Client 
{
    /// <summary>
    /// KycDocuments client settings.
    /// </summary>
    public class KycDocumentsServiceClientSettings 
    {
        /// <summary>Service url.</summary>
        [HttpCheck("api/isalive")]
        public string ServiceUrl {get; set;}
    }
}
