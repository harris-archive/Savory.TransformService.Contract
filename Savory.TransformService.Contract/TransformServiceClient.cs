using Savory.TransformService.Contract.Response;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace Savory.TransformService.Contract
{
    /// <summary>
    /// 模版引擎服务客户端
    /// </summary>
    [DebuggerStepThrough]
    public class TransformServiceClient : ClientBase<ITransformService>, ITransformService
    {
        [Obsolete("警告，尽快移除内部的IP硬编码部分")]
        public TransformServiceClient() :
            base(new ServiceEndpoint(ContractDescription.GetContract(typeof(ITransformService)), new BasicHttpBinding(), new EndpointAddress("http://127.0.0.1:4455")))
        {
        }

        /// <summary>
        /// <see cref="ITransformService.Preview(string, string, string)"/>
        /// </summary>
        public PreviewResult Preview(string templateBody, string extension, string itemJsonValue)
        {
            return base.Channel.Preview(templateBody, extension, itemJsonValue);
        }

        /// <summary>
        /// <see cref="ITransformService.Transform(string, string)"/>
        /// </summary>
        public TransformResult Transform(string templateName, string version)
        {
            return base.Channel.Transform(templateName, version);
        }

        /// <summary>
        /// <see cref="ITransformService.Transform(string, string, string)"/>
        /// </summary>
        public TransformResult Transform(string templateName, string version, string itemJsonValue)
        {
            return base.Channel.Transform(templateName, version, itemJsonValue);
        }
    }
}
