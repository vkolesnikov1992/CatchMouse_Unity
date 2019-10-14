using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{

    [SerializeField]
    private GameObject platform;
    [SerializeField]
    private GameObject Box;
    [SerializeField]
    private GameObject Fan;
    [SerializeField]
    private GameObject Switch;
    [SerializeField]
    private GameObject Spring;
    [SerializeField]
    private GameObject StartGameButton;
    public static bool GameStarted = false;

    private void OnMouseUp()
    {
        Destroy(platform);
        Destroy(StartGameButton);
        if(Box != null)
        {
            Destroy(Box);
        }

        if (Fan != null)
        {
            Destroy(Fan);
        }

        if (Switch != null)
        {
            Destroy(Switch);
        }

        if (Spring != null)
        {
            Destroy(Spring);
        }

        DragDrop.GameStarted = true;
        GameStarted = true;

    }
}
