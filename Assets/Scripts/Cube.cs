using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Cube : Shape


{

    public Cube(Color colorStart) : base(colorStart)
    {
    }

    void Update()
    {
        // INHERITANCE FROM SHAPE  
        ChangeColor();

    }
}




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    // Start is called before the first frame update
    protected Color colorStart;
    public Renderer rend;

    //ENCAPSULATION
    public Color ColorStart { get => colorStart; set => colorStart = value; }

    //private string ColorName;




    public Shape(Color colorStart)
    {
        ColorStart = colorStart;
    }

    void Start()
    {
        rend = GetComponent<Renderer>();
        // Event m_Event = Event.current;
    }

    // Update is called once per frame
    void Update()
    {

        ChangeColor();

    }
    public virtual void ChangeColor() //ABSTRACTION
    {


        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            //RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Cube")
                {
                    ColorStart = Color.blue;
                    rend.material.color = ColorStart;
                    Debug.Log(" You change the color of the Shape, the new color is Blue. ");

                }

            }
        }
    }
}

