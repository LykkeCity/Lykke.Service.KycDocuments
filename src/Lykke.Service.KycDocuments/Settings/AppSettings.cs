using JetBrains.Annotations;
using Lykke.Sdk.Settings;

namespace Lykke.Service.KycDocuments.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class AppSettings : BaseAppSettings
    {
        public KycDocumentsSettings KycDocumentsService { get; set; }
    }
}
