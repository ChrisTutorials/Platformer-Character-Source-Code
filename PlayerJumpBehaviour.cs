using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpBehaviour : StateMachineBehaviour
{
    public float jumpImpulse = 20f;

    [Tooltip("Generally should be negative so that it pushes in the reverse direction")]
    public float wallPushImpulse = -20f;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetFloat(PAP.impulseY, jumpImpulse);

        if(animator.GetBool(PAP.isOnWall) && !animator.GetBool(PAP.isOnGround)) {
            animator.SetFloat(PAP.impulseX, wallPushImpulse);
        }
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
