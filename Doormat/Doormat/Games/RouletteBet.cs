﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DoormatCore.Sites;

namespace DoormatCore.Games
{
    [MoonSharp.Interpreter.MoonSharpUserData]
    public class RouletteBet : Bet
    {
        public override PlaceBet CreateRetry()
        {
            throw new NotImplementedException();
        }

        public override bool GetWin(BaseSite Site)
        {
            throw new NotImplementedException();
        }
    }

    [MoonSharp.Interpreter.MoonSharpUserData]
    public class PlaceRouletteBet:PlaceBet
    {

    }

    public interface iRoulette
    {
        Task PlaceRouletteBet(PlaceRouletteBet BetDetails);
    }
}
