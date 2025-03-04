﻿using System.Collections;
using System.Collections.Generic;

namespace DungeonGame
{
    public class HelpCommand : Command
    {
        CommandWords words;

        public HelpCommand() : this(new CommandWords())
        {
        }

        public HelpCommand(CommandWords commands) : base()
        {
            words = commands;
            this.name = "Help";
        }

        override
        public bool execute(Player player)
        {
            if (this.hasSecondWord())
            {
                player.outputMessage("\nI cannot help you with " + this.secondWord);
            }
            else
            {
                player.outputMessage("\nYou are lost. You wander. \n\nYour available commands are " + words.description());
            }
            return false;
        }
    }
}
