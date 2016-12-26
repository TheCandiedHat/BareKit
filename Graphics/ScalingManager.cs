using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BareKit.Graphics
{
    public class ScalingManager
    {
        Vector2 initialSize;
        Vector2 currentSize;
        float contentScale;
        DisplayOrientation orientation;

        public event EventHandler<EventArgs> Resized;

        public ScalingManager(GameWindow window, Vector3 size)
        {
            window.ClientSizeChanged += OnResized;
            window.OrientationChanged += OnResized;
            initialSize = new Vector2(size.X, size.X / size.Y * size.Z);
            contentScale = 1f;

            OnResized(window, EventArgs.Empty);
        }

        void OnResized(object sender, EventArgs e)
        {
            GameWindow window = (GameWindow)sender;

            currentSize = new Vector2(window.ClientBounds.Width, window.ClientBounds.Height);
            contentScale = Math.Min(currentSize.X / initialSize.X, currentSize.Y / initialSize.Y);

            orientation = window.CurrentOrientation;

            Resized?.Invoke(this, EventArgs.Empty);
        }

        public Vector2 Size
        {
            get { return currentSize; }
        }

        public Vector2 Scale
        {
            get { return new Vector2(contentScale); }
        }

        public DisplayOrientation Orientation
        {
            get { return orientation; }
        }
    }
}
