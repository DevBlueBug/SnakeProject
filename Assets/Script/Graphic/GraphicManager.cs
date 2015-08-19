using UnityEngine;
using System.Collections;

namespace NGraphic{
	
	public class GraphicManager : MonoBehaviour
	{
		public Tile P_Tile; 

		Tile[,] tiles;

		public void Visualize(NWorld.World world){
			tiles = new Tile[world.Width, world.Height];
			for (int i = 0; i < world.Width; i++)
			for (int j = 0; j < world.Height; j++) {
				var tile = Instantiate(P_Tile);
				tile.transform.parent= this.transform;
				tile.transform.localPosition = new Vector3(i,0,j);
				tiles[i,j] = tile;
			}

		
			//will visualize the world

		}
	}

}
