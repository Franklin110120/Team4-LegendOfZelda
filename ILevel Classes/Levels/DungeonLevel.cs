﻿using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Team4_LegendOfZelda.ILevel_Classes.Levels
{
    class DungeonLevel : ILevel
    {
        public IFileLoader FileLoader { get; set; }
        public IMap Map { get; set; }
        public IHUD HUD { get; set; }
        public IPlayer Player { get; set; }
        public List<IRoom> Rooms { get; set; }
        public IRoom CurrentRoom { get; set; }

        public DungeonLevel(IPlayer player, int levelNum)
        {
            FileLoader = new LevelLoader(1);
            Map = new Map(levelNum);
            HUD = new DungeonHUD(this, levelNum);
            Player = player;
            Rooms = new List<IRoom>();
            CurrentRoom = new DungeonRoom();
        }

        public void Initialize(int windowWidth, int roomHeight, int hudHeight)
        {
            Map.Initialize(0, hudHeight, windowWidth, roomHeight);
            HUD.Initialize(0, 0, windowWidth, hudHeight);
            Rooms = FileLoader.LoadRooms();

            if (Rooms.Count > 0)
            {
                CurrentRoom = Rooms[0];
            }

            foreach (IRoom room in Rooms)
            {
                room.Blocks = new List<IBlock>{
                new Block(new Microsoft.Xna.Framework.Rectangle(0, hudHeight, 93, 525)),
                new Block(new Microsoft.Xna.Framework.Rectangle(0, hudHeight, 765, 93)),
                new Block(new Microsoft.Xna.Framework.Rectangle(0, 432 + hudHeight, 765, 93)),
                new Block(new Microsoft.Xna.Framework.Rectangle(672, hudHeight, 93, 525))
                };
            }
        }

        public void North()
        {
            // Transition to room north of current room
        }

        public void East()
        {
            // Transition to room north of current room
        }

        public void South()
        {
            // Transition to room north of current room
        }

        public void West()
        {
            // Transition to room north of current room
        }

        public void Other()
        {
            // Transition to current room's other room, if it exists
        }

        public void Update()
        {
            HUD.Update();
            CurrentRoom.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Map.Draw(spriteBatch);
            HUD.Draw(spriteBatch);
            CurrentRoom.Draw(spriteBatch);
        }
    }
}