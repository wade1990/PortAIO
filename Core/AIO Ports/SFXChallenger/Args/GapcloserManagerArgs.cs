#region License

/*
 Copyright 2014 - 2015 Nikita Bernthaler
 GapcloserManagerArgs.cs is part of SFXChallenger.

 SFXChallenger is free software: you can redistribute it and/or modify
 it under the terms of the GNU General Public License as published by
 the Free Software Foundation, either version 3 of the License, or
 (at your option) any later version.

 SFXChallenger is distributed in the hope that it will be useful,
 but WITHOUT ANY WARRANTY; without even the implied warranty of
 MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 GNU General Public License for more details.

 You should have received a copy of the GNU General Public License
 along with SFXChallenger. If not, see <http://www.gnu.org/licenses/>.
*/

#endregion License

#region

using System;
using LeagueSharp;
using SharpDX;

#endregion

using EloBuddy; namespace SFXChallenger.Args
{
    public class GapcloserManagerArgs : EventArgs
    {
        public GapcloserManagerArgs(string uniqueId, AIHeroClient hero, Vector3 start, Vector3 end, float endTime)
        {
            UniqueId = uniqueId;
            Hero = hero;
            Start = start;
            End = end;
            EndTime = endTime;
        }

        public float EndTime { get; set; }
        public string UniqueId { get; set; }
        public AIHeroClient Hero { get; private set; }
        public Vector3 Start { get; private set; }
        public Vector3 End { get; private set; }
    }
}