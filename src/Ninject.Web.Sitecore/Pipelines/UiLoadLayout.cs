using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sitecore.Pipelines.LoadLayout;

namespace Ninject.Web.Sitecore.Pipelines
{
    public abstract class UiLoadLayout
    {
        public void Process(LoadLayoutArgs args)
        {
            KernelContainer.Inject(this);
            this.DoProcess(args);
        }

        protected abstract void DoProcess(LoadLayoutArgs args);
    }
}
