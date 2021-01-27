
namespace AttributesLib
{
    public class PanelContainerAttribute: System.Attribute
    {
        public bool PanelIsContainer { get; set; }

        public PanelContainerAttribute(bool panelIsContainer)
        {
            PanelIsContainer = panelIsContainer;
        }
    }
}
