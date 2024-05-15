using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Interviewer : MonoBehaviour
{
    public AudioClip ques1;
    public AudioClip ques2;
    public AudioClip ques3;
    public AudioClip ques4;
    public AudioClip ques5;

    private Animation anim;
    private Animation anim_Girl;
    public bool isGirl;
    //private Animation talk1;
    //private Animation talk2;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();
        if(!isGirl){
            anim = gameObject.GetComponent<Animation>();
            anim_Girl = null;
        }
        else {
            anim_Girl = gameObject.GetComponent<Animation>();
            anim = null;
        }

        if(anim_Girl != null){
            anim_Girl.Play("idle");
        }
       if(anim != null){
            anim.Play("idle");
       }
        StartCoroutine(coroutineA());
    }

    IEnumerator coroutineA()
    {
        // wait for 1 second
        yield return new WaitForSeconds(4.0f);
        GetComponent<AudioSource>().clip = ques1;
        GetComponent<AudioSource>().Play();
        if(anim != null){
            anim.Play("talk1");
        }
       if(anim_Girl != null){
            anim_Girl.Play("idle");
       }
        

        yield return new WaitForSeconds(3f);
              if(anim != null){
            anim.Play("idle");
       }
          yield return new WaitForSeconds(7f);

        yield return StartCoroutine(coroutineB());
        Debug.Log("coroutineA running again");
    }

    IEnumerator coroutineB()
    {
        Debug.Log("coroutineB created");
        GetComponent<AudioSource>().clip = ques2;
        GetComponent<AudioSource>().Play();
        if(anim != null){
            anim.Play("idle");

        }
       if(anim_Girl != null){
            anim_Girl.Play("talk1");
       }
        yield return new WaitForSeconds(3f);
       if(anim_Girl != null){
            anim_Girl.Play("idle");
       }
        yield return new WaitForSeconds(10f);

        yield return StartCoroutine(coroutineC());

        Debug.Log("coroutineB enables coroutineA to run");
    }

        IEnumerator coroutineC()
    {
        GetComponent<AudioSource>().clip = ques3;
        GetComponent<AudioSource>().Play();
        if(anim != null){
            anim.Play("talk1");

        }
       if(anim_Girl != null){
            anim_Girl.Play("idle");
       }
        

        yield return new WaitForSeconds(2.6f);
              if(anim != null){
            anim.Play("idle");
       }
        
        yield return new WaitForSeconds(10f);
        yield return StartCoroutine(coroutineD());
        Debug.Log("coroutineA running again");
    }
    IEnumerator coroutineD()
    {
        Debug.Log("coroutineB created");
        GetComponent<AudioSource>().clip = ques4;
        GetComponent<AudioSource>().Play();
        if(anim != null){
            anim.Play("idle");

        }
       if(anim_Girl != null){
            anim_Girl.Play("talk1");
       }
        yield return new WaitForSeconds(4f);
       if(anim_Girl != null){
            anim_Girl.Play("idle");
       }
        yield return new WaitForSeconds(10f);

        yield return StartCoroutine(coroutineE());

        Debug.Log("coroutineB enables coroutineA to run");
    }
     IEnumerator coroutineE()
    {
        GetComponent<AudioSource>().clip = ques5;
        GetComponent<AudioSource>().Play();
        if(anim != null){
            anim.Play("talk1");

        }
       if(anim_Girl != null){
            anim_Girl.Play("idle");
       }
        

        yield return new WaitForSeconds(4f);
              if(anim != null){
            anim.Play("idle");
       }
         yield return new WaitForSeconds(10f);
      // yield return StartCoroutine(coroutineF());
        Debug.Log("coroutineA running again");
    }
}
