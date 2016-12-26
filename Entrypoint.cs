using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;

using BareKit.Graphics;

namespace BareKit
{
    public class Entrypoint : Game
    {
        GraphicsDeviceManager graphics;
        ScalingManager scaling;

        SpriteBatch buffer;		

        public Entrypoint()
        {
            graphics = new GraphicsDeviceManager(this);
            scaling = new ScalingManager(Window, new Vector3(720, 16, 9));

            IsMouseVisible = true; 	
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            buffer = new SpriteBatch(GraphicsDevice);
        }

        protected override void Update(GameTime gameTime)
        {   	
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            base.Draw(gameTime);
        }
    }
}
