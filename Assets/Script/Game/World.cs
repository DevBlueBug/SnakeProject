using UnityEngine;
using System.Collections;

namespace NWorld{
	public class World
	{
		int w,h;
		Tile[,] tiles;
		public World(int w, int h){
			this.w = w;
			this.h = h;
			tiles = new Tile[w, h];

		}
	}
}
