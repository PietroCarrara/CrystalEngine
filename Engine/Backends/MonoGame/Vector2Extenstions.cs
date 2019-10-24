using Microsoft.Xna.Framework;
using Vec2 = Crystal.Framework.Vector2;

namespace Crystal.Engine.Backends.MonoGame
{
    public static class Vector2Extensions
    {
        public static Vector2 ToMonoGame(this Vec2 self)
        {
            return new Vector2(self.X, self.Y);
        }

        public static Vec2 ToCrystal(this Vector2 self)
        {
            return new Vec2(self.X, self.Y);
        }
    }
}