using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class TextBehavior : MonoBehaviour
{
    private Text textObj;
    //If text update itself
    public UnityEvent awakeEvent;


    void Awake()
    {
        textObj = GetComponent<Text>();
    }


    public void UpdateTextStringData(StringListData stringListDatObj)
    {
        textObj.text = stringListDatObj.ReturnCurrentLine();
    }

    public void UpdateTextStringData(IntData intDataObj)
    {
        textObj.text = intDataObj.value.ToString();
    }
}
