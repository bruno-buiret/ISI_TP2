﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MyPacman
{
    public class Blinky : Ghost
    {
        /// <summary>
        /// Loads graphic contents for Blinky.
        /// </summary>
        /// <param name="contentManager">Reference to the content manager.</param>
        public override void LoadContent(ContentManager contentManager)
        {
            this.texture = contentManager.Load<Texture2D>(@"images\blinky");
        }
    }
}
