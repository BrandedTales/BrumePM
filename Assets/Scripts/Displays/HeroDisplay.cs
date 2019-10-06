using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using BT.Events;
using BT.Variables;

namespace BT.Brume
{
    public class HeroDisplay : MonoBehaviour
    {

        [SerializeField] TextMeshProUGUI heroName;
        [SerializeField] Image portrait;

        public Hero hero;

        // Use this for initialization
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            if (hero != null)
            {
                heroName.text = hero.heroName;
                portrait.sprite = hero.cardImage;
            }
        }
    }
}