using UnityEngine;
using System.Collections;

namespace NGraphic{
	public class VisualizerWorld : MonoBehaviour
	{
		public Tile P_Tile; 

		Tile[,] tiles;

		public VisualizerWorld Dispaly(NWorld.World world){
			tiles = new Tile[world.Width, world.Height];
			for (int i = 0; i < world.Width; i++)
			for (int j = 0; j < world.Height; j++) {
				var tile = Instantiate(P_Tile);
				tile.transform.parent= this.transform;
				tile.transform.localPosition = new Vector3(i,0,j);
				tiles[i,j] = tile;
			}
			return this;
		}
	}
}