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
        public string landName;
        public string flavor;

        public Sprite cardImage;

        public bool isHomeland;
    }
}