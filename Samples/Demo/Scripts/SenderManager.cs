using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SenderManager : MonoBehaviour
{
    [Header("Broadcasts to")]
    public EmptyEventSO startGame;
    public StringEventSO setPlayerName;
    public BoolEventSO onGameFinished;

    public void StartGame()
    {
        startGame.RaiseEvent();
    }

    public void SetPlayerName()
    {
        setPlayerName.RaiseEvent("Johnathan");
    }

    public void FinishGame()
    {
        onGameFinished.RaiseEvent(true);
    }
}
