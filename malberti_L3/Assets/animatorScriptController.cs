using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorScriptController : MonoBehaviour
{
    // // Referència a l'Animator
    private Animator animator;

    void Start()
    {
        // // Obtenim el componen Animator
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // //Quan el jugador prem la tecla Q, activem el trigger de StartWarmUp
        if (Input.GetKeyDown (KeyCode.Q))
        {
            // //Activem el trigger "StartWarmUp"
            animator.SetTrigger("StartWarmUp");
        }

        // //Quan el jugador prem la tecla W, activem el trigger de DoSimpleDance
        if (Input.GetKeyDown (KeyCode.W))
        {
            // // Activem el trigger "DoSimpleDance"
            animator.SetTrigger("DoSimpleDance");
        }

        // // Quan el jugador prem la tecla E, activem el trigger de DoAdvancedMove
        if (Input.GetKeyDown (KeyCode.E))
        { 
            // //Activem el trigger "DoAdvancedMove"
            animator.SetTrigger("DoAdvancedMove");
        }

        // // Quan el jugador prem la tecla R, activem el trigger de DoFinalMove
        if (Input.GetKeyDown (KeyCode.R))
        {
            // // Activem el trigger de "DoFinalMove"
            animator.SetTrigger("DoFinalMove");
        }
    }
}
