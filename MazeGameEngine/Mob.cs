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

            if (direction == MobDirection.Up)
            {
                Sprite.Rotation = Directions.Up;
            }
            else if (direction == MobDirection.Down)
            {
                Sprite.Rotation = Directions.Down;
            }
            else if (direction == MobDirection.Left)
            {
                Sprite.Rotation = Directions.Left;
            }
            else if (direction == MobDirection.Right)
            {
                Sprite.Rotation = Directions.Right;
            }
        }
    }
}
