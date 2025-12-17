using nspector.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nspector.XmlExportModel
{
    [DataContract(Name = "SettingState")]
    public enum SettingStateXml
    {
        [EnumMember(Value = "NotAssiged")]
        NotAssiged,

        [EnumMember(Value = "GlobalSetting")]
        GlobalSetting,

        [EnumMember(Value = "UserdefinedSetting")]
        UserdefinedSetting,

        [EnumMember(Value = "NvidiaSetting")]
        NvidiaSetting,
    }

    [DataContract]
    public class SettingItemXml
    {
        [DataMember]
        public uint SettingId { get; set; }

        [DataMember]
        public string SettingText { get; set; }

        [DataMember]
        public string ValueText { get; set; }

        [DataMember]
        public string ValueRaw { get; set; }

        [DataMember]
        public string GroupName { get; set; }

        [DataMember]
        public SettingStateXml State { get; set; }

        [DataMember]
        public bool IsStringValue { get; set; }

        [DataMember]
        public bool IsApiExposed { get; set; }

        [DataMember]
        public bool IsSettingHidden { get; set; }

        internal static SettingItemXml MapFromServiceModel(SettingItem item)
        {
            return new SettingItemXml
            {
                SettingId = item.SettingId,
                SettingText = item.SettingText,
                ValueText = item.ValueText,
                ValueRaw = item.ValueRaw,
                GroupName = item.GroupName,
                State = (SettingStateXml)item.State,
                IsStringValue = item.IsStringValue,
                IsApiExposed = item.IsApiExposed,
                IsSettingHidden = item.IsSettingHidden
            };
        }
    }
}
