using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace One_piece.Interfaces
{
    interface IGameobject
    {
        void Update(GameTime gameTime);
        void Draw(SpriteBatch sprite);
    }
}
