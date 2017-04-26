using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour {

	public void NewGameBtn (string newGameLevel)
    {

        SceneManager.LoadScene(newGameLevel);

    }

    public void ExitGameButton() {
        Application.Quit();
    }
        
}
