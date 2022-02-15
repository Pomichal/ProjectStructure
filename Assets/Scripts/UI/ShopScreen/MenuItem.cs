using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuItem : MonoBehaviour
{
    protected Dictionary<string, object> data;
    public virtual void Init(Dictionary<string, object> data)
    {
        this.data = data;
    }
}
