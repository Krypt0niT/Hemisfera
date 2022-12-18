using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Shop : MonoBehaviour
{
    manager managerVariables;
    public TextMeshProUGUI Name;
    public TextMeshProUGUI Description;
    public GameObject Cost0;
    public GameObject Cost1;
    public GameObject Cost2;
    public class PlayerShop
    {
        //===== PLAYER =====//
        public bool startBool = true;

        //=== damage ===//
        public bool[] damageBool = new bool[5] { false, false, false, false, false };
        public string[] damageName = new string[5] {"Damage I", "Damage II", "Damage III", "Damage IV", "Damage V"};
        public string[] damageDescription = new string[5] { "Drill damage + 10", "Drill damage + 40", "Drill damage + 120", "Drill damage + 300", "Drill damage + 800" };
        public string[] damageCost = new string[5] { "0:5, , ", "0:10,1:6, ", "2:10,3:5, ", "2:15,4:10,5:6", "4:20,5:10,6:3" };

        //=== speed ===//
        public bool[] speedBool = new bool[5] { false, false, false, false, false };
        public string[] speedName = new string[5] { "Speed I", "Speed II", "Speed III", "Speed IV", "Speed V" };
        public string[] speedDescription = new string[5] { "Player speed + 3", "Player speed + 5", "Player speed + 8", "Player speed + 12", "Player speed + 16" };
        public string[] speedCost = new string[5] { "0:5, , ", "0:10,1:6, ", "2:10,3:5, ", "2:15,4:10,5:6", "4:20,5:10,6:3" };

        //=== hardness ===//
        public bool[] hardnessBool = new bool[4] { false, false, false, false};
        public string[] hardnessName = new string[4] { "Drill I", "Drill II", "Drill III", "Drill IV" };
        public string[] hardnessDescription = new string[4] { "Unlocks the ability to mine Iron", "Unlocks the ability to mine Gold", "Unlocks the ability to mine Diamond", "Unlocks the ability to mine Chunkerium" };
        public string[] hardnessCost = new string[4] { "0:10, , ", "0:20,2:6, ", "0:20,2:10,4:5", "2:20,4:15,5:5" };

        //===== BASE =====// ???????????????????????????????????? dole treba robit

        //=== shield ===//
        public bool[] shieldBool = new bool[5] { false, false, false, false, false };
        public string[] shieldName = new string[5] { "Shield I", "Shield II", "Shield III", "Shield IV", "Shield V" };
        public string[] shieldDescription = new string[5] { "Shield + 25", "Shield + 50", "Shield + 75", "Shield + 100", "Shield + 120" };
        public string[] shieldCost = new string[5] { "2:4,4:3 , ", "4:12,5:8,6:2 ", "5:12,6:10, ", "5:20,6:18, ", "5:30,6:25, " };

        //=== health ===//
        public bool[] healthBool = new bool[5] { false, false, false, false, false };
        public string[] healthName = new string[5] { "Speed I", "Speed II", "Speed III", "Speed IV", "Speed V" };
        public string[] healthDescription = new string[5] { "Max health + 150", "Max health + 250", "Max health + 500", "Max health + 750", "Max health + 1000" };
        public string[] healthCost = new string[5] { "2:6,3:5 , ", "2:15,4:12,5:8 ", "5:20,6:10, ", "5:30,6:20, ", "5:40,6:28, " };

        //=== repair ===// toto netreba
        public static int[] RepairCost = new int[] { 2, 1 };
        public string[] repairName = new string[1] { "Repair" };
        public string[] repairDescription = new string[1] { "Repairs base to 100%" };
        public string[] repairCost = new string[1] { "2:" + RepairCost[0].ToString() + ",4:" + RepairCost[0].ToString() + ", " };

        //===== Main weapon =====//

        //=== Damage ===//
        public bool[] MainDamageBool = new bool[5] { false, false, false, false, false };
        public string[] MainDamageName = new string[5] { "Damage I", "Damage II", "Damage III", "Damage IV", "Damage V" };
        public string[] MainDamageDescription = new string[5] { "Weapon damage + 2", "Weapon damage + 3", "Weapon damage + 7", "Weapon damage + 12", "Weapon damage + 20" };
        public string[] MainDamageCost = new string[5] { "2:10,3:5, ", "4:6,5:2, ", "4:10,5:5, ", "5:5,6:2, ", "5:10,6:6, " };

        //=== Speed ===//
        public bool[] MainSpeedBool = new bool[5] { false, false, false, false, false };
        public string[] MainSpeedName = new string[5] { "Speed I", "Speed II", "Speed III", "Speed IV", "Speed V" };
        public string[] MainSpeedDescription = new string[5] { "Weapon speed + 0.5 bullet per second", "Weapon speed + 1.0 bullet per second", "Weapon speed + 1.6 bullet per second", "Weapon speed + 2.5 bullet per second", "Weapon speed + 3.2 bullet per second" };
        public string[] MainSpeedCost = new string[5] { "1:10,3:5, ", "2:10,3:10, ", "4:10,5:5, ", "4:10,5:10,6:3", "5:15,6:10, " };

        //=== Accuracy ===//
        public bool[] MainAccuracyBool = new bool[1] { false };
        public string[] MainAccuracyName = new string[1] { "Accuracy" };
        public string[] MainAccuracyDescription = new string[1] { "Accuracy angle improved by 2.5" };
        public string[] MainAccuracyCost = new string[1] { "5:12,6:6, " };

        //===== Secondary weapons =====//
        //TODO: First weapon  RawGold: 8  Diamond: 2   {"3:8, 5:2,"}  |  {"Adds first secondary weapon"}
        //TODO: Second weapon  Gold: 10  Diamond: 5  Chunkerium: 1 {"4:10, 5:5, 6:1"} |  {"Adds second secondary weapon"}

        //=== Damage ===//
        public bool[] SecondaryDamageBool = new bool[5] { false, false, false, false, false };
        public string[] SecondaryDamageName = new string[5] { "Damage I", "Damage II", "Damage III", "Damage IV", "Damage V" };
        public string[] SecondaryDamageDescription = new string[5] { "Weapon damage + 2", "Weapon damage + 3", "DWeapon damage + 7", "Weapon damage + 12", "Weapon damage + 20" };
        public string[] SecondaryDamageCost = new string[5] { "1:10,3:5 , ", "4:6,5:2, ", "4:10,5:5, ", "5:5,6:2,", "5:10,6:6," };

        //=== Speed ===//
        public bool[] SecondarySpeedBool = new bool[5] { false, false, false, false, false };
        public string[] SecondarySpeedName = new string[5] { "Speed I", "Speed II", "Speed III", "Speed IV", "Speed V" };
        public string[] SecondarySpeedDescription = new string[5] { "Weapon speed + 1.0 bullet per second", "Weapon speed + 1.8 bullet per second", "Weapon speed + 2.6 bullet per second", "Weapon speed + 3.8 bullet per second", "Weapon speed + 6.0 bullet per second" };
        public string[] SecondarySpeedCost = new string[5] { "1:15, 3:8, ", "2:10, 3:10, ", "4:8,5:3, ", "4:15,5:8,6:2", "5:15,6:8," };

    }
    public PlayerShop playerShop = new PlayerShop();

    void Start()
    {
        managerVariables = GameObject.Find("Manager").GetComponent<manager>();
    }

    
    void Update()
    {
        
    }
}
