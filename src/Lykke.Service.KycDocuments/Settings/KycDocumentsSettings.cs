using JetBrains.Annotations;
using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.KycDocuments.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class KycDocumentsSettings
    {
        public DbSettings Db { get; set; }
    }
}
