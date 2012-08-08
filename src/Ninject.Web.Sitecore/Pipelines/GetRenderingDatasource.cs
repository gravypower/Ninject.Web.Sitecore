using System;
using System.Linq;
using Sitecore.Pipelines.GetRenderingDatasource;

namespace Ninject.Web.Sitecore.Pipelines
{
    public abstract class GetRenderingDatasource
    {
       public void Process(GetRenderingDatasourceArgs args)
        {
            KernelContainer.Inject(this);
            this.DoGetRenderingDatasource(args);
        }

       protected abstract void DoGetRenderingDatasource(GetRenderingDatasourceArgs args);
    }
}
