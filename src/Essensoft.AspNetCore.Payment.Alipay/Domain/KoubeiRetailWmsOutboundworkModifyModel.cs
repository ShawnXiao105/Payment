using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsOutboundworkModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsOutboundworkModifyModel : AlipayObject
    {
        /// <summary>
        /// 扩展字段，json格式
        /// </summary>
        [JsonProperty("ext_info")]
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 操作上下文
        /// </summary>
        [JsonProperty("operate_context")]
        [XmlElement("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 出库作业id
        /// </summary>
        [JsonProperty("outbound_work_id")]
        [XmlElement("outbound_work_id")]
        public string OutboundWorkId { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonProperty("remark")]
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 出库作业明细列表
        /// </summary>
        [JsonProperty("work_details")]
        [XmlArray("work_details")]
        [XmlArrayItem("work_detail")]
        public List<WorkDetail> WorkDetails { get; set; }
    }
}
