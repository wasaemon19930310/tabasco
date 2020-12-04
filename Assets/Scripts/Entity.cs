using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    private int generatorIndex;
    private int controllerIndex;

    public int GeneratorIndex
    {
        get { return this.generatorIndex; }
        set { this.generatorIndex = value; }
    }
    public int ControllerIndex
    {
        get { return this.controllerIndex; }
        set { this.controllerIndex = value; }
    }
}
