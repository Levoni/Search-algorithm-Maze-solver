using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
   /// <summary>
   /// Class responsible for handling the info assosiated with a node
   /// </summary>
   public class Tile
   {
      //Array of children tiles that connect in the four direction.
      //index for the node correlates with the dir enum value for that
      // direction.
      public Tile[] adjacentTiles; //adjacent tiles
      public int xPos, yPos;

      /// <summary>
      /// Creates a node at a specific location.
      /// </summary>
      /// <param name="x">X location in the maze</param>
      /// <param name="y">Y location in the maze</param>
      public Tile(int x,int y)
      {
         xPos = x;
         yPos = y;
         //visited = false;
         //pl = place.none;
         adjacentTiles = new Tile[4];
         for (int i = 0; i < adjacentTiles.Length; i++)
            adjacentTiles[i] = null;
      }

      /// <summary>
      /// Adds a child node to the nodes array in the position
      /// correlating to the direction it is connecting to.
      /// </summary>
      /// <param name="n">Tile to add</param>
      /// <param name="d">Direction the added node is connecting to</param>
      public void AddNode(Tile n, dir d)
      {
         adjacentTiles[(int)d] = n;
      }

      /// <summary>
      /// Checks to see if the node has one or less children nodes.
      /// This determines if the node is a deadend
      /// </summary>
      /// <returns>true if a dead end false otherwise</returns>
      public bool IsDeadEnd()
      {
         int connection = 0;
         foreach(Tile n in adjacentTiles)
         {
            if (n != null)
               connection++;
         }
         if (connection <= 1)
            return true;
         return false;
      }

   }
}
