﻿using System;

namespace GameLib
{
    /// <summary>
    /// Class representing a nonogram tile
    /// </summary>
    internal class Tile: IComparable<Tile>
    {
        /// <summary>
        /// Tile priority. Approximately how usefull would it be to resolve this tile
        /// </summary>
        internal int Priority;
        /// <summary>
        /// State of tile. null if tile is not set, true if set to true, false if set to false.
        /// </summary>
        internal bool? State = null;

        /// <summary>
        /// Tile constructore
        /// </summary>
        /// <param name="prio">Initial tile priority</param>
        public Tile(int prio)
        {
            Priority = prio;
        }

        /// <summary>
        /// Gets a character representation of the tile state.
        /// </summary>
        /// <returns>█ if true, space if false and ? if null</returns>
        public char ToChar()
        {
            if (State.HasValue)
            {
                return State.Value ? '█' : ' ';
            }
            return '?';
        }

        /// <summary>
        /// Natural ordering based on tile priority.
        /// </summary>
        /// <param name="other">Tile to compare to</param>
        /// <returns>Positive if this higher that other</returns>
        public int CompareTo(Tile other)
        {
            return Priority - other.Priority;
        }
    }
}