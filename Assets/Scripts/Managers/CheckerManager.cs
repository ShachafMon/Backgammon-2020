using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    public class CheckerManager : MonoBehaviour
    {
        private GameObject currentGameObject;
        public Checker currentChecker { get; set; }

        private void Awake()
        {
            this.currentGameObject = gameObject;
        }
        private void Start()
        {
        }
        private void Update()
        {

        }

        public void onCheckerClicked()
        {
            this.gameObject.transform.Translate(Vector3.up);
        }

    }
}
