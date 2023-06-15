using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JewelDrag : MonoBehaviour
{
    private bool dragging = false;
    private Vector3 offset;
    private Transform originalParent;

    [SerializeField]
    private List<Transform> dropTargets; // List of drop target transforms

    private void OnMouseDown()
    {
        dragging = true;
        offset = transform.position - MousePosition();
        originalParent = transform.parent;
        transform.SetParent(originalParent.parent);
    }

    private void OnMouseDrag()
    {
        if (dragging)
        {
            transform.position = MousePosition() + offset;
        }
    }

    private void OnMouseUp()
    {
        if (dragging)
        {
            bool droppedOnTarget = CheckDropTargets();

            if (!droppedOnTarget)
            {
                // Set the parent of the game object back to itself
                transform.SetParent(originalParent);
                transform.localPosition = Vector3.zero;
            }

            dragging = false;
        }
    }

    private Vector3 MousePosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private bool CheckDropTargets()
    {
        foreach (Transform dropTarget in dropTargets)
        {
            if (IsMouseOverTarget(dropTarget))
            {
                // Set the parent of the game object to the drop target
                transform.SetParent(dropTarget);

                // Lock the position relative to the parent
                transform.localPosition = Vector3.zero;

                return true;
            }
        }

        return false;
    }

    private bool IsMouseOverTarget(Transform dropTarget)
    {
        Collider2D[] collidersAtMousePos = Physics2D.OverlapPointAll(MousePosition());

        foreach (Collider2D collider in collidersAtMousePos)
        {
            if (collider.transform == dropTarget)
            {
                return true;
            }
        }

        return false;
    }
}
