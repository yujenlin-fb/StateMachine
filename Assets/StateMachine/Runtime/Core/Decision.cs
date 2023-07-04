using System;
using UnityEngine;

namespace YJL.Fsm
{
    public abstract class Decision : ScriptableObject
    {
        public abstract bool Decide(StateMachine stateMachine);
    }
}