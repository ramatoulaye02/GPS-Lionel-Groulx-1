using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathfindingNode : Node
{

    public bool EstEndroitPublic { get; set; } //anything that isnt a classsroom

    public bool EstTraversable { get; set; }

    public List<int> ConnectedNodes { get; set; }

    public PathfindingNode ParentNode { get; set; }

    public bool EstDansClosedList { get; set; } = false;

    public bool EstDansOpenList { get; set; } = false;

    public PathfindingNode Départ { get; set; }

    public float FCost { get; set; }
    public float HCost { get; set; }
    public float GCost { get; set; }


    // Start is called before the first frame update
    public PathfindingNode(int nombre, string nom, bool estEndroitPublic, Étage étage,
        List<int> connectedNodes, GPSCoordinate coordonéesGps) : base(nombre, nom, étage, coordonéesGps)
    {
        ConnectedNodes = connectedNodes;
        EstEndroitPublic = estEndroitPublic;


    }
}