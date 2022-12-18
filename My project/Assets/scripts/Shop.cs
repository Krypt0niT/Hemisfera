using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shop : MonoBehaviour
{
    manager managerVariables;
    public class PlayerShop
    {
        //=== start ===//
        public bool startBool = true;

        //=== damage ===//
        public bool[] damageBool = new bool[5] { false, false, false, false, false };
        public string[] damageName = new string[5] {"Damage I", "Damage II", "Damage III", "Damage IV", "Damage V"};
        public string[] damageDescription = new string[5] { "Drill damage + 10", "Drill damage + 40", "Drill damage + 120", "Drill damage + 300", "Drill damage + 800" };
        public string[] damageCost = new string[5] { "Stone:5, , ", "Stone:10,RawIron:6, ", "Iron:10,RawGold:5, ", "Iron:15,Gold:10,Diamond:6", "Gold:20,Diamond:10,Chunkerium:3" };

        //=== speed ===//
        public bool[] speedBool = new bool[5] { false, false, false, false, false };
        public string[] speedName = new string[5] { "Speed I", "Speed II", "Speed III", "Speed IV", "Speed V" };
        public string[] speedDescription = new string[5] { "Player speed + 3", "Player speed + 5", "Player speed + 8", "Player speed + 12", "Player speed + 16" };
        public string[] speedCost = new string[5] { "Stone:5, , ", "Stone:10,RawIron:6, ", "Iron:10,RawGold:5, ", "Iron:15,Gold:10,Diamond:6", "Gold:20,Diamond:10,Chunkerium:3" };

        //=== hardness ===//
        public bool[] hardnessBool = new bool[4] { false, false, false, false};
        public string[] hardnessName = new string[4] { "Damage I", "Damage II", "Damage III", "Damage IV"};
        public string[] hardnessDescription = new string[4] { "Drill damage + 10", "Drill damage + 40", "Drill damage + 120", "Drill damage + 300"};
        public string[] hardnessCost = new string[4] { "Stone:5, , ", "Stone:10,RawIron:6, ", "Iron:10,RawGold:5, ", "Iron:15,Gold:10,Diamond:6"};

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
