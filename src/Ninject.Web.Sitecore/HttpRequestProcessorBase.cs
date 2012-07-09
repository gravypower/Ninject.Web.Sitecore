
using Sitecore.Pipelines.HttpRequest;
namespace Ninject.Web.Sitecore
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class HttpRequestProcessorBase :  HttpRequestProcessor
    {
        public override void Process(HttpRequestArgs args)
        {
            KernelContainer.Inject(this);

            foreach (var property in GetType().GetProperties())
            {
                var attribute = property.Attributes.GetType();
                if (attribute == typeof(InjectAttribute))
                {
                    var injectedProp = KernelContainer.Kernel.Get(property.GetType());
                    //var rightValue = property.GetValue(injectedProp, null);

                    //set the properties values for the right to the left object
                    property.SetValue(injectedProp, injectedProp, null);
                }
            }
            
            DoProcessRequest(args);
        }

        protected abstract void DoProcessRequest(HttpRequestArgs args);
    }
}
