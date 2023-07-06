
using DevExpress.ExpressApp.Templates.ActionControls;

namespace DXApplication1.Blazor.Server.Components
{
    public class CustomComponentModel : FrameTemplate
    {
        protected override RenderFragment CreateComponent()
        {
            //return CustomComponent.Create(this);
            throw new NotImplementedException();
        }

        protected override IEnumerable<IActionControlContainer> GetActionControlContainers()
        {
            //return new List<IActionControlContainer> { };
            throw new NotImplementedException();
        }
    }
}
