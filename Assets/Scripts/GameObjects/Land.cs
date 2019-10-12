using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BT.Events;
using BT.Variables;

namespace BT.Brume
{
    public class Land
    {
        public static float VARIANCE = 0.10f;
        public static float POP_ADJUST = 0.05f;

        public string landName;
        public string flavor;
        public Sprite cardImage;

        public bool isHomeland;
        public bool isDiscovered = false;

        public float population;
        public float maxPopulation;
        public float goldIncome;
        public float materialIncome;
        public float manaIncome;

        public int villageCount;
        public int ruinCount;
        public int forestCount;
        public int mountainCount;

        public List<Zone> zones;


        public Land (LandContent lc)
        {
            landName = lc.landName;
            flavor = lc.flavor;
            cardImage = lc.cardImage;

            zones = new List<Zone>();

            isHomeland = lc.isHomeland;
            population = StartingPopulation(lc.startingPopulation);
            goldIncome = lc.goldIncome;
            materialIncome = lc.materialIncome;
            manaIncome = lc.manaIncome;
            maxPopulation = lc.maxPopulation;

            villageCount = lc.villageCount;
            ruinCount = lc.ruinCount;
            forestCount = lc.forestCount;
            mountainCount = lc.mountainCount;
        }


        public float StartingPopulation(float startingPopulation)
        {
            return Mathf.RoundToInt(Random.Range(startingPopulation * (1 - VARIANCE), startingPopulation * (1 + VARIANCE)));
        }

        public void AdjustPopulation(float morale)
        {
            //Base Adjustment
            float populationAdjustment = POP_ADJUST * maxPopulation;
            Debug.Log("Base adjustment: " + populationAdjustment);
            //Modified by Current Population
            populationAdjustment *= (1 - (population / maxPopulation));
            Debug.Log("Current Population: " + populationAdjustment + " / " + maxPopulation);
            //Modify by Morale
            populationAdjustment *= morale;
            Debug.Log("Morale: " + populationAdjustment);

            //TODO:  Modify by other adjustments once I come up with them (zones, governer, hero tasks, threats, events, etc)

            //And Randomize!
            populationAdjustment *= Random.Range((1 - VARIANCE), (1 + VARIANCE));
            Debug.Log("Randomized: " + populationAdjustment);


            //Great!  Now update it!
            population += (Mathf.RoundToInt(populationAdjustment));
            Debug.Log("New pop: " + population);
        }

        public void AddZone(Zone zone)
        {
            zones.Add(zone);
        }

    }
}