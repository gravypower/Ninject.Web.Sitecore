using System;
using System.Linq;
using Sitecore.Pipelines.GetChromeData;

namespace Ninject.Web.Sitecore.Pipelines
{
    public abstract class GetChromeData: GetPlaceholderChromeData
    {
        public override void Process(GetChromeDataArgs args)
        {
            KernelContainer.Inject(this);
            this.DoGetChromeData(args);
        }

        protected abstract void DoGetChromeData(GetChromeDataArgs args);
    }
}
