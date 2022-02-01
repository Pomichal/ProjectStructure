using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitBehaviour : MonoBehaviour
{
    protected UnitBaseModel model;
    public void Init(UnitBaseModel model)
    {
        this.model = model;
    }
}
