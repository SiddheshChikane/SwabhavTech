using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TictactoeCore.Model
{
    public class Cell
    {
        private MarkType mark;
        public Cell()
        {
            this.mark = MarkType.EMPTY;
        }

        public bool IsMarked()
        {
            if (mark == MarkType.EMPTY)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool IsMarkCellTwice(MarkType inputMarkType)
        {
            try
            {
                if (mark == inputMarkType)
                {
                    throw new Exception("you tried to Mark cell twice....try another cell");
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return true;
        }

        public MarkType Mark
        {
            get
            {
                return mark;
            }
            set
            {
                mark = value;
            }
        }
    }
}
