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






