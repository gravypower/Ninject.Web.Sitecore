using System;
using System.Linq;
using Sitecore.Pipelines.HttpRequest;

namespace Ninject.Web.Sitecore.Pipelines
{
    public abstract class HttpRequestBegin : HttpRequestProcessor
    {
        public override void Process(HttpRequestArgs args)
        {
            KernelContainer.Inject(this);
            this.DoProcessRequest(args);
        }

        protected abstract void DoProcessRequest(HttpRequestArgs args);

    }
}
