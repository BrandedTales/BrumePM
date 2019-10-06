using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.Brume
{
    [CreateAssetMenu(menuName = "Cards/TraitIndex")]
    public class TraitIndex : ScriptableObject
    {
        public List<Trait> traitList;

    }
}