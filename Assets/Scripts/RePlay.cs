using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RePlay : MonoBehaviour
{

    [SerializeField]
    private int LVL;

    private void OnMouseUp()
    {
        
        SceneManager.LoadScene("Level" + LVL);
        MouseController.isRightMove = true;

        DragDrop.GameStarted = false;
        MouseController.IsMovingMouse = false;
        StartGame.GameStarted = false;
    }

}
