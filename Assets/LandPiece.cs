using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BT.Variables;
using BT.Events;
using BT.Brume;
using System;

namespace BT.Brume
{
    public class LandPiece : MonoBehaviour
    {
        ActivePiece activePiece;

        [SerializeField] GameEvent spawnZone;

        public void Start()
        {
            activePiece = FindObjectOfType<ActivePiece>();

            if (activePiece == null)
            {
                Debug.Log("No active piece controllers");
                return;
            }
        }


        public void Click()
        {
            activePiece.activeLand = GetComponent<LandDisplay>();
            activePiece.activeType = ActivePiece.ActiveType.Land;

            spawnZone.Raise();
        }

    }
}