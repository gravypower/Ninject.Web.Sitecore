using System;
using System.Linq;
using Sitecore.Pipelines.GetPlaceholderRenderings;

namespace Ninject.Web.Sitecore.Pipelines
{
    public abstract class GetPlaceholderRenderings : GetAllowedRenderings
    {
        public new void Process(GetPlaceholderRenderingsArgs args)
        {
            KernelContainer.Inject(this);
            this.DoGetAllowedRenderingsa(args);
        }

        protected abstract void DoGetAllowedRenderingsa(GetPlaceholderRenderingsArgs args);
    }
}
