using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DemoTextConfigurer : MonoBehaviour
{
    public Text text;

    public HyperChannelSO showJumping;
    public HyperChannelSO showStarting;
    public HyperChannelSO showDying;

    public void Start()
    {
        showDying.OnEventRaised += () => ConfigureText("The player is dying");
        showJumping.OnEventRaised += () => ConfigureText("The player is jumping");
        showStarting.OnEventRaised += () => ConfigureText("The player is starting");


    }

    public void ConfigureText(string configurableText)
    {
        text.text = configurableText;
    }
}
