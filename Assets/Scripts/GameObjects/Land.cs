using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BT.Events;
using BT.Variables;

namespace BT.Brume
{
    public class Land
    {
        public static float VARIANCE = 0.20f;
        public static float POP_ADJUST = 10;

        public string landName;
        public string flavor;
        public Sprite cardImage;

        public bool isHomeland;
        public bool isDiscovered = false;

        public float population;
        public float goldIncome;
        public float materialIncome;
        public float manaIncome;

        public float morale;

        public Land (LandContent lc)
        {
            landName = lc.landName;
            flavor = lc.flavor;
            cardImage = lc.cardImage;


            isHomeland = lc.isHomeland;
            population = StartingPopulation(lc.startingPopulation);
            goldIncome = lc.goldIncome;
            materialIncome = lc.materialIncome;
            manaIncome = lc.manaIncome;
        }


        public float StartingPopulation(float startingPopulation)
        {
            return Mathf.RoundToInt(Random.Range(startingPopulation * (1 - VARIANCE), startingPopulation * (1 + VARIANCE)));
        }

        public void AdjustPopulation()
        {
            var tempPopAdjust = Mathf.RoundToInt(Random.Range(POP_ADJUST * (1 - VARIANCE), POP_ADJUST * (1 + VARIANCE)));
            population += tempPopAdjust;
        }

    }
}