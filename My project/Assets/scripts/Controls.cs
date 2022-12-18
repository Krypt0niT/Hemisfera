using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public KeyCode PlayerRightKey = KeyCode.D;
    public KeyCode PlayerLeftKey = KeyCode.A;
    public KeyCode PlayerUseKey = KeyCode.E;
    public KeyCode PlayerAttackKey = KeyCode.Mouse0;
    public KeyCode PlayerRightArrowKey = KeyCode.RightArrow;
    public KeyCode PlayerLeftArrowKey = KeyCode.LeftArrow;

    public bool PlayerRight;
    public bool PlayerLeft;
    public bool PlayerUse;
    public bool PlayerUse2;
    public float PlayerUseTime = 0f;
    public bool PlayerAttack;
    public bool PlayerRightArrow;
    public bool PlayerLeftArrow;

    private void Update()
    {
        PlayerAttack = Input.GetKey(PlayerAttackKey);
        PlayerRight = Input.GetKey(PlayerRightKey) && !PlayerAttack;
        PlayerLeft = Input.GetKey(PlayerLeftKey) && !PlayerAttack;
        PlayerUse2 = Input.GetKey(PlayerUseKey);
        PlayerUseTime += Time.deltaTime;
        PlayerLeftArrow = Input.GetKey(PlayerLeftArrowKey);
        PlayerRightArrow = Input.GetKey(PlayerRightArrowKey);
    }

    private void FixedUpdate()
    {
        if(PlayerUseTime > 1f && PlayerUse2)
        {
            PlayerUse = true;
            PlayerUseTime = 0f;
        }
        else PlayerUse = false;
    }
}
