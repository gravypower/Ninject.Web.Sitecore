using System;
using System.Linq;
using Sitecore.Pipelines.RenderField;

namespace Ninject.Web.Sitecore.Pipelines
{
    public abstract class RenderField
    {
        public void Process(RenderFieldArgs args)
        {
            KernelContainer.Inject(this);
            this.DoRenderField(args);
        }

        protected abstract void DoRenderField(RenderFieldArgs args);
    }
}
