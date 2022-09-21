using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ButtonManager : MonoBehaviour
{
                                    //Deklaration...
    public Button redButton;
    public Button greenButton;
    public Button blueButton;
    public Button switchButton;

    private bool redButtonClicked;
    private bool greenButtonClicked;
    private bool blueButtonClicked;


    void Start()
    {                                                                   //Einfärben der Buttons in die Ausgangsfarbe
        redButton.GetComponent<Image>().color = Color.red;
        greenButton.GetComponent<Image>().color = Color.green;
        blueButton.GetComponent<Image>().color = Color.blue;

        switchButton.interactable = false; //Den Weiter Button 'deaktivieren'...
    }

    public void ChangeRed()
    {
        redButton.GetComponent<Image>().color = Random.ColorHSV(); //Einfärben in eine beliebige Farbe
    }

    public void ChangeGreen()
    {
        greenButton.GetComponent<Image>().color = Random.ColorHSV(); //Einfärben in eine beliebige Farbe
    }

    public void ChangeBlue()
    {
        blueButton.GetComponent<Image>().color = Random.ColorHSV(); //Einfärben in eine beliebige Farbe
    }

    public void ClickStatus(int buttonNumber)  //Definition das wenn man den Button drückt er 'true' wird
                                               //wenn alle drei 'true' sind dann erst kann man den Switch Button betätigen. 
    {
        if (buttonNumber == 0)
            redButtonClicked = true;

        if (buttonNumber == 1)
            greenButtonClicked = true;

        if (buttonNumber == 2)
            blueButtonClicked = true;

        if (redButtonClicked && greenButtonClicked && blueButtonClicked) // (F/T Tabelle)
            switchButton.interactable = true;
    }

    public void SwitchScene() 
    {
        SceneManager.LoadScene(1); //Szene wechseln
    }
}