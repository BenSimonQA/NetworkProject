using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RhinoGame
{
    public class Chat : MonoBehaviour
    {
        public InputField InputField;
        public Text ChatTextarea;
        // Start is called before the first frame update
        void Start()
        {

        }

        public void SendMessage()
        {
            ChatTextarea.text += "\n" + InputField.text;
            InputField.text = "";
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}