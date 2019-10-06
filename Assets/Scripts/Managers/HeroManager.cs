using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BT.Variables;
using BT.Events;
using BT.Brume;
using System;

namespace BT.Brume.Managers
{
    public class HeroManager : MonoBehaviour
    {
        [SerializeField] FloatReference initialHeroCount;
        [SerializeField] HeroDisplay heroDisplay;
        [SerializeField] GameObject heroSpace;
        [SerializeField] HeroIndex heroIndex;

        public void SetupHeroes()
        {
            for (int i=0;i<initialHeroCount;i++)
            {
                var randomHero = new Hero(heroIndex.RandomHero());
                Debug.Log(randomHero.heroName + " has been created.");
                AddNewHero(randomHero);
            }
        }

        public void AddNewHero(Hero randomHero)
        {
            HeroDisplay newHero = Instantiate(heroDisplay, heroSpace.transform);
            newHero.hero = randomHero;
            Debug.Log("Display: " + newHero.hero.heroName + " passed from " + randomHero.heroName);
        }
    }
}