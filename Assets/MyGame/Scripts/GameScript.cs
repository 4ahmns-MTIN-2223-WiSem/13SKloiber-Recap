using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    int spriteIndex = -1;

    public int PlayerTurn()
    {
        spriteIndex++;
        return spriteIndex % 2;
    }

    // QUELLEN: https://youtu.be/Xml-qIF7E44
}
