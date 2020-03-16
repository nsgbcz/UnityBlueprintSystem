﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace Toodles.Core.Adapters.Triggers2D
{
    public class TriggerEnter2DAdapter : Trigger2DAdapterBase<ITriggerEnter2D>
    {
        protected override bool Action(Collider2D coll)
        {
            return Value.OnTriggerEnter2D(coll);
        }
    }
}
