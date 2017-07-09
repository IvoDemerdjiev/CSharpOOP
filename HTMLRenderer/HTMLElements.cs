namespace HTMLRenderer
{
    using System.Collections.Generic;
    using System.Text;

    public class HTMLElements : HTMLCommonElements, ISimpleElement
    {
        private ICollection<IElement> childElements;

        public HTMLElements(string name=null)
        {
            this.Name = name;
            this.childElements = new List<IElement>();
        }
        public IEnumerable<IElement> ChildElements
        {
            get
            {
                return new List<IElement>(this.childElements);
            }
        }

        public string TextContent { get; set; }
       

        public void AddElement(IElement element)
        {
            this.childElements.Add(element);
        }

        public override void Render(StringBuilder output)
        {
            output.AppendFormat("<{0}>{1}{2}</{0}>", this.Name, this.TextContent, string.Join("", this.ChildElements));
        }
    }
}
