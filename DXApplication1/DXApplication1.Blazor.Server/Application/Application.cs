
namespace DXApplication1.Blazor.Server.Application
{
    public class Application : BlazorApplication
    {
        protected override IFrameTemplate CreateDefaultTemplate(TemplateContext context)
        {
            //if(context == TemplateContext.NestedFrame)
            //    return new CustomComponentModel();
            return base.CreateDefaultTemplate(context);
        }
    }
}
