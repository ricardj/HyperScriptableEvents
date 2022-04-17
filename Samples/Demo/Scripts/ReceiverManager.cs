using UnityEngine;

public class ReceiverManager : MonoBehaviour
{
     [Header("Listens to")]
    public EmptyEventSO startGame;
    public StringEventSO setPlayerName;
    public BoolEventSO onGameFinished;

    public void OnEnable()
    {
        startGame.AddListener(StartGame);
        setPlayerName.AddListener(SetName);
        onGameFinished.AddListener(EndGame);
    }

    public void OnDisable()
    {
        startGame.RemoveListener(StartGame);
        setPlayerName.RemoveListener(SetName);
        onGameFinished.RemoveListener(EndGame);
    }

    public void StartGame()
    {
        Debug.Log("Game started");
    }

    public void SetName(string name)
    {
        Debug.Log("Players name is " + name);
    }

    public void EndGame(bool win)
    {
        Debug.Log("Game has finished with result : " + win.ToString());
    }
}
