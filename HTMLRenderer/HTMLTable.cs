namespace HTMLRenderer
{
    using System;
    using System.Text;

    public class HTMLTable : HTMLCommonElements, ITable
    {
        private IElement[,] matrix;

        public HTMLTable()
        {
            this.matrix = new IElement[,];
        }
        public IElement this[int row, int col]
        {
            get
            {
                return matrix[row,col];
            }

            set
            {
                this.matrix = value;
            }
        }

        public int Cols { get;private set; }
       

        public int Rows { get;private set; }

        public override void Render(StringBuilder output)
        {
            throw new NotImplementedException();
            //<table><tr><td>(cell_0_0)</td><td>(cell_0_1)</td>…</tr><tr><td>(cell_1_0)</td><td>(cell_1_1)</td>…</tr>…</table>
        }
    }
}
