using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Gun : item
{
    public abstract override void Use();
    public GameObject bulletImpactPrefab;
}
