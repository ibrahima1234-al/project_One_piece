using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace One_piece.Animation
{
    public class AnimationFrames
    {
        public Rectangle sourceRectangle { get; set; }

        public AnimationFrames(Rectangle rectangle)
        {
            sourceRectangle = rectangle;
        }
       
    }
}
