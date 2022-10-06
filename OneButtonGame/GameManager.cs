using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneButtonGame
{
    public class GameManager : GameComponent
    {
        PlayerController playerController;
        Timer timer;

        enum BeatState { miss, okay, good, perfect}
        BeatState currentBeatState;
        public GameManager(Game game, PlayerController playerController, Timer timer) : base(game)
        {
            this.playerController = playerController;
            this.timer = timer; 
            Game.Components.Add(this);
        }

        void checkBeatState()
        {
            switch (currentBeatState)
            {
                case BeatState.okay:
                case BeatState.good:
                    Debug.WriteLine("Good" + timer.CurrentTime);
                    break;
                case BeatState.perfect:
                case BeatState.miss:
                    Debug.WriteLine("Miss" + timer.CurrentTime);
                    break;
            }
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            if(timer.CurrentTime >= timer.maxTime - 357 && playerController.PressedKey())
            {
                currentBeatState = BeatState.good;
            }
            else if(timer.CurrentTime < timer.maxTime - 357 && playerController.PressedKey())
            {
                currentBeatState = BeatState.miss;
            }
            if (playerController.PressedKey())
            {
                checkBeatState();
            }
            
        }
    }
}
