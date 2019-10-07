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
        public float goldIncome;
        public float materialIncome;
        public float manaIncome;
    }
}