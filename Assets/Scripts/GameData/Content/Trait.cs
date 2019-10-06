using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BT.Events;
using BT.Variables;

namespace BT.Brume
{
    [CreateAssetMenu(menuName ="Cards/Trait")]
    public class Trait : ScriptableObject
    {
        public enum TypeLimit { Any, Unit, Hero, Land }

        public string traitName;
        public string flavor;

        public TypeLimit typeLimit;

        public Sprite tokenImage;



    }
}