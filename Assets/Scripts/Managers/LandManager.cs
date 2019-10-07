﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BT.Variables;
using BT.Events;
using BT.Brume;
using System;

namespace BT.Brume.Managers
{
    public class LandManager : MonoBehaviour
    {
        [SerializeField] LandDisplay landDisplay;
        [SerializeField] GameObject landSpace;
        [SerializeField] LandIndex landIndex;

        public void SetupLand()
        {
            var randomLand = new Land(landIndex.RandomLand());
            Debug.Log(randomLand.landName + " has been created.");
            AddNewLand(randomLand);

        }

        public void AddNewLand(Land randomLand)
        {
            LandDisplay newLand = Instantiate(landDisplay, landSpace.transform);
            newLand.land = randomLand;
            Debug.Log("Display: " + newLand.land.landName);
        }
    }
}