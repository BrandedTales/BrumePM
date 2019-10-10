using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BT.Variables;
using BT.Events;
using BT.Brume;
using System;

namespace BT.Brume.Managers
{
    public class ResourceManager : MonoBehaviour
    {
        [SerializeField] FloatReference population;
        [SerializeField] FloatReference gold;
        [SerializeField] FloatReference material;
        [SerializeField] FloatReference morale;

        [SerializeField] GameObject landPanel;

        public void ResetResources()
        {
            population.SetValue(0);
            gold.SetValue(0);
            material.SetValue(0);
        }


        public void UpdateResources()
        {
            population.SetValue(0);

            foreach (Transform child in landPanel.transform)
            {
                LandDisplay lc = child.GetComponent<LandDisplay>();
                if (lc == null) continue;

                lc.land.AdjustPopulation(morale);
                population.SetValue(population + lc.land.population);

                gold.SetValue(gold + lc.land.goldIncome);
                material.SetValue(material + lc.land.materialIncome);

            }
        }

    }
}