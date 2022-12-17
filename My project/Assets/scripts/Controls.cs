using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public KeyCode PlayerRightKey = KeyCode.D;
    public KeyCode PlayerLeftKey = KeyCode.A;
    public KeyCode PlayerUseKey = KeyCode.E;
    public KeyCode PlayerAttackKey = KeyCode.Mouse0;

    public bool PlayerRight;
    public bool PlayerLeft;
    public bool PlayerUse;
    public bool PlayerAttack;
    private void Update()
    {
        PlayerAttack = Input.GetKey(PlayerAttackKey);
        PlayerRight = Input.GetKey(PlayerRightKey) && !PlayerAttack;
        PlayerLeft = Input.GetKey(PlayerLeftKey) && !PlayerAttack;
        PlayerUse = Input.GetKeyDown(PlayerUseKey);
    }
}
