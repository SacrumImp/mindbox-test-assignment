using MindBoxAreaLibrary.Shapes;
using System.ComponentModel.DataAnnotations;

namespace MindBoxAreaLibrary
{
    public static class AreaGetter
    {
        public static double GetArea(object shape)
        {
            if (shape is null)
            {
                throw new ArgumentNullException(nameof(shape));
            }

            if (shape is IArea shapeWithArea)
            {
                return shapeWithArea.GetArea();
            }
            else
            {
                throw new InvalidCastException("This object does not implement IArea interface");
            }
        }
    }
}