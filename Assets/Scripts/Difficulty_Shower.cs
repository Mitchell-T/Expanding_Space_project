using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Difficulty_Shower : MonoBehaviour {

    [SerializeField]
    private GameObject[] _objects;

    public int _difficulty_level = 1;

    private float _color = 100f;
    private float _colorStart = 200f;

    //[SerializeField]
    private Color colorStart;
    //[SerializeField]
    private Color colorNew;

    private Image Image_object_0;
    private Image Image_object_1;
    private Image Image_object_2;
    private Image Image_object_3;


    // Update is called once per frame
    void Start()
    {
        Color colorStart = new Color(_colorStart, _colorStart, _colorStart, 255f);
        Color colorNew = new Color(_color, _color, _color, 255f);

        Image Image_object_0 = _objects[0].GetComponent<Image>();
        Image Image_object_1 = _objects[1].GetComponent<Image>();
        Image Image_object_2 = _objects[2].GetComponent<Image>();
        Image Image_object_3 = _objects[3].GetComponent<Image>();

        Image_object_0.color = colorNew;
        Image_object_1.color = colorStart;
        Image_object_2.color = colorStart;
        Image_object_3.color = colorStart;

        //_objects[0].GetComponent<Image>().color = new Color(_colorStart, _colorStart, _colorStart, 255f);
        //_objects[1].GetComponent<Image>().color = new Color(_colorStart, _colorStart, _colorStart, 255f);
        //_objects[2].GetComponent<Image>().color = new Color(_colorStart, _colorStart, _colorStart, 255f);
        //_objects[3].GetComponent<Image>().color = new Color(_colorStart, _colorStart, _colorStart, 255f);
    }

    public void FixedUpdate ()
    {
        Image Image_object_0 = _objects[0].GetComponent<Image>();
        Image Image_object_1 = _objects[1].GetComponent<Image>();
        Image Image_object_2 = _objects[2].GetComponent<Image>();
        Image Image_object_3 = _objects[3].GetComponent<Image>();

        Color colorStart = new Color(_colorStart, _colorStart, _colorStart, 255f);
        Color colorNew = new Color(_color, _color, _color, 255f);

        UpdateColor(0, colorNew);

        if (_difficulty_level > 0)
        {
            UpdateColor(1,colorNew);
            //_objects[0].GetComponent<Image>().color = new Color(_color, _color,_color, 255f);
        }
        if (_difficulty_level > 1)
        {
            UpdateColor(2, colorNew);
            //_objects[0].GetComponent<Image>().color = new Color(_color, _color, _color, 255f);
            //_objects[1].GetComponent<Image>().color = new Color(_color, _color, _color, 255f);
        }
        if (_difficulty_level > 2)
        {
            UpdateColor(3, colorNew);
            //_objects[0].GetComponent<Image>().color = new Color(_color, _color, _color, 255f);
            //_objects[1].GetComponent<Image>().color = new Color(_color, _color, _color, 255f);
            //_objects[2].GetComponent<Image>().color = new Color(_color, _color, _color, 255f);
        }

        

    }

    private void UpdateColor(int i, Color kleur)
    {
        _objects[i].GetComponent<Image>().color = kleur; 
    }

}
