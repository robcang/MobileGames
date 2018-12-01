using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scoreCollisionTracker : MonoBehaviour
{

    public Text countText;
    public Text highScoreText;

    private int count;
    private int highScore = 0;
    private Collider2D setteract;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("highscore", 0);
        setHighScoreText();
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        setteract = other;
        if (other.tag == "Blue 1")
        {
            count = count + 1;
            SetCountText();
        }
        else if (other.tag == "Yellow 1")
        {
            count = count + 1;
            SetCountText();
        }
        else if (other.tag == "Red 1")
        {
            count = count + 1;
            SetCountText();
        }
        else if (other.tag == "Green 1")
        {
            count = count + 1;
            SetCountText();
        }
        else if (other.tag == "Blue 2")
        {
            count = count + 2;
            SetCountText();
        }
        else if (other.tag == "Yellow 2")
        {
            count = count + 2;
            SetCountText();
        }
        else if (other.tag == "Red 2")
        {
            count = count + 2;
            SetCountText();
        }
        else if (other.tag == "Green 2")
        {
            count = count + 2;
            SetCountText();
        }
        else if (other.tag == "Blue 3")
        {
            count = count + 3;
            SetCountText();
        }
        else if (other.tag == "Yellow 3")
        {
            count = count + 3;
            SetCountText();
        }
        else if (other.tag == "Red 3")
        {
            count = count + 3;
            SetCountText();
        }
        else if (other.tag == "Green 3")
        {
            count = count + 3;
            SetCountText();
        }
        else if (other.tag == "Blue 4")
        {
            count = count + 4;
            SetCountText();
        }
        else if (other.tag == "Yellow 4")
        {
            count = count + 4;
            SetCountText();
        }
        else if (other.tag == "Red 4")
        {
            count = count + 4;
            SetCountText();
        }
        else if (other.tag == "Green 4")
        {
            count = count + 4;
            SetCountText();
        }
        else if (other.tag == "Blue 5")
        {
            count = count + 5;
            SetCountText();
        }
        else if (other.tag == "Yellow 5")
        {
            count = count + 5;
            SetCountText();
        }
        else if (other.tag == "Red 5")
        {
            count = count + 5;
            SetCountText();
        }
        else if (other.tag == "Green 5")
        {
            count = count + 5;
            SetCountText();
        }
        else if (other.tag == "ColorChanger")
        {
            return;
        }
        Invoke("setFalse", 0.1f);
    }


    void Update()
    {
        if (count > highScore)
        {
            highScore = count;
            setHighScoreText();
            PlayerPrefs.SetInt("highscore", highScore);
        }
    }

    void SetCountText()
    {
        countText.text = count.ToString();
    }

    void setHighScoreText()
    {
        highScoreText.text = highScore.ToString();
    }



    void setFalse()
    {
        setteract.gameObject.SetActive(false);
    }
}
