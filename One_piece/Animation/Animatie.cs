using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace One_piece.Animation
{
    public class Animatie
    {
        public AnimationFrames curentframe { get; set; }
        
        private List<AnimationFrames> frames;
        
        private int counter;
        private double framemovement = 0;
        public Animatie()
        {
            frames = new List<AnimationFrames>();
        }

        public void AadFrame(AnimationFrames animationFrame)
        {
            frames.Add(animationFrame);
            curentframe = frames[0];
        }

        public void Update(GameTime gameTime)
        {
            curentframe = frames[counter];
            framemovement += curentframe.sourceRectangle.Width * gameTime.ElapsedGameTime.TotalSeconds;
            if (framemovement >= curentframe.sourceRectangle.Width / 8)
            {
                counter++;
                framemovement = 0;
            }


            if (counter >= frames.Count)
            {
                counter = 0;
            }
        }
    }
}
