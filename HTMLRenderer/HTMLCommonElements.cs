namespace HTMLRenderer
{
    using System;
    using System.Text;

    public abstract class HTMLCommonElements : IElement
    {
        public HTMLCommonElements()
        {

        }
        public string Name { get;private set; }

        public virtual void Render(StringBuilder output)
        {

        }
    }
}
