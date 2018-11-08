using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IDragHandler, IEndDragHandler {

    public void OnDrag(PointerEventData eventData)
    {
		Vector3 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		pz.z = 0;
        transform.position = pz;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
    }

}
