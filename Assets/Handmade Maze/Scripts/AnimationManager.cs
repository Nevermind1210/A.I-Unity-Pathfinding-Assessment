using System;
using System.Collections;
using System.Collections.Generic;
using AI;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.AI;


namespace AIAnimations
{
   public class AnimationManager : MonoBehaviour
   {
      private AgentSmith Smithy;
      private Animator anim;
      private NavMeshLink Jump;
      private float speed;
      

      private void Start()
      {
         anim = GetComponent<Animator>();
      }

      private void Update()
      {
         if (anim != null)
         {
            anim.SetTrigger("Walkin'");
            if (Smithy)
            {
               
            }
         }
         else if (anim == null)
         {
            anim.SetTrigger("Idle");
         }
      }
   }
}