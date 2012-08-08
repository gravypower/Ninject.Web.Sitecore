using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sitecore.Shell.Applications.ContentEditor.Pipelines.GetContentEditorFields;

namespace Ninject.Web.Sitecore.Pipelines
{
    public abstract class GetContentEditorFields
    {
        public void Process(GetContentEditorFieldsArgs args)
        {
            KernelContainer.Inject(this);
            this.DoProcess(args);
        }

        protected abstract void DoProcess(GetContentEditorFieldsArgs args);
    }
}
