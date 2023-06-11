using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class JewelDisplay : MonoBehaviour
{

    public Jewels jewels;

    public TMP_Text nameText;
    public Image jewelImage;

    public List<AudioClip> jewelAudio; 
    /// <summary>
    /// This script is used to call the data stored in Jewels.cs 
    /// Jewels.cs is the Scriptable objects baseline
    /// </summary>

    void Start()
    {

        nameText.text = jewels.name;

        jewelImage.sprite = jewels.jewelSprite;
        

    }

}
