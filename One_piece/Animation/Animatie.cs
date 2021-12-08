using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace One_piece.Animation
{
    public class Animatie
    {
        /*public AnimationFrames curentframe { get; set; }
        
        private List<AnimationFrames> frames;
        
        private int counter = 0;
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
        }*/
        public AnimationFrames CurrentFrame { get; set; }
        private List<AnimationFrames> frames;
        private int counter;
        private double secondCounter = 0;


        public Animatie()
        {
            frames = new List<AnimationFrames>();
        }

        public void AadFrame(AnimationFrames frame)
        {
            frames.Add(frame);
            CurrentFrame = frames[0];
        }

        public void Update(GameTime gameTime)
        {
            CurrentFrame = frames[counter];

            secondCounter += gameTime.ElapsedGameTime.TotalSeconds;
            int fps = 5;

            if (secondCounter >= 1d / fps)
            {
                counter++;
                secondCounter = 0;
            }

            if (counter >= frames.Count)
            {
                counter = 0;
            }
        }




        public void GetFramesFromTextureProperties(int width, int height, int numberOfWidthSprites, int numberOfHeightSprites)
        {
            int widthOfFrame = width / numberOfWidthSprites;
            int heightOfFrame = height / numberOfHeightSprites;

            for (int y = 0; y <= height - heightOfFrame; y += heightOfFrame)
            {
                for (int x = 0; x <= width - widthOfFrame; x += widthOfFrame)
                {
                    frames.Add(new AnimationFrames(new Rectangle(x, y, widthOfFrame, heightOfFrame)));
                }
            }
        }
    }
}
