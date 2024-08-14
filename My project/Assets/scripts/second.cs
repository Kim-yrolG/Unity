using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class second : MonoBehaviour
{
    public Text id_Text;
    public Text level_Text;
    public Text exp_Text;

    public string ID;
    [Range(1, 99)] public int level;
    [Range(0.0f, 100.0f)] public float exp;
    // Start is called before the first frame update
    void Start()
    {
        id_Text.text = ID;
        level_Text.text = level.ToString();
        exp_Text.text = exp.ToString();

    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/
}
