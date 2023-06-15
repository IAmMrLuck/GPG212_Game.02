using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Misc;

public class JewelDisplay : MonoBehaviour
{


    public Jewels currentJewel;

    public TMP_Text nameText;
    public Image jewelImage;

    public Jewels[] scriptableObjects;

    public List<AudioClip> jewelAudio; 
    /// <summary>
    /// This script is used to call the data stored in Jewels.cs 
    /// Jewels.cs is the Scriptable objects baseline
    /// </summary>

    void Start()
    {
        int randomNumber = Random.Range(0, scriptableObjects.Length);
        currentJewel = scriptableObjects[randomNumber];



        nameText.text = currentJewel.name;

        jewelImage.sprite = currentJewel.jewelSprite;

    }

}
