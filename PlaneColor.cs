using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaneColor : MonoBehaviour {

  public TextMesh numberText;
  public GameObject Plane;
  public SpriteRenderer rend;
  public string currentColor;
  public Color colorBlue;
  public Color colorYellow;
  public Color colorRed;
  public Color colorGreen;
  public Color colorChange;

  void Start () {

        setRandomColor();

  }



  void setRandomColor () {

      int index = Random.Range(0, 20);

      switch (index)
      {
          case 0:
          rend.tag = "Blue 1";
          numberText.text = "1";
          currentColor = "Blue";
          rend.color = colorBlue;
          break;
          case 1:
          currentColor = "Yellow";
          rend.tag = "Yellow 1";
          numberText.text = "1";
          rend.color = colorYellow;
          break;
          case 2:
          currentColor = "Red";
          numberText.text = "1";
          rend.tag = "Red 1";
          rend.color = colorRed;
          break;
          case 3:
          currentColor = "Green";
          numberText.text = "1";
          rend.tag = "Green 1";
          rend.color = colorGreen;
          break;
          case 4:
          rend.tag = "Blue 2";
          numberText.text = "2";
          currentColor = "Blue";
          rend.color = colorBlue;
          break;
          case 5:
          currentColor = "Yellow";
          numberText.text = "2";
          rend.tag = "Yellow 2";
          rend.color = colorYellow;
          break;
          case 6:
          currentColor = "Red";
          numberText.text = "2";
          rend.tag = "Red 2";
          rend.color = colorRed;
          break;
          case 7:
          currentColor = "Green";
          numberText.text = "2";
          rend.tag = "Green 2";
          rend.color = colorGreen;
          break;
          case 8:
          rend.tag = "Blue 3";
          numberText.text = "3";
          currentColor = "Blue";
          rend.color = colorBlue;
          break;
          case 9:
          currentColor = "Yellow";
          numberText.text = "3";
          rend.tag = "Yellow 3";
          rend.color = colorYellow;
          break;
          case 10:
          currentColor = "Red";
          numberText.text = "3";
          rend.tag = "Red 3";
          rend.color = colorRed;
          break;
          case 11:
          currentColor = "Green";
          numberText.text = "3";
          rend.tag = "Green 3";
          rend.color = colorGreen;
          break;
          case 12:
          rend.tag = "Blue 4";
          numberText.text = "4";
          currentColor = "Blue";
          rend.color = colorBlue;
          break;
          case 13:
          currentColor = "Yellow";
          numberText.text = "4";
          rend.tag = "Yellow 4";
          rend.color = colorYellow;
          break;
          case 14:
          currentColor = "Red";
          numberText.text = "4";
          rend.tag = "Red 4";
          rend.color = colorRed;
          break;
          case 15:
          currentColor = "Green";
          numberText.text = "4";
          rend.tag = "Green 4";
          rend.color = colorGreen;
          break;
          case 16:
          rend.tag = "Blue 5";
          numberText.text = "5";
          currentColor = "Blue";
          rend.color = colorBlue;
          break;
          case 17:
          currentColor = "Yellow";
          numberText.text = "5";
          rend.tag = "Yellow 5";
          rend.color = colorYellow;
          break;
          case 18:
          currentColor = "Red";
          numberText.text = "5";
          rend.tag = "Red 5";
          rend.color = colorRed;
          break;
          case 19:
          currentColor = "Green";
          numberText.text = "5";
          rend.tag = "Green 5";
          rend.color = colorGreen;
          break;
          case 20:
          currentColor = "ColorChanger";
          numberText.text = "Color Change";
          rend.tag = "ColorChanger";
          rend.color = colorChange;
          break;
          case 21:
          currentColor = "ColorChanger";
          numberText.text = "Color Change";
          rend.tag = "ColorChanger";
          rend.color = colorChange;
          break;
      }

    }
    
}
