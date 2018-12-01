using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelFinished : MonoBehaviour {

    void OnTriggerStay(Collider other)
    {
        LevelControlScript.instance.youWin ();
	  }

}
