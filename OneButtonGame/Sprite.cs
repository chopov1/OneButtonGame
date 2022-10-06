using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneButtonGame
{
    public class Sprite : DrawableGameComponent
    {
        protected Texture2D SpriteTexture;
        protected Vector2 pos;
        SpriteBatch sb;
        string textureName;
        public Sprite(Game game, string textureName) : base(game)
        {
            this.textureName = textureName; 
        }

        protected override void LoadContent()
        {
            base.LoadContent();
            SpriteTexture = Game.Content.Load<Texture2D>(textureName);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            sb.Begin();
            sb.Draw(SpriteTexture, pos, Color.White);
            sb.End();
            base.Draw(gameTime);

        }


    }
}
