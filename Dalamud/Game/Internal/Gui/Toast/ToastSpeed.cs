﻿namespace Dalamud.Game.Internal.Gui.Toast
{
    public enum ToastSpeed : byte
    {
        /// <summary>
        /// The toast will take longer to disappear (around four seconds).
        /// </summary>
        Slow = 0,

        /// <summary>
        /// The toast will disappear more quickly (around two seconds).
        /// </summary>
        Fast = 1,
    }
}
