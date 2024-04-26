using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace test
{
    public class test : MonoBehaviour
    {
        DialogSystem ds;
        TextArchitect architect;
        int index;

        string[] lines = new string[5]
        {
             "This is a random line of dialogue",
            "I want to say something, come over here",
            "The world is a crazy place sometimes.",
              "Don't lose hope, things will get better!",
            "It's a bird? It's a plane? No! It's Super Sheltie!"
        };
        // Start is called before the first frame update
        void Start()
        {
            ds = DialogSystem.instance;
            architect = new TextArchitect(ds.DialogContainer.TrueDialog);
            architect.buildMethod = TextArchitect.BuildMethod.typewriter ;

        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetKeyUp(KeyCode.Space)) 
            {
                architect.Build(lines[index]);
                index++;
            }
        }
    }




}

