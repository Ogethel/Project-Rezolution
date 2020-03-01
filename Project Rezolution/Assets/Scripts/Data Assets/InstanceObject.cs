using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Instancing/Instane Object")]
public class InstanceObject : ScriptableObject
{
    //Instancing objects should be done in just this one script
    public GameObject prefab;

    public void CreateInstance(GameObject instance)
    {
        Instantiate(instance);
    }

    /* Anthony does not use this because he views it as the instantiated object to position and rotate itself
    public void CreateInstanceAtLocation(Vector3Data location)
    {
        Instantiate(prefab, location.value, Quaternion.identity);
    }
    */
}
