using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sitecore.Pipelines.HttpRequest;

namespace Ninject.Web.Sitecore.Pipelines
{
    public abstract class HttpRequestEnd: HttpRequestProcessor
    {
        public override void Process(HttpRequestArgs args)
        {
            KernelContainer.Inject(this);
            this.DoProcessRequest(args);
        }

        protected abstract void DoProcessRequest(HttpRequestArgs args);
    }
}
