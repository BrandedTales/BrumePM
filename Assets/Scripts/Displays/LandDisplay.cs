using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using BT.Events;
using BT.Variables;

namespace BT.Brume
{
    public class LandDisplay : MonoBehaviour
    {

        [SerializeField] TextMeshProUGUI landName;
        [SerializeField] Image portrait;

        public Land land;

        // Use this for initialization
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            if (land != null)
            {
                landName.text = land.landName;
                portrait.sprite = land.cardImage;
            }
        }
    }
}