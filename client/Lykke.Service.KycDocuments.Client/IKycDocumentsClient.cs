using JetBrains.Annotations;

namespace Lykke.Service.KycDocuments.Client
{
    /// <summary>
    /// KycDocuments client interface.
    /// </summary>
    [PublicAPI]
    public interface IKycDocumentsClient
    {
        // Make your app's controller interfaces visible by adding corresponding properties here.
        // NO actual methods should be placed here (these go to controller interfaces, for example - IKycDocumentsApi).
        // ONLY properties for accessing controller interfaces are allowed.

        /// <summary>Application Api interface</summary>
        IKycDocumentsApi Api { get; }
    }
}
