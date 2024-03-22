using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public BodySourceView bsv;
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(bsv.Bodies.Count == 1)
        {
            Transform body = bsv.Bodies.First().Value.transform;
            Transform rightHand = body.Find("HandRight");
            if(rightHand.Find("Olaf") == null)
            {
                GameObject olaf = Instantiate(prefab, rightHand);
                olaf.name = "Olaf";
                olaf.transform.localPosition = Vector3.zero;
            }
        }
    }
}
