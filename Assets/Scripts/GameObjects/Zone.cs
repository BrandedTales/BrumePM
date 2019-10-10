using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BT.Events;
using BT.Variables;
using System;

namespace BT.Brume
{
    public class Zone
    {

        public string zoneName;
        public string flavor;

        public Sprite tokenImage;



        public Zone(ZoneContent zc)
        {
            zoneName = zc.zoneName;
            flavor = zc.flavor;
            tokenImage = zc.tokenImage;

        }

    }
}