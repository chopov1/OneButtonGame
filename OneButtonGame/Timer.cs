using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneButtonGame
{
    public class Timer : GameComponent
    {
        int currentTime;
        public int CurrentTime { get { return currentTime; } }
        public int maxTime;
        int beatsPerMin;

        StringSprite output;

        public Timer(Game game, int bpm, StringSprite output) : base(game)
        {
            beatsPerMin = bpm/60;
            currentTime = 0;
            this.output = output;
            Game.Components.Add(this);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
           //if beatsPerMin = 60, I would think this should increase at a consistent rate and stay synced with the audio. 
            currentTime += beatsPerMin * gameTime.ElapsedGameTime.Milliseconds;
            output.StringToDraw = "first Timer: " + currentTime;

        }

        protected virtual void onComplete()
        {
            currentTime = 0;
        }

    }
}
