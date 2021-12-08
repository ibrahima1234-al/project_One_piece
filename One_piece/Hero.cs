
﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;
using One_piece.Interfaces;
using One_piece.Animation;
using SharpDX.DXGI;
using System.Diagnostics;
using Microsoft.Xna.Framework.Input;
using One_piece.Input;

namespace One_piece
{
    
    
        public class Hero:IGameobject
        {
            Texture2D herotexture;
            Animatie animatie;
            private Vector2 positie;
            private Vector2 snelheid;
            private Vector2 versnelling;
            InputReader inputReader;

        public bool IsDestinationInput => inputReader.IsDestinationInput;
        public Hero(Texture2D texture, InputReader reader )
            {
                this.herotexture = texture;
                animatie = new Animatie();
            animatie.AadFrame(new AnimationFrames(new Rectangle(0, 0, 78, 87)));
           
            /*animatie.AadFrame(new AnimationFrames(new Rectangle(78, 87, 78, 87)));
            animatie.AadFrame(new AnimationFrames(new Rectangle(156, 0, 78, 87)));
            animatie.AadFrame(new AnimationFrames(new Rectangle(234, 0, 78, 87)));
            animatie.AadFrame(new AnimationFrames(new Rectangle(312, 0, 78, 87)));*/
            //animatie.AadFrame(new AnimationFrame(new Rectangle(900, 0, 120, 140)));
           
            
            positie = new Vector2(0, 1);
                snelheid = new Vector2(1, 1);
                versnelling = new Vector2(0.1f, 0.1f);
            // lees de input van de hero class 
            this.inputReader = reader;

            
            }
            public void Update(GameTime gameTime)
            {
            var direction = inputReader.ReadInput();

            positie += direction;

             Move();
            animatie.Update(gameTime);
            }

        
            private void Move()
            {

            
            
            KeyboardState state = Keyboard.GetState();
            if (state.IsKeyDown(Keys.Down))
            {
               
            }



            if (state.IsKeyDown(Keys.Right))
            {
                
                
                /*animatie.AadFrame(new AnimationFrames(new Rectangle(0, 0, 78, 87)));
                animatie.AadFrame(new AnimationFrames(new Rectangle(78, 87, 78, 87)));
                animatie.AadFrame(new AnimationFrames(new Rectangle(156, 87, 78, 87)));
                animatie.AadFrame(new AnimationFrames(new Rectangle(234, 87, 78, 87)));
                animatie.AadFrame(new AnimationFrames(new Rectangle(312, 87, 78, 87)));*/
            }
            if (state.IsKeyDown(Keys.Right))
            {
               
                /*
                animatie.AadFrame(new AnimationFrames(new Rectangle(0, 0, 78, 87)));
                animatie.AadFrame(new AnimationFrames(new Rectangle(78, 87, 78, 87)));
                animatie.AadFrame(new AnimationFrames(new Rectangle(156, 87, 78, 87)));
                animatie.AadFrame(new AnimationFrames(new Rectangle(234, 87, 78, 87)));
                animatie.AadFrame(new AnimationFrames(new Rectangle(312, 87, 78, 87)));*/
            }

            if (state.IsKeyDown(Keys.Up))
            {
                
            }

            var direction = inputReader.ReadInput();
            direction.Normalize();
                 direction = Vector2.Multiply(direction, 0.5f); 

                snelheid += direction;
                snelheid = Limit(snelheid, 10);
                positie += snelheid;
                if (positie.X > 500 || positie.X < 0)
                {
                    snelheid.X += -1;
                    versnelling.X += -1;
                }
                if (positie.Y > 300 || positie.Y < 0)
                {
                    snelheid.Y += -1;
                    versnelling.Y += -1;
                }
            }

           private Vector2 Limit(Vector2 v, float max)
            {
                if (v.Length() > max)
                {
                    var ratio = max / v.Length();
                    v.X = ratio;
                    v.Y = ratio;
                }
                return v;
            }
        

            public void Draw(SpriteBatch spriteBatch)
            {
                // spriteBatch.Draw(herotexture, new Vector2(0, 0), animatie.curentframe.sourceRectangle, Color.White);//

                spriteBatch.Draw(herotexture, positie, animatie.CurrentFrame.sourceRectangle, Color.White);
            }
        }
  }

