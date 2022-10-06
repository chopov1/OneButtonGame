using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneButtonGame
{
    public class PlayerController : GameComponent
    {
        InputHandler inputHandler = new InputHandler();
        Keys strikeKey = Keys.Space;

        public PlayerController(Game game) : base(game)
        {
            Game.Components.Add(this);
        }

        public bool PressedKey()
        {
            if (inputHandler.IsKeyDown(strikeKey))
            {
                return true;
            }
            return false;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            inputHandler.Update();
        }
    }
}
