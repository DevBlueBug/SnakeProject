using UnityEngine;
using System.Collections.Generic;

namespace NWorld{
	public class World
	{
		public delegate void D_Me_Entity(World me, NEntity.Entity entity);
		public D_Me_Entity E_EntityAdded = delegate{};

		int w,h;
		Tile[,] tiles;
		internal List<NEntity.Entity> entities;


		public World(int w, int h){
			entities = new List<NWorld.NEntity.Entity> ();
			this.w = w;
			this.h = h;
			tiles = new Tile[w, h];
			for (int i = 0; i < w; i++) for(int j = 0 ; j < h;j++){
				tiles[i,j] = new Tile();
			}
		}
		public int Width{
			get{return this.w;}
		}
		public int Height{
			get{return this.h;}
		}
		public Tile this[int x,int y]{
			get{return tiles[x,y];}
		}
		public World AddEntity(NEntity.Entity entity){
			entities.Add (entity);
			this.E_EntityAdded (this, entity);
			return this;
		}

	}
}
