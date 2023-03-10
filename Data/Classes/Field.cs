using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wyrm.Data.Classes
{
    public class Field
    {
        private int sizeX;
        private int sizeY;
        private int[] cells;

        public enum cellTypes
        {
            Empty = 0,
            Serpent = 1,
            Snack = 2,
            Default = Empty
        }

        public Field(int size)
        {
            sizeX = size;
            sizeY = size;
            cells = InititalizeCells((int)cellTypes.Default);
        }

        private int[] InititalizeCells(int defaultValue)
        {
            int[] cells = new int[sizeX * sizeY];
            for (int i = 0; i < sizeX * sizeY; ++i)
            {
                cells[i] = defaultValue;
            }
            return cells;
        }
    }
}
