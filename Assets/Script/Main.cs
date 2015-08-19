using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour
{
	public NGraphic.GraphicManager gManager;
	//temporary initial class for prototype purpose
	NWorld.World world;
	void Awake(){
		world = new NWorld.World (10,10);
		gManager.Visualize (world);
	}
	void Start(){
	}
}

