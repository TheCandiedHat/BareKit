using Microsoft.Xna.Framework.Graphics;

namespace BareKit.Graphics
{
    public class Page : Container
    {
        Stage stage;

        public Page(ScalingManager scaling, Stage stage) : base(scaling)
        {
            this.stage = stage;
        }

        public virtual void Enter(Page from)
        {

        }

        public virtual void Leave(bool terminate)
        {

        }

        protected Stage Stage
        {
            get { return stage; }
        }
    }
}
