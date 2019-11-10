using Crystal.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Crystal.Engine.Backends.MonoGame
{
    public static class RectangleExtensions
    {
        public static Rectangle ToMonoGame(this TextureSlice self)
        {
            return new Rectangle(self.TopLeft.X, self.TopLeft.Y, self.Width, self.Height);
        }

        public static TextureSlice ToCrystal(this Rectangle self)
        {
            return new TextureSlice(self.X, self.Y, self.Width, self.Height);
        }
    }
}