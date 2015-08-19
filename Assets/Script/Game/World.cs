using UnityEngine;
using System.Collections;

namespace NWorld{
	public class World
	{
		int w,h;
		Tile[,] tiles;
		public int Width{
			get{
				return this.w;
			}
		}
		public int Height{
			get{
				return this.h;
			}
		}
		public Tile this[int x,int y]{
			get{
				return tiles[x,y];
			}
		}
		public World(int w, int h){
			this.w = w;
			this.h = h;
			tiles = new Tile[w, h];
			for (int i = 0; i < w; i++) for(int j = 0 ; j < h;j++){
				tiles[i,j] = new Tile();
			}

		}
	}
}
