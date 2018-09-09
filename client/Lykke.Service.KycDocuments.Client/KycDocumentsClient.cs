using Lykke.HttpClientGenerator;

namespace Lykke.Service.KycDocuments.Client
{
    /// <summary>
    /// KycDocuments API aggregating interface.
    /// </summary>
    public class KycDocumentsClient : IKycDocumentsClient
    {
        // Note: Add similar Api properties for each new service controller

        /// <summary>Inerface to KycDocuments Api.</summary>
        public IKycDocumentsApi Api { get; private set; }

        /// <summary>C-tor</summary>
        public KycDocumentsClient(IHttpClientGenerator httpClientGenerator)
        {
            Api = httpClientGenerator.Generate<IKycDocumentsApi>();
        }
    }
}
