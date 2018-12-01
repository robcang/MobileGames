using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Renderer rend;
    public string currentColor;
    public Color colorBlue;
    public Color colorYellow;
    public Color colorRed;
    public Color colorGreen;

	void Start () {

        setRandomColor();
	}

	void OnTriggerEnter2D (Collider2D col) {

		if (col.tag == "ColorChanger")
        {
            setRandomColor();
            return;
        }

        if (col.tag[0] != currentColor[0])
        {
             Time.timeScale = 0.0f;
        }

        if (col.tag == currentColor+" 1" || col.tag == currentColor+" 2" || col.tag == currentColor+" 3" || col.tag == currentColor+" 4" || col.tag == currentColor+" 5")
        {
            setRandomColor();
            return;
        }


	}

    void setRandomColor () {

    int index = Random.Range(0, 4);

    switch (index)
    {
    case 0:
        currentColor = "Blue";
        rend.material.color = colorBlue;
        break;
    case 1:
        currentColor = "Yellow";
        rend.material.color = colorYellow;
        break;
    case 2:
        currentColor = "Red";
        rend.material.color = colorRed;
        break;
    case 3:
        currentColor = "Green";
        rend.material.color = colorGreen;
        break;
    }

  }

}
