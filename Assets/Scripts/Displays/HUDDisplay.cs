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
        [Header("Values")]
        [SerializeField] FloatReference turnNumber;
        [SerializeField] FloatReference populationNumber;
        [SerializeField] FloatReference goldNumber;
        [SerializeField] FloatReference materialNumber;
        [SerializeField] GameEvent NextTurn;

        [Header("UI Hookups")]
        [SerializeField] TextMeshProUGUI TurnNumberTMP;
        [SerializeField] TextMeshProUGUI populationTMP;
        [SerializeField] TextMeshProUGUI goldTMP;
        [SerializeField] TextMeshProUGUI materialTMP;


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            RefreshTurnNumber();
            RefreshResources();
        }

        private void RefreshResources()
        {
            if (populationNumber != null)
            {
                populationTMP.text = populationNumber.ToString();
            }
            if (goldNumber != null)
            {
                goldTMP.text = goldNumber.ToString();
            }
            if (materialNumber != null)
            {
                materialTMP.text = materialNumber.ToString();
            }
        }

        private void RefreshTurnNumber()
        {
            if (turnNumber != null)
            {
                TurnNumberTMP.text = "Turn: " + turnNumber.ToString();
            }
        }

        public void NextTurnButton()
        {
            NextTurn.Raise();
        }


    }
}