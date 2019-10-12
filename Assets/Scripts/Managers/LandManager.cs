using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BT.Variables;
using BT.Events;
using BT.Brume;
using System;

namespace BT.Brume.Managers
{
    public class LandManager : MonoBehaviour
    {

        ActivePiece activePiece;

        [Header("Components")]
        [SerializeField] LandDisplay landPrefab;
        [SerializeField] GameObject landSpace;
        [SerializeField] LandIndex landIndex;

        [Header("ZoneContent")]
        [SerializeField] ZoneContent villageZone;
        [SerializeField] ZoneContent ruinZone;
        [SerializeField] ZoneContent forestZone;
        [SerializeField] ZoneContent mountainZone;


        //[Header("Attributes")]
        public void Awake()
        {
            activePiece = FindObjectOfType<ActivePiece>();

            if (activePiece != null)
            {
                Debug.Log("Setting active piece controllers");
                return;
            }
        }

        public void SetupLand()
        {
            var randomLand = new Land(landIndex.RandomLand());
            Debug.Log(randomLand.landName + " has been created.");
            AddNewLand(randomLand);

        }

        public void AddNewLand(Land randomLand)
        {
            LandDisplay newLand = Instantiate(landPrefab, landSpace.transform);
            newLand.land = randomLand;
            AddZoneObject(newLand, villageZone);
            Debug.Log("Display: " + newLand.land.landName);
            activePiece.activeLand = newLand;
        }

        public void TEST_AddNewLand()
        {
            AddNewLand(new Land(landIndex.RandomLand()));
        }

        

        public void AddZoneObject(LandDisplay landDisplay, ZoneContent zc)
        {
            var zone = new Zone(zc);
            ZoneDisplay newZone = Instantiate(landDisplay.zoneDisplay, landDisplay.zonePanel.transform);
            landDisplay.land.AddZone(zone);
            newZone.zone = zone;

        }

        public void SpawnZone()
        {
            List<ZoneContent> possibleZones = new List<ZoneContent>();

            for (int i=0;i<activePiece.activeLand.land.villageCount;i++) { possibleZones.Add(villageZone); }
            for (int i = 0; i < activePiece.activeLand.land.ruinCount; i++) { possibleZones.Add(ruinZone); }
            for (int i = 0; i < activePiece.activeLand.land.mountainCount; i++) { possibleZones.Add(mountainZone); }
            for (int i = 0; i < activePiece.activeLand.land.forestCount; i++) { possibleZones.Add(forestZone); }

            ZoneContent newZone = possibleZones[UnityEngine.Random.Range(0, possibleZones.Count)];

            AddZoneObject(activePiece.activeLand, newZone);

        }
    }
}