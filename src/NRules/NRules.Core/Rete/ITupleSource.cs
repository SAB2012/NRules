﻿namespace NRules.Core.Rete
{
    internal interface ITupleSource
    {
        void Attach(ITupleMemory sink);
    }
}