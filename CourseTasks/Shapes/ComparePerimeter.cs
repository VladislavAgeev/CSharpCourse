using System.Collections.Generic;

namespace Shapes
{
    class ComparePerimeter : IComparer<IShape>
    {
        public int Compare(IShape obj1, IShape obj2)
        {
            if (obj1.GetPerimeter() < obj2.GetPerimeter())
            {
                return 1;
            }
            else if (obj1.GetPerimeter() > obj2.GetPerimeter())
            {
                return -1;
            }

            return 0;
        }
    }
}
