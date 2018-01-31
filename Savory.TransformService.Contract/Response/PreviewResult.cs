using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Savory.TransformService.Contract.Response
{
    /// <summary>
    /// 预览返回
    /// </summary>
    [DataContract]
    public class PreviewResult
    {
        /// <summary>
        /// 状态码
        /// </summary>
        [DataMember]
        public int PreviewStatus { get; set; }

        /// <summary>
        /// 引擎状态码
        /// </summary>
        [DataMember]
        public int EngineStatus { get; set; }

        /// <summary>
        /// 引擎编译错误
        /// </summary>
        [DataMember]
        public string EngineCompileErrors { get; set; }

        /// <summary>
        /// 引擎运行异常
        /// </summary>
        [DataMember]
        public string EngineRunException { get; set; }

        /// <summary>
        /// 输出
        /// </summary>
        [DataMember]
        public string Output { get; set; }
    }
}
