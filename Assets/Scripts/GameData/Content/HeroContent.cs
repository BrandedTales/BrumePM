﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BT.Events;
using BT.Variables;

namespace BT.Brume
{
    [CreateAssetMenu(menuName ="Heroes/Content")]
    public class HeroContent : ScriptableObject
    {
        public string heroName;
        public string flavor;

        public Sprite cardImage;

        public List<Trait> traits;


    }
}