using N2.Definitions;
using N2.Installation;
using N2.Integrity;
using N2.Web;

namespace N2.Management.Myself
{
    [PageDefinition("Root Page (fallback)", 
		Description = "A fallback root page used to organize start pages. This root can be replaced or inherited in a web application project.", 
		SortOrder = 0,
		IconUrl = "{ManagementUrl}/Resources/icons/page_gear.png",
		TemplateUrl = "{ManagementUrl}/Myself/Root.aspx")]
    [RestrictParents(AllowedTypes.None)]
    [AvailableZone("Left", "Left")]
    [AvailableZone("Center", "Center")]
    [AvailableZone("Right", "Right")]
    [AvailableZone("Above", "Above")]
    [AvailableZone("Below", "Below")]
	public class RootBase : ContentItem, IRootPage, ISystemNode
    {
        public override string Url
        {
			get { return FindPath(PathData.DefaultAction).RewrittenUrl; }
        }
    }
}