using System.Collections.Generic;

namespace Shapes
{
    class CompareArea : IComparer<IShape>
    {
        public int Compare(IShape obj1, IShape obj2)
        {
            if (obj1.GetArea() < obj2.GetArea())
            {
                return 1;
            }
            else if (obj1.GetArea() > obj2.GetArea())
            {
                return -1;
            }

            return 0;
        }
    }
}
