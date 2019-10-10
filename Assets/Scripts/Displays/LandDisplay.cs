﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using BT.Events;
using BT.Variables;
using System;

namespace BT.Brume
{
    public class LandDisplay : MonoBehaviour
    {
        [Header("UI Hookups")]
        [SerializeField] TextMeshProUGUI landName;
        [SerializeField] Image portrait;
        [SerializeField] TextMeshProUGUI populationTMP;
        [SerializeField] TextMeshProUGUI goldTMP;
        [SerializeField] TextMeshProUGUI materialTMP;

        [Header("Zone Hookups")]
        [SerializeField] ZoneDisplay zoneDisplay;
        [SerializeField] GameObject zonePanel;


        public Land land;

        // Use this for initialization
        void Start()
        {          
        }

        // Update is called once per frame
        void Update()
        {
            if (land != null)
            {
                landName.text = land.landName;
                portrait.sprite = land.cardImage;
                populationTMP.text = land.population.ToString();
                goldTMP.text = land.goldIncome.ToString();
                materialTMP.text = land.materialIncome.ToString();

                if (land.goldIncome < 0)
                {
                    goldTMP.color = Color.red;
                }

                if (land.materialIncome < 0)
                {
                    materialTMP.color = Color.red;
                }

            }


        }

        public void AddZoneObject(ZoneContent zc)
        {
            var zone = new Zone(zc);
            ZoneDisplay newZone = Instantiate(zoneDisplay, zonePanel.transform);
            land.AddZone(zone);  //I really don't like this since I try to avoid having the Displays do any business logic.
            newZone.zone = zone;

        }
    }
}