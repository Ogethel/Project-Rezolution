using UnityEngine;

public abstract class DoWorkAnthony : ScriptableObject
{
    public abstract void Work();
    //We are not using this function, so anything that inherits from this script must use this function.  This is a template script, great for Inheritance.
}
