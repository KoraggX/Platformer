﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Platformer
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Player player = new Player(); // Create an instance of our player class.


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            player.Load(Content); // Call the 'Load' function in the Player class.
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            player.Update(deltaTime); // Call the 'Update' from our Player class.

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            // Clears anything previously drawn to the screen.
            GraphicsDevice.Clear(Color.Gray);
            // Begin drawing.
            spriteBatch.Begin();
            // Call the 'Draw' function from our Player class.
            player.Draw(spriteBatch);
            // Finish drawing.
            spriteBatch.End();
            

            base.Draw(gameTime);
        }
    }
}
