using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BT.Variables;
using BT.Events;

namespace BT.Brume.Managers
{
    public class TurnManager : MonoBehaviour
    {

        [SerializeField] FloatReference turnCounter;

        public void IncrementTurn()
        {
            turnCounter.SetValue(turnCounter + 1);
        }

        public void ResetTurn()
        {
            turnCounter.SetValue(1);
        }

    }
}