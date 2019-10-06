using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BT.Events;
using BT.Variables;

namespace BT.Brume
{
    public class Hero
    {
        public string heroName;
        public string flavor;

        public Sprite cardImage;



        public Hero (HeroContent hc)
        {
            heroName = hc.heroName;
            flavor = hc.flavor;
            cardImage = hc.cardImage;

        }

    }
}