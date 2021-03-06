﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace Toodles.Core.Adapters
{
    public class BaseAdapter<T> : IExecuteAdapter
    {
        [SerializeField, HideLabel]
        public T Value;
    }
}