using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchManager : MonoBehaviour,IPointerClickHandler,IPointerDownHandler,IPointerUpHandler {
    public virtual void OnPointerClick(PointerEventData eventData)
    {
      //  Debug.Log("c");
    }

    public virtual void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("d");

    }



    public virtual void OnPointerUp(PointerEventData eventData)
    {
       // throw new NotImplementedException();
    }
}
