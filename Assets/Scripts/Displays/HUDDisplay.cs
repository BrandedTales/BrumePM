using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using BT.Variables;
using BT.Events;

namespace BT.Brume
{
    public class HUDDisplay : MonoBehaviour
    {

        [SerializeField] FloatReference turnNumber;
        [SerializeField] TextMeshProUGUI tmpTurnNumber;

        [SerializeField] GameEvent NextTurn;


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            RefreshTurnNumber();
        }

        private void RefreshTurnNumber()
        {
            if (turnNumber != null)
            {
                tmpTurnNumber.text = "Turn: " + turnNumber.ToString();
            }
        }

        public void NextTurnButton()
        {
            NextTurn.Raise();
        }


    }
}