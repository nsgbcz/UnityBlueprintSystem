﻿using UnityEngine;
using Toodles.Mono;
using Sirenix.OdinInspector;

namespace Toodles.Mono
{
    public struct IterateThroughFrames : IIteratable
    {
        [SerializeField, Required]
        IIteratable iterate;
        [SerializeField, Required]
        IGet<int> delay;

        bool executed;
        public bool Iterate()
        {
            if (!executed)
            {
                FrameEventHandler.ExecuteThroughFrames(Action, delay.Value);
            }
            return executed;
        }

        void Action()
        {
            if (!executed) executed = iterate.Iterate();
        }
    }
}
