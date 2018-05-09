using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;


namespace NoFlapBird
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        Random random = new Random();
        public static Vector2 gravity;
        Player player;
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;       
        List<Snowflake> snowflake = new List<Snowflake>();
        Vector2 snowflakeStartposition;
        Snowflake snow;
        
        int loop=0;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            
            gravity = new Vector2(0, 0.4f);

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {

            snowflakeStartposition = new Vector2(0,-100);
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            
            Texture2D playerSprite = Content.Load<Texture2D>("flappybird");
            Texture2D SnowflakeT2D = Content.Load<Texture2D>("Snowflake");
            snow = new Snowflake(SnowflakeT2D, snowflakeStartposition);
            while (loop < 1)
            {

                snowflake.Add(new Snowflake(Content.Load<Texture2D>("Snowflake"),snowflakeStartposition));
                loop++;
            }
            player = new Player(playerSprite);
            
            // TODO: use this.Content to load your game content here
        }

        
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        
        protected override void Update(GameTime gameTime)
        {
            snowflakeStartposition = new Vector2(random.Next(-500,700), -100);
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            for (int i = 0; i < snowflake.Count; i++)
            {
                snowflake[i].velocity.Y = (float)random.NextDouble()+2;
                snowflake[i].Update();
                
            }
            for (int i = 0; i < snowflake.Count; i++)
            {

                if (snowflake[i].position.Y > Window.ClientBounds.Bottom+50)
                    snowflake.Remove(snowflake[i]);
            }
                player.Update();
           
            snowflake.Add(new Snowflake(Content.Load<Texture2D>("Snowflake"), snowflakeStartposition));
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkBlue);

            //Rita ut spelaren!
            spriteBatch.Begin();
            player.Draw(spriteBatch);
            snow.Draw(spriteBatch);

            for (int i = 0; i < snowflake.Count; i++)
            {
                snowflake[i].Draw(spriteBatch);
            }
            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
