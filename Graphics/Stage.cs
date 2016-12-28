using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BareKit.Graphics
{
    public class Stage : Container
    {
        public Stage(ScalingManager scaling) : base(scaling)
        {

        }

        public override void Update(GameTime delta)
        {
            if (Children.Count > 0)
                Children[Children.Count - 1].Update(delta);
        }

        public override void Draw(SpriteBatch buffer)
        {
            if (Children.Count > 0)
                Children[Children.Count - 1].Draw(buffer);
        }

        public Stage NavigateTo(Type pageType)
        {
            Page target = (Page)Activator.CreateInstance(pageType, Scaling, this);
            Page current = null;

            if (Children.Count > 0)
                current = (Page)Children[Children.Count - 1];

            target.Enter(current);
            current?.Leave(false);

            AddChild(target);

            return this;
        }

        public Stage NavigateBack()
        {
            if (Children.Count > 1)
            {
                Page current = (Page)Children[Children.Count - 1];
                Page target = (Page)Children[Children.Count - 2];

                current.Leave(true);
                target.Enter(current);

                RemoveChild(current);
            }

            return this;
        }
    }
}
