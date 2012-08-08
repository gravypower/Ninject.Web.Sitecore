using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ninject.Web.Sitecore
{
    public abstract class SitecoreEvent
    {
        protected abstract void InternalOnItemSave(object sender, EventArgs args);
        protected abstract void InternalOnItemAdded(object sender, EventArgs args);

        public void OnItemSave(object sender, EventArgs args)
        {
            KernelContainer.Inject(this);
            InternalOnItemSave(sender, args);
          
        }

        public void OnItemAdded(object sender, EventArgs args)
        {
            KernelContainer.Inject(this);
            InternalOnItemAdded(sender, args);
        }
    }
}
