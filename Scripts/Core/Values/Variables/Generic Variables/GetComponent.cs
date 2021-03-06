﻿using UnityEngine;
using Sirenix.OdinInspector;

namespace Toodles
{
    public class GetComponent<T> : IGet<T>
    {
        [SerializeField, Required, HideLabel]
        IGet<GameObject> value;
        public T Value => value.Value.GetComponent<T>();
    }
}
