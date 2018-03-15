using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosOrderUploadModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosOrderUploadModel : AlipayObject
    {
        /// <summary>
        /// 设备商回流的设备信息列表
        /// </summary>
        [JsonProperty("pos_device_infos")]
        public List<PosDeviceInfoVO> PosDeviceInfos { get; set; }

        /// <summary>
        /// 回流pos订单信息列表
        /// </summary>
        [JsonProperty("pos_order_infos")]
        public List<PosOrderInfoVO> PosOrderInfos { get; set; }

        /// <summary>
        /// source_type+pos订单设备信息来源类型枚举+(isv回流数据: ISV, 设备商数据: META)
        /// </summary>
        [JsonProperty("source_type")]
        public string SourceType { get; set; }
    }
}
