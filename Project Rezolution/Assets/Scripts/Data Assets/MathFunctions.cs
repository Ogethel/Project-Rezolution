using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]

public class MathFunctions : DoWorkAnthony
{
    public FloatData dataObj;

    public override void Work()
    {
        dataObj.Value++;
    }
}
