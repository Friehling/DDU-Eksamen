using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace test
{
    public class test : MonoBehaviour
    {
        DialogSystem ds;
        TextArchitect architect;
        public int stringIndex;
        public float waitAmount;
        public GameObject image;
        bool isWaiting;


        string[] lines = new string[]
        {
             "This is a random line of dialogue",
            "I want to say something, come over here",
            "The world is a crazy place sometimes.",
              "Don't lose hope, things will get better!",
            "It's a bird? It's a plane? No! It's Super Sheltie!",
            "JEG ER EN DUM KØTER",
            "JEG VIL GERNE HJEM"
        };
        // Start is called before the first frame update
        void Start()
        {
            ds = DialogSystem.instance;
            architect = new TextArchitect(ds.DialogContainer.TrueDialog);
            architect.buildMethod = TextArchitect.BuildMethod.typewriter;

        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetKeyUp(KeyCode.Space)&& !isWaiting) 
            {
                stringIndex++;
                if(stringIndex == 5)
                {

                    StartCoroutine(WaitForImage());

                }
                else
                {
                architect.Build(lines[stringIndex]);

                }
            }
        }
        



        IEnumerator WaitForImage()
        {
            isWaiting = true;
            image.SetActive(true);
            yield return new WaitForSeconds(waitAmount); 
            image.SetActive(false);
            isWaiting = false;
            architect.Build(lines[stringIndex]);
        }
    }




}

