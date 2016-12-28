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
        Stage stage;	

        public Entrypoint()
        {
            graphics = new GraphicsDeviceManager(this);
            scaling = new ScalingManager(Window, new Vector3(720, 16, 9));

            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();

            buffer = new SpriteBatch(GraphicsDevice);
            stage = new Stage(scaling);
        }

        protected override void Update(GameTime gameTime)
        {
            stage.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            buffer.Begin();
            stage.Draw(buffer);
            buffer.End();

            base.Draw(gameTime);
        }
    }
}
