using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BT.Events;
using BT.Variables;

namespace BT.Brume
{
    [CreateAssetMenu(menuName = "Zone/Content")]
    public class ZoneContent : ScriptableObject
    {
        [Header("Display Content")]
        public string zoneName;
        public string flavor;
        public Sprite tokenImage;

        [Header("Mechanics")]
        public float maxPopAdjustment;
        public float popGrowthAdjustment;
        public float goldAdjustment;
        public float materialAdjustment;

    }
}