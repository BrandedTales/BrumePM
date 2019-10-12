using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BT.Variables;
using BT.Events;
using BT.Brume;
using System;

namespace BT.Brume
{
    public class ActivePiece : MonoBehaviour
    {
        public enum ActiveType { Land, Hero }

        public ActiveType activeType;

        public LandDisplay activeLand;
        public HeroDisplay activeHero;
    }
}