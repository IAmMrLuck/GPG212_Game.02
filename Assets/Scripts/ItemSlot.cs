using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{

    [SerializeField] private GameObject _itemSlotToOpen;
    [SerializeField] private Image _image;

    private void Start()
    {
        _itemSlotToOpen.SetActive(false);
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if(eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
        _image.enabled = false;
        _itemSlotToOpen.SetActive(true);

    }
}
