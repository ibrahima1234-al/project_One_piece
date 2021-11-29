using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using One_piece.Animation;
using System;
using System.Collections.Generic;
using System.Text;
using One_piece.Animation;

namespace One_piece.Input
{
    public class Keyboardreader : InputReader , Animatie
    {
        //Animatie animatie;


        Vector2 InputReader.ReadInput()
        {
            animatie = new Animatie();


            var direction = Vector2.Zero;
            KeyboardState state = Keyboard.GetState();
            if (state.IsKeyDown(Keys.Down))
            {
                direction.Y += 1;
            }


            if (state.IsKeyDown(Keys.Right))
            {
                direction.X += 1;
                //animatie.AadFrame(new AnimationFrames(new Rectangle(0, 0, 78, 87)));
                animatie.AadFrame(new AnimationFrames(new Rectangle(78, 87, 78, 87)));
                animatie.AadFrame(new AnimationFrames(new Rectangle(156, 87, 78, 87)));
                animatie.AadFrame(new AnimationFrames(new Rectangle(234, 87, 78, 87)));
                animatie.AadFrame(new AnimationFrames(new Rectangle(312, 87, 78, 87)));
            }

            if (state.IsKeyDown(Keys.Up))
            {
                direction.Y -= 1;
            }

            return direction;
        }

            public void Update(GameTime gameTime)
            {
                animatie.Update(gameTime);
            }
        
    }


}
