using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class item : MonoBehaviour
{
    public Iteminfo iteminfo;
    public GameObject itemGameObject;

    public abstract void Use();

}
