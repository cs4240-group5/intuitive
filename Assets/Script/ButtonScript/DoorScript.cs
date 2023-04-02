using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    private Animator animator;
    private bool isAnimationEnabled = false;
    public AudioClip doorOpenSound;

    private void Start()
    {
        // Get the animator component attached to the object
        animator = GetComponent<Animator>();

        // Disable automatic animation playback
        animator.enabled = false;
    }

    private void Update()
    {
        // If animation is enabled, allow it to play
        if (isAnimationEnabled)
        {
            animator.enabled = true;
        }
        // Otherwise, prevent the animator from playing
        else
        {
            animator.enabled = false;
        }
    }

    // Method to be called when the button is clicked
    public void PlayAnimation()
    {
        // Play door open audio
        if (isAnimationEnabled == false)
        {
            AudioSource.PlayClipAtPoint(doorOpenSound, this.transform.position);
        }
        // Enable animation playback
        isAnimationEnabled = true;
    }
}
