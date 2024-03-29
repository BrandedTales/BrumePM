﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BT.Brume;
using BT.Variables;
using BT.Events;
using System;

namespace BT.Brume.Managers
{
    public class SetupManager : MonoBehaviour
    {

        [SerializeField] GameEvent setupGame;

        [SerializeField] List<HeroContent> heroList;
        [SerializeField] HeroIndex heroIndex;

        [SerializeField] List<LandContent> landList;
        [SerializeField] LandIndex landIndex;

        // Start is called before the first frame update
        void Start()
        {
            InitializeIndexes();
            setupGame.Raise();
        }

        private void InitializeIndexes()
        {
            heroIndex.heroList.Clear();
            foreach (HeroContent hc in heroList)
            {
                heroIndex.heroList.Add(hc);
            }

            landIndex.landList.Clear();
            foreach (LandContent lc in landList)
            {
                landIndex.landList.Add(lc);
            }
        }

    }
}