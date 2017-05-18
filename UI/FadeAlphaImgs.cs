using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeAlphaImgs : MonoBehaviour {

    [Header("Hide Animation Settings")]
    [SerializeField] private float hidingTime = 2.0f;
    [SerializeField] private Image[] aImages;
    private float currentAlpha=1;
    private bool isHiding;  

    void Start () {
    }

    void Update () {

        if (!isHiding) return;
        
        currentAlpha -= Time.deltaTime / hidingTime;
        for (int i = 0; i < aImages.Length; i++)
        {
            aImages[i].color = new Color(aImages[i].color.r, aImages[i].color.g, aImages[i].color.b, currentAlpha);
        }
        if (currentAlpha<= 0)
        {
            isHiding = false;
            currentAlpha = 1;
            gameObject.SetActive(false);
        }

    }

    public void ListenerInit(){
    	isHiding = true;
    }
}
