using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class AvatarCropping
    {
        public Image Image { get; }

        public Rect Rect { get; private set; } = new Rect()
        {
            x = 0,
            y = 0,
            width = 100,
            height = 100,
        };

        static Dictionary<string, Rect> rects = new Dictionary<string, Rect>();

        public AvatarCropping(Image image)
        {
            Image = image;
        }

        public void SaveToMemento(string memento)
        {
            rects[memento] = Rect;
        }

        public void RestoreFromMemento(string memento)
        {
            Rect = rects[memento];
        }

        public void Resize(double width, double height)
        {
            Rect = new Rect()
            {
                x = Rect.x,
                y = Rect.y,
                width = Math.Max(width, 50),
                height = Math.Max(height, 50),
            };
        }

        public void MoveTo(double x, double y)
        {
            Rect = new Rect()
            {
                x = Math.Max(x, 0),
                y = Math.Max(y, 0),
                width = Rect.width,
                height = Rect.height,
            };
        }

        public override string ToString()
        {
            return $"x: {Rect.x}, y: {Rect.y}, width:{Rect.width}, height:{Rect.height}";
        }
    }
}
