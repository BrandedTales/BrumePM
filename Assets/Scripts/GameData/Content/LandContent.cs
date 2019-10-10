using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BT.Events;
using BT.Variables;

namespace BT.Brume
{
    [CreateAssetMenu(menuName = "Land/Content")]
    public class LandContent : ScriptableObject
    {
        [Header("Display Content")]
        public string landName;
        public string flavor;
        public Sprite cardImage;

        [Header("Mechanics")]
        public bool isHomeland;
        public float startingPopulation;
        public float maxPopulation;
        public float goldIncome;
        public float materialIncome;
        public float manaIncome;


        //This section has been hardcoded for the zone types, but I'd love this to be popualted 
        //dynamically from a list to allow adding new zone types easily.
        [Header("Zones")]
        public int villageCount;
        public int ruinCount;
        public int forestCount;
        public int mountainCount;
    }
}