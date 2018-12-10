#pragma strict

private var anim : Animator;
var open : boolean;
var aud : AudioSource;
var character : GameObject;
var distanceToOpen:float = 5;
private var characterNearbyHash : int = Animator.StringToHash("character_nearby");

function Start () 
{
	open = false;
    anim = GetComponent("Animator");
}


function Update () 
{
	var distance = Vector3.Distance(transform.position,character.transform.position);
	
	if (distanceToOpen>=distance){
    	anim.SetBool(characterNearbyHash, true);
        if(!open) {
       		open = true;
        	aud.Play();
        }
    }else{
    	anim.SetBool(characterNearbyHash, false);
    	if(open) {
       		open = false;
        	aud.Play();
        }
    }
}