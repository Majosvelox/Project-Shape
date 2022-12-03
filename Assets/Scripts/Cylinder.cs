using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape




{
    public Cylinder(Color colorStart) : base(colorStart)
    {
    }

    void Update()
    {
        ChangeColor();
    }
    public override void ChangeColor() //POLYMORPHISM
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            //RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Cylinder")
                {
                    colorStart = Color.yellow;
                    rend.material.color = colorStart;
                    Debug.Log(" You change the color of the Shape, the new color is Yellow. ");

                }

            }
        }
    }
}

