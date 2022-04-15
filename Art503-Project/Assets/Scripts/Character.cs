using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public class Details {
        public float moveSp;
        public float jumpHt;
        public int jumpCounter;
        public SpriteRenderer playerSprite;

        public Animation attackPattern;

        // test for first playable
        // only for movement and jumps
        public Details(float ms, float jh, int jc){
            moveSp = ms;
            jumpHt = jh;
            jumpCounter = jc;
        }

        // this will load player sprite and their own attack animation
        // not implemented yet
        public Details(float ms, float jh, int jc, Animation attackP){
            moveSp = ms;
            jumpHt = jh;
            jumpCounter = jc;
            attackPattern = attackP;
        }
    }
}
