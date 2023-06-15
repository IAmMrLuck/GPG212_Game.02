using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class JewelJuice : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IPointerUpHandler
{
    [SerializeField] private CanvasGroup _canvasGroup;
    [SerializeField] private Image _image;
    [SerializeField] private TMP_Text _text;
    [SerializeField] private Outline _outline;
    [SerializeField] private RectTransform _rectTransform;
    [SerializeField] private ParticleSystem _particleSystem;

    public string sortingLayerName = "Jewels";
    public int sortingOrder = 1;

    [SerializeField] private TrailRenderer trailRenderer;


    private void Start()
    {

        _text.enabled = false;
        _outline.enabled = false;

        trailRenderer = GetComponent<TrailRenderer>();
        trailRenderer.sortingLayerName = sortingLayerName;
        trailRenderer.sortingOrder = sortingOrder;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Pointer Over");
        _text.enabled = true;         //pop-up name
        _outline.enabled = true; //Hightlight the image       
        //soundclip

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Pointer Exit");
        _text.enabled=false;        //remove pop-name
        _outline.enabled = false; //Stop Hightlighting the image

    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        _canvasGroup.alpha = .6f;
    }


    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        _canvasGroup.alpha = 1f;

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
        _canvasGroup.alpha = .6f;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
        _canvasGroup.alpha = 1f;
    }


}
