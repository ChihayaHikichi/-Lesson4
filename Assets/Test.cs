using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {




    class Boss
    {
        private int mp = 53;

        public void Magic(int c_mp)
        {
            if (this.mp >= c_mp)
            {
                this.mp -= c_mp;

                Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
            }
            else
            {
                Debug.Log("MPが足りないため、魔法が使えない。");
            }
        }


    }


    // Use this for initialization
    void Start () {

        
        // 通常課題
        int[] array = new int[5] { 10, 20, 30, 40, 50 };

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        for (int i = array.Length; i > 0; i--)
        {
            Debug.Log(array[i - 1]);
        }
        
        // 応用課題
        Boss lastboss = new Boss();

        lastboss.Magic(5);

        for (int i = 0; i < 10; i++)
        {
            lastboss.Magic(5);
        }




        //Debug.Log(c);

    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
