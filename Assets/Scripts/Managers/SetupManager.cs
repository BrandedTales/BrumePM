using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BT.Brume;
using BT.Variables;
using BT.Events;
using System;

namespace BT.Brume.Managers
{
    public class SetupManager : MonoBehaviour
    {

        [SerializeField] GameEvent setupGame;

        // Start is called before the first frame update
        void Start()
        {
            setupGame.Raise();
        }

        
    }
}