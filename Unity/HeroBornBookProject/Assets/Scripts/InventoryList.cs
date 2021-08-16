using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvnetoryList<T> where T: class
{
    private T _item;

    public T item
    {
        get { return _item; }
    }

    public InvnetoryList()
    {
        Debug.Log("Generic List Initialized...");
    }

    public void SetItem(T newItem)
    {
        _item = newItem;
        Debug.Log("New item added...");
    }
}