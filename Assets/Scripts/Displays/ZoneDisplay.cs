using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using BT.Events;
using BT.Variables;
using System;

namespace BT.Brume
{
    public class ZoneDisplay : MonoBehaviour
    {
        public Zone zone;

        [SerializeField] Image tokenImage;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            tokenImage.sprite = zone.tokenImage;
        }
    }
}