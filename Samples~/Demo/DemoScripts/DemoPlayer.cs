using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoPlayer : MonoBehaviour
{
    public HyperChannelSO playerDie;
    public HyperChannelSO playerStart;
    public HyperChannelSO playerJump;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            playerJump.RaiseEvent();
        if (Input.GetKeyDown(KeyCode.D))
            playerDie.RaiseEvent();
        if (Input.GetKeyDown(KeyCode.S))
            playerStart.RaiseEvent();
    }
}
