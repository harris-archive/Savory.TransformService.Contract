using Savory.TransformService.Contract.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Savory.TransformService.Contract
{
    /// <summary>
    /// 模版引擎服务
    /// </summary>
    [ServiceContract]
    public interface ITransformService
    {
        /// <summary>
        /// 从模版引擎获取代码
        /// </summary>
        /// <param name="templateName">模版唯一标识</param>
        /// <param name="version">版本号</param>
        /// <returns></returns>
        [OperationContract(Name = "Transform")]
        TransformResult Transform(string templateName, string version);

        /// <summary>
        /// 从模版引擎获取代码
        /// </summary>
        /// <param name="templateName">模版唯一标识</param>
        /// <param name="version">版本号</param>
        /// <param name="itemjsonValue">参数</param>
        /// <returns></returns>
        [OperationContract(Name = "TransformWithItem")]
        TransformResult Transform(string templateName, string version, string itemJsonValue);

        /// <summary>
        /// 预览生成的代码
        /// </summary>
        /// <param name="templateBody">模版</param>
        /// <param name="extension">扩展类，参与编译</param>
        /// <param name="itemJsonValue">参数</param>
        /// <returns></returns>
        [OperationContract(Name = "Preview")]
        PreviewResult Preview(string templateBody, string extension, string itemJsonValue);
    }
}
