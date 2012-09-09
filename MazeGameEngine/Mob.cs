using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

using Wormhole;

namespace MazeGameEngine
{
    public enum MobDirection
    {
        Up, Down, Left, Right
    }

    public abstract class Mob : MovingObject
    {

        public Mob()
            : base()
        {
            Direction = MobDirection.Up;
            Sprite.Origin = new Vector2(Sprite.Image.Width / 2, Sprite.Image.Height / 2);
        }
        public Mob(Vector2 position)
            : base(position)
        {
            Direction = MobDirection.Up;
            Sprite.Origin = new Vector2(Sprite.Image.Width / 2, Sprite.Image.Height / 2);
        }
        public Mob(Vector2 position, MobDirection direction)
            : base(position)
        {
            ChangeDirectionAndImage(direction);
            Sprite.Origin = new Vector2(Sprite.Image.Width / 2, Sprite.Image.Height / 2);
        }


        public MobDirection Direction = MobDirection.Right;

        protected override void Update()
        {
            
        }

        protected void ChangeDirectionAndImage(MobDirection direction)
        {
            Direction = direction;

            Sprite.Rotation = MobDirectionToAngle(direction);
        }

        public static float MobDirectionToAngle(MobDirection direction)
        {
            if (direction == MobDirection.Left)
            {
                return Directions.Left;
            }
            else if (direction == MobDirection.Right)
            {
                return Directions.Right;
            }
            else if (direction == MobDirection.Up)
            {
                return Directions.Up;
            }
            else if (direction == MobDirection.Down)
            {
                return Directions.Down;
            }

            return 0;
        }
    }
}
