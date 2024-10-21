using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable] //Para poder generar el JSON
public class CharacterPosition
{
    //Public para generar el JSON
    public string name;
    public float timestamp;
    public Vector3 position;

    public CharacterPosition(string name, float timestamp, Vector3 position)
    {
        this.name = name;
        this.timestamp = timestamp;
        this.position = position;
    }

    public CharacterPosition()
    {

    }

    public override string ToString()
    {
        return $"{name} {timestamp} {position}"; //Interpolated string
    }

    public string ToCSV()
    {
        return $"{name};{timestamp};{position.x};{position.y};{position.z}";
    }
}
