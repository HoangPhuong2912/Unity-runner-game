using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void GameStart()
    {
        Time.timeScale = 1;

        GameEvents.instance.gameStarted.SetValueAndForceNotify(true);
    }
}