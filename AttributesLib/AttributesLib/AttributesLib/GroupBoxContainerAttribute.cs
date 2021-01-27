
namespace AttributesLib
{
    public class GroupBoxContainerAttribute: System.Attribute
    {
        public bool ContainerIsGroupBox { get; set; }

        public GroupBoxContainerAttribute(bool containerIsGroupBox)
        {
            ContainerIsGroupBox = containerIsGroupBox;
        }
    }
}
