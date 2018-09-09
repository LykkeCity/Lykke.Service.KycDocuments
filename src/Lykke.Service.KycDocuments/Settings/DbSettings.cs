using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.KycDocuments.Settings
{
    public class DbSettings
    {
        [AzureTableCheck]
        public string LogsConnString { get; set; }
    }
}
