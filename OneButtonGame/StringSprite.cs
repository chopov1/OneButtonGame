using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneButtonGame
{
    public class StringSprite : DrawableGameComponent
    {
        Vector2 pos;
        SpriteBatch sb;
        SpriteFont font;
        string fontName;
        public string StringToDraw;
        public StringSprite(Game game, string fontname, Vector2 position) : base(game)
        {
            fontName = fontname;
            
            pos = position;
            Game.Components.Add(this);
        }

        public override void Initialize()
        {
            base.Initialize();
            sb = new SpriteBatch(Game.GraphicsDevice);
        }

        protected override void LoadContent()
        {
            base.LoadContent();
            font = Game.Content.Load<SpriteFont>(fontName);
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
            sb.Begin();
            sb.DrawString(font, StringToDraw, pos, Color.Black);
            sb.End();
        }
    }
}
