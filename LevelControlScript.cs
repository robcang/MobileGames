using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelControlScript : MonoBehaviour {

    public static LevelControlScript instance = null;
    GameObject levelSign, gameOverText, youWinText;
    int sceneIndex, levelPassed;

	void Start () {

        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        levelSign = GameObject.Find ("LevelNumber");
        gameOverText = GameObject.Find ("GameOver");
        youWinText = GameObject.Find ("YouWin");
        gameOverText.gameObject.SetActive (false);
        youWinText.gameObject.SetActive (false);

        sceneIndex = SceneManager.GetActiveScene ().buildIndex;
        levelPassed = PlayerPrefs.GetInt ("LevelPassed");

    }

	public void youWin() {

        int nextScene = sceneIndex + 1;

        if (nextScene == null)
            Invoke ("loadMainMenu", .2f);
        else
        {
            if (levelPassed < sceneIndex)
                PlayerPrefs.SetInt ("LevelPassed", sceneIndex);
                levelSign.gameObject.SetActive (false);
                youWinText.gameObject.SetActive (true);
                Invoke ("loadNextLevel", .2f);
        }
	}

    public void youLose() {

        levelSign.gameObject.SetActive (false);
        gameOverText.gameObject.SetActive (true);
        Invoke ("loadMainMenu", .2f);

    }

    void loadNextLevel() {

        SceneManager.LoadScene(sceneIndex + 1);

    }

    void loadMainMenu() {

        SceneManager.LoadScene ("Menu");

    }



}
