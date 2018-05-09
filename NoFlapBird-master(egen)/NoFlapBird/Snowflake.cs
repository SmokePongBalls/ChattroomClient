using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace NoFlapBird
{
    class Snowflake
    {
        //-----Fält-----
        Texture2D texture;

        public Vector2 position, velocity;
        float rotation = 5;
        Random random = new Random();
        //-----Konstruktor-----
        public Snowflake(Texture2D texture, Vector2 startPosition)
        {
            this.texture = texture;
            position = startPosition;
        }

        //-----Metoder-----

        //Kod för en fin fallande flinga!
        public void Update(/*Valfritt med parametrar*/)
        {
            
            velocity.X = 1;
            position += velocity;
            velocity.X++;
            rotation += (float)0.1;
        }

        //Ritar ut flingan
        public void Draw(SpriteBatch spriteBatch)
        {
            Vector2 origin = new Vector2(texture.Width / 2, texture.Height / 2);
            //spriteBatch.Draw(texture,position,Color.White);
            spriteBatch.Draw(texture, position, null, Color.White, rotation, origin, 0.15f, SpriteEffects.None, 0);
           
        }



    }
}
