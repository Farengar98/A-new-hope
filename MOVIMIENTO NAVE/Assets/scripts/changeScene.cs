using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour {

	public void NewGameBtn (int newGameLevel)
    {

        SceneManager.LoadScene(newGameLevel);
    }

    public void ExitGameButton() {
        Application.Quit();
    }
        
}
